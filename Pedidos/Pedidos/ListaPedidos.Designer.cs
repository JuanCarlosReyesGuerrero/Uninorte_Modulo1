namespace Pedidos
{
    partial class ListaPedidos
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
            dataGridView1 = new DataGridView();
            btnConfirmar = new Button();
            btnAnular = new Button();
            txtTotal = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(871, 327);
            dataGridView1.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(635, 29);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(121, 23);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "Confirmar Pedido";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(762, 29);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(121, 23);
            btnAnular.TabIndex = 2;
            btnAnular.Text = "Anular Pedido";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(783, 403);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(702, 406);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Total  Pedido";
            // 
            // ListaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 450);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(btnAnular);
            Controls.Add(btnConfirmar);
            Controls.Add(dataGridView1);
            Name = "ListaPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaPedidos";
            Load += ListaPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnConfirmar;
        private Button btnAnular;
        private TextBox txtTotal;
        private Label label1;
    }
}