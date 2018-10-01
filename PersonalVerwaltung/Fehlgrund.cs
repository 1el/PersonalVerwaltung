using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVerwaltung
{
    public class Fehlgrund
    {
        public int fg_id
        {
            get;
        }

        public string fehlgrund
        {
            get;
        }

        public Fehlgrund(int fg_id, string fehlgrund)
        {
            this.fg_id = fg_id;
            this.fehlgrund = fehlgrund;
        }
    }
}
