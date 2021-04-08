namespace GyartmanylapKeszito
{
    partial class AlapanyagForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlapanyagForm));
            this.lbTalalatok = new System.Windows.Forms.ListBox();
            this.tbKeres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.lbKereses = new System.Windows.Forms.ListBox();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbTalalatok
            // 
            this.lbTalalatok.BackColor = System.Drawing.SystemColors.Control;
            this.lbTalalatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTalalatok.FormattingEnabled = true;
            this.lbTalalatok.ItemHeight = 20;
            this.lbTalalatok.Location = new System.Drawing.Point(32, 146);
            this.lbTalalatok.Name = "lbTalalatok";
            this.lbTalalatok.Size = new System.Drawing.Size(788, 444);
            this.lbTalalatok.TabIndex = 0;
            this.lbTalalatok.DoubleClick += new System.EventHandler(this.btnModosit_Click);
            // 
            // tbKeres
            // 
            this.tbKeres.BackColor = System.Drawing.SystemColors.Control;
            this.tbKeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKeres.Location = new System.Drawing.Point(32, 84);
            this.tbKeres.Name = "tbKeres";
            this.tbKeres.Size = new System.Drawing.Size(788, 26);
            this.tbKeres.TabIndex = 1;
            this.tbKeres.TextChanged += new System.EventHandler(this.tbKeres_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keresés:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alapanyagok:";
            // 
            // btnUj
            // 
            this.btnUj.FlatAppearance.BorderSize = 0;
            this.btnUj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUj.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUj.Image = ((System.Drawing.Image)(resources.GetObject("btnUj.Image")));
            this.btnUj.Location = new System.Drawing.Point(854, 57);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(261, 174);
            this.btnUj.TabIndex = 4;
            this.btnUj.Text = "Új alapanyag hozzáadása";
            this.btnUj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            this.btnUj.MouseHover += new System.EventHandler(this.btnUj_MouseHover);
            // 
            // btnModosit
            // 
            this.btnModosit.FlatAppearance.BorderSize = 0;
            this.btnModosit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModosit.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModosit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModosit.Image = ((System.Drawing.Image)(resources.GetObject("btnModosit.Image")));
            this.btnModosit.Location = new System.Drawing.Point(854, 237);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(261, 174);
            this.btnModosit.TabIndex = 5;
            this.btnModosit.Text = "Alapanyag módosítása";
            this.btnModosit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModosit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            this.btnModosit.MouseHover += new System.EventHandler(this.btnModosit_MouseHover);
            // 
            // btnTorles
            // 
            this.btnTorles.FlatAppearance.BorderSize = 0;
            this.btnTorles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorles.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorles.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTorles.Image = ((System.Drawing.Image)(resources.GetObject("btnTorles.Image")));
            this.btnTorles.Location = new System.Drawing.Point(854, 414);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(261, 174);
            this.btnTorles.TabIndex = 6;
            this.btnTorles.Text = "Alapanyag törlése";
            this.btnTorles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTorles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            this.btnTorles.MouseHover += new System.EventHandler(this.btnTorles_MouseHover);
            // 
            // lbKereses
            // 
            this.lbKereses.BackColor = System.Drawing.SystemColors.Control;
            this.lbKereses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbKereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKereses.FormattingEnabled = true;
            this.lbKereses.ItemHeight = 20;
            this.lbKereses.Location = new System.Drawing.Point(32, 147);
            this.lbKereses.Name = "lbKereses";
            this.lbKereses.Size = new System.Drawing.Size(788, 442);
            this.lbKereses.TabIndex = 7;
            this.lbKereses.Visible = false;
            this.lbKereses.DoubleClick += new System.EventHandler(this.btnModosit_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(1119, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 33);
            this.close.TabIndex = 8;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(826, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 174);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 33);
            this.panel2.TabIndex = 10;
            // 
            // AlapanyagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1155, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lbKereses);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKeres);
            this.Controls.Add(this.lbTalalatok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AlapanyagForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alapanyagkezelő";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlapanyagForm_FormClosing);
            this.Load += new System.EventHandler(this.AlapanyagForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTalalatok;
        private System.Windows.Forms.TextBox tbKeres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.ListBox lbKereses;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}