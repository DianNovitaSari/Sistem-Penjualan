namespace TA_PBD15E
{
    partial class Frm_CariPanitia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.txt_CariPanitia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_Caripanitia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_Caripanitia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_batal);
            this.groupBox1.Controls.Add(this.txt_CariPanitia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Panitia Berdasarkan ID / Nama Panitia";
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(393, 20);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(75, 23);
            this.btn_batal.TabIndex = 2;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // txt_CariPanitia
            // 
            this.txt_CariPanitia.Location = new System.Drawing.Point(74, 20);
            this.txt_CariPanitia.Name = "txt_CariPanitia";
            this.txt_CariPanitia.Size = new System.Drawing.Size(313, 20);
            this.txt_CariPanitia.TabIndex = 1;
            this.txt_CariPanitia.TextChanged += new System.EventHandler(this.txt_CariPanitia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Panitia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_Caripanitia);
            this.groupBox2.Location = new System.Drawing.Point(14, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Panitia";
            // 
            // lst_Caripanitia
            // 
            this.lst_Caripanitia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_Caripanitia.Location = new System.Drawing.Point(6, 19);
            this.lst_Caripanitia.Name = "lst_Caripanitia";
            this.lst_Caripanitia.Size = new System.Drawing.Size(453, 177);
            this.lst_Caripanitia.TabIndex = 0;
            this.lst_Caripanitia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_Caripanitia_CellClick);
            this.lst_Caripanitia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_Caripanitia_CellContentClick);
            // 
            // Frm_CariPanitia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_CariPanitia";
            this.Text = "Frm_CariPanitia";
            this.Load += new System.EventHandler(this.Frm_CariPanitia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lst_Caripanitia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.TextBox txt_CariPanitia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView lst_Caripanitia;
    }
}