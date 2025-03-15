namespace Agenda
{
    partial class Modificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgbUSUARIOS = new DataGridView();
            menuStrip1 = new MenuStrip();
            insertarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgbUSUARIOS).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgbUSUARIOS
            // 
            dgbUSUARIOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbUSUARIOS.Location = new Point(8, 43);
            dgbUSUARIOS.Name = "dgbUSUARIOS";
            dgbUSUARIOS.RowHeadersWidth = 51;
            dgbUSUARIOS.Size = new Size(780, 395);
            dgbUSUARIOS.TabIndex = 0;
            dgbUSUARIOS.CellClick += dataGridView1_CellClick;
            dgbUSUARIOS.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { insertarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // insertarToolStripMenuItem
            // 
            insertarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem, salirToolStripMenuItem1 });
            insertarToolStripMenuItem.Name = "insertarToolStripMenuItem";
            insertarToolStripMenuItem.Size = new Size(68, 24);
            insertarToolStripMenuItem.Text = "Accion";
            insertarToolStripMenuItem.Click += insertarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(141, 26);
            salirToolStripMenuItem.Text = "Insertar";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(141, 26);
            salirToolStripMenuItem1.Text = "Salir";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // Modificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgbUSUARIOS);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Modificar";
            Text = "Modificar";
            Activated += Form3_Activated;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgbUSUARIOS).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgbUSUARIOS;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
    }
}