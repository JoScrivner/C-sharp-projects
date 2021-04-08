namespace GyartmanylapKeszito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAlapanyagKezelo = new System.Windows.Forms.Button();
            this.btnGyartmanylapKezelo = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAlapanyagKezelo
            // 
            this.btnAlapanyagKezelo.FlatAppearance.BorderSize = 0;
            this.btnAlapanyagKezelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlapanyagKezelo.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAlapanyagKezelo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlapanyagKezelo.Image = ((System.Drawing.Image)(resources.GetObject("btnAlapanyagKezelo.Image")));
            this.btnAlapanyagKezelo.Location = new System.Drawing.Point(37, 71);
            this.btnAlapanyagKezelo.Name = "btnAlapanyagKezelo";
            this.btnAlapanyagKezelo.Size = new System.Drawing.Size(521, 502);
            this.btnAlapanyagKezelo.TabIndex = 0;
            this.btnAlapanyagKezelo.Text = "Alapanyagkezelő";
            this.btnAlapanyagKezelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlapanyagKezelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlapanyagKezelo.UseVisualStyleBackColor = true;
            this.btnAlapanyagKezelo.Click += new System.EventHandler(this.btnAlapanyagKezelo_Click);
            // 
            // btnGyartmanylapKezelo
            // 
            this.btnGyartmanylapKezelo.FlatAppearance.BorderSize = 0;
            this.btnGyartmanylapKezelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGyartmanylapKezelo.Font = new System.Drawing.Font("Bookman Old Style", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGyartmanylapKezelo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGyartmanylapKezelo.Image = ((System.Drawing.Image)(resources.GetObject("btnGyartmanylapKezelo.Image")));
            this.btnGyartmanylapKezelo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGyartmanylapKezelo.Location = new System.Drawing.Point(591, 71);
            this.btnGyartmanylapKezelo.Name = "btnGyartmanylapKezelo";
            this.btnGyartmanylapKezelo.Size = new System.Drawing.Size(521, 502);
            this.btnGyartmanylapKezelo.TabIndex = 1;
            this.btnGyartmanylapKezelo.Text = "Gyártmánylapkezelő";
            this.btnGyartmanylapKezelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGyartmanylapKezelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGyartmanylapKezelo.UseVisualStyleBackColor = true;
            this.btnGyartmanylapKezelo.Click += new System.EventHandler(this.btnGyartmanylapKezelo_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.close.Location = new System.Drawing.Point(1115, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 33);
            this.close.TabIndex = 2;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 33);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(37, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 11);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1152, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.btnGyartmanylapKezelo);
            this.Controls.Add(this.btnAlapanyagKezelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gyártmánylap-készítő program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlapanyagKezelo;
        private System.Windows.Forms.Button btnGyartmanylapKezelo;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

