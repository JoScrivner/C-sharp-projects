namespace Iskolak
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAltalanos = new System.Windows.Forms.ListBox();
            this.lbGimnazium = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.labelkalk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altalanos iskolak:";
            // 
            // lbAltalanos
            // 
            this.lbAltalanos.FormattingEnabled = true;
            this.lbAltalanos.Location = new System.Drawing.Point(13, 30);
            this.lbAltalanos.Name = "lbAltalanos";
            this.lbAltalanos.Size = new System.Drawing.Size(784, 186);
            this.lbAltalanos.TabIndex = 1;
            this.lbAltalanos.Click += new System.EventHandler(this.lbAltalanos_Click);
            this.lbAltalanos.SelectedIndexChanged += new System.EventHandler(this.lbAltalanos_SelectedIndexChanged);
            // 
            // lbGimnazium
            // 
            this.lbGimnazium.FormattingEnabled = true;
            this.lbGimnazium.Location = new System.Drawing.Point(12, 238);
            this.lbGimnazium.Name = "lbGimnazium";
            this.lbGimnazium.Size = new System.Drawing.Size(785, 186);
            this.lbGimnazium.TabIndex = 3;
            this.lbGimnazium.Click += new System.EventHandler(this.lbGimnazium_Click);
            this.lbGimnazium.SelectedIndexChanged += new System.EventHandler(this.lbGimnazium_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gimnaziumok:";
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(12, 427);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(143, 58);
            this.btnUj.TabIndex = 4;
            this.btnUj.Text = "Uj iskola hozzaadasa";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(161, 427);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(143, 58);
            this.btnTorol.TabIndex = 5;
            this.btnTorol.Text = "Kijelolt iskola torlese";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // labelkalk
            // 
            this.labelkalk.AutoSize = true;
            this.labelkalk.Location = new System.Drawing.Point(310, 427);
            this.labelkalk.Name = "labelkalk";
            this.labelkalk.Size = new System.Drawing.Size(10, 13);
            this.labelkalk.TabIndex = 7;
            this.labelkalk.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 496);
            this.Controls.Add(this.labelkalk);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.lbGimnazium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAltalanos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Iskolak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAltalanos;
        private System.Windows.Forms.ListBox lbGimnazium;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Label labelkalk;
    }
}

