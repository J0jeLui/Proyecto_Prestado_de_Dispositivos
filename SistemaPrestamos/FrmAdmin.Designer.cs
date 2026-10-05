namespace SistemaPresatamos
{
    partial class FrmAdmin
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
            txtResultadoAdmin = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txtRutaImagenAdmin = new TextBox();
            txtContrasenaAdmin = new TextBox();
            btnGuardarAdmin = new Button();
            chkEstadoAdmin = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            txtNombreAdmin = new TextBox();
            txtCorreoAdmin = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            pnlFormularioBase.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(txtResultadoAdmin);
            pnlFormularioBase.Controls.Add(label7);
            pnlFormularioBase.Controls.Add(groupBox1);
            pnlFormularioBase.Controls.SetChildIndex(label1, 0);
            pnlFormularioBase.Controls.SetChildIndex(textBox1, 0);
            pnlFormularioBase.Controls.SetChildIndex(groupBox1, 0);
            pnlFormularioBase.Controls.SetChildIndex(label7, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtResultadoAdmin, 0);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 98);
            // 
            // label1
            // 
            label1.Location = new Point(50, 101);
            label1.Size = new Size(18, 15);
            label1.Text = "ID";
            // 
            // txtResultadoAdmin
            // 
            txtResultadoAdmin.Location = new Point(326, 140);
            txtResultadoAdmin.Multiline = true;
            txtResultadoAdmin.Name = "txtResultadoAdmin";
            txtResultadoAdmin.Size = new Size(447, 202);
            txtResultadoAdmin.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 43);
            label7.Name = "label7";
            label7.Size = new Size(506, 15);
            label7.TabIndex = 4;
            label7.Text = "Equipo 4 Fernández Hernández Kevin Isaid, Flores Becerra Cid Héctor, Govea Mijares Jorge Luis ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtRutaImagenAdmin);
            groupBox1.Controls.Add(txtContrasenaAdmin);
            groupBox1.Controls.Add(btnGuardarAdmin);
            groupBox1.Controls.Add(chkEstadoAdmin);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNombreAdmin);
            groupBox1.Controls.Add(txtCorreoAdmin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(27, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 220);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administrador";
            // 
            // txtRutaImagenAdmin
            // 
            txtRutaImagenAdmin.Location = new Point(87, 129);
            txtRutaImagenAdmin.Name = "txtRutaImagenAdmin";
            txtRutaImagenAdmin.Size = new Size(100, 23);
            txtRutaImagenAdmin.TabIndex = 3;
            // 
            // txtContrasenaAdmin
            // 
            txtContrasenaAdmin.Location = new Point(87, 103);
            txtContrasenaAdmin.MaxLength = 6;
            txtContrasenaAdmin.Name = "txtContrasenaAdmin";
            txtContrasenaAdmin.Size = new Size(100, 23);
            txtContrasenaAdmin.TabIndex = 3;
            // 
            // btnGuardarAdmin
            // 
            btnGuardarAdmin.Location = new Point(87, 179);
            btnGuardarAdmin.Name = "btnGuardarAdmin";
            btnGuardarAdmin.Size = new Size(100, 23);
            btnGuardarAdmin.TabIndex = 2;
            btnGuardarAdmin.Text = "Validar Admin";
            btnGuardarAdmin.UseVisualStyleBackColor = true;
            btnGuardarAdmin.Click += btnGuardarAdmin_Click;
            // 
            // chkEstadoAdmin
            // 
            chkEstadoAdmin.AutoSize = true;
            chkEstadoAdmin.Location = new Point(87, 154);
            chkEstadoAdmin.Name = "chkEstadoAdmin";
            chkEstadoAdmin.Size = new Size(103, 19);
            chkEstadoAdmin.TabIndex = 1;
            chkEstadoAdmin.Text = "Disponible/No";
            chkEstadoAdmin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 158);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 132);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 4;
            label5.Text = "RutaImagen:";
            // 
            // txtNombreAdmin
            // 
            txtNombreAdmin.Location = new Point(87, 74);
            txtNombreAdmin.Name = "txtNombreAdmin";
            txtNombreAdmin.Size = new Size(100, 23);
            txtNombreAdmin.TabIndex = 2;
            // 
            // txtCorreoAdmin
            // 
            txtCorreoAdmin.Location = new Point(87, 47);
            txtCorreoAdmin.Name = "txtCorreoAdmin";
            txtCorreoAdmin.Size = new Size(100, 23);
            txtCorreoAdmin.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Constraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 55);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 1;
            label3.Text = "Correo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 82);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 2;
            label8.Text = "Nombre:";
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FrmAdmin";
            Load += FrmAdmin_Load;
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtResultadoAdmin;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txtRutaImagenAdmin;
        private TextBox txtContrasenaAdmin;
        private Button btnGuardarAdmin;
        private CheckBox chkEstadoAdmin;
        private Label label6;
        private Label label5;
        private TextBox txtNombreAdmin;
        private TextBox txtCorreoAdmin;
        private Label label4;
        private Label label3;
        private Label label8;
    }
}