
namespace Prototipo1P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña, cargo = " ";
            int columna = 3;
            string[] resultado = new string[columna];
            usuario = txtusuario.Text;
            contraseña = txtcontraseña.Text;

            if (radioadministrador.Checked == true)
            {
                cargo = "administrador";
            }

            if (radiotrabajador.Checked == true)
            {
                cargo = "trabajador";
            }


            conexion con = new conexion();
            string sql = "select * from usuario where usuario = '" + usuario + "'";

            resultado = con.buscar(sql, columna);
            if (resultado[0] == usuario && resultado[1] == contraseña && resultado[2] == cargo)
            {
                if (resultado[2].Equals("administrador"))
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido " + usuario + " " + cargo);

                }
                else if (resultado[2].Equals("trabajador"))
                {
                    Menu m = new Menu();
                    m.Show();
                    this.Hide();
                    MessageBox.Show("Bienvenido " + usuario + " " + cargo);

                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}