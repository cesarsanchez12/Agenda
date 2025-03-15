namespace Agenda
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnUsuarios = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitledafgdwhsdghd_Photoroom;
            pictureBox1.Location = new Point(96, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 389);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.ForeColor = SystemColors.ActiveBorder;
            btnUsuarios.Image = Properties.Resources.hjvhjv_Photoroom1;
            btnUsuarios.Location = new Point(240, 304);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(161, 206);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(626, 511);
            Controls.Add(btnUsuarios);
            Controls.Add(pictureBox1);
            Name = "Menu";
            ShowInTaskbar = false;
            Text = "Menu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnUsuarios;
    }
}
