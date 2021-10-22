
namespace Creational_Pattern.Builder
{
    partial class btn
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
            this.btnDominosPizza = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVegetarianPizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDominosPizza
            // 
            this.btnDominosPizza.Location = new System.Drawing.Point(143, 58);
            this.btnDominosPizza.Name = "btnDominosPizza";
            this.btnDominosPizza.Size = new System.Drawing.Size(136, 86);
            this.btnDominosPizza.TabIndex = 0;
            this.btnDominosPizza.Text = "DominosPizza";
            this.btnDominosPizza.UseVisualStyleBackColor = true;
            this.btnDominosPizza.Click += new System.EventHandler(this.btnDominosPizza_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(83, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 244);
            this.listBox1.TabIndex = 1;
            // 
            // btnVegetarianPizza
            // 
            this.btnVegetarianPizza.Location = new System.Drawing.Point(322, 58);
            this.btnVegetarianPizza.Name = "btnVegetarianPizza";
            this.btnVegetarianPizza.Size = new System.Drawing.Size(140, 86);
            this.btnVegetarianPizza.TabIndex = 2;
            this.btnVegetarianPizza.Text = "VegetarianPizza";
            this.btnVegetarianPizza.UseVisualStyleBackColor = true;
            this.btnVegetarianPizza.Click += new System.EventHandler(this.btnVegetarianPizza_Click);
            // 
            // btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVegetarianPizza);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDominosPizza);
            this.Name = "btn";
            this.Text = "Product_Client";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDominosPizza;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnVegetarianPizza;
    }
}