namespace calculadora
{
    partial class frmCmparaPolegadas
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
            lblCm = new Label();
            txtCentimetros = new TextBox();
            btnConverter = new Button();
            txtPolegadas = new TextBox();
            label1 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblCm
            // 
            lblCm.AutoSize = true;
            lblCm.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCm.Location = new Point(22, 23);
            lblCm.Name = "lblCm";
            lblCm.Size = new Size(171, 38);
            lblCm.TabIndex = 0;
            lblCm.Text = "Centimetros";
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(22, 64);
            txtCentimetros.Multiline = true;
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.Size = new Size(344, 50);
            txtCentimetros.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.Pink;
            btnConverter.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.ForeColor = SystemColors.ControlText;
            btnConverter.Location = new Point(22, 150);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(344, 51);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "CONVERTER";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtPolegadas
            // 
            txtPolegadas.Location = new Point(22, 276);
            txtPolegadas.Multiline = true;
            txtPolegadas.Name = "txtPolegadas";
            txtPolegadas.Size = new Size(344, 50);
            txtPolegadas.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 235);
            label1.Name = "label1";
            label1.Size = new Size(147, 38);
            label1.TabIndex = 3;
            label1.Text = "Polegadas";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Pink;
            btnLimpar.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.ControlText;
            btnLimpar.Location = new Point(233, 374);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(147, 39);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmCmparaPolegadas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(407, 425);
            Controls.Add(btnLimpar);
            Controls.Add(txtPolegadas);
            Controls.Add(label1);
            Controls.Add(btnConverter);
            Controls.Add(txtCentimetros);
            Controls.Add(lblCm);
            Name = "frmCmparaPolegadas";
            Text = "frmCmparaPolegadas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCm;
        private TextBox txtCentimetros;
        private Button btnConverter;
        private TextBox txtPolegadas;
        private Label label1;
        private Button btnLimpar;
    }
}