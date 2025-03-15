namespace Agenda
{
    partial class ActualizarUsuario
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
            label1 = new Label();
            txtID = new TextBox();
            txtAPATERNO = new TextBox();
            txtAMATERNO = new TextBox();
            txtNOMBRE = new TextBox();
            txtTELEFONO = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCORREO = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnACTUALIZAR = new Button();
            btnELIMINAR = new Button();
            btnCANCELAR = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(11, 44);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 1;
            // 
            // txtAPATERNO
            // 
            txtAPATERNO.Location = new Point(12, 113);
            txtAPATERNO.Name = "txtAPATERNO";
            txtAPATERNO.Size = new Size(296, 27);
            txtAPATERNO.TabIndex = 2;
            // 
            // txtAMATERNO
            // 
            txtAMATERNO.Location = new Point(363, 113);
            txtAMATERNO.Name = "txtAMATERNO";
            txtAMATERNO.Size = new Size(277, 27);
            txtAMATERNO.TabIndex = 3;
            // 
            // txtNOMBRE
            // 
            txtNOMBRE.Location = new Point(11, 184);
            txtNOMBRE.Name = "txtNOMBRE";
            txtNOMBRE.Size = new Size(297, 27);
            txtNOMBRE.TabIndex = 4;
            // 
            // txtTELEFONO
            // 
            txtTELEFONO.Location = new Point(12, 258);
            txtTELEFONO.Name = "txtTELEFONO";
            txtTELEFONO.Size = new Size(228, 27);
            txtTELEFONO.TabIndex = 5;
            txtTELEFONO.TextChanged += textBox5_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 90);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 6;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(363, 90);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 7;
            label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 161);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            // 
            // txtCORREO
            // 
            txtCORREO.Location = new Point(300, 258);
            txtCORREO.Name = "txtCORREO";
            txtCORREO.Size = new Size(340, 27);
            txtCORREO.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 235);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(300, 235);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 11;
            label6.Text = "Correo";
            // 
            // btnACTUALIZAR
            // 
            btnACTUALIZAR.BackColor = Color.FromArgb(64, 64, 64);
            btnACTUALIZAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnACTUALIZAR.ForeColor = SystemColors.ButtonHighlight;
            btnACTUALIZAR.Location = new Point(324, 317);
            btnACTUALIZAR.Name = "btnACTUALIZAR";
            btnACTUALIZAR.Size = new Size(94, 29);
            btnACTUALIZAR.TabIndex = 12;
            btnACTUALIZAR.Text = "Actualizar";
            btnACTUALIZAR.UseVisualStyleBackColor = false;
            btnACTUALIZAR.Click += btnACTUALIZAR_Click;
            // 
            // btnELIMINAR
            // 
            btnELIMINAR.BackColor = Color.FromArgb(64, 64, 64);
            btnELIMINAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnELIMINAR.ForeColor = SystemColors.ButtonHighlight;
            btnELIMINAR.Location = new Point(546, 317);
            btnELIMINAR.Name = "btnELIMINAR";
            btnELIMINAR.Size = new Size(94, 29);
            btnELIMINAR.TabIndex = 13;
            btnELIMINAR.Text = "Eliminar";
            btnELIMINAR.UseVisualStyleBackColor = false;
            btnELIMINAR.Click += btnELIMINAR_Click;
            // 
            // btnCANCELAR
            // 
            btnCANCELAR.BackColor = Color.FromArgb(64, 64, 64);
            btnCANCELAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCANCELAR.ForeColor = SystemColors.ButtonHighlight;
            btnCANCELAR.Location = new Point(435, 317);
            btnCANCELAR.Name = "btnCANCELAR";
            btnCANCELAR.Size = new Size(94, 29);
            btnCANCELAR.TabIndex = 14;
            btnCANCELAR.Text = "Cancelar";
            btnCANCELAR.UseVisualStyleBackColor = false;
            btnCANCELAR.Click += btnCANCELAR_Click;
            // 
            // ActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.Untitledkjgyfuh_Photoroom;
            ClientSize = new Size(670, 367);
            Controls.Add(btnCANCELAR);
            Controls.Add(btnELIMINAR);
            Controls.Add(btnACTUALIZAR);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCORREO);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTELEFONO);
            Controls.Add(txtNOMBRE);
            Controls.Add(txtAMATERNO);
            Controls.Add(txtAPATERNO);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "ActualizarUsuario";
            Text = "Actualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtAPATERNO;
        private TextBox txtAMATERNO;
        private TextBox txtNOMBRE;
        private TextBox txtTELEFONO;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCORREO;
        private Label label5;
        private Label label6;
        private Button btnACTUALIZAR;
        private Button btnELIMINAR;
        private Button btnCANCELAR;
    }
}