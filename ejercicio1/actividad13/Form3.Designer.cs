namespace ejercicio1
{
    partial class Form3
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
            lbMedidas = new ListBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lbMedidas
            // 
            lbMedidas.Font = new Font("Segoe UI", 10F);
            lbMedidas.FormattingEnabled = true;
            lbMedidas.Location = new Point(25, 24);
            lbMedidas.Name = "lbMedidas";
            lbMedidas.Size = new Size(220, 191);
            lbMedidas.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Segoe UI", 10F);
            btnOK.Location = new Point(87, 238);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(95, 40);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 302);
            Controls.Add(btnOK);
            Controls.Add(lbMedidas);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion
        private Button btnOK;
        public ListBox lbMedidas;
    }
}