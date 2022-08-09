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
    public partial class FProcesos : Form
    {
        public FProcesos()
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
            string[] datos1 = new string[4];
            int n = tabla1.Rows.Add();

            string sql = "select * from compras_detalle";


            conexion con = new conexion();
            datos1 = con.buscar(sql, 5);



            tabla1.Rows[n].Cells[0].Value = datos1[0];
            tabla1.Rows[n].Cells[1].Value = datos1[1];
            tabla1.Rows[n].Cells[2].Value = datos1[2];
            tabla1.Rows[n].Cells[3].Value = datos1[3];
            tabla1.Rows[n].Cells[4].Value = datos1[4];
            


      
        }
    }
}
