using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Islemleri
{
	public partial class frmPersonel : Form
	{
		public frmPersonel()
		{
			InitializeComponent();
		}
		public void Listele()
		{
			this.tBLPersonelTableAdapter.Fill(this.dBPersonelDataSet.TBLPersonel);
		}
		public void Temizle()
		{
			txtId.Text = "";
			txtAd.Text = "";
			txtMaas.Text = "";
			txtMeslek.Text = "";
			txtSoyad.Text = "";
			cmbSehir.Text = "";
			radioEvli.Checked = false;
			radioEvli.Checked = false;
		}
		SqlConnection ctxConnection = new SqlConnection("Data Source=DESKTOP-7IV832G\\MSSQLSERVER01;Initial Catalog=DBPersonel;Integrated Security=True");
		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dBPersonelDataSet.TBLPersonel' table. You can move, or remove it, as needed.
			this.tBLPersonelTableAdapter.Fill(this.dBPersonelDataSet.TBLPersonel);
			lblDurum.Visible = true;
		}

		private void xuıButton8_Click(object sender, EventArgs e)
		{
			DialogResult dialog = new DialogResult();
			dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialog == DialogResult.Yes)
			{ this.Close(); }

		}

		private void xBtnKaydet_Click(object sender, EventArgs e)
		{
			ctxConnection.Open();
			SqlCommand insert = new SqlCommand("insert into TBLPersonel " +
				"(PersonelAd,PersonelSoyad,PersonelSehir,PersonelMaas,PersonelDurum,PersonelMeslek) " +
				"values (@item1,@item2,@item3,@item4,@item5,@item6)", ctxConnection);
			insert.Parameters.AddWithValue("@item1", txtAd.Text);
			insert.Parameters.AddWithValue("@item2", txtSoyad.Text);
			insert.Parameters.AddWithValue("@item3", cmbSehir.Text);
			insert.Parameters.AddWithValue("@item4", txtMaas.Text);
			insert.Parameters.AddWithValue("@item5", lblDurum.Text);
			insert.Parameters.AddWithValue("@item6", txtMeslek.Text);
			insert.ExecuteNonQuery();
			ctxConnection.Close();
			Listele();
			Temizle();
			MessageBox.Show("Kayıt başarıyla eklendi!", "Uyarı");
		}

		private void radioEvli_Click(object sender, EventArgs e)
		{
			if (radioEvli.Checked == true)
			{
				lblDurum.Text = "True";
			}
		}

		private void radioBekar_Click(object sender, EventArgs e)
		{
			if (radioBekar.Checked == true)
			{
				lblDurum.Text = "False";
			}
		}

		private void xBtnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dgvKayitlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int item = dgvKayitlar.SelectedCells[0].RowIndex;

			txtId.Text = dgvKayitlar.Rows[item].Cells[0].Value.ToString();
			txtAd.Text = dgvKayitlar.Rows[item].Cells[1].Value.ToString();
			txtSoyad.Text = dgvKayitlar.Rows[item].Cells[2].Value.ToString();
			cmbSehir.Text = dgvKayitlar.Rows[item].Cells[3].Value.ToString();
			txtMaas.Text = dgvKayitlar.Rows[item].Cells[4].Value.ToString();
			lblDurum.Text = dgvKayitlar.Rows[item].Cells[5].Value.ToString();
			txtMeslek.Text = dgvKayitlar.Rows[item].Cells[6].Value.ToString();
		}

		private void lblDurum_TextChanged(object sender, EventArgs e)
		{
			if (lblDurum.Text == "True")
			{
				radioEvli.Checked = true;
				radioBekar.Checked = false;
			}
			if (lblDurum.Text == "False")
			{
				radioBekar.Checked = true;
				radioEvli.Checked = false;
			}
		}

		private void xBtnSil_Click(object sender, EventArgs e)
		{
			ctxConnection.Open();
			SqlCommand komut = new SqlCommand("Delete From TBLPersonel Where Personelid=@item", ctxConnection);
			komut.Parameters.AddWithValue("@item", txtId.Text);
			komut.ExecuteNonQuery();
			ctxConnection.Close();
			Temizle();
			Listele();
			MessageBox.Show("Kayıt başarıyla silindi!", "Uyarı");
		}

		private void xBtnGuncelle_Click(object sender, EventArgs e)
		{
			ctxConnection.Open();
			SqlCommand update = new SqlCommand("Update TBLPersonel Set " +
				"PersonelAd=@item1, PersonelSoyad=@item2, PersonelSehir=@item3, PersonelMaas=@item4, PersonelDurum=@item5, PersonelMeslek=@item6 Where Personelid=@item7", ctxConnection);
			update.Parameters.AddWithValue("@item1", txtAd.Text);
			update.Parameters.AddWithValue("@item2", txtSoyad.Text);
			update.Parameters.AddWithValue("@item3", cmbSehir.Text);
			update.Parameters.AddWithValue("@item4", txtMaas.Text);
			update.Parameters.AddWithValue("@item5", lblDurum.Text);
			update.Parameters.AddWithValue("@item6", txtMeslek.Text);
			update.Parameters.AddWithValue("@item7", txtId.Text);
			update.ExecuteNonQuery();
			ctxConnection.Close();
			Temizle();
			Listele();
			MessageBox.Show("Kayıt başarıyla güncellendi!", "Uyarı");

		}

		private void xBtnIstatistik_Click(object sender, EventArgs e)
		{
			frmIstatistik frm = new frmIstatistik();
			frm.Show();
		}

		private void xBtnGrafikler_Click(object sender, EventArgs e)
		{
			frmGrafikler frm = new frmGrafikler();
			frm.Show();
		}
	}
}
