namespace TomJerry
{
    partial class Form1
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
            this.jerryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jerryBtn
            // 
            this.jerryBtn.BackColor = System.Drawing.Color.Transparent;
            this.jerryBtn.BackgroundImage = global::TomJerry.Properties.Resources.pngimg_com___tom_and_jerry_PNG2__1_;
            this.jerryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jerryBtn.FlatAppearance.BorderSize = 0;
            this.jerryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jerryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jerryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jerryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.jerryBtn.Location = new System.Drawing.Point(152, 523);
            this.jerryBtn.Name = "jerryBtn";
            this.jerryBtn.Size = new System.Drawing.Size(149, 78);
            this.jerryBtn.TabIndex = 0;
            this.jerryBtn.UseVisualStyleBackColor = false;
            this.jerryBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.jerryBtn_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TomJerry.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(884, 628);
            this.Controls.Add(this.jerryBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jerryBtn;
    }
}

