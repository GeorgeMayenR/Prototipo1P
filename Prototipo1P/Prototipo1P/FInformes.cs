using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class FInformes : Form
    {
        public FInformes()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string[] datos1 = new string[5];
            int n = tabla1.Rows.Add();

            string sql = "select * from productos";


            conexion con = new conexion();
            datos1 = con.buscar(sql, 6);



            tabla1.Rows[n].Cells[0].Value = datos1[0];
            tabla1.Rows[n].Cells[1].Value = datos1[1];
            tabla1.Rows[n].Cells[2].Value = datos1[2];
            tabla1.Rows[n].Cells[3].Value = datos1[3];
            tabla1.Rows[n].Cells[4].Value = datos1[4];
            tabla1.Rows[n].Cells[5].Value = datos1[5];


            string[] datos2 = new string[2];
            int n2 = tabla2.Rows.Add();

            string sql2 = "select * from existencias";


            conexion con2 = new conexion();
            datos2 = con2.buscar(sql2, 3);



            tabla2.Rows[n2].Cells[0].Value = datos1[0];
            tabla2.Rows[n2].Cells[1].Value = datos1[1];
            tabla2.Rows[n2].Cells[2].Value = datos1[2];
        }
    }
}
