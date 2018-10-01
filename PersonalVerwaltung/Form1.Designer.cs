namespace PersonalVerwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMA = new System.Windows.Forms.TabPage();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlGet = new System.Windows.Forms.Button();
            this.labelFehlerMA = new System.Windows.Forms.Label();
            this.btnDeleteMA = new System.Windows.Forms.Button();
            this.btnNewMA = new System.Windows.Forms.Button();
            this.btnSaveMA = new System.Windows.Forms.Button();
            this.listBoxMA = new System.Windows.Forms.ListBox();
            this.label_MA_Geburtsdatum = new System.Windows.Forms.Label();
            this.dateTimePicker_MA_Geburtsdatum = new System.Windows.Forms.DateTimePicker();
            this.label_MA_Urlaubsanspruch = new System.Windows.Forms.Label();
            this.textBox_MA_Urlaubsanspruch = new System.Windows.Forms.TextBox();
            this.label_Ma_TArbeitszeit = new System.Windows.Forms.Label();
            this.textBox_MA_TArbeitszeit = new System.Windows.Forms.TextBox();
            this.label_MA_ID = new System.Windows.Forms.Label();
            this.textBox_MA_ID = new System.Windows.Forms.TextBox();
            this.label_MA_nachname = new System.Windows.Forms.Label();
            this.textBox_MA_nachname = new System.Windows.Forms.TextBox();
            this.label_MA_vorname = new System.Windows.Forms.Label();
            this.textBox_MA_vorname = new System.Windows.Forms.TextBox();
            this.tabPageEinsatz = new System.Windows.Forms.TabPage();
            this.maskedTextBox_E_bis = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_E_von = new System.Windows.Forms.MaskedTextBox();
            this.labelFehlerEinsatz = new System.Windows.Forms.Label();
            this.btnDeleteE = new System.Windows.Forms.Button();
            this.btnNewE = new System.Windows.Forms.Button();
            this.btnSaveE = new System.Windows.Forms.Button();
            this.label_E_bis = new System.Windows.Forms.Label();
            this.label_E_von = new System.Windows.Forms.Label();
            this.label_E_Datum = new System.Windows.Forms.Label();
            this.dateTimePicker_E_Datum = new System.Windows.Forms.DateTimePicker();
            this.comboBox_E_MA = new System.Windows.Forms.ComboBox();
            this.label_E_ID = new System.Windows.Forms.Label();
            this.textBox_E_ID = new System.Windows.Forms.TextBox();
            this.label_E_MA = new System.Windows.Forms.Label();
            this.listBoxEinsatz = new System.Windows.Forms.ListBox();
            this.tabPageFehlzeiten = new System.Windows.Forms.TabPage();
            this.labelFehlerFZ = new System.Windows.Forms.Label();
            this.btnDeleteFZ = new System.Windows.Forms.Button();
            this.comboBox_FZ_fehlgrund = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_FZ_von = new System.Windows.Forms.DateTimePicker();
            this.comboBox_FZ_MA = new System.Windows.Forms.ComboBox();
            this.btnNewFZ = new System.Windows.Forms.Button();
            this.btnSaveFZ = new System.Windows.Forms.Button();
            this.listBoxFehlzeiten = new System.Windows.Forms.ListBox();
            this.label_FZ_bis = new System.Windows.Forms.Label();
            this.dateTimePicker_FZ_bis = new System.Windows.Forms.DateTimePicker();
            this.label_FZ_fehltage = new System.Windows.Forms.Label();
            this.textBox_FZ_fehltage = new System.Windows.Forms.TextBox();
            this.label_FZ_fehlgrund = new System.Windows.Forms.Label();
            this.label_FZ_ID = new System.Windows.Forms.Label();
            this.textBox_FZ_ID = new System.Windows.Forms.TextBox();
            this.label_FZ_von = new System.Windows.Forms.Label();
            this.label_FZ_MA = new System.Windows.Forms.Label();
            this.tabPageFehlgruende = new System.Windows.Forms.TabPage();
            this.labelFehlerFG = new System.Windows.Forms.Label();
            this.btnDeleteFG = new System.Windows.Forms.Button();
            this.btnNewFG = new System.Windows.Forms.Button();
            this.btnSaveFG = new System.Windows.Forms.Button();
            this.listBoxFehlgruende = new System.Windows.Forms.ListBox();
            this.label_FG_ID = new System.Windows.Forms.Label();
            this.textBox_FG_ID = new System.Windows.Forms.TextBox();
            this.label_FG_Fehlgrund = new System.Windows.Forms.Label();
            this.textBox_FG_grund = new System.Windows.Forms.TextBox();
            this.TabPageAuswertungen = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxMonat = new System.Windows.Forms.CheckBox();
            this.rBtnInsgesamt = new System.Windows.Forms.RadioButton();
            this.rBtnYear = new System.Windows.Forms.RadioButton();
            this.textBoxJahr = new System.Windows.Forms.TextBox();
            this.textBoxMonat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtnFZ = new System.Windows.Forms.RadioButton();
            this.rBtnE = new System.Windows.Forms.RadioButton();
            this.checkBoxUrlaub = new System.Windows.Forms.CheckBox();
            this.checkBoxKrank = new System.Windows.Forms.CheckBox();
            this.panelMA = new System.Windows.Forms.Panel();
            this.rBtn_MA_alle = new System.Windows.Forms.RadioButton();
            this.comboBoxAW = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ma_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageExcel = new System.Windows.Forms.TabPage();
            this.btnSaveExcel = new System.Windows.Forms.Button();
            this.comboBoxExcel = new System.Windows.Forms.ComboBox();
            this.btnSaveDbInXml = new System.Windows.Forms.Button();
            this.labelDragDrop = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageMA.SuspendLayout();
            this.tabPageEinsatz.SuspendLayout();
            this.tabPageFehlzeiten.SuspendLayout();
            this.tabPageFehlgruende.SuspendLayout();
            this.TabPageAuswertungen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMA);
            this.tabControl1.Controls.Add(this.tabPageEinsatz);
            this.tabControl1.Controls.Add(this.tabPageFehlzeiten);
            this.tabControl1.Controls.Add(this.tabPageFehlgruende);
            this.tabControl1.Controls.Add(this.TabPageAuswertungen);
            this.tabControl1.Controls.Add(this.tabPageExcel);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMA
            // 
            this.tabPageMA.Controls.Add(this.btnXmlWrite);
            this.tabPageMA.Controls.Add(this.btnXmlGet);
            this.tabPageMA.Controls.Add(this.labelFehlerMA);
            this.tabPageMA.Controls.Add(this.btnDeleteMA);
            this.tabPageMA.Controls.Add(this.btnNewMA);
            this.tabPageMA.Controls.Add(this.btnSaveMA);
            this.tabPageMA.Controls.Add(this.listBoxMA);
            this.tabPageMA.Controls.Add(this.label_MA_Geburtsdatum);
            this.tabPageMA.Controls.Add(this.dateTimePicker_MA_Geburtsdatum);
            this.tabPageMA.Controls.Add(this.label_MA_Urlaubsanspruch);
            this.tabPageMA.Controls.Add(this.textBox_MA_Urlaubsanspruch);
            this.tabPageMA.Controls.Add(this.label_Ma_TArbeitszeit);
            this.tabPageMA.Controls.Add(this.textBox_MA_TArbeitszeit);
            this.tabPageMA.Controls.Add(this.label_MA_ID);
            this.tabPageMA.Controls.Add(this.textBox_MA_ID);
            this.tabPageMA.Controls.Add(this.label_MA_nachname);
            this.tabPageMA.Controls.Add(this.textBox_MA_nachname);
            this.tabPageMA.Controls.Add(this.label_MA_vorname);
            this.tabPageMA.Controls.Add(this.textBox_MA_vorname);
            this.tabPageMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMA.Location = new System.Drawing.Point(4, 25);
            this.tabPageMA.Name = "tabPageMA";
            this.tabPageMA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMA.Size = new System.Drawing.Size(589, 344);
            this.tabPageMA.TabIndex = 0;
            this.tabPageMA.Text = "Mitarbeiter";
            this.tabPageMA.UseVisualStyleBackColor = true;
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(490, 308);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(83, 23);
            this.btnXmlWrite.TabIndex = 19;
            this.btnXmlWrite.Text = "in XML";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnXmlGet
            // 
            this.btnXmlGet.Location = new System.Drawing.Point(373, 308);
            this.btnXmlGet.Name = "btnXmlGet";
            this.btnXmlGet.Size = new System.Drawing.Size(81, 23);
            this.btnXmlGet.TabIndex = 17;
            this.btnXmlGet.Text = "von XML";
            this.btnXmlGet.UseVisualStyleBackColor = true;
            this.btnXmlGet.Click += new System.EventHandler(this.btnXmlGet_Click);
            // 
            // labelFehlerMA
            // 
            this.labelFehlerMA.AutoSize = true;
            this.labelFehlerMA.ForeColor = System.Drawing.Color.Red;
            this.labelFehlerMA.Location = new System.Drawing.Point(370, 255);
            this.labelFehlerMA.Name = "labelFehlerMA";
            this.labelFehlerMA.Size = new System.Drawing.Size(0, 13);
            this.labelFehlerMA.TabIndex = 16;
            // 
            // btnDeleteMA
            // 
            this.btnDeleteMA.Location = new System.Drawing.Point(423, 276);
            this.btnDeleteMA.Name = "btnDeleteMA";
            this.btnDeleteMA.Size = new System.Drawing.Size(63, 23);
            this.btnDeleteMA.TabIndex = 14;
            this.btnDeleteMA.Text = "loeschen";
            this.btnDeleteMA.UseVisualStyleBackColor = true;
            this.btnDeleteMA.Click += new System.EventHandler(this.btnDeleteMA_Click);
            // 
            // btnNewMA
            // 
            this.btnNewMA.Location = new System.Drawing.Point(373, 276);
            this.btnNewMA.Name = "btnNewMA";
            this.btnNewMA.Size = new System.Drawing.Size(34, 23);
            this.btnNewMA.TabIndex = 13;
            this.btnNewMA.Text = "neu";
            this.btnNewMA.UseVisualStyleBackColor = true;
            this.btnNewMA.Click += new System.EventHandler(this.btnNewMA_Click);
            // 
            // btnSaveMA
            // 
            this.btnSaveMA.Location = new System.Drawing.Point(507, 276);
            this.btnSaveMA.Name = "btnSaveMA";
            this.btnSaveMA.Size = new System.Drawing.Size(66, 23);
            this.btnSaveMA.TabIndex = 15;
            this.btnSaveMA.Text = "speichern";
            this.btnSaveMA.UseVisualStyleBackColor = true;
            this.btnSaveMA.Click += new System.EventHandler(this.btnSaveMA_Click);
            // 
            // listBoxMA
            // 
            this.listBoxMA.FormattingEnabled = true;
            this.listBoxMA.Location = new System.Drawing.Point(16, 15);
            this.listBoxMA.Name = "listBoxMA";
            this.listBoxMA.Size = new System.Drawing.Size(348, 316);
            this.listBoxMA.TabIndex = 0;
            this.listBoxMA.SelectedIndexChanged += new System.EventHandler(this.listBoxMA_SelectedIndexChanged);
            // 
            // label_MA_Geburtsdatum
            // 
            this.label_MA_Geburtsdatum.AutoSize = true;
            this.label_MA_Geburtsdatum.Location = new System.Drawing.Point(370, 131);
            this.label_MA_Geburtsdatum.Name = "label_MA_Geburtsdatum";
            this.label_MA_Geburtsdatum.Size = new System.Drawing.Size(73, 13);
            this.label_MA_Geburtsdatum.TabIndex = 7;
            this.label_MA_Geburtsdatum.Text = "Geburtsdatum";
            // 
            // dateTimePicker_MA_Geburtsdatum
            // 
            this.dateTimePicker_MA_Geburtsdatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_MA_Geburtsdatum.Location = new System.Drawing.Point(373, 147);
            this.dateTimePicker_MA_Geburtsdatum.MaxDate = new System.DateTime(2018, 7, 3, 0, 0, 0, 0);
            this.dateTimePicker_MA_Geburtsdatum.Name = "dateTimePicker_MA_Geburtsdatum";
            this.dateTimePicker_MA_Geburtsdatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_MA_Geburtsdatum.TabIndex = 8;
            this.dateTimePicker_MA_Geburtsdatum.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label_MA_Urlaubsanspruch
            // 
            this.label_MA_Urlaubsanspruch.AutoSize = true;
            this.label_MA_Urlaubsanspruch.Location = new System.Drawing.Point(370, 209);
            this.label_MA_Urlaubsanspruch.Name = "label_MA_Urlaubsanspruch";
            this.label_MA_Urlaubsanspruch.Size = new System.Drawing.Size(134, 13);
            this.label_MA_Urlaubsanspruch.TabIndex = 11;
            this.label_MA_Urlaubsanspruch.Text = "Urlaubsanspruch (pro Jahr)";
            // 
            // textBox_MA_Urlaubsanspruch
            // 
            this.textBox_MA_Urlaubsanspruch.Location = new System.Drawing.Point(373, 225);
            this.textBox_MA_Urlaubsanspruch.Name = "textBox_MA_Urlaubsanspruch";
            this.textBox_MA_Urlaubsanspruch.Size = new System.Drawing.Size(200, 20);
            this.textBox_MA_Urlaubsanspruch.TabIndex = 12;
            // 
            // label_Ma_TArbeitszeit
            // 
            this.label_Ma_TArbeitszeit.AutoSize = true;
            this.label_Ma_TArbeitszeit.Location = new System.Drawing.Point(370, 170);
            this.label_Ma_TArbeitszeit.Name = "label_Ma_TArbeitszeit";
            this.label_Ma_TArbeitszeit.Size = new System.Drawing.Size(84, 13);
            this.label_Ma_TArbeitszeit.TabIndex = 9;
            this.label_Ma_TArbeitszeit.Text = "Tagesarbeitszeit";
            // 
            // textBox_MA_TArbeitszeit
            // 
            this.textBox_MA_TArbeitszeit.Location = new System.Drawing.Point(373, 186);
            this.textBox_MA_TArbeitszeit.Name = "textBox_MA_TArbeitszeit";
            this.textBox_MA_TArbeitszeit.Size = new System.Drawing.Size(200, 20);
            this.textBox_MA_TArbeitszeit.TabIndex = 10;
            // 
            // label_MA_ID
            // 
            this.label_MA_ID.AutoSize = true;
            this.label_MA_ID.Location = new System.Drawing.Point(370, 14);
            this.label_MA_ID.Name = "label_MA_ID";
            this.label_MA_ID.Size = new System.Drawing.Size(67, 13);
            this.label_MA_ID.TabIndex = 1;
            this.label_MA_ID.Text = "MitarbeiterID";
            // 
            // textBox_MA_ID
            // 
            this.textBox_MA_ID.Location = new System.Drawing.Point(373, 30);
            this.textBox_MA_ID.Name = "textBox_MA_ID";
            this.textBox_MA_ID.Size = new System.Drawing.Size(200, 20);
            this.textBox_MA_ID.TabIndex = 2;
            // 
            // label_MA_nachname
            // 
            this.label_MA_nachname.AutoSize = true;
            this.label_MA_nachname.Location = new System.Drawing.Point(370, 53);
            this.label_MA_nachname.Name = "label_MA_nachname";
            this.label_MA_nachname.Size = new System.Drawing.Size(59, 13);
            this.label_MA_nachname.TabIndex = 3;
            this.label_MA_nachname.Text = "Nachname";
            // 
            // textBox_MA_nachname
            // 
            this.textBox_MA_nachname.Location = new System.Drawing.Point(373, 69);
            this.textBox_MA_nachname.Name = "textBox_MA_nachname";
            this.textBox_MA_nachname.Size = new System.Drawing.Size(200, 20);
            this.textBox_MA_nachname.TabIndex = 4;
            // 
            // label_MA_vorname
            // 
            this.label_MA_vorname.AutoSize = true;
            this.label_MA_vorname.Location = new System.Drawing.Point(370, 92);
            this.label_MA_vorname.Name = "label_MA_vorname";
            this.label_MA_vorname.Size = new System.Drawing.Size(49, 13);
            this.label_MA_vorname.TabIndex = 5;
            this.label_MA_vorname.Text = "Vorname";
            // 
            // textBox_MA_vorname
            // 
            this.textBox_MA_vorname.Location = new System.Drawing.Point(373, 108);
            this.textBox_MA_vorname.Name = "textBox_MA_vorname";
            this.textBox_MA_vorname.Size = new System.Drawing.Size(200, 20);
            this.textBox_MA_vorname.TabIndex = 6;
            // 
            // tabPageEinsatz
            // 
            this.tabPageEinsatz.Controls.Add(this.maskedTextBox_E_bis);
            this.tabPageEinsatz.Controls.Add(this.maskedTextBox_E_von);
            this.tabPageEinsatz.Controls.Add(this.labelFehlerEinsatz);
            this.tabPageEinsatz.Controls.Add(this.btnDeleteE);
            this.tabPageEinsatz.Controls.Add(this.btnNewE);
            this.tabPageEinsatz.Controls.Add(this.btnSaveE);
            this.tabPageEinsatz.Controls.Add(this.label_E_bis);
            this.tabPageEinsatz.Controls.Add(this.label_E_von);
            this.tabPageEinsatz.Controls.Add(this.label_E_Datum);
            this.tabPageEinsatz.Controls.Add(this.dateTimePicker_E_Datum);
            this.tabPageEinsatz.Controls.Add(this.comboBox_E_MA);
            this.tabPageEinsatz.Controls.Add(this.label_E_ID);
            this.tabPageEinsatz.Controls.Add(this.textBox_E_ID);
            this.tabPageEinsatz.Controls.Add(this.label_E_MA);
            this.tabPageEinsatz.Controls.Add(this.listBoxEinsatz);
            this.tabPageEinsatz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEinsatz.Location = new System.Drawing.Point(4, 25);
            this.tabPageEinsatz.Name = "tabPageEinsatz";
            this.tabPageEinsatz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEinsatz.Size = new System.Drawing.Size(589, 344);
            this.tabPageEinsatz.TabIndex = 1;
            this.tabPageEinsatz.Text = "Einsatz";
            this.tabPageEinsatz.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_E_bis
            // 
            this.maskedTextBox_E_bis.Location = new System.Drawing.Point(369, 215);
            this.maskedTextBox_E_bis.Mask = "90:00";
            this.maskedTextBox_E_bis.Name = "maskedTextBox_E_bis";
            this.maskedTextBox_E_bis.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox_E_bis.TabIndex = 32;
            this.maskedTextBox_E_bis.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox_E_von
            // 
            this.maskedTextBox_E_von.Location = new System.Drawing.Point(369, 168);
            this.maskedTextBox_E_von.Mask = "90:00";
            this.maskedTextBox_E_von.Name = "maskedTextBox_E_von";
            this.maskedTextBox_E_von.Size = new System.Drawing.Size(199, 20);
            this.maskedTextBox_E_von.TabIndex = 31;
            this.maskedTextBox_E_von.ValidatingType = typeof(System.DateTime);
            // 
            // labelFehlerEinsatz
            // 
            this.labelFehlerEinsatz.AutoSize = true;
            this.labelFehlerEinsatz.ForeColor = System.Drawing.Color.Red;
            this.labelFehlerEinsatz.Location = new System.Drawing.Point(369, 247);
            this.labelFehlerEinsatz.Name = "labelFehlerEinsatz";
            this.labelFehlerEinsatz.Size = new System.Drawing.Size(0, 13);
            this.labelFehlerEinsatz.TabIndex = 30;
            // 
            // btnDeleteE
            // 
            this.btnDeleteE.Location = new System.Drawing.Point(423, 266);
            this.btnDeleteE.Name = "btnDeleteE";
            this.btnDeleteE.Size = new System.Drawing.Size(63, 23);
            this.btnDeleteE.TabIndex = 28;
            this.btnDeleteE.Text = "loeschen";
            this.btnDeleteE.UseVisualStyleBackColor = true;
            this.btnDeleteE.Click += new System.EventHandler(this.btnDeleteE_Click);
            // 
            // btnNewE
            // 
            this.btnNewE.Location = new System.Drawing.Point(369, 266);
            this.btnNewE.Name = "btnNewE";
            this.btnNewE.Size = new System.Drawing.Size(35, 23);
            this.btnNewE.TabIndex = 27;
            this.btnNewE.Text = "neu";
            this.btnNewE.UseVisualStyleBackColor = true;
            this.btnNewE.Click += new System.EventHandler(this.btnNewE_Click);
            // 
            // btnSaveE
            // 
            this.btnSaveE.Location = new System.Drawing.Point(502, 266);
            this.btnSaveE.Name = "btnSaveE";
            this.btnSaveE.Size = new System.Drawing.Size(66, 23);
            this.btnSaveE.TabIndex = 29;
            this.btnSaveE.Text = "speichern";
            this.btnSaveE.UseVisualStyleBackColor = true;
            this.btnSaveE.Click += new System.EventHandler(this.btnSaveE_Click);
            // 
            // label_E_bis
            // 
            this.label_E_bis.AutoSize = true;
            this.label_E_bis.Location = new System.Drawing.Point(366, 199);
            this.label_E_bis.Name = "label_E_bis";
            this.label_E_bis.Size = new System.Drawing.Size(20, 13);
            this.label_E_bis.TabIndex = 25;
            this.label_E_bis.Text = "bis";
            // 
            // label_E_von
            // 
            this.label_E_von.AutoSize = true;
            this.label_E_von.Location = new System.Drawing.Point(366, 151);
            this.label_E_von.Name = "label_E_von";
            this.label_E_von.Size = new System.Drawing.Size(25, 13);
            this.label_E_von.TabIndex = 23;
            this.label_E_von.Text = "von";
            // 
            // label_E_Datum
            // 
            this.label_E_Datum.AutoSize = true;
            this.label_E_Datum.Location = new System.Drawing.Point(366, 104);
            this.label_E_Datum.Name = "label_E_Datum";
            this.label_E_Datum.Size = new System.Drawing.Size(38, 13);
            this.label_E_Datum.TabIndex = 21;
            this.label_E_Datum.Text = "Datum";
            // 
            // dateTimePicker_E_Datum
            // 
            this.dateTimePicker_E_Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_E_Datum.Location = new System.Drawing.Point(369, 120);
            this.dateTimePicker_E_Datum.Name = "dateTimePicker_E_Datum";
            this.dateTimePicker_E_Datum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_E_Datum.TabIndex = 22;
            this.dateTimePicker_E_Datum.Value = new System.DateTime(2018, 7, 3, 0, 0, 0, 0);
            // 
            // comboBox_E_MA
            // 
            this.comboBox_E_MA.FormattingEnabled = true;
            this.comboBox_E_MA.Location = new System.Drawing.Point(369, 74);
            this.comboBox_E_MA.Name = "comboBox_E_MA";
            this.comboBox_E_MA.Size = new System.Drawing.Size(200, 21);
            this.comboBox_E_MA.TabIndex = 20;
            // 
            // label_E_ID
            // 
            this.label_E_ID.AutoSize = true;
            this.label_E_ID.Location = new System.Drawing.Point(366, 16);
            this.label_E_ID.Name = "label_E_ID";
            this.label_E_ID.Size = new System.Drawing.Size(52, 13);
            this.label_E_ID.TabIndex = 17;
            this.label_E_ID.Text = "EinsatzID";
            // 
            // textBox_E_ID
            // 
            this.textBox_E_ID.Enabled = false;
            this.textBox_E_ID.Location = new System.Drawing.Point(369, 32);
            this.textBox_E_ID.Name = "textBox_E_ID";
            this.textBox_E_ID.Size = new System.Drawing.Size(200, 20);
            this.textBox_E_ID.TabIndex = 18;
            // 
            // label_E_MA
            // 
            this.label_E_MA.AutoSize = true;
            this.label_E_MA.Location = new System.Drawing.Point(366, 60);
            this.label_E_MA.Name = "label_E_MA";
            this.label_E_MA.Size = new System.Drawing.Size(56, 13);
            this.label_E_MA.TabIndex = 19;
            this.label_E_MA.Text = "Mitarbeiter";
            // 
            // listBoxEinsatz
            // 
            this.listBoxEinsatz.FormattingEnabled = true;
            this.listBoxEinsatz.Location = new System.Drawing.Point(16, 15);
            this.listBoxEinsatz.Name = "listBoxEinsatz";
            this.listBoxEinsatz.Size = new System.Drawing.Size(333, 316);
            this.listBoxEinsatz.TabIndex = 16;
            this.listBoxEinsatz.SelectedIndexChanged += new System.EventHandler(this.listBoxEinsatz_SelectedIndexChanged);
            // 
            // tabPageFehlzeiten
            // 
            this.tabPageFehlzeiten.Controls.Add(this.labelFehlerFZ);
            this.tabPageFehlzeiten.Controls.Add(this.btnDeleteFZ);
            this.tabPageFehlzeiten.Controls.Add(this.comboBox_FZ_fehlgrund);
            this.tabPageFehlzeiten.Controls.Add(this.dateTimePicker_FZ_von);
            this.tabPageFehlzeiten.Controls.Add(this.comboBox_FZ_MA);
            this.tabPageFehlzeiten.Controls.Add(this.btnNewFZ);
            this.tabPageFehlzeiten.Controls.Add(this.btnSaveFZ);
            this.tabPageFehlzeiten.Controls.Add(this.listBoxFehlzeiten);
            this.tabPageFehlzeiten.Controls.Add(this.label_FZ_bis);
            this.tabPageFehlzeiten.Controls.Add(this.dateTimePicker_FZ_bis);
            this.tabPageFehlzeiten.Controls.Add(this.label_FZ_fehltage);
            this.tabPageFehlzeiten.Controls.Add(this.textBox_FZ_fehltage);
            this.tabPageFehlzeiten.Controls.Add(this.label_FZ_fehlgrund);
            this.tabPageFehlzeiten.Controls.Add(this.label_FZ_ID);
            this.tabPageFehlzeiten.Controls.Add(this.textBox_FZ_ID);
            this.tabPageFehlzeiten.Controls.Add(this.label_FZ_von);
            this.tabPageFehlzeiten.Controls.Add(this.label_FZ_MA);
            this.tabPageFehlzeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageFehlzeiten.Location = new System.Drawing.Point(4, 25);
            this.tabPageFehlzeiten.Name = "tabPageFehlzeiten";
            this.tabPageFehlzeiten.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFehlzeiten.Size = new System.Drawing.Size(589, 344);
            this.tabPageFehlzeiten.TabIndex = 2;
            this.tabPageFehlzeiten.Text = "Fehlzeiten";
            this.tabPageFehlzeiten.UseVisualStyleBackColor = true;
            // 
            // labelFehlerFZ
            // 
            this.labelFehlerFZ.AutoSize = true;
            this.labelFehlerFZ.ForeColor = System.Drawing.Color.Red;
            this.labelFehlerFZ.Location = new System.Drawing.Point(372, 287);
            this.labelFehlerFZ.Name = "labelFehlerFZ";
            this.labelFehlerFZ.Size = new System.Drawing.Size(0, 13);
            this.labelFehlerFZ.TabIndex = 46;
            // 
            // btnDeleteFZ
            // 
            this.btnDeleteFZ.Location = new System.Drawing.Point(423, 308);
            this.btnDeleteFZ.Name = "btnDeleteFZ";
            this.btnDeleteFZ.Size = new System.Drawing.Size(63, 23);
            this.btnDeleteFZ.TabIndex = 44;
            this.btnDeleteFZ.Text = "loeschen";
            this.btnDeleteFZ.UseVisualStyleBackColor = true;
            this.btnDeleteFZ.Click += new System.EventHandler(this.btnDeleteFZ_Click);
            // 
            // comboBox_FZ_fehlgrund
            // 
            this.comboBox_FZ_fehlgrund.FormattingEnabled = true;
            this.comboBox_FZ_fehlgrund.Location = new System.Drawing.Point(372, 214);
            this.comboBox_FZ_fehlgrund.Name = "comboBox_FZ_fehlgrund";
            this.comboBox_FZ_fehlgrund.Size = new System.Drawing.Size(199, 21);
            this.comboBox_FZ_fehlgrund.TabIndex = 40;
            // 
            // dateTimePicker_FZ_von
            // 
            this.dateTimePicker_FZ_von.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FZ_von.Location = new System.Drawing.Point(372, 119);
            this.dateTimePicker_FZ_von.Name = "dateTimePicker_FZ_von";
            this.dateTimePicker_FZ_von.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FZ_von.TabIndex = 36;
            // 
            // comboBox_FZ_MA
            // 
            this.comboBox_FZ_MA.FormattingEnabled = true;
            this.comboBox_FZ_MA.Location = new System.Drawing.Point(372, 75);
            this.comboBox_FZ_MA.Name = "comboBox_FZ_MA";
            this.comboBox_FZ_MA.Size = new System.Drawing.Size(200, 21);
            this.comboBox_FZ_MA.TabIndex = 34;
            // 
            // btnNewFZ
            // 
            this.btnNewFZ.Location = new System.Drawing.Point(372, 308);
            this.btnNewFZ.Name = "btnNewFZ";
            this.btnNewFZ.Size = new System.Drawing.Size(35, 23);
            this.btnNewFZ.TabIndex = 43;
            this.btnNewFZ.Text = "neu";
            this.btnNewFZ.UseVisualStyleBackColor = true;
            this.btnNewFZ.Click += new System.EventHandler(this.btnNewFZ_Click);
            // 
            // btnSaveFZ
            // 
            this.btnSaveFZ.Location = new System.Drawing.Point(505, 308);
            this.btnSaveFZ.Name = "btnSaveFZ";
            this.btnSaveFZ.Size = new System.Drawing.Size(66, 23);
            this.btnSaveFZ.TabIndex = 45;
            this.btnSaveFZ.Text = "speichern";
            this.btnSaveFZ.UseVisualStyleBackColor = true;
            this.btnSaveFZ.Click += new System.EventHandler(this.btnSaveFZ_Click);
            // 
            // listBoxFehlzeiten
            // 
            this.listBoxFehlzeiten.FormattingEnabled = true;
            this.listBoxFehlzeiten.Location = new System.Drawing.Point(16, 15);
            this.listBoxFehlzeiten.Name = "listBoxFehlzeiten";
            this.listBoxFehlzeiten.Size = new System.Drawing.Size(347, 316);
            this.listBoxFehlzeiten.TabIndex = 30;
            this.listBoxFehlzeiten.SelectedIndexChanged += new System.EventHandler(this.listBoxFehlzeiten_SelectedIndexChanged);
            // 
            // label_FZ_bis
            // 
            this.label_FZ_bis.AutoSize = true;
            this.label_FZ_bis.Location = new System.Drawing.Point(369, 149);
            this.label_FZ_bis.Name = "label_FZ_bis";
            this.label_FZ_bis.Size = new System.Drawing.Size(20, 13);
            this.label_FZ_bis.TabIndex = 37;
            this.label_FZ_bis.Text = "bis";
            // 
            // dateTimePicker_FZ_bis
            // 
            this.dateTimePicker_FZ_bis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FZ_bis.Location = new System.Drawing.Point(372, 165);
            this.dateTimePicker_FZ_bis.Name = "dateTimePicker_FZ_bis";
            this.dateTimePicker_FZ_bis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FZ_bis.TabIndex = 38;
            // 
            // label_FZ_fehltage
            // 
            this.label_FZ_fehltage.AutoSize = true;
            this.label_FZ_fehltage.Location = new System.Drawing.Point(369, 245);
            this.label_FZ_fehltage.Name = "label_FZ_fehltage";
            this.label_FZ_fehltage.Size = new System.Drawing.Size(48, 13);
            this.label_FZ_fehltage.TabIndex = 41;
            this.label_FZ_fehltage.Text = "Fehltage";
            // 
            // textBox_FZ_fehltage
            // 
            this.textBox_FZ_fehltage.Enabled = false;
            this.textBox_FZ_fehltage.Location = new System.Drawing.Point(372, 261);
            this.textBox_FZ_fehltage.Name = "textBox_FZ_fehltage";
            this.textBox_FZ_fehltage.Size = new System.Drawing.Size(200, 20);
            this.textBox_FZ_fehltage.TabIndex = 42;
            // 
            // label_FZ_fehlgrund
            // 
            this.label_FZ_fehlgrund.AutoSize = true;
            this.label_FZ_fehlgrund.Location = new System.Drawing.Point(369, 198);
            this.label_FZ_fehlgrund.Name = "label_FZ_fehlgrund";
            this.label_FZ_fehlgrund.Size = new System.Drawing.Size(54, 13);
            this.label_FZ_fehlgrund.TabIndex = 39;
            this.label_FZ_fehlgrund.Text = "Fehlgrund";
            // 
            // label_FZ_ID
            // 
            this.label_FZ_ID.AutoSize = true;
            this.label_FZ_ID.Location = new System.Drawing.Point(369, 16);
            this.label_FZ_ID.Name = "label_FZ_ID";
            this.label_FZ_ID.Size = new System.Drawing.Size(54, 13);
            this.label_FZ_ID.TabIndex = 31;
            this.label_FZ_ID.Text = "FehlzeitID";
            // 
            // textBox_FZ_ID
            // 
            this.textBox_FZ_ID.Enabled = false;
            this.textBox_FZ_ID.Location = new System.Drawing.Point(372, 32);
            this.textBox_FZ_ID.Name = "textBox_FZ_ID";
            this.textBox_FZ_ID.Size = new System.Drawing.Size(200, 20);
            this.textBox_FZ_ID.TabIndex = 32;
            // 
            // label_FZ_von
            // 
            this.label_FZ_von.AutoSize = true;
            this.label_FZ_von.Location = new System.Drawing.Point(369, 102);
            this.label_FZ_von.Name = "label_FZ_von";
            this.label_FZ_von.Size = new System.Drawing.Size(25, 13);
            this.label_FZ_von.TabIndex = 35;
            this.label_FZ_von.Text = "von";
            // 
            // label_FZ_MA
            // 
            this.label_FZ_MA.AutoSize = true;
            this.label_FZ_MA.Location = new System.Drawing.Point(369, 59);
            this.label_FZ_MA.Name = "label_FZ_MA";
            this.label_FZ_MA.Size = new System.Drawing.Size(56, 13);
            this.label_FZ_MA.TabIndex = 33;
            this.label_FZ_MA.Text = "Mitarbeiter";
            // 
            // tabPageFehlgruende
            // 
            this.tabPageFehlgruende.Controls.Add(this.labelFehlerFG);
            this.tabPageFehlgruende.Controls.Add(this.btnDeleteFG);
            this.tabPageFehlgruende.Controls.Add(this.btnNewFG);
            this.tabPageFehlgruende.Controls.Add(this.btnSaveFG);
            this.tabPageFehlgruende.Controls.Add(this.listBoxFehlgruende);
            this.tabPageFehlgruende.Controls.Add(this.label_FG_ID);
            this.tabPageFehlgruende.Controls.Add(this.textBox_FG_ID);
            this.tabPageFehlgruende.Controls.Add(this.label_FG_Fehlgrund);
            this.tabPageFehlgruende.Controls.Add(this.textBox_FG_grund);
            this.tabPageFehlgruende.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageFehlgruende.Location = new System.Drawing.Point(4, 25);
            this.tabPageFehlgruende.Name = "tabPageFehlgruende";
            this.tabPageFehlgruende.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFehlgruende.Size = new System.Drawing.Size(589, 344);
            this.tabPageFehlgruende.TabIndex = 3;
            this.tabPageFehlgruende.Text = "Fehlgruende";
            this.tabPageFehlgruende.UseVisualStyleBackColor = true;
            // 
            // labelFehlerFG
            // 
            this.labelFehlerFG.AutoSize = true;
            this.labelFehlerFG.ForeColor = System.Drawing.Color.Red;
            this.labelFehlerFG.Location = new System.Drawing.Point(370, 101);
            this.labelFehlerFG.Name = "labelFehlerFG";
            this.labelFehlerFG.Size = new System.Drawing.Size(0, 13);
            this.labelFehlerFG.TabIndex = 54;
            // 
            // btnDeleteFG
            // 
            this.btnDeleteFG.Location = new System.Drawing.Point(425, 125);
            this.btnDeleteFG.Name = "btnDeleteFG";
            this.btnDeleteFG.Size = new System.Drawing.Size(63, 23);
            this.btnDeleteFG.TabIndex = 52;
            this.btnDeleteFG.Text = "loeschen";
            this.btnDeleteFG.UseVisualStyleBackColor = true;
            this.btnDeleteFG.Click += new System.EventHandler(this.btnDeleteFG_Click);
            // 
            // btnNewFG
            // 
            this.btnNewFG.Location = new System.Drawing.Point(373, 125);
            this.btnNewFG.Name = "btnNewFG";
            this.btnNewFG.Size = new System.Drawing.Size(35, 23);
            this.btnNewFG.TabIndex = 51;
            this.btnNewFG.Text = "neu";
            this.btnNewFG.UseVisualStyleBackColor = true;
            this.btnNewFG.Click += new System.EventHandler(this.btnNewFG_Click);
            // 
            // btnSaveFG
            // 
            this.btnSaveFG.Location = new System.Drawing.Point(506, 125);
            this.btnSaveFG.Name = "btnSaveFG";
            this.btnSaveFG.Size = new System.Drawing.Size(66, 23);
            this.btnSaveFG.TabIndex = 53;
            this.btnSaveFG.Text = "speichern";
            this.btnSaveFG.UseVisualStyleBackColor = true;
            this.btnSaveFG.Click += new System.EventHandler(this.btnSaveFG_Click);
            // 
            // listBoxFehlgruende
            // 
            this.listBoxFehlgruende.FormattingEnabled = true;
            this.listBoxFehlgruende.Location = new System.Drawing.Point(16, 15);
            this.listBoxFehlgruende.Name = "listBoxFehlgruende";
            this.listBoxFehlgruende.Size = new System.Drawing.Size(347, 316);
            this.listBoxFehlgruende.TabIndex = 46;
            this.listBoxFehlgruende.SelectedIndexChanged += new System.EventHandler(this.listBoxFehlgruende_SelectedIndexChanged);
            // 
            // label_FG_ID
            // 
            this.label_FG_ID.AutoSize = true;
            this.label_FG_ID.Location = new System.Drawing.Point(369, 14);
            this.label_FG_ID.Name = "label_FG_ID";
            this.label_FG_ID.Size = new System.Drawing.Size(65, 13);
            this.label_FG_ID.TabIndex = 47;
            this.label_FG_ID.Text = "FehlgrundID";
            // 
            // textBox_FG_ID
            // 
            this.textBox_FG_ID.Enabled = false;
            this.textBox_FG_ID.Location = new System.Drawing.Point(372, 30);
            this.textBox_FG_ID.Name = "textBox_FG_ID";
            this.textBox_FG_ID.Size = new System.Drawing.Size(200, 20);
            this.textBox_FG_ID.TabIndex = 48;
            // 
            // label_FG_Fehlgrund
            // 
            this.label_FG_Fehlgrund.AutoSize = true;
            this.label_FG_Fehlgrund.Location = new System.Drawing.Point(369, 58);
            this.label_FG_Fehlgrund.Name = "label_FG_Fehlgrund";
            this.label_FG_Fehlgrund.Size = new System.Drawing.Size(54, 13);
            this.label_FG_Fehlgrund.TabIndex = 49;
            this.label_FG_Fehlgrund.Text = "Fehlgrund";
            // 
            // textBox_FG_grund
            // 
            this.textBox_FG_grund.Location = new System.Drawing.Point(372, 74);
            this.textBox_FG_grund.Name = "textBox_FG_grund";
            this.textBox_FG_grund.Size = new System.Drawing.Size(200, 20);
            this.textBox_FG_grund.TabIndex = 50;
            // 
            // TabPageAuswertungen
            // 
            this.TabPageAuswertungen.Controls.Add(this.panel2);
            this.TabPageAuswertungen.Controls.Add(this.panel1);
            this.TabPageAuswertungen.Controls.Add(this.panelMA);
            this.TabPageAuswertungen.Controls.Add(this.btnSend);
            this.TabPageAuswertungen.Controls.Add(this.dataGridView1);
            this.TabPageAuswertungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageAuswertungen.Location = new System.Drawing.Point(4, 25);
            this.TabPageAuswertungen.Name = "TabPageAuswertungen";
            this.TabPageAuswertungen.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAuswertungen.Size = new System.Drawing.Size(589, 344);
            this.TabPageAuswertungen.TabIndex = 4;
            this.TabPageAuswertungen.Text = "Auswertungen";
            this.TabPageAuswertungen.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxMonat);
            this.panel2.Controls.Add(this.rBtnInsgesamt);
            this.panel2.Controls.Add(this.rBtnYear);
            this.panel2.Controls.Add(this.textBoxJahr);
            this.panel2.Controls.Add(this.textBoxMonat);
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 91);
            this.panel2.TabIndex = 18;
            // 
            // checkBoxMonat
            // 
            this.checkBoxMonat.AutoSize = true;
            this.checkBoxMonat.Location = new System.Drawing.Point(26, 59);
            this.checkBoxMonat.Name = "checkBoxMonat";
            this.checkBoxMonat.Size = new System.Drawing.Size(77, 17);
            this.checkBoxMonat.TabIndex = 14;
            this.checkBoxMonat.Text = "und Monat";
            this.checkBoxMonat.UseVisualStyleBackColor = true;
            this.checkBoxMonat.CheckedChanged += new System.EventHandler(this.checkBoxMonat_CheckedChanged);
            // 
            // rBtnInsgesamt
            // 
            this.rBtnInsgesamt.AutoSize = true;
            this.rBtnInsgesamt.Checked = true;
            this.rBtnInsgesamt.Location = new System.Drawing.Point(6, 13);
            this.rBtnInsgesamt.Name = "rBtnInsgesamt";
            this.rBtnInsgesamt.Size = new System.Drawing.Size(72, 17);
            this.rBtnInsgesamt.TabIndex = 9;
            this.rBtnInsgesamt.TabStop = true;
            this.rBtnInsgesamt.Text = "insgesamt";
            this.rBtnInsgesamt.UseVisualStyleBackColor = true;
            this.rBtnInsgesamt.CheckedChanged += new System.EventHandler(this.rBtnInsgesamt_CheckedChanged);
            // 
            // rBtnYear
            // 
            this.rBtnYear.AutoSize = true;
            this.rBtnYear.Location = new System.Drawing.Point(6, 36);
            this.rBtnYear.Name = "rBtnYear";
            this.rBtnYear.Size = new System.Drawing.Size(86, 17);
            this.rBtnYear.TabIndex = 10;
            this.rBtnYear.Text = "fuer das Jahr";
            this.rBtnYear.UseVisualStyleBackColor = true;
            // 
            // textBoxJahr
            // 
            this.textBoxJahr.Location = new System.Drawing.Point(98, 35);
            this.textBoxJahr.Name = "textBoxJahr";
            this.textBoxJahr.Size = new System.Drawing.Size(60, 20);
            this.textBoxJahr.TabIndex = 12;
            this.textBoxJahr.TextChanged += new System.EventHandler(this.textBoxJahr_TextChanged);
            // 
            // textBoxMonat
            // 
            this.textBoxMonat.Location = new System.Drawing.Point(109, 57);
            this.textBoxMonat.Name = "textBoxMonat";
            this.textBoxMonat.Size = new System.Drawing.Size(49, 20);
            this.textBoxMonat.TabIndex = 13;
            this.textBoxMonat.TextChanged += new System.EventHandler(this.textBoxMonat_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnFZ);
            this.panel1.Controls.Add(this.rBtnE);
            this.panel1.Controls.Add(this.checkBoxUrlaub);
            this.panel1.Controls.Add(this.checkBoxKrank);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 100);
            this.panel1.TabIndex = 17;
            // 
            // rBtnFZ
            // 
            this.rBtnFZ.AutoSize = true;
            this.rBtnFZ.Location = new System.Drawing.Point(6, 26);
            this.rBtnFZ.Name = "rBtnFZ";
            this.rBtnFZ.Size = new System.Drawing.Size(73, 17);
            this.rBtnFZ.TabIndex = 5;
            this.rBtnFZ.Text = "Fehlzeiten";
            this.rBtnFZ.UseVisualStyleBackColor = true;
            this.rBtnFZ.CheckedChanged += new System.EventHandler(this.rBtnFZ_CheckedChanged);
            // 
            // rBtnE
            // 
            this.rBtnE.AutoSize = true;
            this.rBtnE.Checked = true;
            this.rBtnE.Location = new System.Drawing.Point(6, 3);
            this.rBtnE.Name = "rBtnE";
            this.rBtnE.Size = new System.Drawing.Size(71, 17);
            this.rBtnE.TabIndex = 6;
            this.rBtnE.TabStop = true;
            this.rBtnE.Text = "Einsaetze";
            this.rBtnE.UseVisualStyleBackColor = true;
            this.rBtnE.CheckedChanged += new System.EventHandler(this.rBtnE_CheckedChanged);
            // 
            // checkBoxUrlaub
            // 
            this.checkBoxUrlaub.AutoSize = true;
            this.checkBoxUrlaub.Location = new System.Drawing.Point(26, 49);
            this.checkBoxUrlaub.Name = "checkBoxUrlaub";
            this.checkBoxUrlaub.Size = new System.Drawing.Size(57, 17);
            this.checkBoxUrlaub.TabIndex = 7;
            this.checkBoxUrlaub.Text = "Urlaub";
            this.checkBoxUrlaub.UseVisualStyleBackColor = true;
            this.checkBoxUrlaub.CheckedChanged += new System.EventHandler(this.checkBoxUrlaub_CheckedChanged);
            // 
            // checkBoxKrank
            // 
            this.checkBoxKrank.AutoSize = true;
            this.checkBoxKrank.Location = new System.Drawing.Point(26, 72);
            this.checkBoxKrank.Name = "checkBoxKrank";
            this.checkBoxKrank.Size = new System.Drawing.Size(71, 17);
            this.checkBoxKrank.TabIndex = 8;
            this.checkBoxKrank.Text = "Krankheit";
            this.checkBoxKrank.UseVisualStyleBackColor = true;
            this.checkBoxKrank.CheckedChanged += new System.EventHandler(this.checkBoxKrank_CheckedChanged);
            // 
            // panelMA
            // 
            this.panelMA.Controls.Add(this.rBtn_MA_alle);
            this.panelMA.Controls.Add(this.comboBoxAW);
            this.panelMA.Location = new System.Drawing.Point(0, 13);
            this.panelMA.Name = "panelMA";
            this.panelMA.Size = new System.Drawing.Size(165, 59);
            this.panelMA.TabIndex = 16;
            // 
            // rBtn_MA_alle
            // 
            this.rBtn_MA_alle.AutoSize = true;
            this.rBtn_MA_alle.Checked = true;
            this.rBtn_MA_alle.Location = new System.Drawing.Point(6, 6);
            this.rBtn_MA_alle.Name = "rBtn_MA_alle";
            this.rBtn_MA_alle.Size = new System.Drawing.Size(93, 17);
            this.rBtn_MA_alle.TabIndex = 3;
            this.rBtn_MA_alle.TabStop = true;
            this.rBtn_MA_alle.Text = "alle Mitarbeiter";
            this.rBtn_MA_alle.UseVisualStyleBackColor = true;
            this.rBtn_MA_alle.CheckedChanged += new System.EventHandler(this.rBtn_MA_alle_CheckedChanged);
            // 
            // comboBoxAW
            // 
            this.comboBoxAW.FormattingEnabled = true;
            this.comboBoxAW.Location = new System.Drawing.Point(6, 29);
            this.comboBoxAW.Name = "comboBoxAW";
            this.comboBoxAW.Size = new System.Drawing.Size(152, 21);
            this.comboBoxAW.TabIndex = 4;
            this.comboBoxAW.SelectedIndexChanged += new System.EventHandler(this.comboBoxAW_SelectedIndexChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(55, 307);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 23);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Abfrage schicken";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_id,
            this.nachname,
            this.vorname,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(183, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(390, 320);
            this.dataGridView1.TabIndex = 2;
            // 
            // ma_id
            // 
            this.ma_id.HeaderText = "ID";
            this.ma_id.Name = "ma_id";
            this.ma_id.ReadOnly = true;
            this.ma_id.Visible = false;
            this.ma_id.Width = 30;
            // 
            // nachname
            // 
            this.nachname.HeaderText = "Nachname";
            this.nachname.Name = "nachname";
            this.nachname.ReadOnly = true;
            this.nachname.Visible = false;
            this.nachname.Width = 50;
            // 
            // vorname
            // 
            this.vorname.HeaderText = "Vorname";
            this.vorname.Name = "vorname";
            this.vorname.ReadOnly = true;
            this.vorname.Visible = false;
            this.vorname.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 73;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 40;
            // 
            // tabPageExcel
            // 
            this.tabPageExcel.Controls.Add(this.btnSaveExcel);
            this.tabPageExcel.Controls.Add(this.comboBoxExcel);
            this.tabPageExcel.Location = new System.Drawing.Point(4, 25);
            this.tabPageExcel.Name = "tabPageExcel";
            this.tabPageExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExcel.Size = new System.Drawing.Size(589, 344);
            this.tabPageExcel.TabIndex = 5;
            this.tabPageExcel.Text = "Auswertung Excel";
            this.tabPageExcel.UseVisualStyleBackColor = true;
            // 
            // btnSaveExcel
            // 
            this.btnSaveExcel.Location = new System.Drawing.Point(246, 146);
            this.btnSaveExcel.Name = "btnSaveExcel";
            this.btnSaveExcel.Size = new System.Drawing.Size(160, 23);
            this.btnSaveExcel.TabIndex = 1;
            this.btnSaveExcel.Text = "Excel-Datei generieren";
            this.btnSaveExcel.UseVisualStyleBackColor = true;
            this.btnSaveExcel.Click += new System.EventHandler(this.btnSaveExcel_Click);
            // 
            // comboBoxExcel
            // 
            this.comboBoxExcel.FormattingEnabled = true;
            this.comboBoxExcel.Location = new System.Drawing.Point(38, 145);
            this.comboBoxExcel.Name = "comboBoxExcel";
            this.comboBoxExcel.Size = new System.Drawing.Size(173, 24);
            this.comboBoxExcel.TabIndex = 0;
            // 
            // btnSaveDbInXml
            // 
            this.btnSaveDbInXml.Location = new System.Drawing.Point(16, 392);
            this.btnSaveDbInXml.Name = "btnSaveDbInXml";
            this.btnSaveDbInXml.Size = new System.Drawing.Size(198, 23);
            this.btnSaveDbInXml.TabIndex = 1;
            this.btnSaveDbInXml.Text = "DB in XML-Datei schreiben";
            this.btnSaveDbInXml.UseVisualStyleBackColor = true;
            this.btnSaveDbInXml.Click += new System.EventHandler(this.btnSaveDbInXml_Click);
            // 
            // labelDragDrop
            // 
            this.labelDragDrop.AllowDrop = true;
            this.labelDragDrop.AutoSize = true;
            this.labelDragDrop.Location = new System.Drawing.Point(259, 397);
            this.labelDragDrop.Name = "labelDragDrop";
            this.labelDragDrop.Size = new System.Drawing.Size(208, 13);
            this.labelDragDrop.TabIndex = 2;
            this.labelDragDrop.Text = "aus XML-Datei importieren (hier reinziehen)";
            this.labelDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDragDrop_DragDrop);
            this.labelDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDragDrop_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 435);
            this.Controls.Add(this.labelDragDrop);
            this.Controls.Add(this.btnSaveDbInXml);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Personalverwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMA.ResumeLayout(false);
            this.tabPageMA.PerformLayout();
            this.tabPageEinsatz.ResumeLayout(false);
            this.tabPageEinsatz.PerformLayout();
            this.tabPageFehlzeiten.ResumeLayout(false);
            this.tabPageFehlzeiten.PerformLayout();
            this.tabPageFehlgruende.ResumeLayout(false);
            this.tabPageFehlgruende.PerformLayout();
            this.TabPageAuswertungen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMA.ResumeLayout(false);
            this.panelMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageExcel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMA;
        private System.Windows.Forms.TabPage tabPageEinsatz;
        private System.Windows.Forms.TabPage tabPageFehlzeiten;
        private System.Windows.Forms.TabPage tabPageFehlgruende;
        private System.Windows.Forms.Button btnNewMA;
        private System.Windows.Forms.Button btnSaveMA;
        private System.Windows.Forms.ListBox listBoxMA;
        private System.Windows.Forms.Label label_MA_Geburtsdatum;
        private System.Windows.Forms.DateTimePicker dateTimePicker_MA_Geburtsdatum;
        private System.Windows.Forms.Label label_MA_Urlaubsanspruch;
        private System.Windows.Forms.TextBox textBox_MA_Urlaubsanspruch;
        private System.Windows.Forms.Label label_Ma_TArbeitszeit;
        private System.Windows.Forms.TextBox textBox_MA_TArbeitszeit;
        private System.Windows.Forms.Label label_MA_ID;
        private System.Windows.Forms.TextBox textBox_MA_ID;
        private System.Windows.Forms.Label label_MA_nachname;
        private System.Windows.Forms.TextBox textBox_MA_nachname;
        private System.Windows.Forms.Label label_MA_vorname;
        private System.Windows.Forms.TextBox textBox_MA_vorname;
        private System.Windows.Forms.ListBox listBoxEinsatz;
        private System.Windows.Forms.Label label_E_ID;
        private System.Windows.Forms.TextBox textBox_E_ID;
        private System.Windows.Forms.Label label_E_MA;
        private System.Windows.Forms.ComboBox comboBox_E_MA;
        private System.Windows.Forms.Label label_E_bis;
        private System.Windows.Forms.Label label_E_von;
        private System.Windows.Forms.Label label_E_Datum;
        private System.Windows.Forms.Button btnNewE;
        private System.Windows.Forms.Button btnSaveE;
        private System.Windows.Forms.ComboBox comboBox_FZ_fehlgrund;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FZ_von;
        private System.Windows.Forms.ComboBox comboBox_FZ_MA;
        private System.Windows.Forms.Button btnNewFZ;
        private System.Windows.Forms.Button btnSaveFZ;
        private System.Windows.Forms.ListBox listBoxFehlzeiten;
        private System.Windows.Forms.Label label_FZ_bis;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FZ_bis;
        private System.Windows.Forms.Label label_FZ_fehltage;
        private System.Windows.Forms.TextBox textBox_FZ_fehltage;
        private System.Windows.Forms.Label label_FZ_fehlgrund;
        private System.Windows.Forms.Label label_FZ_ID;
        private System.Windows.Forms.TextBox textBox_FZ_ID;
        private System.Windows.Forms.Label label_FZ_von;
        private System.Windows.Forms.Label label_FZ_MA;
        private System.Windows.Forms.Button btnNewFG;
        private System.Windows.Forms.Button btnSaveFG;
        private System.Windows.Forms.ListBox listBoxFehlgruende;
        private System.Windows.Forms.Label label_FG_ID;
        private System.Windows.Forms.TextBox textBox_FG_ID;
        private System.Windows.Forms.Label label_FG_Fehlgrund;
        private System.Windows.Forms.TextBox textBox_FG_grund;
        private System.Windows.Forms.DateTimePicker dateTimePicker_E_Datum;
        private System.Windows.Forms.Button btnDeleteMA;
        private System.Windows.Forms.Button btnDeleteE;
        private System.Windows.Forms.Button btnDeleteFZ;
        private System.Windows.Forms.Button btnDeleteFG;
        private System.Windows.Forms.Label labelFehlerFZ;
        private System.Windows.Forms.Label labelFehlerMA;
        private System.Windows.Forms.Label labelFehlerEinsatz;
        private System.Windows.Forms.Label labelFehlerFG;
        private System.Windows.Forms.TabPage TabPageAuswertungen;
        private System.Windows.Forms.RadioButton rBtnE;
        private System.Windows.Forms.RadioButton rBtnFZ;
        private System.Windows.Forms.ComboBox comboBoxAW;
        private System.Windows.Forms.RadioButton rBtn_MA_alle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rBtnYear;
        private System.Windows.Forms.RadioButton rBtnInsgesamt;
        private System.Windows.Forms.CheckBox checkBoxKrank;
        private System.Windows.Forms.CheckBox checkBoxUrlaub;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox checkBoxMonat;
        private System.Windows.Forms.TextBox textBoxMonat;
        private System.Windows.Forms.TextBox textBoxJahr;
        private System.Windows.Forms.Panel panelMA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn vorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_E_bis;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_E_von;
        private System.Windows.Forms.Button btnXmlGet;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnSaveDbInXml;
        private System.Windows.Forms.Label labelDragDrop;
        private System.Windows.Forms.TabPage tabPageExcel;
        private System.Windows.Forms.Button btnSaveExcel;
        private System.Windows.Forms.ComboBox comboBoxExcel;
    }
}

