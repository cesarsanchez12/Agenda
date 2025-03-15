using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Agenda
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        private void actualizarGrid()
        {
            datos ds = new datos();
            DataSet Datos = ds.query("SELECT ID as 'ID', APATERNO as 'Ap. Paterno', AMATERNO as 'Ap. Materno', NOMBRE as 'Nombre', TELEFONO as 'Telefono', CORREO as 'Correo' FROM Usuarios");
            if (Datos != null)
            {
                dgbUSUARIOS.DataSource = Datos.Tables[0];
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarUsuario actualizarusuarios = new ActualizarUsuario(
                    dgbUSUARIOS[0, e.RowIndex].Value.ToString(),
                    dgbUSUARIOS[1, e.RowIndex].Value.ToString(),
                    dgbUSUARIOS[2, e.RowIndex].Value.ToString(),
                    dgbUSUARIOS[3, e.RowIndex].Value.ToString(),
                    dgbUSUARIOS[4, e.RowIndex].Value.ToString(),
                    dgbUSUARIOS[5, e.RowIndex].Value.ToString()
                );
            actualizarusuarios.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarUsuarios insertar = new InsertarUsuarios();
            insertar.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

