namespace calculadora
{
    partial class frmConversor
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
            lblTexto = new Label();
            txtCelcius = new TextBox();
            btnConverter = new Button();
            txtFahrenheit = new TextBox();
            label1 = new Label();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(22, 25);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(262, 38);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Temperatura em ºC";
            // 
            // txtCelcius
            // 
            txtCelcius.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCelcius.Location = new Point(34, 66);
            txtCelcius.Multiline = true;
            txtCelcius.Name = "txtCelcius";
            txtCelcius.Size = new Size(346, 47);
            txtCelcius.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.AliceBlue;
            btnConverter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.Location = new Point(34, 152);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(346, 48);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "CONVERTER";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFahrenheit.Location = new Point(34, 266);
            txtFahrenheit.Multiline = true;
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.ReadOnly = true;
            txtFahrenheit.Size = new Size(346, 47);
            txtFahrenheit.TabIndex = 3;
            txtFahrenheit.TextChanged += txtFahrenheit_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 225);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 4;
            label1.Text = "Temperatura em ºF";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.AliceBlue;
            btnLimpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(214, 339);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(175, 42);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += this.btnLimpar_Click;
            // 
            // frmConversor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(412, 393);
            Controls.Add(btnLimpar);
            Controls.Add(label1);
            Controls.Add(txtFahrenheit);
            Controls.Add(btnConverter);
            Controls.Add(txtCelcius);
            Controls.Add(lblTexto);
            Name = "frmConversor";
            Text = "conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox txtCelcius;
        private Button btnConverter;
        private TextBox txtFahrenheit;
        private Label label1;
        private Button btnLimpar;
    }
}