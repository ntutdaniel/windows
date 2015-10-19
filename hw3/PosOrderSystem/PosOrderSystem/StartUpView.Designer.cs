namespace PosOrderSystem
{
    partial class StartUpView
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
            this._frontButton = new System.Windows.Forms.Button();
            this._backButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _frontendButton
            // 
            this._frontButton.Location = new System.Drawing.Point(109, 44);
            this._frontButton.Name = "_frontendButton";
            this._frontButton.Size = new System.Drawing.Size(352, 96);
            this._frontButton.TabIndex = 0;
            this._frontButton.Text = "Customer order system";
            this._frontButton.UseVisualStyleBackColor = true;
            this._frontButton.Click += new System.EventHandler(this.ClickFrontButton);
            // 
            // _backendButton
            // 
            this._backButton.Location = new System.Drawing.Point(571, 44);
            this._backButton.Name = "_backendButton";
            this._backButton.Size = new System.Drawing.Size(393, 96);
            this._backButton.TabIndex = 1;
            this._backButton.Text = "Restaurant order system";
            this._backButton.UseVisualStyleBackColor = true;
            this._backButton.Click += new System.EventHandler(this.ClickBackButton);
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(744, 247);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(220, 86);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // StartUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 365);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._backButton);
            this.Controls.Add(this._frontButton);
            this.Name = "StartUpView";
            this.Text = "StartUpView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _frontButton;
        private System.Windows.Forms.Button _backButton;
        private System.Windows.Forms.Button _exitButton;
    }
}