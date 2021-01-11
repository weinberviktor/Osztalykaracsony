namespace Osztalykaracsony
{
    partial class FrmOsztaly
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
            this.talloz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.adatbazis_add = new System.Windows.Forms.Button();
            this.tallozas_helye = new System.Windows.Forms.TextBox();
            this.osztaly_neve = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osztálynévsor tallózása:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // talloz
            // 
            this.talloz.Location = new System.Drawing.Point(410, 61);
            this.talloz.Name = "talloz";
            this.talloz.Size = new System.Drawing.Size(102, 23);
            this.talloz.TabIndex = 1;
            this.talloz.Text = "Tallozás";
            this.talloz.UseVisualStyleBackColor = true;
            this.talloz.Click += new System.EventHandler(this.talloz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Írja be az osztályjelzést: ";
            // 
            // adatbazis_add
            // 
            this.adatbazis_add.Enabled = false;
            this.adatbazis_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adatbazis_add.Location = new System.Drawing.Point(99, 224);
            this.adatbazis_add.Name = "adatbazis_add";
            this.adatbazis_add.Size = new System.Drawing.Size(299, 30);
            this.adatbazis_add.TabIndex = 3;
            this.adatbazis_add.Text = "Hozzáadás adatbázishoz";
            this.adatbazis_add.UseVisualStyleBackColor = true;
            this.adatbazis_add.Click += new System.EventHandler(this.adatbazis_add_Click);
            // 
            // tallozas_helye
            // 
            this.tallozas_helye.Location = new System.Drawing.Point(16, 63);
            this.tallozas_helye.Name = "tallozas_helye";
            this.tallozas_helye.Size = new System.Drawing.Size(382, 20);
            this.tallozas_helye.TabIndex = 4;
            this.tallozas_helye.TextChanged += new System.EventHandler(this.tallozas_helye_TextChanged);
            // 
            // osztaly_neve
            // 
            this.osztaly_neve.BackColor = System.Drawing.Color.WhiteSmoke;
            this.osztaly_neve.Enabled = false;
            this.osztaly_neve.Location = new System.Drawing.Point(227, 148);
            this.osztaly_neve.Name = "osztaly_neve";
            this.osztaly_neve.Size = new System.Drawing.Size(269, 20);
            this.osztaly_neve.TabIndex = 5;
            // 
            // FrmOsztaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(539, 390);
            this.Controls.Add(this.osztaly_neve);
            this.Controls.Add(this.tallozas_helye);
            this.Controls.Add(this.adatbazis_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.talloz);
            this.Controls.Add(this.label1);
            this.Name = "FrmOsztaly";
            this.Text = "FrmOsztaly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button talloz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adatbazis_add;
        private System.Windows.Forms.TextBox tallozas_helye;
        private System.Windows.Forms.TextBox osztaly_neve;
    }
}