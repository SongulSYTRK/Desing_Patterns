
namespace Structural_Patterns.Decorator.Decorator_Example2
{
    partial class DecoratorStudent
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtdepartmant = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecord = new System.Windows.Forms.TextBox();
            this.btnRecorPrice = new System.Windows.Forms.Button();
            this.btnGaziAmount = new System.Windows.Forms.Button();
            this.btnREcord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(308, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtdepartmant
            // 
            this.txtdepartmant.Location = new System.Drawing.Point(308, 114);
            this.txtdepartmant.Name = "txtdepartmant";
            this.txtdepartmant.Size = new System.Drawing.Size(138, 22);
            this.txtdepartmant.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(308, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "StudentId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Departmant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Record Amount ";
            // 
            // txtRecord
            // 
            this.txtRecord.Location = new System.Drawing.Point(308, 155);
            this.txtRecord.Name = "txtRecord";
            this.txtRecord.Size = new System.Drawing.Size(138, 22);
            this.txtRecord.TabIndex = 3;
            // 
            // btnRecorPrice
            // 
            this.btnRecorPrice.Location = new System.Drawing.Point(192, 229);
            this.btnRecorPrice.Name = "btnRecorPrice";
            this.btnRecorPrice.Size = new System.Drawing.Size(138, 114);
            this.btnRecorPrice.TabIndex = 4;
            this.btnRecorPrice.Text = "First Record Amount";
            this.btnRecorPrice.UseVisualStyleBackColor = true;
            this.btnRecorPrice.Click += new System.EventHandler(this.btnRecorPrice_Click);
            // 
            // btnGaziAmount
            // 
            this.btnGaziAmount.Location = new System.Drawing.Point(393, 232);
            this.btnGaziAmount.Name = "btnGaziAmount";
            this.btnGaziAmount.Size = new System.Drawing.Size(140, 111);
            this.btnGaziAmount.TabIndex = 6;
            this.btnGaziAmount.Text = "Gazi Record Amount";
            this.btnGaziAmount.UseVisualStyleBackColor = true;
            this.btnGaziAmount.Click += new System.EventHandler(this.btnGaziAmount_Click);
            // 
            // btnREcord
            // 
            this.btnREcord.Location = new System.Drawing.Point(12, 232);
            this.btnREcord.Name = "btnREcord";
            this.btnREcord.Size = new System.Drawing.Size(143, 111);
            this.btnREcord.TabIndex = 7;
            this.btnREcord.Text = "Record";
            this.btnREcord.UseVisualStyleBackColor = true;
            this.btnREcord.Click += new System.EventHandler(this.btnREcord_Click);
            // 
            // DecoratorStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnREcord);
            this.Controls.Add(this.btnGaziAmount);
            this.Controls.Add(this.btnRecorPrice);
            this.Controls.Add(this.txtRecord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtdepartmant);
            this.Controls.Add(this.txtId);
            this.Name = "DecoratorStudent";
            this.Text = "DecoratorStudent";
            this.Load += new System.EventHandler(this.DecoratorStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtdepartmant;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecord;
        private System.Windows.Forms.Button btnRecorPrice;
        private System.Windows.Forms.Button btnGaziAmount;
        private System.Windows.Forms.Button btnREcord;
    }
}