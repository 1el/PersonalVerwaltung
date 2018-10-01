using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVerwaltung
{
    public class Mitarbeiter
    {
        public int ma_id
        {
            get;
        }

        public string nachname
        {
            get;
        }

        public string vorname
        {
            get;
        }

        public DateTime geburtsdatum
        {
            get;
            set;
        }

        public int tagesArbeitszeit
        {
            get;
            set;
        }

        public int urlaubsAnspruch
        {
            get;
            set;
        }

        public Mitarbeiter(int ma_id, string nachname, string vorname,
            DateTime geburtsdatum, int tagesArbeitszeit, int urlaubsAnspruch)
        {
            this.ma_id = ma_id;
            this.nachname = nachname;
            this.vorname = vorname;
            this.geburtsdatum = geburtsdatum;
            this.tagesArbeitszeit = tagesArbeitszeit;
            this.urlaubsAnspruch = urlaubsAnspruch;
        }

        public Mitarbeiter(int ma_id, string nachname, string vorname)
        {
            this.ma_id = ma_id;
            this.nachname = nachname;
            this.vorname = vorname;
            this.geburtsdatum = DateTime.Today;
            this.tagesArbeitszeit = 0;
            this.urlaubsAnspruch = 0;
        }
    }
}
