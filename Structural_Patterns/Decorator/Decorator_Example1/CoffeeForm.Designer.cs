
namespace Structural_Patterns.Decorator.Decorator_Example1
{
    partial class CoffeeForm
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
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnMilkCoffee = new System.Windows.Forms.Button();
            this.btnMixCoffe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoffee
            // 
            this.btnCoffee.Location = new System.Drawing.Point(85, 182);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(181, 84);
            this.btnCoffee.TabIndex = 0;
            this.btnCoffee.Text = "CaramelCoffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnMilkCoffee
            // 
            this.btnMilkCoffee.Location = new System.Drawing.Point(329, 182);
            this.btnMilkCoffee.Name = "btnMilkCoffee";
            this.btnMilkCoffee.Size = new System.Drawing.Size(157, 84);
            this.btnMilkCoffee.TabIndex = 1;
            this.btnMilkCoffee.Text = "MilkCofeee";
            this.btnMilkCoffee.UseVisualStyleBackColor = true;
            this.btnMilkCoffee.Click += new System.EventHandler(this.btnMilkCoffee_Click);
            // 
            // btnMixCoffe
            // 
            this.btnMixCoffe.Location = new System.Drawing.Point(533, 182);
            this.btnMixCoffe.Name = "btnMixCoffe";
            this.btnMixCoffe.Size = new System.Drawing.Size(144, 84);
            this.btnMixCoffe.TabIndex = 2;
            this.btnMixCoffe.Text = "MixCofee";
            this.btnMixCoffe.UseVisualStyleBackColor = true;
            this.btnMixCoffe.Click += new System.EventHandler(this.btnMixCoffe_Click);
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMixCoffe);
            this.Controls.Add(this.btnMilkCoffee);
            this.Controls.Add(this.btnCoffee);
            this.Name = "CoffeeForm";
            this.Text = "CoffeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnMilkCoffee;
        private System.Windows.Forms.Button btnMixCoffe;
    }
}