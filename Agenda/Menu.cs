namespace Agenda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.ShowDialog();
        }
    }
}
