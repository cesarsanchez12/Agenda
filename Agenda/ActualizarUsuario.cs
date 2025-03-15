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
    public partial class ActualizarUsuario : Form
    {
        int Index;
        public ActualizarUsuario(string ID, string APATERNO, string AMATERNO, string NOMBRE, string TELEFONO, string CORREO)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtAPATERNO.Text = APATERNO;
            txtAMATERNO.Text = AMATERNO;
            txtNOMBRE.Text = NOMBRE;
            txtTELEFONO.Text = TELEFONO;
            txtCORREO.Text = CORREO;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string APATERNO = txtAPATERNO.Text;
            string AMATERNO = txtAMATERNO.Text;
            string NOMBRE = txtNOMBRE.Text;
            string TELEFONO = txtTELEFONO.Text;
            string CORREO = txtCORREO.Text;

            datos DS = new datos();
            System.Boolean f = DS.command("UPDATE Usuarios SET " +
                "APATERNO='" + APATERNO + "', " +
                "AMATERNO='" + AMATERNO + "', " +
                "NOMBRE='" + NOMBRE + "', " +
                "TELEFONO='" + TELEFONO + "', " +
                "CORREO='" + CORREO + "' " +
                "WHERE ID='" + ID + "';"
                );

            if (f)
            {
                MessageBox.Show("Registro actualizado", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;

            DialogResult r = MessageBox.Show("Seguro que quieres eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                datos ds = new datos();
                bool f = ds.command("delete from Usuarios where  ID='" + ID + "';");
                if (f)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OKCancel);
                }
            }
        }
    }
}
