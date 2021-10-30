
namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2
{
    partial class CorExample
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
            this.BTNPLAY = new System.Windows.Forms.Button();
            this.txtplayer = new System.Windows.Forms.TextBox();
            this.btnchoeseFile = new System.Windows.Forms.Button();
            this.openfileplayer = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BTNPLAY
            // 
            this.BTNPLAY.Location = new System.Drawing.Point(216, 151);
            this.BTNPLAY.Name = "BTNPLAY";
            this.BTNPLAY.Size = new System.Drawing.Size(160, 80);
            this.BTNPLAY.TabIndex = 0;
            this.BTNPLAY.Text = "PLAY ";
            this.BTNPLAY.UseVisualStyleBackColor = true;
            this.BTNPLAY.Click += new System.EventHandler(this.BTNPLAY_Click);
            // 
            // txtplayer
            // 
            this.txtplayer.Location = new System.Drawing.Point(232, 65);
            this.txtplayer.Name = "txtplayer";
            this.txtplayer.Size = new System.Drawing.Size(128, 22);
            this.txtplayer.TabIndex = 1;
            // 
            // btnchoeseFile
            // 
            this.btnchoeseFile.Location = new System.Drawing.Point(109, 65);
            this.btnchoeseFile.Name = "btnchoeseFile";
            this.btnchoeseFile.Size = new System.Drawing.Size(101, 23);
            this.btnchoeseFile.TabIndex = 2;
            this.btnchoeseFile.Text = "Find File";
            this.btnchoeseFile.UseVisualStyleBackColor = true;
            this.btnchoeseFile.Click += new System.EventHandler(this.btnchoeseFile_Click);
            // 
            // openfileplayer
            // 
            this.openfileplayer.FileName = "openFileDialog1";
            // 
            // CorExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnchoeseFile);
            this.Controls.Add(this.txtplayer);
            this.Controls.Add(this.BTNPLAY);
            this.Name = "CorExample";
            this.Text = "PlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNPLAY;
        private System.Windows.Forms.TextBox txtplayer;
        private System.Windows.Forms.Button btnchoeseFile;
        private System.Windows.Forms.OpenFileDialog openfileplayer;
    }
}