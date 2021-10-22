
namespace Creational_Pattern.Factory.Factory_Example1
{
    partial class CreateComputor
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
            this.btncomputerCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncomputerCreate
            // 
            this.btncomputerCreate.Location = new System.Drawing.Point(117, 129);
            this.btncomputerCreate.Name = "btncomputerCreate";
            this.btncomputerCreate.Size = new System.Drawing.Size(94, 55);
            this.btncomputerCreate.TabIndex = 0;
            this.btncomputerCreate.Text = "Computor Create";
            this.btncomputerCreate.UseVisualStyleBackColor = true;
            this.btncomputerCreate.Click += new System.EventHandler(this.btncomputerCreate_Click);
            // 
            // CreateComputor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncomputerCreate);
            this.Name = "CreateComputor";
            this.Text = "CreateComputor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncomputerCreate;
    }
}