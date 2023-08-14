namespace Pedidos
{
    partial class Abastecer
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
            cboProveedor = new ComboBox();
            cboProducto = new ComboBox();
            btnCargarLista = new Button();
            label2 = new Label();
            Producto = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtCantidad = new TextBox();
            btnProcesar = new Button();
            btnLisatr = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cboProveedor
            // 
            cboProveedor.FormattingEnabled = true;
            cboProveedor.Location = new Point(92, 37);
            cboProveedor.Name = "cboProveedor";
            cboProveedor.Size = new Size(246, 23);
            cboProveedor.TabIndex = 13;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(92, 9);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(246, 23);
            cboProducto.TabIndex = 12;
            // 
            // btnCargarLista
            // 
            btnCargarLista.Location = new Point(416, 48);
            btnCargarLista.Name = "btnCargarLista";
            btnCargarLista.Size = new Size(100, 23);
            btnCargarLista.TabIndex = 11;
            btnCargarLista.Text = "Agregar a Lista";
            btnCargarLista.UseVisualStyleBackColor = true;
            btnCargarLista.Click += btnCargarLista_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 10;
            label2.Text = "Proveedor";
            // 
            // Producto
            // 
            Producto.AutoSize = true;
            Producto.Location = new Point(12, 12);
            Producto.Name = "Producto";
            Producto.Size = new Size(56, 15);
            Producto.TabIndex = 9;
            Producto.Text = "Producto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 322);
            dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 12);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 14;
            label3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(416, 9);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 15;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(12, 415);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(76, 23);
            btnProcesar.TabIndex = 16;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // btnLisatr
            // 
            btnLisatr.Location = new Point(94, 415);
            btnLisatr.Name = "btnLisatr";
            btnLisatr.Size = new Size(76, 23);
            btnLisatr.TabIndex = 17;
            btnLisatr.Text = "Listar";
            btnLisatr.UseVisualStyleBackColor = true;
            btnLisatr.Click += btnLisatr_Click;
            // 
            // Abastecer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLisatr);
            Controls.Add(btnProcesar);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(cboProveedor);
            Controls.Add(cboProducto);
            Controls.Add(btnCargarLista);
            Controls.Add(label2);
            Controls.Add(Producto);
            Controls.Add(dataGridView1);
            Name = "Abastecer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Abastecer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboProveedor;
        private ComboBox cboProducto;
        private Button btnCargarLista;
        private Label label2;
        private Label Producto;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtCantidad;
        private Button btnProcesar;
        private Button btnLisatr;
    }
}