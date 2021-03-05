
namespace Calculadora
{
    partial class Historio_de_Calculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historio_de_Calculo));
            this.boxHistorico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boxHistorico
            // 
            this.boxHistorico.FormattingEnabled = true;
            this.boxHistorico.Location = new System.Drawing.Point(12, 12);
            this.boxHistorico.Name = "boxHistorico";
            this.boxHistorico.Size = new System.Drawing.Size(303, 264);
            this.boxHistorico.TabIndex = 28;
            // 
            // Historio_de_Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 291);
            this.Controls.Add(this.boxHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Historio_de_Calculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historio_de_Calculo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox boxHistorico;
    }
}