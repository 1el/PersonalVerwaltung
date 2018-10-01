using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVerwaltung
{
    public class Fehlzeit
    {
        public int fz_id
        {
            get;
        }

        public int ma_id
        {
            get;
        }
        
        public DateTime fz_von
        {
            get;
        }

        public DateTime fz_bis
        {
            get;
        }

        public int fehlgrund
        {
            get;
        }

        public int fehltage
        {
            get;
        }
        
        public Fehlzeit(int fz_id, int ma_id, DateTime fz_von, DateTime fz_bis, int fehlgrund, int fehltage)
        {
            this.fz_id = fz_id;
            this.ma_id = ma_id;
            this.fz_von = fz_von;
            this.fz_bis = fz_bis;
            this.fehlgrund = fehlgrund;
            this.fehltage = fehltage;
        }
    }
}
