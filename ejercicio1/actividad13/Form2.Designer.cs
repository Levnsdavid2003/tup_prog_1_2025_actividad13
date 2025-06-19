namespace ejercicio1
{
    partial class Form2
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            tbValor = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.AutoEllipsis = true;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(57, 87);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 50);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Font = new Font("Segoe UI", 10F);
            btnAceptar.Location = new Point(180, 87);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 50);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(85, 33);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(204, 25);
            tbValor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 3;
            label1.Text = "Valor:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 169);
            Controls.Add(label1);
            Controls.Add(tbValor);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label label1;
        public TextBox tbValor;
    }
}