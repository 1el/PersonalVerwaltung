using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVerwaltung
{
    public class queryResult
    {
        public string ma_id
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

        public string column4
        {
            get;
        }

        public string column5
        {
            get;
        }

        public string column6
        {
            get;
        }

        public string column7
        {
            get;
        }

        public queryResult(string ma_id, string nachname, string vorname, string c4, string c5, string c6)
        {
            this.ma_id = ma_id;
            this.nachname = nachname;
            this.vorname = vorname;
            this.column4 = c4;
            this.column5 = c5;
            this.column6 = c6;
        }

        public queryResult(string ma_id, string nachname, string vorname, string c4, string c5, string c6, string c7)
        {
            this.ma_id = ma_id;
            this.nachname = nachname;
            this.vorname = vorname;
            this.column4 = c4;
            this.column5 = c5;
            this.column6 = c6;
            this.column7 = c7;
        }
    }
}
