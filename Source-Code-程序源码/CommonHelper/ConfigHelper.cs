using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace CommonHelper
{
    public static class ConfigHelper
    {
        private static CommonHelper.Model.Config _config = null;

        /// <summary>
        /// 获取当前应用程序根目录（末尾不带\）
        /// </summary>
        public static string RootPath
        {
            get { return System.Windows.Forms.Application.StartupPath.TrimEnd('\\'); }
        }

        #region Config.xml

        /// <summary>
        /// Config.xml的路径
        /// </summary>
        /// <returns></returns>
        public static string CategoryConfigPath
        {
            get { return string.Format(@"{0}\Config\Config.xml", RootPath); }
        }

        /// <summary>
        /// 配置
        /// </summary>
        public static CommonHelper.Model.Config Config
        {
            get
            {
                if (null == _config)
                {
                    _config = XCLNetTools.Serialize.XML.DeserializeFromXMLFile<CommonHelper.Model.Config>(CategoryConfigPath);
                }
                return _config;
            }
        }

        /// <summary>
        /// 返回程序集的描述，以便将文字描述放在form的标题栏中
        /// </summary>
        public static string GetCategoryNameInfo(string assemblyName)
        {
            string str = string.Empty;
            if (null != Config && null != Config.CategoryConfig && null != Config.CategoryConfig.CategoryList && Config.CategoryConfig.CategoryList.Count > 0)
            {
                var model = Config.CategoryConfig.CategoryList.FirstOrDefault(k => k.CategoryItemList.Exists(m => string.Equals(m.AssemblyName, assemblyName, StringComparison.CurrentCultureIgnoreCase)));
                if (null != model)
                {
                    str = string.Format("{0}--{1}", model.Name, model.CategoryItemList.FirstOrDefault(m => string.Equals(m.AssemblyName, assemblyName, StringComparison.CurrentCultureIgnoreCase)).Name);
                }
            }
            return str;
        }

        #endregion Config.xml

        #region Shell

        [DllImport("shell32.dll")]
        private extern static IntPtr ShellExecute(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        public enum ShowWindowCommands
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_MAX = 10
        }

        public static void OpenUrl(string url)
        {
            ShellExecute(0, @"open", url, null, null, (int)ShowWindowCommands.SW_NORMAL);
        }

        #endregion Shell
    }
}