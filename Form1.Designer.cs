namespace calculadora
{
    partial class calculadora
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            pictureBox1 = new PictureBox();
            pgbCarregamento = new ProgressBar();
            label1 = new Label();
            tmrTempo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-27, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pgbCarregamento
            // 
            pgbCarregamento.ForeColor = Color.DarkSlateBlue;
            pgbCarregamento.Location = new Point(33, 114);
            pgbCarregamento.Name = "pgbCarregamento";
            pgbCarregamento.Size = new Size(485, 23);
            pgbCarregamento.TabIndex = 1;
            pgbCarregamento.Click += pgbCarregamento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 84);
            label1.Name = "label1";
            label1.Size = new Size(145, 24);
            label1.TabIndex = 2;
            label1.Text = "carregando...";
            // 
            // tmrTempo
            // 
            tmrTempo.Enabled = true;
            tmrTempo.Interval = 60;
            tmrTempo.Tick += tmrTempo_Tick;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(549, 156);
            Controls.Add(label1);
            Controls.Add(pgbCarregamento);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "calculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calculadora";
            Load += calculadora_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar pgbCarregamento;
        private Label label1;
        private System.Windows.Forms.Timer tmrTempo;
    }
}
