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
    public partial class InsertarUsuarios : Form
    {
        public InsertarUsuarios()
        {
            InitializeComponent();
        }

        private void btnINSERTAR_Click(object sender, EventArgs e)
        {
            string APATERNO = txtAPATERNO.Text;
            string AMATERNO = txtAMATERNO.Text;
            string NOMBRE = txtNOMBRE.Text;
            string TELEFONO = txtTELEFONO.Text;
            string CORREO = txtCORREO.Text;

            datos ds = new datos();
            bool f = ds.command("insert into Usuarios(APATERNO,AMATERNO,NOMBRE,TELEFONO,CORREO)"
                + "values ('" + APATERNO + "','" + AMATERNO + "','" + NOMBRE + "','" + TELEFONO + "','" + CORREO + "');");

            if (f)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

