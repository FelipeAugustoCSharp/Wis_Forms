namespace WisGalery.FeedContent
{
    partial class LerPostit
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbRichPostit = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txbRichPostit
            // 
            this.txbRichPostit.Location = new System.Drawing.Point(27, 20);
            this.txbRichPostit.Name = "txbRichPostit";
            this.txbRichPostit.Size = new System.Drawing.Size(268, 189);
            this.txbRichPostit.TabIndex = 0;
            this.txbRichPostit.Text = "";
            this.txbRichPostit.TextChanged += new System.EventHandler(this.txbRichPostit_TextChanged);
            // 
            // LerPostit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.txbRichPostit);
            this.Name = "LerPostit";
            this.Size = new System.Drawing.Size(315, 273);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbRichPostit;
    }
}
