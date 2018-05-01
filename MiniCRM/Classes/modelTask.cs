using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCRM.Classes
{
    class modelTask
    {
        public int ID { get; set; }
        public int idUser { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime dataStart { get; set; }
        public DateTime dataFinish { get; set; }
        public short percent { get; set; }
    }
}
