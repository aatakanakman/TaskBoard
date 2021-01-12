using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    class Proje
    {
        public string ad { get; set; }
        public string tarih { get; set; }
        public int userId { get; set; }
        public string not { get; set; }
        public string aciklama { get; set; }
        public string tahminiSure { get; set; }
        public string gercekSure { get; set; }


        public Proje()
        {
            this.gercekSure = "";
        }

    }
}
