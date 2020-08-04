using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace DB2ExcelDX
{
    class Config
    {
        private string name;
        private string ip;
        private string user;
        private string pwd;
        private string sql;
        private string db;
        private int count;
        private Scripts script;
        private DataSource dataSource;

        public Config(string ip, string user, string pwd, string sql, string db)
        {
            this.ip = ip;
            this.user = user;
            this.pwd = pwd;
            this.sql = sql;
            this.db = db;
        }

        public Config(string name, string ip, string user, string pwd, string sql, string db, int count = 0)
        {
            this.name = name;
            this.ip = ip;
            this.user = user;
            this.pwd = pwd;
            this.sql = sql;
            this.db = db;
            this.count = count;
        }

        public Config(Scripts script, DataSource dataSource)
        {
            this.script = script;
            this.dataSource = dataSource;
        }

        public string Name { get => name; set => name = value; }
        public string Ip { get => ip; set => ip = value; }
        public string User { get => user; set => user = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Sql { get => sql; set => sql = value; }
        public string Db { get => db; set => db = value; }
        public int Count { get => count; set => count = value; }
        internal Scripts Script { get => script; set => script = value; }
        internal DataSource DataSource { get => dataSource; set => dataSource = value; }

        public static void saveScript(Config c, string path, string fileName)
        {
            string SavePath = path + "\\" + fileName;
            //if the directory exist
            if (!Directory.Exists(path))
            {
                //create
                Directory.CreateDirectory(path);
            }
            XmlDocument doc = new XmlDocument();
            if (File.Exists(SavePath))
            {
                //load the xml
                doc.Load(SavePath);
                //get script list
                XmlNodeList scripts = doc.SelectNodes("/DB2Excel/Item");
                //get db list
                XmlNodeList dbs = doc.SelectNodes("/DB2Excel/DataSource/Item");
                /*if (scripts.Count < 1||dbs.Count<1)
                {
                    string id = DateTime.Now.ToString("yyyyMMddHHmmssms", DateTimeFormatInfo.InvariantInfo);
                    c.dataSource.Id = id;
                    c.script.Dbid = id;
                    CreateDoc(SavePath, c);
                }
                else
                {*/
                    XmlNode scriptParent = doc.SelectSingleNode("/DB2Excel");
                    XmlNode dbParent = doc.SelectSingleNode("/DB2Excel/DataSource");
                    //XmlNode PNode = null;
                    var isHave = false;
                    //resolve dbnode
                    foreach (XmlNode db in dbs)
                    {
                        if (db.Attributes["IP"].Value.Equals(c.dataSource.Ip)&&
                            db.Attributes["User"].Value.Equals(c.dataSource.User)&&
                            db.Attributes["PWD"].Value.Equals(c.dataSource.Pwd))
                        {
                            isHave = true;
                            c.script.Dbid = db.Attributes["ID"].Value;
                            c.DataSource.Id = db.Attributes["ID"].Value;
                            break;
                        }
                    }
                    if (!isHave)
                    {
                        string id = DateTime.Now.ToString("yyyyMMddHHmmssms", DateTimeFormatInfo.InvariantInfo);
                        c.dataSource.Id = id;
                        c.script.Dbid = id;
                        XmlElement name1 = doc.CreateElement("Item");
                        name1.SetAttribute("ID", c.dataSource.Id);
                        name1.SetAttribute("IP", c.dataSource.Ip);
                        name1.SetAttribute("User", c.dataSource.User);
                        name1.SetAttribute("PWD", c.dataSource.Pwd);
                        dbParent.AppendChild(name1);
                    }
                    //resolve script node
                    isHave = false;
                    foreach (XmlNode item in scripts)
                    {
                        if (item.Attributes["Name"].Value.Equals(c.script.Name))
                        {
                            isHave = true;
                            item.Attributes["DBID"].Value = c.dataSource.Id;
                            item.Attributes["SQL"].Value = c.script.Sql;
                            item.Attributes["DB"].Value = c.script.Db;
                            break;
                        }
                    }
                    if (!isHave)
                    {
                        XmlElement name1 = doc.CreateElement("Item");
                        name1.SetAttribute("Name", c.script.Name);
                        name1.SetAttribute("DBID", c.dataSource.Id);
                        name1.SetAttribute("SQL", c.script.Sql);
                        name1.SetAttribute("DB", c.script.Db);
                        scriptParent.AppendChild(name1);
                    }
                    

                    doc.Save(SavePath);
               /* }*/
                
            }
            else
            {
                string id= DateTime.Now.ToString("yyyyMMddHHmmssms", DateTimeFormatInfo.InvariantInfo);
                c.dataSource.Id = id;
                c.script.Dbid = id;
                CreateDoc(SavePath, c);
            }
            MessageBox.Show("脚本保存成功", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }
        private static void CreateDoc(string file, Config c)
        {
            XmlDocument doc = new XmlDocument();
            //setup the description information and add to doc
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //setup root node
            XmlElement DB2Excel = doc.CreateElement("DB2Excel");
            //set db node
            XmlElement db = doc.CreateElement("DataSource");
            XmlElement dbitem = doc.CreateElement("Item");
            dbitem.SetAttribute("ID", c.DataSource.Id);
            dbitem.SetAttribute("IP", c.DataSource.Ip);
            dbitem.SetAttribute("User", c.dataSource.User);
            dbitem.SetAttribute("PWD", c.dataSource.Pwd);
            db.AppendChild(dbitem);
            DB2Excel.AppendChild(db);
            //将根节点添加到文档中
            doc.AppendChild(DB2Excel);
            //setup script node
            XmlElement name1 = doc.CreateElement("Item");
            name1.SetAttribute("DBID", c.DataSource.Id);
            name1.SetAttribute("Name", c.script.Name);
            name1.SetAttribute("SQL", c.script.Sql);
            name1.SetAttribute("DB", c.script.Db);
            DB2Excel.AppendChild(name1);
            // set verson

            XmlElement ver = doc.CreateElement("Version");
            ver.SetAttribute("v", "1.0");
            ver.SetAttribute("UpDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo));
            DB2Excel.AppendChild(ver);

            doc.Save(file);
        }

        private static void createForEmpty(string file,string url,string version)
        {
            XmlDocument doc = new XmlDocument();
            //setup the description information and add to doc
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //setup root node
            XmlElement DB2Excel = doc.CreateElement("DB2Excel");
            //set db node
            XmlElement db = doc.CreateElement("DataSource");
            DB2Excel.AppendChild(db);

            // set verson
            XmlElement ver = doc.CreateElement("Version");
            ver.SetAttribute("v",version);
            ver.SetAttribute("UpDateTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo));
            DB2Excel.AppendChild(ver);
            // set url
            XmlElement urlNode = doc.CreateElement("Url");
            urlNode.SetAttribute("value", url);
            DB2Excel.AppendChild(urlNode);
            //set save path
            XmlElement savePath = doc.CreateElement("SavePath");
            savePath.SetAttribute("path", "default");
            savePath.SetAttribute("EditTime",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo));
            DB2Excel.AppendChild(savePath);
            //将根节点添加到文档中
            doc.AppendChild(DB2Excel);

            doc.Save(file);
        }
        public static List<Config> ReadDoc(string file)
        {
            List<Config> confs = new List<Config>();
            XmlDocument doc = new XmlDocument();
            if (File.Exists(file))
            {
                //if file exist  then load the XML
                doc.Load(file);
                //get root script
                XmlNodeList scripts = doc.SelectNodes("/DB2Excel/Item");
                //get root dataSource
                XmlNodeList dbs = doc.SelectNodes("/DB2Excel/DataSource/Item");
                if (scripts.Count > 0)
                {
                    foreach (XmlNode item in scripts)
                    {
                        foreach(XmlNode db in dbs)
                        {
                            if (db.Attributes["ID"].Value.Equals(item.Attributes["DBID"].Value))
                            {
                                confs.Add(new Config(new Scripts(item.Attributes["DBID"].Value, item.Attributes["Name"].Value, item.Attributes["SQL"].Value, item.Attributes["DB"].Value),
                                    new DataSource(db.Attributes["ID"].Value, db.Attributes["IP"].Value, db.Attributes["User"].Value, db.Attributes["PWD"].Value)
                                    ));
                                break;
                            }
                        }
                        /*confs.Add(new Config(item.Attributes["Name"].Value,
                            item.Attributes["IP"].Value,
                            item.Attributes["User"].Value,
                            item.Attributes["PWD"].Value,
                            item.Attributes["SQL"].Value,
                            item.Attributes["DB"].Value));*/
                    }
                }
            }
            return confs;
        }

        public static string getUrl(string file)
        {
            string url = "http://192.168.1.5:190/DB2Excel.txt";
            XmlDocument doc = new XmlDocument();
            if (File.Exists(file))
            {
                //if file exist  then load the XML
                doc.Load(file);
                //get root script
                XmlNode urlNode = doc.SelectSingleNode("/DB2Excel/Url");
                url = urlNode.Attributes["value"].Value;
            }
            else
            {
                createForEmpty(file, url, "1.0");
            }
            return url;
        }

        public static string getSavePath(string file)
        {
            string url = "default";
            XmlDocument doc = new XmlDocument();
            if (File.Exists(file))
            {
                //if file exist  then load the XML
                doc.Load(file);
                //get root script
                XmlNode pathNode = doc.SelectSingleNode("/DB2Excel/SavePath");
                url = pathNode.Attributes["path"].Value;
            }
            else
            {
                createForEmpty(file, url, "1.0");
            }
            return url;
        }

        /// <summary>
        /// load new save path to file
        /// </summary>
        /// <param name="file"></param>
        /// <param name="path"></param>
        /// <returns>if success return 1, if file not exist return 2</returns>
        public static int saveSavePath(string file,string path="default")
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists(file))
            {
                //if file exist  then load the XML
                doc.Load(file);
                //get root script
                XmlNode pathNode = doc.SelectSingleNode("/DB2Excel/SavePath");
                pathNode.Attributes["path"].Value=path;
                pathNode.Attributes["EditTime"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
                doc.Save(file);
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static int saveUrl(string file,string url)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists(file))
            {
                //if file exist  then load the XML
                doc.Load(file);
                //get root script
                XmlNode urlNode = doc.SelectSingleNode("/DB2Excel/SavePath");
                urlNode.Attributes["value"].Value = url;
                doc.Save(file);
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static Boolean parseNetConfig(string xmlStr,string localFile,bool auto=true)
        {
            XmlDocument netDoc = new XmlDocument();
            XmlDocument localDoc = new XmlDocument();
            try
            {
                netDoc.LoadXml(xmlStr);
                localDoc.Load(localFile);
                XmlNode oldV = localDoc.SelectSingleNode("/DB2Excel/Version");
                XmlNode newV = netDoc.SelectSingleNode("/DB2Excel/Version");
                string oldVersion = oldV.Attributes["v"].Value;
                string newVersion = newV.Attributes["v"].Value;
                if (newVersion.Equals(oldVersion)&&auto) return true;
                oldV.Attributes["v"].Value = newVersion;
                oldV.Attributes["UpDateTime"].Value = newV.Attributes["UpDateTime"].Value;
                XmlNodeList localDB = localDoc.SelectNodes("/DB2Excel/DataSource/Item");
                XmlNodeList netDB = netDoc.SelectNodes("/DB2Excel/DataSource/Item");
                XmlNodeList localSQL = localDoc.SelectNodes("/DB2Excel/Item");
                XmlNodeList netSQL = netDoc.SelectNodes("/DB2Excel/Item");

                ConfigMergeForm cmf = new ConfigMergeForm(localSQL.Count, netSQL.Count, oldVersion, newVersion);
                int result = cmf.show();
                if (result == 1)    return true;
                #region overwrite local file
                else if (result ==2)
                {
                    XmlElement urlNode = netDoc.CreateElement("Url");
                    urlNode.SetAttribute("value", localDoc.SelectSingleNode("/DB2Excel/Url").Attributes["value"].Value);
                    netDoc.SelectSingleNode("/DB2Excel").AppendChild(urlNode);
                    XmlElement pathNode = netDoc.CreateElement("SavePath");
                    pathNode.SetAttribute("path", localDoc.SelectSingleNode("/DB2Excel/SavePath").Attributes["path"].Value);
                    pathNode.SetAttribute("EditTime", localDoc.SelectSingleNode("/DB2Excel/SavePath").Attributes["EditTime"].Value);
                    netDoc.SelectSingleNode("/DB2Excel").AppendChild(pathNode);

                    netDoc.Save(localFile);
                    MessageBox.Show("文件已覆盖!");
                }
                #endregion
                #region check db conflict
                else
                {
                    // if local datasource id is same as the net datasource id
                    foreach (XmlNode netdb in netDB)
                    {
                        foreach (XmlNode localdb2 in localDB)
                        {
                            if (netdb.Attributes["ID"].Value.Equals(localdb2.Attributes["ID"].Value))
                            {
                                string newId = DateTime.Now.ToString("yyyyMMddHHmmssms", DateTimeFormatInfo.InvariantInfo);
                                foreach (XmlNode localsql4 in localSQL)
                                {
                                    if (localsql4.Attributes["DBID"].Value.Equals(localdb2.Attributes["ID"].Value))
                                        localsql4.Attributes["DBID"].Value = newId;
                                }
                                localdb2.Attributes["ID"].Value = newId;
                            }
                        }
                    }

                    // if local datasource are similar to net datasource
                    foreach (XmlNode netdb in netDB)
                    {
                        foreach (XmlNode localdb1 in localDB)
                        {
                            if (netdb.Attributes["IP"].Value.Equals(localdb1.Attributes["IP"].Value) &&
                                netdb.Attributes["User"].Value.Equals(localdb1.Attributes["User"].Value) &&
                                netdb.Attributes["PWD"].Value.Equals(localdb1.Attributes["PWD"].Value))
                            {

                                foreach (XmlNode localsql3 in localSQL)
                                {
                                    if (localsql3.Attributes["DBID"].Value.Equals(localdb1.Attributes["ID"].Value))
                                        localsql3.Attributes["DBID"].Value = netdb.Attributes["ID"].Value;
                                }
                                localdb1.Attributes["ID"].Value = netdb.Attributes["ID"].Value;
                            }
                        }
                    }
                    // if local sql name are similar to net sql name
                    foreach (XmlNode netsql in netSQL)
                    {
                        foreach (XmlNode localsql2 in localSQL)
                        {
                            if (netsql.Attributes["Name"].Value.Equals(localsql2.Attributes["Name"].Value))
                            {
                                localsql2.Attributes["Name"].Value += DateTime.Now.ToString("mmssms", DateTimeFormatInfo.InvariantInfo);
                            }
                        }
                    }
                    XmlNode localsql = localDoc.SelectSingleNode("/DB2Excel");
                    foreach (XmlNode netsql in netSQL)
                    {
                        localsql.AppendChild(localDoc.ImportNode(netsql, false));
                    }
                    XmlNode localdb = localDoc.SelectSingleNode("/DB2Excel/DataSource");
                    foreach (XmlNode netdb in netDB)
                    {
                        foreach (XmlNode x in localDB)
                        {
                            if (!x.Attributes["ID"].Value.Equals(netdb.Attributes["ID"].Value))
                                localdb.AppendChild(localDoc.ImportNode(netdb, false));
                        }
                    }
                    localDoc.Save(localFile);
                    MessageBox.Show("配置文件合并成功!");
                }
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show("合并过程中出现了错误,建议重试\r\n"+e.Message, "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            


            return true;
        }

        public static int deleteConfigByName(string name,string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList scripts = doc.SelectNodes("/DB2Excel/Item");
            XmlNode scriptParent = doc.SelectSingleNode("/DB2Excel");
            XmlNode dbParent = doc.SelectSingleNode("/DB2Excel/DataSource");
            string dbid = "";
            bool isHave = false;
            #region remove scripts
            foreach (XmlNode item in scripts)
            {
                if (item.Attributes["Name"].Value.Equals(name))
                {
                    dbid = item.Attributes["DBID"].Value;
                    scriptParent.RemoveChild(item);
                    isHave = true;
                    break;
                }
            }
            #endregion

            #region remove db ,if there is no script that is combained with the db 
            XmlNodeList dbs = doc.SelectNodes("/DB2Excel/DataSource/Item");
            isHave = false;
            foreach (XmlNode item in scripts)
            {
                if (item.Attributes["DBID"].Value.Equals(dbid))
                {
                    isHave = true;
                    break;
                }
            }
            isHave = !isHave;
            // no isHave=true means the datasource need to be deleted
            if (isHave)
            {
                foreach (XmlNode item in dbs)
                {
                    if (item.Attributes["ID"].Value.Equals(dbid))
                    {
                        dbid = item.Attributes["DBID"].Value;
                        dbParent.RemoveChild(item);
                        isHave = true;
                    }
                }
                isHave = false;
            }

            #endregion
            doc.Save(fileName);
            return 0;
        }
    }

    class Scripts
    {
        private string dbid;
        private string name;
        private string sql;
        private string db;

        public Scripts(string name, string sql, string db)
        {
            this.name = name;
            this.sql = sql;
            this.db = db;
        }

        public Scripts(string dbid, string name, string sql, string db)
        {
            this.dbid = dbid;
            this.name = name;
            this.sql = sql;
            this.db = db;
        }

        public string Name { get => name; set => name = value; }
        public string Sql { get => sql; set => sql = value; }
        public string Db { get => db; set => db = value; }
        public string Dbid { get => dbid; set => dbid = value; }
    }
    class DataSource {
        private string id;
        private string ip;
        private string user;
        private string pwd;

        public DataSource(string ip, string user, string pwd)
        {
            this.ip = ip;
            this.user = user;
            this.pwd = pwd;
        }

        public DataSource(string id, string ip, string user, string pwd)
        {
            this.Id = id;
            this.Ip = ip;
            this.User = user;
            this.Pwd = pwd;
        }

        public string Id { get => id; set => id = value; }
        public string Ip { get => ip; set => ip = value; }
        public string User { get => user; set => user = value; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}
