using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public class Task
    {
        public string name { get; set; }
        public string desc { get; set; }
        public string note { get; set; }
        public string date { get; set; }

        public string estimatedTime { get; set; }
        public int durumId { get; set; }
        public int userId { get; set; }
        public int projeId { get; set; }
        public string proje_ad { get; set; }

    }
}
