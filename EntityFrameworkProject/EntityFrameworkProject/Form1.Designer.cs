namespace EntityFrameworkProject
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxKategori = new System.Windows.Forms.GroupBox();
            this.gbxUrun = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUrun = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxKategori.SuspendLayout();
            this.gbxUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(36, 170);
            this.dgwProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(918, 419);
            this.dgwProducts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori:";
            // 
            // gbxKategori
            // 
            this.gbxKategori.Controls.Add(this.cbxCategory);
            this.gbxKategori.Controls.Add(this.label1);
            this.gbxKategori.Location = new System.Drawing.Point(69, 29);
            this.gbxKategori.Name = "gbxKategori";
            this.gbxKategori.Size = new System.Drawing.Size(377, 92);
            this.gbxKategori.TabIndex = 3;
            this.gbxKategori.TabStop = false;
            this.gbxKategori.Text = "Kategoriye Göre Listele";
            // 
            // gbxUrun
            // 
            this.gbxUrun.Controls.Add(this.label2);
            this.gbxUrun.Controls.Add(this.tbxUrun);
            this.gbxUrun.Location = new System.Drawing.Point(501, 29);
            this.gbxUrun.Name = "gbxUrun";
            this.gbxUrun.Size = new System.Drawing.Size(377, 92);
            this.gbxUrun.TabIndex = 4;
            this.gbxUrun.TabStop = false;
            this.gbxUrun.Text = "Ürün İsmine Göre Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ara:";
            // 
            // tbxUrun
            // 
            this.tbxUrun.Location = new System.Drawing.Point(116, 38);
            this.tbxUrun.Name = "tbxUrun";
            this.tbxUrun.Size = new System.Drawing.Size(236, 28);
            this.tbxUrun.TabIndex = 2;
            this.tbxUrun.TextChanged += new System.EventHandler(this.tbxUrun_TextChanged);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(127, 38);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(230, 30);
            this.cbxCategory.TabIndex = 2;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.gbxUrun);
            this.Controls.Add(this.gbxKategori);
            this.Controls.Add(this.dgwProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxKategori.ResumeLayout(false);
            this.gbxKategori.PerformLayout();
            this.gbxUrun.ResumeLayout(false);
            this.gbxUrun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxKategori;
        private System.Windows.Forms.GroupBox gbxUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUrun;
        private System.Windows.Forms.ComboBox cbxCategory;
    }
}

