﻿namespace SeSa_Kirtasiye
{
    partial class Kategoriler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.müsterilerTabPage = new System.Windows.Forms.TabPage();
            this.kategorilerGridView = new System.Windows.Forms.DataGridView();
            this.kategoriAra = new System.Windows.Forms.Button();
            this.aranacakKategori = new System.Windows.Forms.TextBox();
            this.kategoriSil = new System.Windows.Forms.Button();
            this.kategoriDuzenle = new System.Windows.Forms.Button();
            this.kategoriEkle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.müsterilerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.müsterilerTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // müsterilerTabPage
            // 
            this.müsterilerTabPage.Controls.Add(this.kategorilerGridView);
            this.müsterilerTabPage.Controls.Add(this.kategoriAra);
            this.müsterilerTabPage.Controls.Add(this.aranacakKategori);
            this.müsterilerTabPage.Controls.Add(this.kategoriSil);
            this.müsterilerTabPage.Controls.Add(this.kategoriDuzenle);
            this.müsterilerTabPage.Controls.Add(this.kategoriEkle);
            this.müsterilerTabPage.Location = new System.Drawing.Point(4, 22);
            this.müsterilerTabPage.Name = "müsterilerTabPage";
            this.müsterilerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.müsterilerTabPage.Size = new System.Drawing.Size(768, 400);
            this.müsterilerTabPage.TabIndex = 1;
            this.müsterilerTabPage.Text = "KATEGORİLER";
            this.müsterilerTabPage.UseVisualStyleBackColor = true;
            // 
            // kategorilerGridView
            // 
            this.kategorilerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategorilerGridView.Location = new System.Drawing.Point(6, 36);
            this.kategorilerGridView.Name = "kategorilerGridView";
            this.kategorilerGridView.Size = new System.Drawing.Size(755, 358);
            this.kategorilerGridView.TabIndex = 7;
            // 
            // kategoriAra
            // 
            this.kategoriAra.Location = new System.Drawing.Point(686, 7);
            this.kategoriAra.Name = "kategoriAra";
            this.kategoriAra.Size = new System.Drawing.Size(75, 23);
            this.kategoriAra.TabIndex = 5;
            this.kategoriAra.Text = "Kategori Ara";
            this.kategoriAra.UseVisualStyleBackColor = true;
            this.kategoriAra.Click += new System.EventHandler(this.kategoriAra_Click);
            // 
            // aranacakKategori
            // 
            this.aranacakKategori.Location = new System.Drawing.Point(581, 7);
            this.aranacakKategori.Name = "aranacakKategori";
            this.aranacakKategori.Size = new System.Drawing.Size(100, 20);
            this.aranacakKategori.TabIndex = 4;
            // 
            // kategoriSil
            // 
            this.kategoriSil.Location = new System.Drawing.Point(167, 7);
            this.kategoriSil.Name = "kategoriSil";
            this.kategoriSil.Size = new System.Drawing.Size(75, 23);
            this.kategoriSil.TabIndex = 3;
            this.kategoriSil.Text = "Sil";
            this.kategoriSil.UseVisualStyleBackColor = true;
            this.kategoriSil.Click += new System.EventHandler(this.kategoriSil_Click);
            // 
            // kategoriDuzenle
            // 
            this.kategoriDuzenle.Location = new System.Drawing.Point(87, 7);
            this.kategoriDuzenle.Name = "kategoriDuzenle";
            this.kategoriDuzenle.Size = new System.Drawing.Size(75, 23);
            this.kategoriDuzenle.TabIndex = 2;
            this.kategoriDuzenle.Text = "Düzenle";
            this.kategoriDuzenle.UseVisualStyleBackColor = true;
            this.kategoriDuzenle.Click += new System.EventHandler(this.kategoriDuzenle_Click);
            // 
            // kategoriEkle
            // 
            this.kategoriEkle.Location = new System.Drawing.Point(7, 7);
            this.kategoriEkle.Name = "kategoriEkle";
            this.kategoriEkle.Size = new System.Drawing.Size(75, 23);
            this.kategoriEkle.TabIndex = 1;
            this.kategoriEkle.Text = "Ekle";
            this.kategoriEkle.UseVisualStyleBackColor = true;
            this.kategoriEkle.Click += new System.EventHandler(this.kategoriEkle_Click);
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            this.tabControl1.ResumeLayout(false);
            this.müsterilerTabPage.ResumeLayout(false);
            this.müsterilerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage müsterilerTabPage;
        private System.Windows.Forms.DataGridView kategorilerGridView;
        private System.Windows.Forms.Button kategoriAra;
        private System.Windows.Forms.TextBox aranacakKategori;
        private System.Windows.Forms.Button kategoriSil;
        private System.Windows.Forms.Button kategoriDuzenle;
        private System.Windows.Forms.Button kategoriEkle;
    }
}