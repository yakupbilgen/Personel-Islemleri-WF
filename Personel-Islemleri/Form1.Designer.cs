namespace Personel_Islemleri
{
	partial class frmPersonel
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonel));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblDurum = new System.Windows.Forms.Label();
			this.radioBekar = new XanderUI.XUIRadio();
			this.radioEvli = new XanderUI.XUIRadio();
			this.txtMeslek = new System.Windows.Forms.TextBox();
			this.txtMaas = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.cmbSehir = new System.Windows.Forms.ComboBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.xBtnCikis = new XanderUI.XUIButton();
			this.xBtnGrafikler = new XanderUI.XUIButton();
			this.xBtnIstatistik = new XanderUI.XUIButton();
			this.xBtnTemizle = new XanderUI.XUIButton();
			this.xBtnGuncelle = new XanderUI.XUIButton();
			this.xBtnSil = new XanderUI.XUIButton();
			this.xBtnKaydet = new XanderUI.XUIButton();
			this.xBtnListele = new XanderUI.XUIButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvKayitlar = new System.Windows.Forms.DataGridView();
			this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.personelDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.personelMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tBLPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dBPersonelDataSet = new Personel_Islemleri.DBPersonelDataSet();
			this.tBLPersonelTableAdapter = new Personel_Islemleri.DBPersonelDataSetTableAdapters.TBLPersonelTableAdapter();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tBLPersonelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dBPersonelDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblDurum);
			this.groupBox1.Controls.Add(this.radioBekar);
			this.groupBox1.Controls.Add(this.radioEvli);
			this.groupBox1.Controls.Add(this.txtMeslek);
			this.groupBox1.Controls.Add(this.txtMaas);
			this.groupBox1.Controls.Add(this.txtSoyad);
			this.groupBox1.Controls.Add(this.txtAd);
			this.groupBox1.Controls.Add(this.cmbSehir);
			this.groupBox1.Controls.Add(this.txtId);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(342, 244);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Kayıt";
			// 
			// lblDurum
			// 
			this.lblDurum.AutoSize = true;
			this.lblDurum.Location = new System.Drawing.Point(117, 16);
			this.lblDurum.Name = "lblDurum";
			this.lblDurum.Size = new System.Drawing.Size(77, 13);
			this.lblDurum.TabIndex = 8;
			this.lblDurum.Text = "xxxxxxxxxxxxxx";
			this.lblDurum.TextChanged += new System.EventHandler(this.lblDurum_TextChanged);
			// 
			// radioBekar
			// 
			this.radioBekar.Checked = false;
			this.radioBekar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.radioBekar.ForeColor = System.Drawing.Color.White;
			this.radioBekar.Location = new System.Drawing.Point(192, 180);
			this.radioBekar.Name = "radioBekar";
			this.radioBekar.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
			this.radioBekar.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
			this.radioBekar.RadioStyle = XanderUI.XUIRadio.Style.Material;
			this.radioBekar.Size = new System.Drawing.Size(73, 16);
			this.radioBekar.TabIndex = 7;
			this.radioBekar.Text = "Bekar";
			this.radioBekar.Click += new System.EventHandler(this.radioBekar_Click);
			// 
			// radioEvli
			// 
			this.radioEvli.Checked = false;
			this.radioEvli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.radioEvli.ForeColor = System.Drawing.Color.White;
			this.radioEvli.Location = new System.Drawing.Point(121, 180);
			this.radioEvli.Name = "radioEvli";
			this.radioEvli.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
			this.radioEvli.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
			this.radioEvli.RadioStyle = XanderUI.XUIRadio.Style.Material;
			this.radioEvli.Size = new System.Drawing.Size(55, 16);
			this.radioEvli.TabIndex = 6;
			this.radioEvli.Text = "Evli";
			this.radioEvli.Click += new System.EventHandler(this.radioEvli_Click);
			// 
			// txtMeslek
			// 
			this.txtMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMeslek.Location = new System.Drawing.Point(120, 202);
			this.txtMeslek.Name = "txtMeslek";
			this.txtMeslek.Size = new System.Drawing.Size(197, 22);
			this.txtMeslek.TabIndex = 8;
			// 
			// txtMaas
			// 
			this.txtMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMaas.Location = new System.Drawing.Point(119, 152);
			this.txtMaas.Name = "txtMaas";
			this.txtMaas.Size = new System.Drawing.Size(197, 22);
			this.txtMaas.TabIndex = 5;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyad.Location = new System.Drawing.Point(119, 92);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(197, 22);
			this.txtSoyad.TabIndex = 3;
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(120, 64);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(197, 22);
			this.txtAd.TabIndex = 2;
			// 
			// cmbSehir
			// 
			this.cmbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbSehir.FormattingEnabled = true;
			this.cmbSehir.Location = new System.Drawing.Point(119, 120);
			this.cmbSehir.Name = "cmbSehir";
			this.cmbSehir.Size = new System.Drawing.Size(197, 24);
			this.cmbSehir.TabIndex = 4;
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtId.Location = new System.Drawing.Point(120, 36);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(197, 22);
			this.txtId.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(63, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Meslek";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(20, 180);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Medeni Durum";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(73, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Maaş";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(76, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Şehir";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(8, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Personel Soyad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(33, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Personel Ad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(37, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Personel ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.xBtnCikis);
			this.groupBox2.Controls.Add(this.xBtnGrafikler);
			this.groupBox2.Controls.Add(this.xBtnIstatistik);
			this.groupBox2.Controls.Add(this.xBtnTemizle);
			this.groupBox2.Controls.Add(this.xBtnGuncelle);
			this.groupBox2.Controls.Add(this.xBtnSil);
			this.groupBox2.Controls.Add(this.xBtnKaydet);
			this.groupBox2.Controls.Add(this.xBtnListele);
			this.groupBox2.Location = new System.Drawing.Point(360, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(439, 244);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Personel İşlemleri";
			// 
			// xBtnCikis
			// 
			this.xBtnCikis.BackgroundColor = System.Drawing.Color.White;
			this.xBtnCikis.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnCikis.ButtonImage")));
			this.xBtnCikis.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnCikis.ButtonText = "Çıkış";
			this.xBtnCikis.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnCikis.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnCikis.CornerRadius = 5;
			this.xBtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnCikis.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnCikis.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnCikis.HoverTextColor = System.Drawing.Color.White;
			this.xBtnCikis.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnCikis.Location = new System.Drawing.Point(219, 186);
			this.xBtnCikis.Name = "xBtnCikis";
			this.xBtnCikis.Size = new System.Drawing.Size(207, 51);
			this.xBtnCikis.TabIndex = 7;
			this.xBtnCikis.TextColor = System.Drawing.Color.Black;
			this.xBtnCikis.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnCikis.Click += new System.EventHandler(this.xuıButton8_Click);
			// 
			// xBtnGrafikler
			// 
			this.xBtnGrafikler.BackgroundColor = System.Drawing.Color.White;
			this.xBtnGrafikler.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnGrafikler.ButtonImage")));
			this.xBtnGrafikler.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnGrafikler.ButtonText = "Grafikler";
			this.xBtnGrafikler.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnGrafikler.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnGrafikler.CornerRadius = 5;
			this.xBtnGrafikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnGrafikler.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnGrafikler.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnGrafikler.HoverTextColor = System.Drawing.Color.White;
			this.xBtnGrafikler.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnGrafikler.Location = new System.Drawing.Point(219, 131);
			this.xBtnGrafikler.Name = "xBtnGrafikler";
			this.xBtnGrafikler.Size = new System.Drawing.Size(207, 51);
			this.xBtnGrafikler.TabIndex = 6;
			this.xBtnGrafikler.TextColor = System.Drawing.Color.Black;
			this.xBtnGrafikler.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnGrafikler.Click += new System.EventHandler(this.xBtnGrafikler_Click);
			// 
			// xBtnIstatistik
			// 
			this.xBtnIstatistik.BackgroundColor = System.Drawing.Color.White;
			this.xBtnIstatistik.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnIstatistik.ButtonImage")));
			this.xBtnIstatistik.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnIstatistik.ButtonText = "İstatistik";
			this.xBtnIstatistik.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnIstatistik.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnIstatistik.CornerRadius = 5;
			this.xBtnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnIstatistik.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnIstatistik.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnIstatistik.HoverTextColor = System.Drawing.Color.White;
			this.xBtnIstatistik.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnIstatistik.Location = new System.Drawing.Point(219, 75);
			this.xBtnIstatistik.Name = "xBtnIstatistik";
			this.xBtnIstatistik.Size = new System.Drawing.Size(207, 53);
			this.xBtnIstatistik.TabIndex = 5;
			this.xBtnIstatistik.TextColor = System.Drawing.Color.Black;
			this.xBtnIstatistik.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnIstatistik.Click += new System.EventHandler(this.xBtnIstatistik_Click);
			// 
			// xBtnTemizle
			// 
			this.xBtnTemizle.BackgroundColor = System.Drawing.Color.White;
			this.xBtnTemizle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnTemizle.ButtonImage")));
			this.xBtnTemizle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnTemizle.ButtonText = "Temizle";
			this.xBtnTemizle.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnTemizle.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnTemizle.CornerRadius = 5;
			this.xBtnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnTemizle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnTemizle.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnTemizle.HoverTextColor = System.Drawing.Color.White;
			this.xBtnTemizle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnTemizle.Location = new System.Drawing.Point(219, 19);
			this.xBtnTemizle.Name = "xBtnTemizle";
			this.xBtnTemizle.Size = new System.Drawing.Size(207, 53);
			this.xBtnTemizle.TabIndex = 4;
			this.xBtnTemizle.TextColor = System.Drawing.Color.Black;
			this.xBtnTemizle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnTemizle.Click += new System.EventHandler(this.xBtnTemizle_Click);
			// 
			// xBtnGuncelle
			// 
			this.xBtnGuncelle.BackgroundColor = System.Drawing.Color.White;
			this.xBtnGuncelle.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnGuncelle.ButtonImage")));
			this.xBtnGuncelle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnGuncelle.ButtonText = "Güncelle";
			this.xBtnGuncelle.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnGuncelle.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnGuncelle.CornerRadius = 5;
			this.xBtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnGuncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnGuncelle.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnGuncelle.HoverTextColor = System.Drawing.Color.White;
			this.xBtnGuncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnGuncelle.Location = new System.Drawing.Point(6, 186);
			this.xBtnGuncelle.Name = "xBtnGuncelle";
			this.xBtnGuncelle.Size = new System.Drawing.Size(207, 51);
			this.xBtnGuncelle.TabIndex = 3;
			this.xBtnGuncelle.TextColor = System.Drawing.Color.Black;
			this.xBtnGuncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnGuncelle.Click += new System.EventHandler(this.xBtnGuncelle_Click);
			// 
			// xBtnSil
			// 
			this.xBtnSil.BackgroundColor = System.Drawing.Color.White;
			this.xBtnSil.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnSil.ButtonImage")));
			this.xBtnSil.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnSil.ButtonText = "Sil";
			this.xBtnSil.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnSil.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnSil.CornerRadius = 5;
			this.xBtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnSil.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnSil.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnSil.HoverTextColor = System.Drawing.Color.White;
			this.xBtnSil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnSil.Location = new System.Drawing.Point(6, 131);
			this.xBtnSil.Name = "xBtnSil";
			this.xBtnSil.Size = new System.Drawing.Size(207, 51);
			this.xBtnSil.TabIndex = 2;
			this.xBtnSil.TextColor = System.Drawing.Color.Black;
			this.xBtnSil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnSil.Click += new System.EventHandler(this.xBtnSil_Click);
			// 
			// xBtnKaydet
			// 
			this.xBtnKaydet.BackgroundColor = System.Drawing.Color.White;
			this.xBtnKaydet.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnKaydet.ButtonImage")));
			this.xBtnKaydet.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnKaydet.ButtonText = "Kaydet";
			this.xBtnKaydet.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnKaydet.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnKaydet.CornerRadius = 5;
			this.xBtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnKaydet.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnKaydet.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnKaydet.HoverTextColor = System.Drawing.Color.White;
			this.xBtnKaydet.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnKaydet.Location = new System.Drawing.Point(6, 75);
			this.xBtnKaydet.Name = "xBtnKaydet";
			this.xBtnKaydet.Size = new System.Drawing.Size(207, 53);
			this.xBtnKaydet.TabIndex = 1;
			this.xBtnKaydet.TextColor = System.Drawing.Color.Black;
			this.xBtnKaydet.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnKaydet.Click += new System.EventHandler(this.xBtnKaydet_Click);
			// 
			// xBtnListele
			// 
			this.xBtnListele.BackgroundColor = System.Drawing.Color.White;
			this.xBtnListele.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xBtnListele.ButtonImage")));
			this.xBtnListele.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
			this.xBtnListele.ButtonText = "Listele";
			this.xBtnListele.ClickBackColor = System.Drawing.Color.Black;
			this.xBtnListele.ClickTextColor = System.Drawing.Color.Black;
			this.xBtnListele.CornerRadius = 5;
			this.xBtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.xBtnListele.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
			this.xBtnListele.HoverBackgroundColor = System.Drawing.Color.Black;
			this.xBtnListele.HoverTextColor = System.Drawing.Color.White;
			this.xBtnListele.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
			this.xBtnListele.Location = new System.Drawing.Point(6, 19);
			this.xBtnListele.Name = "xBtnListele";
			this.xBtnListele.Size = new System.Drawing.Size(207, 53);
			this.xBtnListele.TabIndex = 0;
			this.xBtnListele.TextColor = System.Drawing.Color.Black;
			this.xBtnListele.Vertical_Alignment = System.Drawing.StringAlignment.Center;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvKayitlar);
			this.groupBox3.Location = new System.Drawing.Point(12, 262);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(787, 233);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Kayıtlar";
			// 
			// dgvKayitlar
			// 
			this.dgvKayitlar.AutoGenerateColumns = false;
			this.dgvKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKayitlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelSoyadDataGridViewTextBoxColumn,
            this.personelSehirDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn,
            this.personelDurumDataGridViewCheckBoxColumn,
            this.personelMeslekDataGridViewTextBoxColumn});
			this.dgvKayitlar.DataSource = this.tBLPersonelBindingSource;
			this.dgvKayitlar.Location = new System.Drawing.Point(11, 19);
			this.dgvKayitlar.Name = "dgvKayitlar";
			this.dgvKayitlar.Size = new System.Drawing.Size(763, 208);
			this.dgvKayitlar.TabIndex = 0;
			this.dgvKayitlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKayitlar_CellDoubleClick);
			// 
			// personelidDataGridViewTextBoxColumn
			// 
			this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personelid";
			this.personelidDataGridViewTextBoxColumn.HeaderText = "Personelid";
			this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
			this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// personelAdDataGridViewTextBoxColumn
			// 
			this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
			this.personelAdDataGridViewTextBoxColumn.HeaderText = "PersonelAd";
			this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
			// 
			// personelSoyadDataGridViewTextBoxColumn
			// 
			this.personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyad";
			this.personelSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelSoyad";
			this.personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
			// 
			// personelSehirDataGridViewTextBoxColumn
			// 
			this.personelSehirDataGridViewTextBoxColumn.DataPropertyName = "PersonelSehir";
			this.personelSehirDataGridViewTextBoxColumn.HeaderText = "PersonelSehir";
			this.personelSehirDataGridViewTextBoxColumn.Name = "personelSehirDataGridViewTextBoxColumn";
			// 
			// personelMaasDataGridViewTextBoxColumn
			// 
			this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaas";
			this.personelMaasDataGridViewTextBoxColumn.HeaderText = "PersonelMaas";
			this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
			// 
			// personelDurumDataGridViewCheckBoxColumn
			// 
			this.personelDurumDataGridViewCheckBoxColumn.DataPropertyName = "PersonelDurum";
			this.personelDurumDataGridViewCheckBoxColumn.HeaderText = "PersonelDurum";
			this.personelDurumDataGridViewCheckBoxColumn.Name = "personelDurumDataGridViewCheckBoxColumn";
			// 
			// personelMeslekDataGridViewTextBoxColumn
			// 
			this.personelMeslekDataGridViewTextBoxColumn.DataPropertyName = "PersonelMeslek";
			this.personelMeslekDataGridViewTextBoxColumn.HeaderText = "PersonelMeslek";
			this.personelMeslekDataGridViewTextBoxColumn.Name = "personelMeslekDataGridViewTextBoxColumn";
			// 
			// tBLPersonelBindingSource
			// 
			this.tBLPersonelBindingSource.DataMember = "TBLPersonel";
			this.tBLPersonelBindingSource.DataSource = this.dBPersonelDataSet;
			// 
			// dBPersonelDataSet
			// 
			this.dBPersonelDataSet.DataSetName = "DBPersonelDataSet";
			this.dBPersonelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tBLPersonelTableAdapter
			// 
			this.tBLPersonelTableAdapter.ClearBeforeFill = true;
			// 
			// frmPersonel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(811, 507);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmPersonel";
			this.Text = "Personel İşlemleri v0.1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvKayitlar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tBLPersonelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dBPersonelDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private XanderUI.XUIRadio radioBekar;
		private XanderUI.XUIRadio radioEvli;
		private System.Windows.Forms.TextBox txtMeslek;
		private System.Windows.Forms.TextBox txtMaas;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.ComboBox cmbSehir;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private XanderUI.XUIButton xBtnGrafikler;
		private XanderUI.XUIButton xBtnIstatistik;
		private XanderUI.XUIButton xBtnTemizle;
		private XanderUI.XUIButton xBtnGuncelle;
		private XanderUI.XUIButton xBtnSil;
		private XanderUI.XUIButton xBtnKaydet;
		private XanderUI.XUIButton xBtnListele;
		private System.Windows.Forms.DataGridView dgvKayitlar;
		private DBPersonelDataSet dBPersonelDataSet;
		private System.Windows.Forms.BindingSource tBLPersonelBindingSource;
		private DBPersonelDataSetTableAdapters.TBLPersonelTableAdapter tBLPersonelTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelSehirDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn personelDurumDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn personelMeslekDataGridViewTextBoxColumn;
		private XanderUI.XUIButton xBtnCikis;
		private System.Windows.Forms.Label lblDurum;
	}
}

