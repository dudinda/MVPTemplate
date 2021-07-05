
namespace Demo.UILayer.WinForms.Forms.Transient
{
    partial class TransientForm
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
            => Dispose();
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendMessageBtn = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendMessageBtn
            // 
            this.SendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendMessageBtn.Location = new System.Drawing.Point(96, 88);
            this.SendMessageBtn.Name = "SendMessageBtn";
            this.SendMessageBtn.Size = new System.Drawing.Size(238, 89);
            this.SendMessageBtn.TabIndex = 0;
            this.SendMessageBtn.Text = "Send Message";
            this.SendMessageBtn.UseVisualStyleBackColor = true;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLabel.Location = new System.Drawing.Point(12, 9);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(148, 24);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "Transient Form: ";
            // 
            // TransientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 283);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SendMessageBtn);
            this.MaximizeBox = false;
            this.Name = "TransientForm";
            this.Text = "Transient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessageBtn;
        private System.Windows.Forms.Label IdLabel;
    }
}