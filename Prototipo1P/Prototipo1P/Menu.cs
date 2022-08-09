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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            FCatalogo m = new FCatalogo();
            m.Show();
            this.Hide();
        }

        private void btn_Procesos_Click(object sender, EventArgs e)
        {
            FProcesos n = new FProcesos();
            n.Show();
            this.Hide();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            FInformes o = new FInformes();
            o.Show();
            this.Hide();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            FHerramientas p = new FHerramientas();
            p.Show();
            this.Hide();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FAyuda q = new FAyuda();
            q.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
