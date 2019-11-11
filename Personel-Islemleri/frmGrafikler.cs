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
	public partial class frmGrafikler : Form
	{
		SqlConnection ctxConnection = new SqlConnection("Data Source=DESKTOP-LU5VIM4\\MSSQLSERVER1;Initial Catalog=DBPersonel;Integrated Security=True");

		public frmGrafikler()
		{
			InitializeComponent();
		}

		private void frmGrafikler_Load(object sender, EventArgs e)
		{
			if (ctxConnection.State != ConnectionState.Closed)
			{
				ctxConnection.Close();
			}
			else
			{
				//1. Grafik
				ctxConnection.Open();
				SqlCommand cmd1 = new SqlCommand("SELECT PersonelSehir,Count(*) FROM TBLPersonel GROUP BY PersonelSehir", ctxConnection);
				SqlDataReader dr1 = cmd1.ExecuteReader();
				while (dr1.Read())
				{
					chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
				}
				ctxConnection.Close();

				//2. Grafik
				ctxConnection.Open();
				SqlCommand cmd2 = new SqlCommand("SELECT PersonelMeslek,AVG(PersonelMaas) FROM TBLPersonel GROUP BY PersonelMeslek", ctxConnection);

				SqlDataReader dr2 = cmd2.ExecuteReader();
				while (dr2.Read())
				{
					chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
				}
				ctxConnection.Close();
			}
		}
	}
}
