namespace Prototipo1P
{
    partial class FProcesos
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla1 = new System.Windows.Forms.DataGridView();
            this.documentocompraenca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(230, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 86);
            this.label3.TabIndex = 29;
            this.label3.Text = "PROCESOS";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btnMenu.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(663, 394);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(125, 44);
            this.btnMenu.TabIndex = 35;
            this.btnMenu.Text = "Menú Principal";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "DETALLE COMPRA";
            // 
            // tabla1
            // 
            this.tabla1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentocompraenca,
            this.codigoproducto,
            this.cantidadcompra,
            this.costocompra,
            this.codigobodega});
            this.tabla1.Location = new System.Drawing.Point(12, 178);
            this.tabla1.Name = "tabla1";
            this.tabla1.RowTemplate.Height = 25;
            this.tabla1.Size = new System.Drawing.Size(620, 146);
            this.tabla1.TabIndex = 45;
            // 
            // documentocompraenca
            // 
            this.documentocompraenca.HeaderText = "documento compraenca";
            this.documentocompraenca.Name = "documentocompraenca";
            this.documentocompraenca.Width = 149;
            // 
            // codigoproducto
            // 
            this.codigoproducto.HeaderText = "codigo producto";
            this.codigoproducto.Name = "codigoproducto";
            this.codigoproducto.Width = 111;
            // 
            // cantidadcompra
            // 
            this.cantidadcompra.HeaderText = "cantidad compra";
            this.cantidadcompra.Name = "cantidadcompra";
            this.cantidadcompra.Width = 112;
            // 
            // costocompra
            // 
            this.costocompra.HeaderText = "costo compra";
            this.costocompra.Name = "costocompra";
            this.costocompra.Width = 97;
            // 
            // codigobodega
            // 
            this.codigobodega.HeaderText = "codigo bodega";
            this.codigobodega.Name = "codigobodega";
            this.codigobodega.Width = 103;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btnMostrar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(522, 394);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(125, 44);
            this.btnMostrar.TabIndex = 47;
            this.btnMostrar.Text = "Mostrar datos";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabla1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label3);
            this.Name = "FProcesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesos";
            ((System.ComponentModel.ISupportInitialize)(this.tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button btnMenu;
        private Label label2;
        private DataGridView tabla1;
        private DataGridViewTextBoxColumn documentocompraenca;
        private DataGridViewTextBoxColumn codigoproducto;
        private DataGridViewTextBoxColumn cantidadcompra;
        private DataGridViewTextBoxColumn costocompra;
        private DataGridViewTextBoxColumn codigobodega;
        private Button btnMostrar;
    }
}