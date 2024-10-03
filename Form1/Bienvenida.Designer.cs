namespace Venta_de_Cartas
{
    partial class Bienvenida
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(272, 52);
            label1.Name = "label1";
            label1.Size = new Size(242, 35);
            label1.TabIndex = 0;
            label1.Text = "Que deseas realizar?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(53, 94);
            button1.Name = "button1";
            button1.Size = new Size(711, 83);
            button1.TabIndex = 1;
            button1.Text = "Regristrar Marca";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegistrarMarca_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(53, 200);
            button2.Name = "button2";
            button2.Size = new Size(711, 83);
            button2.TabIndex = 2;
            button2.Text = "Registrar inventario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnRegistrarInventario_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(53, 308);
            button3.Name = "button3";
            button3.Size = new Size(711, 83);
            button3.TabIndex = 3;
            button3.Text = "Venta de Cartas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnVentaCartas_Click;
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Bienvenida";
            Text = "Bienvenido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}