using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace PersonalVerwaltung
{
    public partial class Form1 : Form
    {
        private List<Mitarbeiter> listMA = new List<Mitarbeiter>();
        private List<Einsatz> listE = new List<Einsatz>();
        private List<Fehlzeit> listFZ = new List<Fehlzeit>();
        private List<Fehlgrund> listFG = new List<Fehlgrund>();

        private Datenbank db = new Datenbank();

        public Form1()
        {
            InitializeComponent();
            db.dbConnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateMA();
            updateEinsatz();
            updateFG();
            updateFZ();
            
        }
        
        #region Mitarbeiter
        private void updateMA()
        {
            listMA = db.getMitarbeiterFromDB();
            listBoxMA.Items.Clear();
            comboBox_E_MA.Items.Clear();
            comboBox_FZ_MA.Items.Clear();
            comboBoxExcel.Items.Clear();
            foreach (Mitarbeiter ma in listMA)
            {
                listBoxMA.Items.Add(ma.ma_id.ToString() + ". " + ma.vorname + " " + ma.nachname
                    + ", " + ma.geburtsdatum.ToShortDateString() + ", " + ma.tagesArbeitszeit.ToString()
                    + " Std/Tag, " + ma.urlaubsAnspruch.ToString() + " Tage/Jahr Urlaub");
                comboBox_E_MA.Items.Add(ma.ma_id.ToString() + " " + ma.vorname + " " + ma.nachname);
                comboBox_FZ_MA.Items.Add(ma.ma_id.ToString() + " " + ma.vorname + " " + ma.nachname);
                comboBoxAW.Items.Add(ma.ma_id.ToString() + " " + ma.vorname + " " + ma.nachname);
                comboBoxExcel.Items.Add(ma.ma_id.ToString() + " " + ma.vorname + " " + ma.nachname);
            }
        }

        private void btnNewMA_Click(object sender, EventArgs e)
        {
            clearMaForm();
        }

        private void btnSaveMA_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxMA.SelectedIndex == -1)
                {
                    if (!listMA.Exists(x => x.ma_id == Convert.ToInt32(textBox_MA_ID.Text))) // todo
                    {
                        db.saveNewMA(textBox_MA_ID.Text, textBox_MA_nachname.Text, textBox_MA_vorname.Text,
                            dateTimePicker_MA_Geburtsdatum.Value, textBox_MA_TArbeitszeit.Text,
                            textBox_MA_Urlaubsanspruch.Text);
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                else
                {
                    db.saveMA(listMA[listBoxMA.SelectedIndex].ma_id.ToString(), textBox_MA_nachname.Text,
                            textBox_MA_vorname.Text, dateTimePicker_MA_Geburtsdatum.Value,
                            textBox_MA_TArbeitszeit.Text, textBox_MA_Urlaubsanspruch.Text);
                }
                updateMA();
                clearMaForm();
            }
            catch (FormatException ex)
            {
                labelFehlerMA.Text = "ungueltige ID";
            }
            catch (ArgumentNullException ex)
            {
                labelFehlerMA.Text = "es fehlen Daten";
            }
        }

        private void btnDeleteMA_Click(object sender, EventArgs e)
        {
            if (listBoxMA.SelectedIndex != -1)
            {
                db.deleteMA(textBox_MA_ID.Text);
                updateMA();
                clearMaForm();
            }
        }

        private void listBoxMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMA.SelectedIndex != -1)
            {
                textBox_MA_ID.Text = listMA[listBoxMA.SelectedIndex].ma_id.ToString();
                textBox_MA_nachname.Text = listMA[listBoxMA.SelectedIndex].nachname;
                textBox_MA_vorname.Text = listMA[listBoxMA.SelectedIndex].vorname;
                dateTimePicker_MA_Geburtsdatum.Value = listMA[listBoxMA.SelectedIndex].geburtsdatum;
                textBox_MA_TArbeitszeit.Text = listMA[listBoxMA.SelectedIndex].tagesArbeitszeit.ToString();
                textBox_MA_Urlaubsanspruch.Text = listMA[listBoxMA.SelectedIndex].urlaubsAnspruch.ToString();
            }
        }
        
        private void clearMaForm()
        {
            textBox_MA_ID.Text = "";
            textBox_MA_nachname.Text = "";
            textBox_MA_vorname.Text = "";
            dateTimePicker_MA_Geburtsdatum.Value = new DateTime(1980, 1, 1);
            textBox_MA_TArbeitszeit.Text = "";
            textBox_MA_Urlaubsanspruch.Text = "";
            listBoxMA.SelectedIndex = -1;
            labelFehlerMA.Text = "";
        }
        #endregion

        #region Einsatz
        private void updateEinsatz()
        {
            listE = db.getEinsatzFromDB();
            listBoxEinsatz.Items.Clear();
            foreach (Einsatz e in listE)
            {
                listBoxEinsatz.Items.Add(e.ma_id.ToString() + ", am " + e.e_datum.ToShortDateString()
                    + " von " + e.e_von.ToString() + " bis " + e.e_bis.ToString());
            }
        }

        private void btnNewE_Click(object sender, EventArgs e)
        {
            clearEinsatzForm();
        }

        private void btnSaveE_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxEinsatz.SelectedIndex == -1)
                {
                    db.saveNewEinsatz(listMA[comboBox_E_MA.SelectedIndex].ma_id.ToString(), // get mitarbeiter ID from selected index
                            dateTimePicker_E_Datum.Value, maskedTextBox_E_von.Text, maskedTextBox_E_bis.Text);
                }
                else
                {
                    db.saveEinsatz(textBox_E_ID.Text, listMA[comboBox_E_MA.SelectedIndex].ma_id.ToString(),
                            dateTimePicker_E_Datum.Value, maskedTextBox_E_von.Text, maskedTextBox_E_bis.Text);
                }
                updateEinsatz();
                clearEinsatzForm();
            }
            catch (Exception ex)
            {
                labelFehlerEinsatz.Text = ex.Message; //"es fehlen Daten";
            }
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
            if (listBoxEinsatz.SelectedIndex != -1)
            {
                db.deleteEinsatz(textBox_E_ID.Text);
                updateEinsatz();
                clearEinsatzForm();
            }
        }

        private void listBoxEinsatz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEinsatz.SelectedIndex != -1)
            {
                textBox_E_ID.Text = listE[listBoxEinsatz.SelectedIndex].e_id.ToString();
                comboBox_E_MA.SelectedIndex = listMA.FindIndex(ma => ma.ma_id == listE[listBoxEinsatz.SelectedIndex].ma_id);
                dateTimePicker_E_Datum.Value = listE[listBoxEinsatz.SelectedIndex].e_datum;
                maskedTextBox_E_von.Text = listE[listBoxEinsatz.SelectedIndex].e_von.ToString();
                maskedTextBox_E_bis.Text = listE[listBoxEinsatz.SelectedIndex].e_bis.ToString();
            }
        }

        private void clearEinsatzForm()
        {
            listBoxEinsatz.SelectedIndex = -1;
            textBox_E_ID.Text = "";
            comboBox_E_MA.SelectedIndex = -1;
            dateTimePicker_E_Datum.Value = DateTime.Today;
            maskedTextBox_E_von.Text = "";
            maskedTextBox_E_bis.Text = "";
            labelFehlerEinsatz.Text = "";
        }
        #endregion

        #region Fehlgrund
        private void updateFG()
        {
            listFG = db.getFehlgrundFromDB();
            listBoxFehlgruende.Items.Clear();
            foreach (Fehlgrund fg in listFG)
            {
                listBoxFehlgruende.Items.Add(fg.fehlgrund);
                comboBox_FZ_fehlgrund.Items.Add(fg.fehlgrund);
            }
        }

        private void btnNewFG_Click(object sender, EventArgs e)
        {
            clearFgForm();
        }

        private void btnSaveFG_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFehlgruende.SelectedIndex == -1)
                {
                    db.saveNewFehlgrund(textBox_FG_grund.Text);
                }
                else
                {
                    db.saveFehlgrund(textBox_FG_ID.Text, textBox_FG_grund.Text);
                }
                updateFG();
                clearFgForm();
            }
            catch
            {
                labelFehlerFG.Text = "es fehlen Daten";
            }
}
        
        private void btnDeleteFG_Click(object sender, EventArgs e)
        {
            if (listBoxFehlgruende.SelectedIndex != -1)
            {
                db.deleteFehlgrund(textBox_FG_ID.Text);
                updateFG();
                clearFgForm();
            }
        }

        private void listBoxFehlgruende_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFehlgruende.SelectedIndex != -1)
            {
                textBox_FG_ID.Text = listFG[listBoxFehlgruende.SelectedIndex].fg_id.ToString();
                textBox_FG_grund.Text = listFG[listBoxFehlgruende.SelectedIndex].fehlgrund.ToString();
            }
        }

        private void clearFgForm()
        {
            listBoxFehlgruende.SelectedIndex = -1;
            textBox_FG_ID.Text = "";
            textBox_FG_grund.Text = "";
            labelFehlerFG.Text = "";
        }
        #endregion

        #region Fehlzeit
        private void updateFZ()
        {
            listFZ = db.getFehlzeitFromDB();
            listBoxFehlzeiten.Items.Clear();
            foreach (Fehlzeit fz in listFZ)
            {
                listBoxFehlzeiten.Items.Add(fz.ma_id.ToString() + " vom " + fz.fz_von.ToShortDateString()
                    + " bis " + fz.fz_bis.ToShortDateString() + " Grund: " + fz.fehlgrund.ToString()
                    + ", " + fz.fehltage.ToString() + " Tage");
            }
        }

        private void btnNewFZ_Click(object sender, EventArgs e)
        {
            clearFzForm();
        }

        private void btnSaveFZ_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxFehlzeiten.SelectedIndex == -1)
                {
                    db.saveNewFehlzeit(listMA[comboBox_FZ_MA.SelectedIndex].ma_id.ToString(),
                        dateTimePicker_FZ_von.Value, dateTimePicker_FZ_bis.Value,
                        listFG[comboBox_FZ_fehlgrund.SelectedIndex].fg_id.ToString());
                }
                else
                {
                    db.saveFehlzeit(textBox_FZ_ID.Text, listMA[comboBox_FZ_MA.SelectedIndex].ma_id.ToString(),
                        dateTimePicker_FZ_von.Value, dateTimePicker_FZ_bis.Value,
                        listFG[comboBox_FZ_fehlgrund.SelectedIndex].fg_id.ToString());
                }
                updateFZ();
                clearFzForm();
            }
            catch
            {
                labelFehlerFZ.Text = "es fehlen Daten";
            }
        }

        private void btnDeleteFZ_Click(object sender, EventArgs e)
        {
            if (listBoxFehlzeiten.SelectedIndex != -1)
            {
                db.deleteFehlzeit(textBox_FZ_ID.Text);
                updateFZ();
                clearFzForm();
            }
        }

        private void listBoxFehlzeiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFehlzeiten.SelectedIndex != -1)
            {
                textBox_FZ_ID.Text = listFZ[listBoxFehlzeiten.SelectedIndex].fz_id.ToString();
                comboBox_FZ_MA.SelectedIndex = listMA.FindIndex(x => x.ma_id == listFZ[listBoxFehlzeiten.SelectedIndex].ma_id);
                dateTimePicker_FZ_von.Value = listFZ[listBoxFehlzeiten.SelectedIndex].fz_von;
                dateTimePicker_FZ_bis.Value = listFZ[listBoxFehlzeiten.SelectedIndex].fz_bis;
                comboBox_FZ_fehlgrund.SelectedIndex = listFG.FindIndex(x => x.fg_id == listFZ[listBoxFehlzeiten.SelectedIndex].fehlgrund);
                textBox_FZ_fehltage.Text = listFZ[listBoxFehlzeiten.SelectedIndex].fehltage.ToString();
            }
        }

        private void clearFzForm()
        {
            listBoxFehlzeiten.SelectedIndex = -1;
            textBox_FZ_ID.Text = "";
            comboBox_FZ_MA.SelectedIndex = -1;
            dateTimePicker_FZ_von.Value = DateTime.Today;
            dateTimePicker_FZ_bis.Value = DateTime.Today;
            comboBox_FZ_fehlgrund.SelectedIndex = -1;
            textBox_FZ_fehltage.Text = "";
            labelFehlerFZ.Text = "";
        }
        #endregion

        #region Auswertung (logic)
        private void rBtn_MA_alle_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_MA_alle.Checked)
                comboBoxAW.SelectedIndex = -1;
        }

        private void comboBoxAW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAW.SelectedIndex != -1)
                rBtn_MA_alle.Checked = false;
        }

        private void rBtnE_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnE.Checked)
            {
                checkBoxUrlaub.Checked = false;
                checkBoxKrank.Checked = false;
            }
        }

        private void rBtnFZ_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnFZ.Checked)
            {
                checkBoxKrank.Checked = true;
                checkBoxUrlaub.Checked = true;
            }
        }

        private void checkBoxUrlaub_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUrlaub.Checked == true)
                rBtnFZ.Checked = true;
        }

        private void checkBoxKrank_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKrank.Checked == true)
                rBtnFZ.Checked = true;
        }

        private void rBtnInsgesamt_CheckedChanged(object sender, EventArgs e) // hier Fehler: muss man 2 Mal drucken
        {
            if (rBtnInsgesamt.Checked)
            {
                textBoxJahr.Text = "";
                checkBoxMonat.Checked = false;
                textBoxMonat.Text = "";
            }
        }

        private void textBoxJahr_TextChanged(object sender, EventArgs e)
        {
            if(textBoxJahr.Text != "")
                rBtnYear.Checked = true;
        }

        private void checkBoxMonat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMonat.Checked)
                rBtnYear.Checked = true;
        }

        private void textBoxMonat_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMonat.Text != "")
            {
                rBtnYear.Checked = true;
                checkBoxMonat.Checked = true;
            }
        }
        #endregion

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rBtnYear.Checked && textBoxJahr.Text == "") rBtnInsgesamt.Checked = true;
            string strSel = "";
            int anzahl = 0;
            if (rBtnE.Checked)
            {
                strSel = " Mitarbeiter.Ma_Id, Nachname, Vorname, Datum, EinsatzVon_Zeit, EinsatzBis_Zeit"
                + " FROM Mitarbeiter, Einsatz WHERE Mitarbeiter.Ma_Id = Einsatz.MA_ID";
                anzahl = 6;
                if (rBtnYear.Checked && textBoxJahr.Text != "") // optional
                {
                    strSel += $" AND YEAR(Datum) = '{textBoxJahr.Text}'";
                    if (checkBoxMonat.Checked && textBoxMonat.Text != "") // optional
                        strSel += $" AND MONTH(Datum) = '{textBoxMonat.Text}'";
                }
            }
            else if (rBtnFZ.Checked)
            {
                strSel = " Mitarbeiter.Ma_Id, Nachname, Vorname, Von_Datum, Bis_Datum, DATEDIFF(bis_datum, von_datum)+1 as Fehltage, Grund"
                + " FROM Mitarbeiter, Fehlzeit, Fehlgrund "
                + " WHERE Mitarbeiter.Ma_Id = Fehlzeit.Ma_Id AND Fehlzeit.Fehlgrund = Fehlgrund.FG_Id";
                anzahl = 7;

                if (!checkBoxKrank.Checked) // optional
                    strSel += " AND Grund = 'Urlaub'";

                if(!checkBoxUrlaub.Checked) // optional
                    strSel += " AND Grund = 'Krank'";

                if (rBtnYear.Checked && textBoxJahr.Text != "") // optional
                {
                    strSel += $" AND YEAR(Von_Datum) = '{textBoxJahr.Text}'";
                    if (checkBoxMonat.Checked && textBoxMonat.Text != "") // optional
                        strSel += $" AND MONTH(Von_Datum) = '{textBoxMonat.Text}'";
                }
            }
            if (comboBoxAW.SelectedIndex != -1) // optional
                strSel += $" AND Mitarbeiter.Ma_Id = {listMA[comboBoxAW.SelectedIndex].ma_id.ToString()}";
            
            strSel += ";";
            string[,] result = db.sendSelect(strSel, anzahl);
            showResults(result);
        }

        private void showResults(string[,] arr)
        {
            dataGridView1.Rows.Clear();

            #region Column visibility, names & width
            if (arr.GetUpperBound(1) == 5)
            {
                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[3].HeaderText = "Datum";
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[4].Width = 50;
                dataGridView1.Columns[4].HeaderText = "Zeit von";
                dataGridView1.Columns[5].Visible = true;
                dataGridView1.Columns[5].Width = 50;
                dataGridView1.Columns[5].HeaderText = "Zeit bis";
                dataGridView1.Columns[6].Visible = false;
            }
            if (arr.GetUpperBound(1) == 6)
            {
                dataGridView1.Columns[0].Visible = true;
                dataGridView1.Columns[1].Visible = true;
                dataGridView1.Columns[2].Visible = true;
                dataGridView1.Columns[3].Visible = true;
                dataGridView1.Columns[3].HeaderText = "Datum von";
                dataGridView1.Columns[4].Visible = true;
                dataGridView1.Columns[4].Width = 73;
                dataGridView1.Columns[4].HeaderText = "Datum bis";
                dataGridView1.Columns[5].Visible = true;
                dataGridView1.Columns[5].Width = 40;
                dataGridView1.Columns[5].HeaderText = "Fehl- tage";
                dataGridView1.Columns[6].Visible = true;
                dataGridView1.Columns[6].HeaderText = "Fehl- grund";
            }
            #endregion

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                dataGridView1.Rows.Add();

                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = arr[i, j];
                }
            }
        }

        #region XML
        //importiert die Mitarbeiter aus der mitarbeiter.xml
        private void btnXmlGet_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument reader = new XmlDocument();
                reader.Load("mitarbeiter.xml");
                int i = 1;
                Form2 newMaDatenForm;
                foreach (XmlNode node in reader.DocumentElement.ChildNodes[0].ChildNodes)
                {
                    Mitarbeiter ma = new Mitarbeiter(listMA.Last().ma_id + i++, node.Attributes["name"].Value, node.Attributes["vorname"].Value);
                    newMaDatenForm = new Form2(ma);
                    newMaDatenForm.ShowDialog();
                    db.saveNewMA(ma.ma_id.ToString(), ma.nachname, ma.vorname, ma.geburtsdatum, ma.tagesArbeitszeit.ToString(), ma.urlaubsAnspruch.ToString());
                }
                updateMA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //importiert den gesamten DB aus XML-Datei
        private void getDBfromXML(string datei)
        {
            try
            {
                XmlDocument reader = new XmlDocument();
                reader.Load(datei);
                int i = 1;

                foreach (XmlNode node in reader.DocumentElement.ChildNodes[0].ChildNodes)
                    db.saveNewMA((listMA.Last().ma_id + i++).ToString(), // todo: MA mit IDs importieren
                        node.Attributes["Nachname"].Value,
                        node.Attributes["Vorname"].Value,
                        Convert.ToDateTime(node.Attributes["Geburtsdatum"].Value),
                        node.Attributes["tagesArbeitszeit"].Value,
                        node.Attributes["urlaubsAnspruch"].Value);

                foreach (XmlNode node in reader.DocumentElement.ChildNodes[1].ChildNodes)
                    db.saveNewEinsatz(node.Attributes["MitarbeiterID"].Value,
                        Convert.ToDateTime(node.Attributes["Datum"].Value),
                        node.Attributes["ZeitVon"].Value,
                        node.Attributes["ZeitBis"].Value);

                foreach (XmlNode node in reader.DocumentElement.ChildNodes[2].ChildNodes)
                    db.saveNewFehlzeit(node.Attributes["MitarbeiterID"].Value,
                        Convert.ToDateTime(node.Attributes["FehlzeitVon"].Value),
                        Convert.ToDateTime(node.Attributes["FehlzeitBis"].Value),
                        node.Attributes["Fehlgrund"].Value);

                foreach (XmlNode node in reader.DocumentElement.ChildNodes[3].ChildNodes)
                    db.saveNewFehlgrund(node.Attributes["Fehlgrund"].Value);

                updateMA();
                updateEinsatz();
                updateFZ();
                updateFG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // speichert alle Mitarbeiter in mitarbeiter2.xml
        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // XML-Datei erzeugen
                XmlTextWriter myXmlTextWriter = new XmlTextWriter("mitarbeiter2.xml", System.Text.Encoding.UTF8);
                myXmlTextWriter.Formatting = Formatting.Indented;
                myXmlTextWriter.WriteStartDocument(false);

                // Haupttag Init
                myXmlTextWriter.WriteStartElement("Personal");

                // Attribute schreiben 
                // andere Variante
                //myXmlTextWriter.WriteStartElement("Mitarbeiter", null);
                //myXmlTextWriter.WriteElementString("Nachname", "Hurtig");
                //myXmlTextWriter.WriteElementString("Vorname", "Hugo");
                //myXmlTextWriter.WriteEndElement();

                foreach(Mitarbeiter ma in listMA)
                {
                    myXmlTextWriter.WriteStartElement("Mitarbeiter", null);
                    myXmlTextWriter.WriteAttributeString("Nachname", ma.nachname);
                    myXmlTextWriter.WriteAttributeString("Vorname", ma.vorname);
                    myXmlTextWriter.WriteAttributeString("Geburtsdatum", ma.geburtsdatum.ToShortDateString());
                    myXmlTextWriter.WriteAttributeString("Tagesarbeitszeit", ma.tagesArbeitszeit.ToString());
                    myXmlTextWriter.WriteAttributeString("Urlaubsanspruch", ma.urlaubsAnspruch.ToString());
                    myXmlTextWriter.WriteEndElement();
                }
                // aufraeumen
                myXmlTextWriter.WriteEndElement(); // Init
                myXmlTextWriter.Flush();
                myXmlTextWriter.Close();
                MessageBox.Show("Alle Mitarbeiter wurden in einer XML-Datei erfolgreich geschrieben");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AusnahmeFehler XML-Schreiben. Bitte notieren. " + ex.Message);
            }
        }

        // speichert den gesamten Datenbank in personal_verwaltung.xml
        private void btnSaveDbInXml_Click(object sender, EventArgs e)
        {
            try
            {
                // XML-Datei erzeugen
                XmlTextWriter myXmlTextWriter = new XmlTextWriter("personal_verwaltung.xml", System.Text.Encoding.UTF8);
                myXmlTextWriter.Formatting = Formatting.Indented;
                myXmlTextWriter.WriteStartDocument(false);

                myXmlTextWriter.WriteStartElement("PersonalVerwaltung"); // Haupttag Init

                myXmlTextWriter.WriteStartElement("Mitarbeiter");
                foreach (Mitarbeiter ma in listMA)
                {
                    myXmlTextWriter.WriteStartElement("Mitarbeiter", null);
                    myXmlTextWriter.WriteAttributeString("MitarbeiterID", ma.ma_id.ToString());
                    myXmlTextWriter.WriteAttributeString("Nachname", ma.nachname);
                    myXmlTextWriter.WriteAttributeString("Vorname", ma.vorname);
                    myXmlTextWriter.WriteAttributeString("Geburtsdatum", ma.geburtsdatum.ToShortDateString());
                    myXmlTextWriter.WriteAttributeString("tagesArbeitszeit", ma.tagesArbeitszeit.ToString());
                    myXmlTextWriter.WriteAttributeString("urlaubsAnspruch", ma.urlaubsAnspruch.ToString());
                    myXmlTextWriter.WriteEndElement();
                }
                myXmlTextWriter.WriteEndElement(); // Mitarbeiter

                myXmlTextWriter.WriteStartElement("Einsatz");
                foreach (Einsatz ei in listE)
                {
                    myXmlTextWriter.WriteStartElement("Einsatz", null);
                    myXmlTextWriter.WriteAttributeString("EinsatzID", ei.e_id.ToString());
                    myXmlTextWriter.WriteAttributeString("MitarbeiterID", ei.ma_id.ToString());
                    myXmlTextWriter.WriteAttributeString("Datum", ei.e_datum.ToShortDateString());
                    myXmlTextWriter.WriteAttributeString("ZeitVon", ei.e_von.ToString());
                    myXmlTextWriter.WriteAttributeString("ZeitBis", ei.e_bis.ToString());
                    myXmlTextWriter.WriteEndElement();
                }
                myXmlTextWriter.WriteEndElement(); // Einsatz

                myXmlTextWriter.WriteStartElement("Fehlzeit");
                foreach (Fehlzeit fz in listFZ)
                {
                    myXmlTextWriter.WriteStartElement("Fehlzeit", null);
                    myXmlTextWriter.WriteAttributeString("FehlzeitID", fz.fz_id.ToString());
                    myXmlTextWriter.WriteAttributeString("MitarbeiterID", fz.ma_id.ToString());
                    myXmlTextWriter.WriteAttributeString("FehlzeitVon", fz.fz_von.ToShortDateString());
                    myXmlTextWriter.WriteAttributeString("FehlzeitBis", fz.fz_bis.ToShortDateString());
                    myXmlTextWriter.WriteAttributeString("Fehlgrund", fz.fehlgrund.ToString());
                    myXmlTextWriter.WriteAttributeString("Fehltage", fz.fehltage.ToString());
                    myXmlTextWriter.WriteEndElement();
                }
                myXmlTextWriter.WriteEndElement(); // Fehlzeit


                myXmlTextWriter.WriteStartElement("Fehlgrund");
                foreach (Fehlgrund fg in listFG)
                {
                    myXmlTextWriter.WriteStartElement("Fehlgrund", null);
                    myXmlTextWriter.WriteAttributeString("FehlgrundID", fg.fg_id.ToString());
                    myXmlTextWriter.WriteAttributeString("Fehlgrund", fg.fehlgrund);
                    myXmlTextWriter.WriteEndElement();
                }
                myXmlTextWriter.WriteEndElement(); // Fehlgrund

                // aufraeumen
                myXmlTextWriter.WriteEndElement(); // Init
                myXmlTextWriter.Flush();
                myXmlTextWriter.Close();
                MessageBox.Show("Der Datenbank wurde in einer XML-Datei erfolgreich geschrieben");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AusnahmeFehler XML-Schreiben. Bitte notieren. " + ex.Message);
            }
        }
        #endregion

        #region Drag&Drop
        private void labelDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void labelDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            string[] filesNames = (string[])e.Data.GetData(DataFormats.FileDrop, false); // alle Dateinamen werden in einem Array gespeichert

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (filesNames.Count() > 1) // wenn mehr als eine Datei gedroppt wird
                    MessageBox.Show("Immer nur eine Datei");
                else // wenn nur eine datei gedroppt wird
                {
                    string[] help = filesNames[0].Split('\\'); // Dateiname (mit Pfad) wird gesplitted und in einem Array gespeichert
                    labelDragDrop.Text = help[help.Count() - 1]; // von diesem Array nehmen wir das letzte Element, was dem Dateiname ohne Pfad entspricht
                    getDBfromXML(filesNames[0]); // der kompletten Pfad wird der Funktion übergeben
                }
            }
        }
        #endregion

        #region Excel
        private void ExcelEintragen(Mitarbeiter ma)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            Microsoft.Office.Interop.Excel.Workbook workbook = null;

            try
            {
                var fn = @"C:\Users\tn.DESKTOP-91L17BK\Documents\Visual Studio 2015\Projects\PersonalVerwaltung\PersonalVerwaltung\bin\Debug\auswertung_fehlzeiten2.xlsx";

                excel = new Microsoft.Office.Interop.Excel.Application();

                //excel.Visible = true;

                // Arbeitsmappe öffnen
                workbook = excel.Workbooks.Open(fn);

                // Arbeitsblatt  referenzieren
                // Tabelle öffnen

                Microsoft.Office.Interop.Excel.Worksheet worksheet = workbook.Worksheets[1];
                
                worksheet.Name = $"{ma.vorname} {ma.nachname}";
                /*
                // Hintergrundfarbe, Linienart, -staerke, -farbe, Format
                aRange.Cells.Borders.LineStyle = DataGridLineStyle.Solid;
                bRange.Cells.Interior.Color = System.Drawing.ColorTranslator.ToOle(col);
                bRange.Borders.Weight = 2;
                bRange.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                bRange.Borders.Color = Color.Black.ToArgb();
                String[] cellFormat = { "#####", "dd/mm/yyyy", "@", "#######0.00", "@", "@", "#######0.00 €" };
                bRange.NumberFormat = cellFormat[2];
                */

                // Ueberschrift: Mitarbeitername
                worksheet.Cells.ClearContents();
                Microsoft.Office.Interop.Excel.Range bRange = worksheet.get_Range("B2:B2");
                bRange.Value = $"{ma.vorname} {ma.nachname}";
                //bRange.Font.Size = 15;

                // Zelleneinstellungen
                //bRange.Cells.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Red);
                //bRange.Borders.Weight = 3;
                //bRange.Cells.Borders.LineStyle = DataGridLineStyle.Solid;
                //bRange.Borders.Color = Color.Black.ToArgb();

                // Tabellenkopf
                bRange = worksheet.get_Range("B4:B4");
                bRange.Value = "Datum von";
                bRange = worksheet.get_Range("C4:C4");
                bRange.Value = "Datum bis";
                bRange = worksheet.get_Range("D4:D4");
                bRange.Value = "Fehltage";
                bRange = worksheet.get_Range("E4:E4");
                bRange.Value = "Fehlgrund";

                // Eintraege
                int i = 5;
                char c = 'B';

                Dictionary<string, int> sum = new Dictionary<string, int>();

                //Hashtable sum = new Hashtable();
                foreach (var x in listFG)
                    sum.Add(x.fehlgrund, 0);

                sum.Add("gesamt", 0);
                //int[] sum = new int[listFG.Count()];

                foreach (var fz in listFZ)
                {
                    if(ma.ma_id == fz.ma_id)
                    {
                        bRange = worksheet.get_Range(incrementRange(c++, i));
                        bRange.Value = fz.fz_von.ToShortDateString();

                        bRange = worksheet.get_Range(incrementRange(c++, i));
                        bRange.Value = fz.fz_bis.ToShortDateString();

                        bRange = worksheet.get_Range(incrementRange(c++, i));
                        bRange.Value = fz.fehltage.ToString();

                        bRange = worksheet.get_Range(incrementRange(c++, i));
                        bRange.Value = listFG[listFG.FindIndex(fg => fg.fg_id == fz.fehlgrund)].fehlgrund;
                        // todo


                        sum[bRange.Value] += fz.fehltage;
                        sum["gesamt"] += fz.fehltage;

                        c = 'B';
                        i++;
                    }
                }

                i += 2;
                bRange = worksheet.get_Range(incrementRange('C', i));
                bRange.Value = "Summe:";
                bRange = worksheet.get_Range(incrementRange('D', i));
                bRange.Value = sum["gesamt"];

                sum.Remove("gesamt");

                i += 2;

                foreach (var x in sum)
                {
                    bRange = worksheet.get_Range(incrementRange('C', i));
                    bRange.Value = x.Key;
                    bRange = worksheet.get_Range(incrementRange('D', i));
                    bRange.Value = x.Value;
                    i++;
                }

                bRange = worksheet.get_Range(incrementRange('C', ++i));
                bRange.Value = "Resturlaub";
                bRange = worksheet.get_Range(incrementRange('D', i));
                bRange.Value = ma.urlaubsAnspruch - sum["Urlaub"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Arbeitsmappe speichern
                workbook.Save();

                // Excel beenden
                excel.Quit();
            }
        }

        private string incrementRange(char c, int i)
        {
            return $"{c}{i}:{c}{i}";
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            ExcelEintragen(listMA[comboBoxExcel.SelectedIndex]);
            comboBoxExcel.SelectedIndex = -1;
        }
        #endregion
    }
}
