namespace TA_PBD15E
{
    partial class Frm_CariProdi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CariProdi = new System.Windows.Forms.TextBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.lst_CariProdi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_CariProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_batal);
            this.groupBox1.Controls.Add(this.txt_CariProdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data Program Studi Berdasarkan Kode / Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Program Studi";
            // 
            // txt_CariProdi
            // 
            this.txt_CariProdi.Location = new System.Drawing.Point(108, 18);
            this.txt_CariProdi.Name = "txt_CariProdi";
            this.txt_CariProdi.Size = new System.Drawing.Size(328, 20);
            this.txt_CariProdi.TabIndex = 1;
            this.txt_CariProdi.TextChanged += new System.EventHandler(this.txt_CariProdi_TextChanged);
            // 
            // btn_batal
            // 
            this.btn_batal.Location = new System.Drawing.Point(443, 16);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(75, 23);
            this.btn_batal.TabIndex = 2;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // lst_CariProdi
            // 
            this.lst_CariProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_CariProdi.Location = new System.Drawing.Point(13, 77);
            this.lst_CariProdi.Name = "lst_CariProdi";
            this.lst_CariProdi.Size = new System.Drawing.Size(524, 172);
            this.lst_CariProdi.TabIndex = 1;
            this.lst_CariProdi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_CariProdi_CellClick);
            // 
            // Frm_CariProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 261);
            this.Controls.Add(this.lst_CariProdi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_CariProdi";
            this.Text = "Frm_CariProdi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_CariProdi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CariProdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.DataGridView lst_CariProdi;
    }
}