namespace Prototipo1P
{
    partial class Menu
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
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btn_Procesos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(146, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 86);
            this.label3.TabIndex = 28;
            this.label3.Text = "Menú Principal";
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btnCatalogo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCatalogo.Location = new System.Drawing.Point(130, 164);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(125, 44);
            this.btnCatalogo.TabIndex = 29;
            this.btnCatalogo.Text = "CATÁLOGO";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btnHerramientas.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHerramientas.ForeColor = System.Drawing.Color.White;
            this.btnHerramientas.Location = new System.Drawing.Point(187, 266);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(125, 44);
            this.btnHerramientas.TabIndex = 30;
            this.btnHerramientas.Text = "HERRAMIENTAS";
            this.btnHerramientas.UseVisualStyleBackColor = false;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btnAyuda.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(392, 266);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(125, 44);
            this.btnAyuda.TabIndex = 31;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btnInformes.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Location = new System.Drawing.Point(470, 164);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(125, 44);
            this.btnInformes.TabIndex = 32;
            this.btnInformes.Text = "INFORMES";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btn_Procesos
            // 
            this.btn_Procesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btn_Procesos.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Procesos.ForeColor = System.Drawing.Color.White;
            this.btn_Procesos.Location = new System.Drawing.Point(300, 164);
            this.btn_Procesos.Name = "btn_Procesos";
            this.btn_Procesos.Size = new System.Drawing.Size(125, 44);
            this.btn_Procesos.TabIndex = 33;
            this.btn_Procesos.Text = "PROCESOS";
            this.btn_Procesos.UseVisualStyleBackColor = false;
            this.btn_Procesos.Click += new System.EventHandler(this.btn_Procesos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Procesos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.label3);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button btnCatalogo;
        private Button btnHerramientas;
        private Button btnAyuda;
        private Button btnInformes;
        private Button btn_Procesos;
    }
}