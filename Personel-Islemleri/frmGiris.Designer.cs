﻿namespace Personel_Islemleri
{
	partial class frmGiris
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
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.btnGiris = new System.Windows.Forms.Button();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı";
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciAdi.Location = new System.Drawing.Point(98, 16);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(148, 22);
			this.txtKullaniciAdi.TabIndex = 1;
			// 
			// btnGiris
			// 
			this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGiris.Location = new System.Drawing.Point(98, 70);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(148, 35);
			this.btnGiris.TabIndex = 2;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(98, 42);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.Size = new System.Drawing.Size(148, 22);
			this.txtSifre.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(57, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Şifre";
			// 
			// frmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(276, 126);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.label1);
			this.Name = "frmGiris";
			this.Text = "frmGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Label label2;
	}
}