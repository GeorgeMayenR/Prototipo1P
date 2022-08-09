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
    public partial class FHerramientas : Form
    {
        public FHerramientas()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           

            string codigop, nombrep, codigol, codigom, estatusp;
            float existencia;

            codigop = codproducto.Text;
            nombrep = nomproducto.Text;
            codigol = codlinea.Text;
            codigom = codmarca.Text;
            estatusp = estproductos.Text;
            existencia = float.Parse(exproducto.Text);

            string sql = "insert into productos values" +
           " ('" + codigop + "','" + nombrep + "','" + codigol + "','" + codigom +
           "','" + existencia + "','" + estatusp+ "')";
            conexion con = new conexion();
            con.IDU(sql);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string buscar = tabla1.Rows[0].Cells[0].Value.ToString();

            string sql = "delete from productos where codigo_producto = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql);

            tabla1.Rows.RemoveAt(tabla1.CurrentRow.Index);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            string codigop, nombrep, codigol, codigom, estatusp;
            float existencia;

            codigop = codproducto.Text;
            nombrep = nomproducto.Text;
            codigol = codlinea.Text;
            codigom = codmarca.Text;
            estatusp = estproductos.Text;
            existencia = float.Parse(exproducto.Text);

            string buscar = txtbuscar.Text;
            string sql3 = "delete from productos where codigo_producto = '" + buscar + "'";

            conexion con = new conexion();
            con.IDU(sql3);


            string sql = "insert into productos values" +
           " ('" + codigop + "','" + nombrep + "','" + codigol + "','" + codigom +
           "','" + existencia + "','" + estatusp + "')";
            
            con.IDU(sql);

    
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string buscar = txtbuscar.Text;
            string[] datos1 = new string[5];
            int n = tabla1.Rows.Add();

            string sql = "select * from productos where codigo_producto = '" + buscar + "'";


            conexion con = new conexion();
            datos1 = con.buscar(sql, 6);



            tabla1.Rows[n].Cells[0].Value = datos1[0];
            tabla1.Rows[n].Cells[1].Value = datos1[1];
            tabla1.Rows[n].Cells[2].Value = datos1[2];
            tabla1.Rows[n].Cells[3].Value = datos1[3];
            tabla1.Rows[n].Cells[4].Value = datos1[4];
            tabla1.Rows[n].Cells[5].Value = datos1[5];

        }
    }
}
