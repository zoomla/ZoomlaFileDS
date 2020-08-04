using System.Data.Entity;

namespace DataLayer.DAL
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("XCLWinKitsDB")
        {
        }

        /// <summary>
        /// 表名不要自动生成复数
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        /// <summary>
        /// 文件替换规则
        /// </summary>
        public DbSet<DataLayer.Model.FileReplace_RuleConfig> FileReplace_RuleConfig { get; set; }

        /// <summary>
        /// 文件替换规则视图
        /// </summary>
        public DbSet<DataLayer.Model.v_FileReplace_RuleConfig> v_FileReplace_RuleConfig { get; set; }

        /// <summary>
        /// 文件替换列表
        /// </summary>
        public DbSet<DataLayer.Model.FileReplace_File> FileReplace_File { get; set; }

        /// <summary>
        /// 文件替换列表视图
        /// </summary>
        public DbSet<DataLayer.Model.v_FileReplace_File> v_FileReplace_File { get; set; }

        /// <summary>
        /// 文件替换列表视图（用于导出）
        /// </summary>
        public DbSet<DataLayer.Model.v_FileReplace_File_ForExport> v_FileReplace_File_ForExport { get; set; }

        /// <summary>
        /// 用户设置
        /// </summary>
        public DbSet<DataLayer.Model.UserSetting> UserSetting { get; set; }
    }
}