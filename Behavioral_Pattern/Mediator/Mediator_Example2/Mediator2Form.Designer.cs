
namespace Behavioral_Pattern.Mediator.Mediator_Example2
{
    partial class Mediator2Form
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
            this.btnChatRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChatRoom
            // 
            this.btnChatRoom.Location = new System.Drawing.Point(174, 168);
            this.btnChatRoom.Name = "btnChatRoom";
            this.btnChatRoom.Size = new System.Drawing.Size(144, 76);
            this.btnChatRoom.TabIndex = 0;
            this.btnChatRoom.Text = "ChatRoom";
            this.btnChatRoom.UseVisualStyleBackColor = true;
            this.btnChatRoom.Click += new System.EventHandler(this.btnChatRoom_Click);
            // 
            // Mediator2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChatRoom);
            this.Name = "Mediator2Form";
            this.Text = "Mediator2Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChatRoom;
    }
}