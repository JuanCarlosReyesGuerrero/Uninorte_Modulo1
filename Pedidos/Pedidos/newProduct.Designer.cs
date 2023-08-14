namespace Pedidos
{
    partial class newProduct
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
            txtNombre = new TextBox();
            txtPrecioEntrada = new TextBox();
            label2 = new Label();
            txtPrecioSalida = new TextBox();
            label3 = new Label();
            txtUnidad = new TextBox();
            label4 = new Label();
            btnCancelar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecioEntrada
            // 
            txtPrecioEntrada.Location = new Point(101, 45);
            txtPrecioEntrada.Name = "txtPrecioEntrada";
            txtPrecioEntrada.Size = new Size(195, 23);
            txtPrecioEntrada.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio Entrada";
            // 
            // txtPrecioSalida
            // 
            txtPrecioSalida.Location = new Point(101, 74);
            txtPrecioSalida.Name = "txtPrecioSalida";
            txtPrecioSalida.Size = new Size(195, 23);
            txtPrecioSalida.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio Salida";
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(101, 103);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(195, 23);
            txtUnidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Unidad";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(102, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(199, 154);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // newProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 206);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Controls.Add(txtUnidad);
            Controls.Add(label4);
            Controls.Add(txtPrecioSalida);
            Controls.Add(label3);
            Controls.Add(txtPrecioEntrada);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "newProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "newProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPrecioEntrada;
        private Label label2;
        private TextBox txtPrecioSalida;
        private Label label3;
        private TextBox txtUnidad;
        private Label label4;
        private Button btnCancelar;
        private Button btnAgregar;
    }
}