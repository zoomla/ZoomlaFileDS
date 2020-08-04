using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.BLL
{
    public class FileReplace_RuleConfig
    {
        public DataLayer.Model.FileReplace_RuleConfig GetModel(int ruleConfigId)
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                return (from tb in context.FileReplace_RuleConfig where tb.RuleConfigID == ruleConfigId select tb).FirstOrDefault();
            }
        }

        public bool IsExist(int ruleId)
        {
            return null != this.GetModel(ruleId);
        }

        public void Add(DataLayer.Model.FileReplace_RuleConfig model)
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                context.FileReplace_RuleConfig.Add(model);
                context.SaveChanges();
            }
        }

        public void Add(List<DataLayer.Model.FileReplace_RuleConfig> lst)
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                context.FileReplace_RuleConfig.AddRange(lst);
                context.SaveChanges();
            }
        }

        public void Update(DataLayer.Model.FileReplace_RuleConfig model)
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                var info = context.FileReplace_RuleConfig.FirstOrDefault(k => k.RuleConfigID == model.RuleConfigID);
                if (null == info)
                {
                    return;
                }
                info.IsFileContent = model.IsFileContent;
                info.IsFileName = model.IsFileName;
                info.IsIgnoreCase = model.IsIgnoreCase;
                info.IsRegex = model.IsRegex;
                info.IsWholeMatch = model.IsWholeMatch;
                info.Name = model.Name;
                info.NewContent = model.NewContent;
                info.OldContent = model.OldContent;
                info.UpdateTime = DateTime.Now;
                context.FileReplace_RuleConfig.Attach(info);
                context.Entry(info).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int ruleId)
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                var info = context.FileReplace_RuleConfig.FirstOrDefault(k => k.RuleConfigID == ruleId);
                if (null == info)
                {
                    return;
                }
                context.FileReplace_RuleConfig.Attach(info);
                context.FileReplace_RuleConfig.Remove(info);
                context.SaveChanges();
            }
        }

        public List<DataLayer.Model.FileReplace_RuleConfig> GetAllList()
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                return (from tb in context.FileReplace_RuleConfig orderby tb.CreateTime descending select tb).ToList();
            }
        }
    }
}