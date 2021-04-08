namespace KonyvesboltMintaVizsga
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
            this.lbIrodalmi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTudomanyos = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIrodalmi
            // 
            this.lbIrodalmi.FormattingEnabled = true;
            this.lbIrodalmi.ItemHeight = 16;
            this.lbIrodalmi.Location = new System.Drawing.Point(15, 29);
            this.lbIrodalmi.Name = "lbIrodalmi";
            this.lbIrodalmi.Size = new System.Drawing.Size(641, 180);
            this.lbIrodalmi.TabIndex = 0;
            this.lbIrodalmi.SelectedIndexChanged += new System.EventHandler(this.lbIrodalmi_SelectedIndexChanged);
            this.lbIrodalmi.DoubleClick += new System.EventHandler(this.lbIrodalmi_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Irodalmi könyvek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tudományos könyvek:";
            // 
            // lbTudomanyos
            // 
            this.lbTudomanyos.FormattingEnabled = true;
            this.lbTudomanyos.ItemHeight = 16;
            this.lbTudomanyos.Location = new System.Drawing.Point(15, 232);
            this.lbTudomanyos.Name = "lbTudomanyos";
            this.lbTudomanyos.Size = new System.Drawing.Size(641, 180);
            this.lbTudomanyos.TabIndex = 2;
            this.lbTudomanyos.SelectedIndexChanged += new System.EventHandler(this.lbTudomanyos_SelectedIndexChanged);
            this.lbTudomanyos.DoubleClick += new System.EventHandler(this.lbIrodalmi_DoubleClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML fájl|*.xml";
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(662, 358);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(126, 54);
            this.btnXML.TabIndex = 4;
            this.btnXML.Text = "Exportálás XML-be";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(662, 29);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(126, 54);
            this.btnUj.TabIndex = 5;
            this.btnUj.Text = "Új könyv hozzáadása";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(662, 89);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(126, 54);
            this.btnTorol.TabIndex = 6;
            this.btnTorol.Text = "Kijelölt könyv törlése";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(662, 149);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(126, 54);
            this.btnModosit.TabIndex = 7;
            this.btnModosit.Text = "Kijelölt könyv módosítása";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTudomanyos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIrodalmi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Könyvesbolt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbIrodalmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTudomanyos;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnModosit;
    }
}

