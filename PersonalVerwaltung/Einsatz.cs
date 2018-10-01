using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVerwaltung
{
    public class Einsatz
    {
        public int e_id
        {
            get;
        }

        public int ma_id
        {
            get;
        }

        public DateTime e_datum
        {
            get;
        }

        public TimeSpan e_von
        {
            get;
        }

        public TimeSpan e_bis
        {
            get;
        }

        public Einsatz(int e_id, int ma_id, DateTime e_datum, TimeSpan e_von, TimeSpan e_bis)
        {
            this.e_id = e_id;
            this.ma_id = ma_id;
            this.e_datum = e_datum;
            this.e_von = e_von;
            this.e_bis = e_bis;
        }
    }
}
