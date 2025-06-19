namespace ejercicio1
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
            btnIniciar = new Button();
            btnMedida = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 10F);
            btnIniciar.Location = new Point(28, 28);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 56);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar N° de Lote";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnMedida
            // 
            btnMedida.Font = new Font("Segoe UI", 10F);
            btnMedida.Location = new Point(28, 110);
            btnMedida.Name = "btnMedida";
            btnMedida.Size = new Size(112, 56);
            btnMedida.TabIndex = 1;
            btnMedida.Text = "Agregar Medida";
            btnMedida.UseVisualStyleBackColor = true;
            btnMedida.Click += btnMedida_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 10F);
            btnMostrar.Location = new Point(28, 192);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(112, 56);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Ver Todas las Medidas";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(169, 282);
            Controls.Add(btnMostrar);
            Controls.Add(btnMedida);
            Controls.Add(btnIniciar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Button btnMedida;
        private Button btnMostrar;
    }
}
