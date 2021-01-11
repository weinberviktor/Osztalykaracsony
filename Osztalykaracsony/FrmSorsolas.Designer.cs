namespace Osztalykaracsony
{
    partial class FrmSorsolas
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
            this.rnd = new System.Windows.Forms.Button();
            this.csere = new System.Windows.Forms.Button();
            this.vegleg = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "válasszon osztályt";
            // 
            // rnd
            // 
            this.rnd.Location = new System.Drawing.Point(257, 34);
            this.rnd.Name = "rnd";
            this.rnd.Size = new System.Drawing.Size(273, 23);
            this.rnd.TabIndex = 1;
            this.rnd.Text = "Véletlen összepárosítás";
            this.rnd.UseVisualStyleBackColor = true;
            // 
            // csere
            // 
            this.csere.Location = new System.Drawing.Point(136, 381);
            this.csere.Name = "csere";
            this.csere.Size = new System.Drawing.Size(75, 23);
            this.csere.TabIndex = 2;
            this.csere.Text = "Csere";
            this.csere.UseVisualStyleBackColor = true;
            // 
            // vegleg
            // 
            this.vegleg.Location = new System.Drawing.Point(504, 384);
            this.vegleg.Name = "vegleg";
            this.vegleg.Size = new System.Drawing.Size(242, 23);
            this.vegleg.TabIndex = 3;
            this.vegleg.Text = "Véglegsítés";
            this.vegleg.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a_id,
            this.add,
            this.k_id,
            this.kap});
            this.dataGridView1.Location = new System.Drawing.Point(18, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 284);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "a_id_1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "a_id_2";
            // 
            // a_id
            // 
            this.a_id.HeaderText = "a_id";
            this.a_id.Name = "a_id";
            this.a_id.ReadOnly = true;
            // 
            // add
            // 
            this.add.HeaderText = "add";
            this.add.Name = "add";
            this.add.ReadOnly = true;
            // 
            // k_id
            // 
            this.k_id.HeaderText = "k_id";
            this.k_id.Name = "k_id";
            this.k_id.ReadOnly = true;
            // 
            // kap
            // 
            this.kap.HeaderText = "kap";
            this.kap.Name = "kap";
            // 
            // FrmSorsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.vegleg);
            this.Controls.Add(this.csere);
            this.Controls.Add(this.rnd);
            this.Controls.Add(this.label1);
            this.Name = "FrmSorsolas";
            this.Text = "FrmSorsolas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rnd;
        private System.Windows.Forms.Button csere;
        private System.Windows.Forms.Button vegleg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn k_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kap;
    }
}