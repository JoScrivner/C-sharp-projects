namespace KonyvesboltMintaVizsga
{
    partial class Form3
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
            this.lbKonyvek = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudOldalszam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudKiadasEve = new System.Windows.Forms.NumericUpDown();
            this.btnSzures = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOldalszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKiadasEve)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKonyvek
            // 
            this.lbKonyvek.FormattingEnabled = true;
            this.lbKonyvek.ItemHeight = 16;
            this.lbKonyvek.Location = new System.Drawing.Point(12, 89);
            this.lbKonyvek.Name = "lbKonyvek";
            this.lbKonyvek.Size = new System.Drawing.Size(649, 260);
            this.lbKonyvek.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSzures);
            this.groupBox1.Controls.Add(this.nudKiadasEve);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudOldalszam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Szűrés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum oldalszám:";
            // 
            // nudOldalszam
            // 
            this.nudOldalszam.Location = new System.Drawing.Point(146, 21);
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
            this.nudOldalszam.Size = new System.Drawing.Size(78, 22);
            this.nudOldalszam.TabIndex = 1;
            this.nudOldalszam.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiadás éve:";
            // 
            // nudKiadasEve
            // 
            this.nudKiadasEve.Location = new System.Drawing.Point(331, 21);
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
            this.nudKiadasEve.Size = new System.Drawing.Size(78, 22);
            this.nudKiadasEve.TabIndex = 3;
            this.nudKiadasEve.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // btnSzures
            // 
            this.btnSzures.Location = new System.Drawing.Point(538, 14);
            this.btnSzures.Name = "btnSzures";
            this.btnSzures.Size = new System.Drawing.Size(105, 44);
            this.btnSzures.TabIndex = 4;
            this.btnSzures.Text = "Szűrés";
            this.btnSzures.UseVisualStyleBackColor = true;
            this.btnSzures.Click += new System.EventHandler(this.btnSzures_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbKonyvek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Drága könyvek";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOldalszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKiadasEve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbKonyvek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudKiadasEve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOldalszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzures;
    }
}