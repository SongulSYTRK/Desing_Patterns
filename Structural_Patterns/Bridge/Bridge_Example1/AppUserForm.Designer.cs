
namespace Structural_Patterns.Bridge.Bridge_Example1
{
    partial class AppUserForm
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
            this.btnlistenmusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlistenmusic
            // 
            this.btnlistenmusic.Location = new System.Drawing.Point(76, 73);
            this.btnlistenmusic.Name = "btnlistenmusic";
            this.btnlistenmusic.Size = new System.Drawing.Size(136, 102);
            this.btnlistenmusic.TabIndex = 0;
            this.btnlistenmusic.Text = "Listen Music";
            this.btnlistenmusic.UseVisualStyleBackColor = true;
            this.btnlistenmusic.Click += new System.EventHandler(this.btnlistenmusic_Click);
            // 
            // AppUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlistenmusic);
            this.Name = "AppUserForm";
            this.Text = "AppUserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlistenmusic;
    }
}