using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Classes
{
    class DbContext: System.Data.Entity.DbContext
    {
        public DbContext():base("DBConnection")
        {

        }
        public List<modelUser> modelUsers { get; set; }
        public List<modelTask> modelTasks { get; set; }
    }
}
