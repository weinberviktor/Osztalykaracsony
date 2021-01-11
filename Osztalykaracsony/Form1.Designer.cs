namespace Osztalykaracsony
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.osztbetolt = new System.Windows.Forms.Button();
            this.sors = new System.Windows.Forms.Button();
            this.csomi = new System.Windows.Forms.Button();
            this.kilep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // osztbetolt
            // 
            this.osztbetolt.Location = new System.Drawing.Point(175, 12);
            this.osztbetolt.Name = "osztbetolt";
            this.osztbetolt.Size = new System.Drawing.Size(139, 50);
            this.osztbetolt.TabIndex = 1;
            this.osztbetolt.Text = "Oszály betöltése";
            this.osztbetolt.UseVisualStyleBackColor = true;
            this.osztbetolt.Click += new System.EventHandler(this.osztbetolt_Click);
            // 
            // sors
            // 
            this.sors.Location = new System.Drawing.Point(175, 68);
            this.sors.Name = "sors";
            this.sors.Size = new System.Drawing.Size(139, 50);
            this.sors.TabIndex = 2;
            this.sors.Text = "Sorsolás";
            this.sors.UseVisualStyleBackColor = true;
            this.sors.Click += new System.EventHandler(this.sors_Click);
            // 
            // csomi
            // 
            this.csomi.Location = new System.Drawing.Point(175, 124);
            this.csomi.Name = "csomi";
            this.csomi.Size = new System.Drawing.Size(139, 50);
            this.csomi.TabIndex = 3;
            this.csomi.Text = "Csomagépitő";
            this.csomi.UseVisualStyleBackColor = true;
            this.csomi.Click += new System.EventHandler(this.csomi_Click);
            // 
            // kilep
            // 
            this.kilep.Location = new System.Drawing.Point(175, 180);
            this.kilep.Name = "kilep";
            this.kilep.Size = new System.Drawing.Size(139, 50);
            this.kilep.TabIndex = 4;
            this.kilep.Text = "Kilépés";
            this.kilep.UseVisualStyleBackColor = true;
            this.kilep.Click += new System.EventHandler(this.kilep_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(328, 242);
            this.Controls.Add(this.kilep);
            this.Controls.Add(this.csomi);
            this.Controls.Add(this.sors);
            this.Controls.Add(this.osztbetolt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button osztbetolt;
        private System.Windows.Forms.Button sors;
        private System.Windows.Forms.Button csomi;
        private System.Windows.Forms.Button kilep;
    }
}

