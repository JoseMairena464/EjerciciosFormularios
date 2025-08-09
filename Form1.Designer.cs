
namespace Ejercicios
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
            lblMensaje = new Label();
            btnHola = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 14F);
            lblMensaje.Location = new Point(144, 57);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(196, 32);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "¡smroFniW ,aloH!";
            lblMensaje.Click += lblMensaje_Click;
            // 
            // btnHola
            // 
            btnHola.Font = new Font("Segoe UI", 12F);
            btnHola.Location = new Point(127, 149);
            btnHola.Margin = new Padding(3, 4, 3, 4);
            btnHola.Name = "btnHola";
            btnHola.Size = new Size(185, 53);
            btnHola.TabIndex = 1;
            btnHola.Text = "Magia";
            btnHola.UseVisualStyleBackColor = true;
            btnHola.Click += btnHola_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 286);
            Controls.Add(btnHola);
            Controls.Add(lblMensaje);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblMensaje;
        private Button btnHola;
    }
}
