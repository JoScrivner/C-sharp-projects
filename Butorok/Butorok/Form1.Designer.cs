namespace Butorok
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbButorok = new System.Windows.Forms.ListBox();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKeres = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Butorok:";
            // 
            // lbButorok
            // 
            this.lbButorok.FormattingEnabled = true;
            this.lbButorok.Location = new System.Drawing.Point(16, 29);
            this.lbButorok.Name = "lbButorok";
            this.lbButorok.Size = new System.Drawing.Size(542, 316);
            this.lbButorok.TabIndex = 1;
            this.lbButorok.DoubleClick += new System.EventHandler(this.lbButorok_DoubleClick);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(564, 29);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(154, 57);
            this.btnUj.TabIndex = 2;
            this.btnUj.Text = "Uj termek";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(564, 92);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(154, 62);
            this.btnModosit.TabIndex = 3;
            this.btnModosit.Text = "Termek modositasa";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(564, 160);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(154, 61);
            this.btnTorles.TabIndex = 4;
            this.btnTorles.Text = "Termek torlese";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKeres
            // 
            this.btnKeres.Enabled = false;
            this.btnKeres.Location = new System.Drawing.Point(564, 228);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(154, 53);
            this.btnKeres.TabIndex = 5;
            this.btnKeres.Text = "Kereses";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Összesítés mentése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.lbButorok);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbButorok;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Button button1;
    }
}

