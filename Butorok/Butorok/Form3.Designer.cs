namespace Butorok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKeres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTalalatok = new System.Windows.Forms.ListBox();
            this.cbRendezett = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Írd be a keresett termék nevét";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "vagy annak egy részletét:";
            // 
            // tbKeres
            // 
            this.tbKeres.Location = new System.Drawing.Point(16, 43);
            this.tbKeres.Name = "tbKeres";
            this.tbKeres.Size = new System.Drawing.Size(195, 20);
            this.tbKeres.TabIndex = 2;
            this.tbKeres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Találatok:";
            // 
            // lbTalalatok
            // 
            this.lbTalalatok.FormattingEnabled = true;
            this.lbTalalatok.Location = new System.Drawing.Point(16, 82);
            this.lbTalalatok.Name = "lbTalalatok";
            this.lbTalalatok.Size = new System.Drawing.Size(195, 199);
            this.lbTalalatok.TabIndex = 4;
            // 
            // cbRendezett
            // 
            this.cbRendezett.AutoSize = true;
            this.cbRendezett.Location = new System.Drawing.Point(16, 289);
            this.cbRendezett.Name = "cbRendezett";
            this.cbRendezett.Size = new System.Drawing.Size(119, 17);
            this.cbRendezett.TabIndex = 5;
            this.cbRendezett.Text = "Rendezés ár szerint";
            this.cbRendezett.UseVisualStyleBackColor = true;
            this.cbRendezett.CheckedChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 318);
            this.Controls.Add(this.cbRendezett);
            this.Controls.Add(this.lbTalalatok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKeres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Keresés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKeres;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbTalalatok;
        private System.Windows.Forms.CheckBox cbRendezett;
    }
}