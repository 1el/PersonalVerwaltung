using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalVerwaltung
{
    public partial class Form2 : Form
    {
        private Mitarbeiter ma;
        public Form2(Mitarbeiter ma)
        {
            InitializeComponent();
            this.ma = ma;
            labelMA_name.Text = ma.vorname + " " + ma.nachname;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ma.geburtsdatum = dateTimePickerMaXml.Value;
            ma.tagesArbeitszeit = Convert.ToInt32(textBoxMaXmlAZ.Text);
            ma.urlaubsAnspruch = Convert.ToInt32(textBoxMaXmlUrlaub.Text);
        }
    }
}
