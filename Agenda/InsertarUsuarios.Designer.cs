namespace Agenda
{
    partial class InsertarUsuarios
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
            label6 = new Label();
            label5 = new Label();
            txtCORREO = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTELEFONO = new TextBox();
            txtNOMBRE = new TextBox();
            txtAMATERNO = new TextBox();
            txtAPATERNO = new TextBox();
            btnINSERTAR = new Button();
            btnCANCELAR = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(301, 163);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 23;
            label6.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 22;
            label5.Text = "Telefono";
            // 
            // txtCORREO
            // 
            txtCORREO.Location = new Point(301, 186);
            txtCORREO.Name = "txtCORREO";
            txtCORREO.Size = new Size(340, 27);
            txtCORREO.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 20;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(364, 18);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 19;
            label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 18;
            label2.Text = "Apellido Paterno";
            // 
            // txtTELEFONO
            // 
            txtTELEFONO.Location = new Point(13, 186);
            txtTELEFONO.Name = "txtTELEFONO";
            txtTELEFONO.Size = new Size(228, 27);
            txtTELEFONO.TabIndex = 17;
            // 
            // txtNOMBRE
            // 
            txtNOMBRE.Location = new Point(12, 112);
            txtNOMBRE.Name = "txtNOMBRE";
            txtNOMBRE.Size = new Size(297, 27);
            txtNOMBRE.TabIndex = 16;
            // 
            // txtAMATERNO
            // 
            txtAMATERNO.Location = new Point(364, 41);
            txtAMATERNO.Name = "txtAMATERNO";
            txtAMATERNO.Size = new Size(277, 27);
            txtAMATERNO.TabIndex = 15;
            // 
            // txtAPATERNO
            // 
            txtAPATERNO.Location = new Point(13, 41);
            txtAPATERNO.Name = "txtAPATERNO";
            txtAPATERNO.Size = new Size(296, 27);
            txtAPATERNO.TabIndex = 14;
            // 
            // btnINSERTAR
            // 
            btnINSERTAR.BackColor = Color.FromArgb(64, 64, 64);
            btnINSERTAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnINSERTAR.ForeColor = SystemColors.ButtonHighlight;
            btnINSERTAR.Location = new Point(416, 251);
            btnINSERTAR.Name = "btnINSERTAR";
            btnINSERTAR.Size = new Size(94, 29);
            btnINSERTAR.TabIndex = 24;
            btnINSERTAR.Text = "Insertar";
            btnINSERTAR.UseVisualStyleBackColor = false;
            btnINSERTAR.Click += btnINSERTAR_Click;
            // 
            // btnCANCELAR
            // 
            btnCANCELAR.BackColor = Color.FromArgb(64, 64, 64);
            btnCANCELAR.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCANCELAR.ForeColor = SystemColors.ButtonHighlight;
            btnCANCELAR.Location = new Point(547, 251);
            btnCANCELAR.Name = "btnCANCELAR";
            btnCANCELAR.Size = new Size(94, 29);
            btnCANCELAR.TabIndex = 25;
            btnCANCELAR.Text = "Cancelar";
            btnCANCELAR.UseVisualStyleBackColor = false;
            btnCANCELAR.Click += btnCANCELAR_Click;
            // 
            // InsertarUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources.djdsjfsj_Photoroom;
            ClientSize = new Size(674, 294);
            Controls.Add(btnCANCELAR);
            Controls.Add(btnINSERTAR);
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
            Name = "InsertarUsuarios";
            Text = "Insertar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox txtCORREO;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTELEFONO;
        private TextBox txtNOMBRE;
        private TextBox txtAMATERNO;
        private TextBox txtAPATERNO;
        private Button btnINSERTAR;
        private Button btnCANCELAR;
    }
}