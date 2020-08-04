using System.Linq;

namespace DataLayer.BLL
{
    public class UserSetting
    {
        public DataLayer.Model.UserSetting GetFirstModel()
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                return (from tb in context.UserSetting select tb).FirstOrDefault();
            }
        }

        public void Clear()
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                foreach (var m in context.UserSetting)
                {
                    context.UserSetting.Remove(m);
                }
                context.SaveChanges();
            }
        }

        public void Add(DataLayer.Model.UserSetting model)
        {
            this.Clear();
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                context.UserSetting.Add(model);
                context.SaveChanges();
            }
        }

        public DataLayer.Model.FileReplaceSetting GetFileReplaceSetting()
        {
            var model = this.GetFirstModel();
            if (null != model && !string.IsNullOrEmpty(model.FileReplaceSetting))
            {
                return XCLNetTools.Serialize.JSON.DeSerialize<DataLayer.Model.FileReplaceSetting>(model.FileReplaceSetting);
            }
            return null;
        }
    }
}