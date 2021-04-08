namespace GyartmanylapKeszito
{
    partial class GyartmanylapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GyartmanylapForm));
            this.btnTorlesgy = new System.Windows.Forms.Button();
            this.btnModositgy = new System.Windows.Forms.Button();
            this.btnUjgy = new System.Windows.Forms.Button();
            this.lbGyartmanylapok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTorlesgy
            // 
            this.btnTorlesgy.FlatAppearance.BorderSize = 0;
            this.btnTorlesgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTorlesgy.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorlesgy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTorlesgy.Image = ((System.Drawing.Image)(resources.GetObject("btnTorlesgy.Image")));
            this.btnTorlesgy.Location = new System.Drawing.Point(25, 414);
            this.btnTorlesgy.Name = "btnTorlesgy";
            this.btnTorlesgy.Size = new System.Drawing.Size(181, 174);
            this.btnTorlesgy.TabIndex = 9;
            this.btnTorlesgy.Text = "Gyártmánylap törlése";
            this.btnTorlesgy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTorlesgy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTorlesgy.UseVisualStyleBackColor = true;
            this.btnTorlesgy.Click += new System.EventHandler(this.btnTorlesgy_Click);
            this.btnTorlesgy.MouseHover += new System.EventHandler(this.btnTorlesgy_MouseHover);
            // 
            // btnModositgy
            // 
            this.btnModositgy.FlatAppearance.BorderSize = 0;
            this.btnModositgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModositgy.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModositgy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModositgy.Image = ((System.Drawing.Image)(resources.GetObject("btnModositgy.Image")));
            this.btnModositgy.Location = new System.Drawing.Point(25, 234);
            this.btnModositgy.Name = "btnModositgy";
            this.btnModositgy.Size = new System.Drawing.Size(181, 174);
            this.btnModositgy.TabIndex = 8;
            this.btnModositgy.Text = "Gyártmánylap szerkesztése";
            this.btnModositgy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModositgy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModositgy.UseVisualStyleBackColor = true;
            this.btnModositgy.Click += new System.EventHandler(this.btnModositgy_Click);
            this.btnModositgy.MouseHover += new System.EventHandler(this.btnModositgy_MouseHover);
            // 
            // btnUjgy
            // 
            this.btnUjgy.FlatAppearance.BorderSize = 0;
            this.btnUjgy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjgy.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUjgy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUjgy.Image = ((System.Drawing.Image)(resources.GetObject("btnUjgy.Image")));
            this.btnUjgy.Location = new System.Drawing.Point(25, 54);
            this.btnUjgy.Name = "btnUjgy";
            this.btnUjgy.Size = new System.Drawing.Size(181, 174);
            this.btnUjgy.TabIndex = 7;
            this.btnUjgy.Text = "Új gyártmánylap létrehozása";
            this.btnUjgy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUjgy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUjgy.UseVisualStyleBackColor = true;
            this.btnUjgy.Click += new System.EventHandler(this.btnUjgy_Click);
            this.btnUjgy.MouseHover += new System.EventHandler(this.btnUjgy_MouseHover);
            // 
            // lbGyartmanylapok
            // 
            this.lbGyartmanylapok.BackColor = System.Drawing.SystemColors.Control;
            this.lbGyartmanylapok.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGyartmanylapok.FormattingEnabled = true;
            this.lbGyartmanylapok.ItemHeight = 25;
            this.lbGyartmanylapok.Location = new System.Drawing.Point(250, 84);
            this.lbGyartmanylapok.Name = "lbGyartmanylapok";
            this.lbGyartmanylapok.Size = new System.Drawing.Size(497, 504);
            this.lbGyartmanylapok.TabIndex = 10;
            this.lbGyartmanylapok.DoubleClick += new System.EventHandler(this.btnModositgy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(246, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mentett gyártmánylapok:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(933, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 174);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exportálás PDF-be";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 33);
            this.panel2.TabIndex = 14;
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(1119, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 33);
            this.close.TabIndex = 13;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(209, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 174);
            this.panel1.TabIndex = 15;
            // 
            // GyartmanylapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1155, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGyartmanylapok);
            this.Controls.Add(this.btnTorlesgy);
            this.Controls.Add(this.btnModositgy);
            this.Controls.Add(this.btnUjgy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "GyartmanylapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gyártmánylapkezelő";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GyartmanylapForm_FormClosing);
            this.Load += new System.EventHandler(this.GyartmanylapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTorlesgy;
        private System.Windows.Forms.Button btnModositgy;
        private System.Windows.Forms.Button btnUjgy;
        private System.Windows.Forms.ListBox lbGyartmanylapok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
    }
}