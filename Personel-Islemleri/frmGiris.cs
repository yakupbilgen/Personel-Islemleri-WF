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
	public partial class frmGiris : Form
	{
		SqlConnection ctxConnection = new SqlConnection("Data Source=DESKTOP-LU5VIM4\\MSSQLSERVER1;Initial Catalog=DBPersonel;Integrated Security=True");
		public frmGiris()
		{
			InitializeComponent();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			if (ctxConnection.State!=ConnectionState.Closed)
			{
				ctxConnection.Close();
			}
			else
			{
				ctxConnection.Open();
				SqlCommand cmd = new SqlCommand("Select * From TBLAdmin where KullaniciAdi=@kullaniciadi and Sifre=@sifre", ctxConnection);
				cmd.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
				cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					frmPersonel frm = new frmPersonel();
					frm.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Kullanıcı adı yada şifre yanlış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				ctxConnection.Close();
			}
		}
	}
}
