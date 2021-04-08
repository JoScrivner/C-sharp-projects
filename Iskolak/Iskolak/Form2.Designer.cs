namespace Iskolak
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIskolatipus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMegnevezes = new System.Windows.Forms.TextBox();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.tbIgazgato = new System.Windows.Forms.TextBox();
            this.numAktiv = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.gbAltalanos = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numOsz = new System.Windows.Forms.NumericUpDown();
            this.cbTagozat = new System.Windows.Forms.CheckBox();
            this.cbSzakkorok = new System.Windows.Forms.CheckBox();
            this.gbGimnazium = new System.Windows.Forms.GroupBox();
            this.cbKozponti = new System.Windows.Forms.CheckBox();
            this.cbSport = new System.Windows.Forms.CheckBox();
            this.numTermek = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAktiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            this.gbAltalanos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOsz)).BeginInit();
            this.gbGimnazium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTermek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iskola tipusa:";
            // 
            // cmbIskolatipus
            // 
            this.cmbIskolatipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIskolatipus.FormattingEnabled = true;
            this.cmbIskolatipus.Location = new System.Drawing.Point(16, 30);
            this.cmbIskolatipus.Name = "cmbIskolatipus";
            this.cmbIskolatipus.Size = new System.Drawing.Size(165, 21);
            this.cmbIskolatipus.TabIndex = 1;
            this.cmbIskolatipus.SelectedIndexChanged += new System.EventHandler(this.cmbIskolatipus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Megnevezes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aktiv tanuloszam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Maximalis tanuloszam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Igazgato  neve:";
            // 
            // tbMegnevezes
            // 
            this.tbMegnevezes.Location = new System.Drawing.Point(16, 80);
            this.tbMegnevezes.Name = "tbMegnevezes";
            this.tbMegnevezes.Size = new System.Drawing.Size(234, 20);
            this.tbMegnevezes.TabIndex = 7;
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(16, 203);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(234, 20);
            this.tbCim.TabIndex = 8;
            // 
            // tbIgazgato
            // 
            this.tbIgazgato.Location = new System.Drawing.Point(16, 244);
            this.tbIgazgato.Name = "tbIgazgato";
            this.tbIgazgato.Size = new System.Drawing.Size(234, 20);
            this.tbIgazgato.TabIndex = 9;
            // 
            // numAktiv
            // 
            this.numAktiv.Location = new System.Drawing.Point(16, 120);
            this.numAktiv.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numAktiv.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numAktiv.Name = "numAktiv";
            this.numAktiv.Size = new System.Drawing.Size(120, 20);
            this.numAktiv.TabIndex = 10;
            this.numAktiv.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(16, 161);
            this.numMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 20);
            this.numMax.TabIndex = 11;
            this.numMax.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // gbAltalanos
            // 
            this.gbAltalanos.Controls.Add(this.cbSzakkorok);
            this.gbAltalanos.Controls.Add(this.cbTagozat);
            this.gbAltalanos.Controls.Add(this.numOsz);
            this.gbAltalanos.Controls.Add(this.label7);
            this.gbAltalanos.Location = new System.Drawing.Point(16, 282);
            this.gbAltalanos.Name = "gbAltalanos";
            this.gbAltalanos.Size = new System.Drawing.Size(184, 110);
            this.gbAltalanos.TabIndex = 12;
            this.gbAltalanos.TabStop = false;
            this.gbAltalanos.Text = "Altalanos iskola";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Osztalyok szama:";
            // 
            // numOsz
            // 
            this.numOsz.Location = new System.Drawing.Point(101, 27);
            this.numOsz.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numOsz.Name = "numOsz";
            this.numOsz.Size = new System.Drawing.Size(77, 20);
            this.numOsz.TabIndex = 1;
            this.numOsz.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cbTagozat
            // 
            this.cbTagozat.AutoSize = true;
            this.cbTagozat.Location = new System.Drawing.Point(9, 58);
            this.cbTagozat.Name = "cbTagozat";
            this.cbTagozat.Size = new System.Drawing.Size(113, 17);
            this.cbTagozat.TabIndex = 2;
            this.cbTagozat.Text = "Vannak tagozatok";
            this.cbTagozat.UseVisualStyleBackColor = true;
            // 
            // cbSzakkorok
            // 
            this.cbSzakkorok.AutoSize = true;
            this.cbSzakkorok.Location = new System.Drawing.Point(9, 81);
            this.cbSzakkorok.Name = "cbSzakkorok";
            this.cbSzakkorok.Size = new System.Drawing.Size(115, 17);
            this.cbSzakkorok.TabIndex = 3;
            this.cbSzakkorok.Text = "Vannak szakkorok";
            this.cbSzakkorok.UseVisualStyleBackColor = true;
            // 
            // gbGimnazium
            // 
            this.gbGimnazium.Controls.Add(this.cbKozponti);
            this.gbGimnazium.Controls.Add(this.cbSport);
            this.gbGimnazium.Controls.Add(this.numTermek);
            this.gbGimnazium.Controls.Add(this.label8);
            this.gbGimnazium.Enabled = false;
            this.gbGimnazium.Location = new System.Drawing.Point(206, 282);
            this.gbGimnazium.Name = "gbGimnazium";
            this.gbGimnazium.Size = new System.Drawing.Size(184, 110);
            this.gbGimnazium.TabIndex = 13;
            this.gbGimnazium.TabStop = false;
            this.gbGimnazium.Text = "Gimnazium";
            // 
            // cbKozponti
            // 
            this.cbKozponti.AutoSize = true;
            this.cbKozponti.Location = new System.Drawing.Point(9, 30);
            this.cbKozponti.Name = "cbKozponti";
            this.cbKozponti.Size = new System.Drawing.Size(127, 17);
            this.cbKozponti.TabIndex = 3;
            this.cbKozponti.Text = "Van kozponti felveteli";
            this.cbKozponti.UseVisualStyleBackColor = true;
            // 
            // cbSport
            // 
            this.cbSport.AutoSize = true;
            this.cbSport.Location = new System.Drawing.Point(9, 51);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(171, 17);
            this.cbSport.TabIndex = 2;
            this.cbSport.Text = "Vannak sportolasi lehetosegek";
            this.cbSport.UseVisualStyleBackColor = true;
            // 
            // numTermek
            // 
            this.numTermek.Location = new System.Drawing.Point(91, 74);
            this.numTermek.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numTermek.Name = "numTermek";
            this.numTermek.Size = new System.Drawing.Size(87, 20);
            this.numTermek.TabIndex = 1;
            this.numTermek.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Termek szama:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(16, 408);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 38);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(274, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Megsem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbGimnazium);
            this.Controls.Add(this.gbAltalanos);
            this.Controls.Add(this.numMax);
            this.Controls.Add(this.numAktiv);
            this.Controls.Add(this.tbIgazgato);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.tbMegnevezes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIskolatipus);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Uj iskola hozzaadasa";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAktiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            this.gbAltalanos.ResumeLayout(false);
            this.gbAltalanos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOsz)).EndInit();
            this.gbGimnazium.ResumeLayout(false);
            this.gbGimnazium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTermek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIskolatipus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMegnevezes;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.TextBox tbIgazgato;
        private System.Windows.Forms.NumericUpDown numAktiv;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.GroupBox gbAltalanos;
        private System.Windows.Forms.CheckBox cbSzakkorok;
        private System.Windows.Forms.CheckBox cbTagozat;
        private System.Windows.Forms.NumericUpDown numOsz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbGimnazium;
        private System.Windows.Forms.CheckBox cbKozponti;
        private System.Windows.Forms.CheckBox cbSport;
        private System.Windows.Forms.NumericUpDown numTermek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
    }
}