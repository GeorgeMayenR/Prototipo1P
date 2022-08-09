namespace Prototipo1P
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.radiotrabajador = new System.Windows.Forms.RadioButton();
            this.radioadministrador = new System.Windows.Forms.RadioButton();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(155, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 86);
            this.label3.TabIndex = 27;
            this.label3.Text = "Inicio de Sesión";
            // 
            // radiotrabajador
            // 
            this.radiotrabajador.AutoSize = true;
            this.radiotrabajador.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radiotrabajador.Location = new System.Drawing.Point(465, 248);
            this.radiotrabajador.Name = "radiotrabajador";
            this.radiotrabajador.Size = new System.Drawing.Size(90, 19);
            this.radiotrabajador.TabIndex = 26;
            this.radiotrabajador.TabStop = true;
            this.radiotrabajador.Text = "Trabajador";
            this.radiotrabajador.UseVisualStyleBackColor = true;
            // 
            // radioadministrador
            // 
            this.radioadministrador.AutoSize = true;
            this.radioadministrador.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioadministrador.Location = new System.Drawing.Point(317, 248);
            this.radioadministrador.Name = "radioadministrador";
            this.radioadministrador.Size = new System.Drawing.Size(111, 19);
            this.radioadministrador.TabIndex = 25;
            this.radioadministrador.TabStop = true;
            this.radioadministrador.Text = "Administrador";
            this.radioadministrador.UseVisualStyleBackColor = true;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(101)))), ((int)(((byte)(244)))));
            this.btningresar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btningresar.ForeColor = System.Drawing.Color.White;
            this.btningresar.Location = new System.Drawing.Point(376, 290);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(125, 44);
            this.btningresar.TabIndex = 24;
            this.btningresar.Text = "INICIAR";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcontraseña.Location = new System.Drawing.Point(317, 194);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(242, 21);
            this.txtcontraseña.TabIndex = 23;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusuario.Location = new System.Drawing.Point(317, 155);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(242, 21);
            this.txtusuario.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(238, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radiotrabajador);
            this.Controls.Add(this.radioadministrador);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private RadioButton radiotrabajador;
        private RadioButton radioadministrador;
        private Button btningresar;
        private TextBox txtcontraseña;
        private TextBox txtusuario;
        private Label label2;
        private Label label1;
    }
}