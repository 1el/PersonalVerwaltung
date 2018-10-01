namespace PersonalVerwaltung
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerMaXml = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaXmlAZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaXmlUrlaub = new System.Windows.Forms.TextBox();
            this.labelMA_name = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerMaXml
            // 
            this.dateTimePickerMaXml.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMaXml.Location = new System.Drawing.Point(13, 99);
            this.dateTimePickerMaXml.MaxDate = new System.DateTime(2018, 7, 3, 0, 0, 0, 0);
            this.dateTimePickerMaXml.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerMaXml.Name = "dateTimePickerMaXml";
            this.dateTimePickerMaXml.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerMaXml.TabIndex = 0;
            this.dateTimePickerMaXml.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geburtsdatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tagesarbeitszeit";
            // 
            // textBoxMaXmlAZ
            // 
            this.textBoxMaXmlAZ.Location = new System.Drawing.Point(13, 143);
            this.textBoxMaXmlAZ.Name = "textBoxMaXmlAZ";
            this.textBoxMaXmlAZ.Size = new System.Drawing.Size(178, 20);
            this.textBoxMaXmlAZ.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Urlaubstage";
            // 
            // textBoxMaXmlUrlaub
            // 
            this.textBoxMaXmlUrlaub.Location = new System.Drawing.Point(13, 187);
            this.textBoxMaXmlUrlaub.Name = "textBoxMaXmlUrlaub";
            this.textBoxMaXmlUrlaub.Size = new System.Drawing.Size(178, 20);
            this.textBoxMaXmlUrlaub.TabIndex = 5;
            // 
            // labelMA_name
            // 
            this.labelMA_name.AutoSize = true;
            this.labelMA_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMA_name.Location = new System.Drawing.Point(16, 29);
            this.labelMA_name.Name = "labelMA_name";
            this.labelMA_name.Size = new System.Drawing.Size(0, 17);
            this.labelMA_name.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(115, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 253);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelMA_name);
            this.Controls.Add(this.textBoxMaXmlUrlaub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaXmlAZ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerMaXml);
            this.Name = "Form2";
            this.Text = "neue Mitarbeiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerMaXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaXmlAZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaXmlUrlaub;
        private System.Windows.Forms.Label labelMA_name;
        private System.Windows.Forms.Button btnSave;
    }
}