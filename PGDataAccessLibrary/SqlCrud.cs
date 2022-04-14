using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGDataAccessLibrary
{
    public class SqlCrud
    {
        DataAccess db = new DataAccess();
        public List<PersonModel> GetAllPeople(string connectionString)
        {
            string sql = "SELECT * FROM public.\"People\" " ;
            var output = db.LoadData<PersonModel, dynamic>(sql, new { }, connectionString).ToList();
            return output;
        }
    }
}
