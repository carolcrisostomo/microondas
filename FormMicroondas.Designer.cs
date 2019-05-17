namespace MICROONDASDIGITAL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aquecerButton = new System.Windows.Forms.Button();
            this.entradaTextBox = new System.Windows.Forms.TextBox();
            this.saidaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aquecerButton
            // 
            this.aquecerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aquecerButton.Location = new System.Drawing.Point(548, 35);
            this.aquecerButton.Name = "aquecerButton";
            this.aquecerButton.Size = new System.Drawing.Size(75, 23);
            this.aquecerButton.TabIndex = 0;
            this.aquecerButton.Text = "inicio";
            this.aquecerButton.UseVisualStyleBackColor = true;
            this.aquecerButton.Click += new System.EventHandler(this.AquecerButton_Click);
            // 
            // entradaTextBox
            // 
            this.entradaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entradaTextBox.Location = new System.Drawing.Point(43, 38);
            this.entradaTextBox.Name = "entradaTextBox";
            this.entradaTextBox.Size = new System.Drawing.Size(482, 20);
            this.entradaTextBox.TabIndex = 1;
            // 
            // saidaTextBox
            // 
            this.saidaTextBox.AcceptsReturn = true;
            this.saidaTextBox.AcceptsTab = true;
            this.saidaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saidaTextBox.Location = new System.Drawing.Point(43, 90);
            this.saidaTextBox.Multiline = true;
            this.saidaTextBox.Name = "saidaTextBox";
            this.saidaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.saidaTextBox.Size = new System.Drawing.Size(580, 230);
            this.saidaTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 367);
            this.Controls.Add(this.saidaTextBox);
            this.Controls.Add(this.entradaTextBox);
            this.Controls.Add(this.aquecerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Microondas Digital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aquecerButton;
        private System.Windows.Forms.TextBox entradaTextBox;
        private System.Windows.Forms.TextBox saidaTextBox;
    }
}

