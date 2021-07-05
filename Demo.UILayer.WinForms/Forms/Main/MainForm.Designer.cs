
namespace Demo.UILayer.WinForms.Forms.Main
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.TransientMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.SingletonFormBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.ToolTip(this.components);
            this.Message = new System.Windows.Forms.ToolStripTextBox();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TransientMenuBtn,
            this.SingletonFormBtn,
            this.Message});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 27);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // TransientMenuBtn
            // 
            this.TransientMenuBtn.Name = "TransientMenuBtn";
            this.TransientMenuBtn.Size = new System.Drawing.Size(95, 23);
            this.TransientMenuBtn.Text = "Transient form";
            // 
            // SingletonFormBtn
            // 
            this.SingletonFormBtn.Name = "SingletonFormBtn";
            this.SingletonFormBtn.Size = new System.Drawing.Size(98, 23);
            this.SingletonFormBtn.Text = "Singleton form";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.Location = new System.Drawing.Point(233, 178);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 55);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Size = new System.Drawing.Size(200, 23);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TransientMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem SingletonFormBtn;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.ToolTip Info;
        private System.Windows.Forms.ToolStripTextBox Message;
    }
}