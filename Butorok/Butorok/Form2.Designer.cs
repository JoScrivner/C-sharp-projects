namespace Butorok
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipus = new System.Windows.Forms.ComboBox();
            this.cmbElhelyezes = new System.Windows.Forms.ComboBox();
            this.cmbAnyag = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numx = new System.Windows.Forms.NumericUpDown();
            this.numy = new System.Windows.Forms.NumericUpDown();
            this.numz = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numDarab = new System.Windows.Forms.NumericUpDown();
            this.cbkinyitajtos = new System.Windows.Forms.CheckBox();
            this.cbcsuszasuveg = new System.Windows.Forms.CheckBox();
            this.numferopolc = new System.Windows.Forms.NumericUpDown();
            this.labelFeroPolc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMegnevezes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDarab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numferopolc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Butor tipusa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elhelyezes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anyag tipusa:";
            // 
            // cmbTipus
            // 
            this.cmbTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipus.FormattingEnabled = true;
            this.cmbTipus.Location = new System.Drawing.Point(110, 9);
            this.cmbTipus.Name = "cmbTipus";
            this.cmbTipus.Size = new System.Drawing.Size(233, 21);
            this.cmbTipus.TabIndex = 3;
            this.cmbTipus.SelectedIndexChanged += new System.EventHandler(this.cmbTipus_SelectedIndexChanged);
            // 
            // cmbElhelyezes
            // 
            this.cmbElhelyezes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElhelyezes.FormattingEnabled = true;
            this.cmbElhelyezes.Location = new System.Drawing.Point(110, 72);
            this.cmbElhelyezes.Name = "cmbElhelyezes";
            this.cmbElhelyezes.Size = new System.Drawing.Size(233, 21);
            this.cmbElhelyezes.TabIndex = 4;
            // 
            // cmbAnyag
            // 
            this.cmbAnyag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnyag.FormattingEnabled = true;
            this.cmbAnyag.Location = new System.Drawing.Point(110, 104);
            this.cmbAnyag.Name = "cmbAnyag";
            this.cmbAnyag.Size = new System.Drawing.Size(233, 21);
            this.cmbAnyag.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(15, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(155, 29);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.Location = new System.Drawing.Point(177, 424);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(166, 29);
            this.btnMegsem.TabIndex = 7;
            this.btnMegsem.Text = "Megsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Meret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "x";
            // 
            // numx
            // 
            this.numx.Location = new System.Drawing.Point(110, 134);
            this.numx.Name = "numx";
            this.numx.Size = new System.Drawing.Size(60, 20);
            this.numx.TabIndex = 14;
            // 
            // numy
            // 
            this.numy.Location = new System.Drawing.Point(194, 134);
            this.numy.Name = "numy";
            this.numy.Size = new System.Drawing.Size(60, 20);
            this.numy.TabIndex = 15;
            // 
            // numz
            // 
            this.numz.Location = new System.Drawing.Point(280, 134);
            this.numz.Name = "numz";
            this.numz.Size = new System.Drawing.Size(60, 20);
            this.numz.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mennyiseg:";
            // 
            // numDarab
            // 
            this.numDarab.Location = new System.Drawing.Point(110, 176);
            this.numDarab.Name = "numDarab";
            this.numDarab.Size = new System.Drawing.Size(144, 20);
            this.numDarab.TabIndex = 18;
            // 
            // cbkinyitajtos
            // 
            this.cbkinyitajtos.AutoSize = true;
            this.cbkinyitajtos.Location = new System.Drawing.Point(110, 224);
            this.cbkinyitajtos.Name = "cbkinyitajtos";
            this.cbkinyitajtos.Size = new System.Drawing.Size(100, 17);
            this.cbkinyitajtos.TabIndex = 19;
            this.cbkinyitajtos.Text = "Kinyithato/Ajtos";
            this.cbkinyitajtos.UseVisualStyleBackColor = true;
            // 
            // cbcsuszasuveg
            // 
            this.cbcsuszasuveg.AutoSize = true;
            this.cbcsuszasuveg.Location = new System.Drawing.Point(110, 247);
            this.cbcsuszasuveg.Name = "cbcsuszasuveg";
            this.cbcsuszasuveg.Size = new System.Drawing.Size(156, 17);
            this.cbcsuszasuveg.TabIndex = 20;
            this.cbcsuszasuveg.Text = "Csuszasgatlos/Uvegezheto";
            this.cbcsuszasuveg.UseVisualStyleBackColor = true;
            // 
            // numferopolc
            // 
            this.numferopolc.Location = new System.Drawing.Point(139, 278);
            this.numferopolc.Name = "numferopolc";
            this.numferopolc.Size = new System.Drawing.Size(201, 20);
            this.numferopolc.TabIndex = 21;
            // 
            // labelFeroPolc
            // 
            this.labelFeroPolc.AutoSize = true;
            this.labelFeroPolc.Location = new System.Drawing.Point(12, 280);
            this.labelFeroPolc.Name = "labelFeroPolc";
            this.labelFeroPolc.Size = new System.Drawing.Size(121, 13);
            this.labelFeroPolc.TabIndex = 22;
            this.labelFeroPolc.Text = "Ferohely/Polcok szama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Megnevezes:";
            // 
            // tbMegnevezes
            // 
            this.tbMegnevezes.Location = new System.Drawing.Point(110, 40);
            this.tbMegnevezes.Name = "tbMegnevezes";
            this.tbMegnevezes.Size = new System.Drawing.Size(233, 20);
            this.tbMegnevezes.TabIndex = 24;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 465);
            this.Controls.Add(this.tbMegnevezes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelFeroPolc);
            this.Controls.Add(this.numferopolc);
            this.Controls.Add(this.cbcsuszasuveg);
            this.Controls.Add(this.cbkinyitajtos);
            this.Controls.Add(this.numDarab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numz);
            this.Controls.Add(this.numy);
            this.Controls.Add(this.numx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbAnyag);
            this.Controls.Add(this.cmbElhelyezes);
            this.Controls.Add(this.cmbTipus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDarab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numferopolc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipus;
        private System.Windows.Forms.ComboBox cmbElhelyezes;
        private System.Windows.Forms.ComboBox cmbAnyag;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numx;
        private System.Windows.Forms.NumericUpDown numy;
        private System.Windows.Forms.NumericUpDown numz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDarab;
        private System.Windows.Forms.CheckBox cbkinyitajtos;
        private System.Windows.Forms.CheckBox cbcsuszasuveg;
        private System.Windows.Forms.NumericUpDown numferopolc;
        private System.Windows.Forms.Label labelFeroPolc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMegnevezes;
    }
}