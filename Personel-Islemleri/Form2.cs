using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Islemleri
{
	public partial class frmIstatistik : Form
	{
		SqlConnection ctxConnection = new SqlConnection("Data Source=DESKTOP-7IV832G\\MSSQLSERVER01;Initial Catalog=DBPersonel;Integrated Security=True");
		public frmIstatistik()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			//Toplam personel sayısı
			ctxConnection.Open();
			SqlCommand cmd1 = new SqlCommand("Select Count(*) From TBLPersonel", ctxConnection);
			SqlDataReader dr1 = cmd1.ExecuteReader();
			while (dr1.Read())
			{
				lblToplamPersonel.Text = dr1[0].ToString();
			}
			ctxConnection.Close();


			//Evli personel sayısı
			ctxConnection.Open();
			SqlCommand cmd2 = new SqlCommand("Select Count(*) From TBLPersonel Where PersonelDurum=1", ctxConnection);
			SqlDataReader dr2 = cmd2.ExecuteReader();
			while (dr2.Read())
			{
				lblEvliPersonel.Text = dr2[0].ToString();
			}
			ctxConnection.Close();


			//Bekar personel sayısı
			ctxConnection.Open();
			SqlCommand cmd3 = new SqlCommand("Select Count(*) From TBLPersonel Where PersonelDurum=0", ctxConnection);
			SqlDataReader dr3 = cmd3.ExecuteReader();
			while (dr3.Read())
			{
				lblBekarPersonel.Text = dr3[0].ToString();
			}
			ctxConnection.Close();


			//Şehir sayısı
			ctxConnection.Open();
			SqlCommand cmd6 = new SqlCommand("Select Count(distinct(PersonelSehir)) From TBLPersonel", ctxConnection);
			SqlDataReader dr6 = cmd6.ExecuteReader();
			while (dr6.Read())
			{
				lblSehirSayisi.Text = dr6[0].ToString();
			}
			ctxConnection.Close();


			//Toplam maaş
			ctxConnection.Open();
			SqlCommand cmd4 = new SqlCommand("Select SUM(PersonelMaas) From TBLPersonel", ctxConnection);
			SqlDataReader dr4 = cmd4.ExecuteReader();
			while (dr4.Read())
			{
				lblToplamMaas.Text = dr4[0].ToString()+" TL";
			}
			ctxConnection.Close();


			//Ortalama maaş
			ctxConnection.Open();
			SqlCommand cmd5 = new SqlCommand("Select AVG(PersonelMaas) From TBLPersonel", ctxConnection);
			SqlDataReader dr5 = cmd5.ExecuteReader();
			while (dr5.Read())
			{
				lblOrtalamaMaas.Text = dr5[0].ToString()+" TL";
			}
			ctxConnection.Close();
		}

		private void xBtnCikis_Click(object sender, EventArgs e)
		{
			DialogResult dialog = new DialogResult();
			dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialog == DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
