namespace KonyvesboltMintaVizsga
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
            this.cmbKonyvTipus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSzerzo = new System.Windows.Forms.TextBox();
            this.nudOldalszam = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAr = new System.Windows.Forms.NumericUpDown();
            this.nudKiadasEve = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTudomanyos = new System.Windows.Forms.GroupBox();
            this.cbElismert = new System.Windows.Forms.CheckBox();
            this.cmbTerulet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbIrodalmi = new System.Windows.Forms.GroupBox();
            this.cmbKategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOldalszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKiadasEve)).BeginInit();
            this.gbTudomanyos.SuspendLayout();
            this.gbIrodalmi.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKonyvTipus
            // 
            this.cmbKonyvTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKonyvTipus.FormattingEnabled = true;
            this.cmbKonyvTipus.Location = new System.Drawing.Point(29, 31);
            this.cmbKonyvTipus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKonyvTipus.Name = "cmbKonyvTipus";
            this.cmbKonyvTipus.Size = new System.Drawing.Size(185, 24);
            this.cmbKonyvTipus.TabIndex = 0;
            this.cmbKonyvTipus.SelectedIndexChanged += new System.EventHandler(this.cmbKonyvTipus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Könyv típusa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cím:";
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(29, 92);
            this.tbCim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(297, 22);
            this.tbCim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Szerző:";
            // 
            // tbSzerzo
            // 
            this.tbSzerzo.Location = new System.Drawing.Point(29, 140);
            this.tbSzerzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSzerzo.Name = "tbSzerzo";
            this.tbSzerzo.Size = new System.Drawing.Size(297, 22);
            this.tbSzerzo.TabIndex = 5;
            // 
            // nudOldalszam
            // 
            this.nudOldalszam.Location = new System.Drawing.Point(29, 188);
            this.nudOldalszam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudOldalszam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudOldalszam.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOldalszam.Name = "nudOldalszam";
            this.nudOldalszam.Size = new System.Drawing.Size(187, 22);
            this.nudOldalszam.TabIndex = 6;
            this.nudOldalszam.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oldalszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ár.";
            // 
            // nudAr
            // 
            this.nudAr.Location = new System.Drawing.Point(29, 236);
            this.nudAr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAr.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAr.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAr.Name = "nudAr";
            this.nudAr.Size = new System.Drawing.Size(187, 22);
            this.nudAr.TabIndex = 9;
            this.nudAr.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudKiadasEve
            // 
            this.nudKiadasEve.Location = new System.Drawing.Point(29, 284);
            this.nudKiadasEve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudKiadasEve.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudKiadasEve.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nudKiadasEve.Name = "nudKiadasEve";
            this.nudKiadasEve.Size = new System.Drawing.Size(187, 22);
            this.nudKiadasEve.TabIndex = 10;
            this.nudKiadasEve.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kiadás éve:";
            // 
            // gbTudomanyos
            // 
            this.gbTudomanyos.Controls.Add(this.cbElismert);
            this.gbTudomanyos.Controls.Add(this.cmbTerulet);
            this.gbTudomanyos.Controls.Add(this.label7);
            this.gbTudomanyos.Location = new System.Drawing.Point(29, 316);
            this.gbTudomanyos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTudomanyos.Name = "gbTudomanyos";
            this.gbTudomanyos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTudomanyos.Size = new System.Drawing.Size(200, 116);
            this.gbTudomanyos.TabIndex = 12;
            this.gbTudomanyos.TabStop = false;
            this.gbTudomanyos.Text = "Tudományos könyv";
            // 
            // cbElismert
            // 
            this.cbElismert.AutoSize = true;
            this.cbElismert.Location = new System.Drawing.Point(12, 85);
            this.cbElismert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbElismert.Name = "cbElismert";
            this.cbElismert.Size = new System.Drawing.Size(121, 21);
            this.cbElismert.TabIndex = 15;
            this.cbElismert.Text = "Elismert könyv";
            this.cbElismert.UseVisualStyleBackColor = true;
            // 
            // cmbTerulet
            // 
            this.cmbTerulet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerulet.FormattingEnabled = true;
            this.cmbTerulet.Location = new System.Drawing.Point(12, 52);
            this.cmbTerulet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTerulet.Name = "cmbTerulet";
            this.cmbTerulet.Size = new System.Drawing.Size(173, 24);
            this.cmbTerulet.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Terület:";
            // 
            // gbIrodalmi
            // 
            this.gbIrodalmi.Controls.Add(this.cmbKategoria);
            this.gbIrodalmi.Controls.Add(this.label8);
            this.gbIrodalmi.Enabled = false;
            this.gbIrodalmi.Location = new System.Drawing.Point(237, 316);
            this.gbIrodalmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIrodalmi.Name = "gbIrodalmi";
            this.gbIrodalmi.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIrodalmi.Size = new System.Drawing.Size(200, 116);
            this.gbIrodalmi.TabIndex = 13;
            this.gbIrodalmi.TabStop = false;
            this.gbIrodalmi.Text = "Irodalmi könyv";
            // 
            // cmbKategoria
            // 
            this.cmbKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategoria.FormattingEnabled = true;
            this.cmbKategoria.Location = new System.Drawing.Point(13, 52);
            this.cmbKategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKategoria.Name = "cmbKategoria";
            this.cmbKategoria.Size = new System.Drawing.Size(173, 24);
            this.cmbKategoria.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kategória:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(29, 459);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 36);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.Location = new System.Drawing.Point(301, 459);
            this.btnMegsem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(136, 36);
            this.btnMegsem.TabIndex = 15;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMegsem;
            this.ClientSize = new System.Drawing.Size(468, 510);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbIrodalmi);
            this.Controls.Add(this.gbTudomanyos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudKiadasEve);
            this.Controls.Add(this.nudAr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudOldalszam);
            this.Controls.Add(this.tbSzerzo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKonyvTipus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Új könyv hozzáadása";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOldalszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKiadasEve)).EndInit();
            this.gbTudomanyos.ResumeLayout(false);
            this.gbTudomanyos.PerformLayout();
            this.gbIrodalmi.ResumeLayout(false);
            this.gbIrodalmi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKonyvTipus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSzerzo;
        private System.Windows.Forms.NumericUpDown nudOldalszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAr;
        private System.Windows.Forms.NumericUpDown nudKiadasEve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbTudomanyos;
        private System.Windows.Forms.ComboBox cmbTerulet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbIrodalmi;
        private System.Windows.Forms.ComboBox cmbKategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbElismert;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnMegsem;
    }
}