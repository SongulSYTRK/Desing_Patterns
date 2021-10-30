
namespace Behavioral_Pattern.Mediator
{
    partial class MediatorForm
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
            this.btnTomota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTomota
            // 
            this.btnTomota.Location = new System.Drawing.Point(295, 169);
            this.btnTomota.Name = "btnTomota";
            this.btnTomota.Size = new System.Drawing.Size(146, 104);
            this.btnTomota.TabIndex = 0;
            this.btnTomota.Text = "Buy/Sale tomato";
            this.btnTomota.UseVisualStyleBackColor = true;
            this.btnTomota.Click += new System.EventHandler(this.btnTomota_Click);
            // 
            // MediatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTomota);
            this.Name = "MediatorForm";
            this.Text = "MediatorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTomota;
    }
}