namespace Venta_de_Cartas
{
    partial class RegistroCliente
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
            radioButtonSi = new RadioButton();
            radioButtonNo = new RadioButton();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtRUT = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 0;
            label1.Text = "Desea ingresar un cliente?";
            // 
            // radioButtonSi
            // 
            radioButtonSi.AutoSize = true;
            radioButtonSi.Location = new Point(12, 59);
            radioButtonSi.Name = "radioButtonSi";
            radioButtonSi.Size = new Size(42, 24);
            radioButtonSi.TabIndex = 1;
            radioButtonSi.TabStop = true;
            radioButtonSi.Text = "Si";
            radioButtonSi.UseVisualStyleBackColor = true;
            radioButtonSi.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Location = new Point(12, 316);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(50, 24);
            radioButtonNo.TabIndex = 2;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "No";
            radioButtonNo.UseVisualStyleBackColor = true;
            radioButtonNo.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 83);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 27);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(82, 126);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(223, 27);
            txtApellido.TabIndex = 6;
            txtApellido.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 173);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 7;
            label4.Text = "RUT";
            // 
            // txtRUT
            // 
            txtRUT.Location = new Point(82, 166);
            txtRUT.Name = "txtRUT";
            txtRUT.Size = new Size(223, 27);
            txtRUT.TabIndex = 8;
            txtRUT.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 214);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(82, 211);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(223, 27);
            txtTelefono.TabIndex = 10;
            txtTelefono.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 254);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(82, 251);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(223, 27);
            txtDireccion.TabIndex = 12;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(374, 73);
            button1.Name = "button1";
            button1.Size = new Size(114, 33);
            button1.TabIndex = 13;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(374, 120);
            button2.Name = "button2";
            button2.Size = new Size(114, 33);
            button2.TabIndex = 14;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(374, 173);
            button3.Name = "button3";
            button3.Size = new Size(114, 33);
            button3.TabIndex = 15;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(550, 331);
            button4.Name = "button4";
            button4.Size = new Size(181, 64);
            button4.TabIndex = 16;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(516, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(255, 244);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtRUT);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(radioButtonNo);
            Controls.Add(radioButtonSi);
            Controls.Add(label1);
            Name = "RegistroCliente";
            Text = "Registro de Cliente";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButtonSi;
        private RadioButton radioButtonNo;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtRUT;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtDireccion;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}