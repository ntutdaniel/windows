namespace PosOrderSystem
{
    partial class RestaurantView
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
            this._comeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _comeLabel
            // 
            this._comeLabel.AutoSize = true;
            this._comeLabel.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._comeLabel.Location = new System.Drawing.Point(315, 145);
            this._comeLabel.Name = "_comeLabel";
            this._comeLabel.Size = new System.Drawing.Size(301, 60);
            this._comeLabel.TabIndex = 0;
            this._comeLabel.Text = "Come soon!";
            // 
            // RestaurantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 397);
            this.Controls.Add(this._comeLabel);
            this.Name = "RestaurantView";
            this.Text = "RestaurantView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _comeLabel;
    }
}