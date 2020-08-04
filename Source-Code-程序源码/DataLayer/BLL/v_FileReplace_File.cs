using System.Collections.Generic;
using System.Linq;

namespace DataLayer.BLL
{
    public class v_FileReplace_File
    {
        public List<DataLayer.Model.v_FileReplace_File> GetAllList()
        {
            using (var context = new DataLayer.DAL.MyDBContext())
            {
                return (from tb in context.v_FileReplace_File select tb).ToList();
            }
        }
    }
}