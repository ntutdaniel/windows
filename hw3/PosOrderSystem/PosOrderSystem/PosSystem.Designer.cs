namespace PosOrderSystem
{
    partial class OrderSystem
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._previousPageButton = new System.Windows.Forms.Button();
            this._nextPageButton = new System.Windows.Forms.Button();
            this._pageNumberLabel = new System.Windows.Forms.Label();
            this._mealRecordDataGridView = new System.Windows.Forms.DataGridView();
            this._totalLabel = new System.Windows.Forms.Label();
            this._mealGroupBox = new System.Windows.Forms.GroupBox();
            this._mealDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this._mealTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._quantity = new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            this._partTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._mealRecordDataGridView)).BeginInit();
            this._mealGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _previousPageButton
            // 
            this._previousPageButton.Location = new System.Drawing.Point(470, 782);
            this._previousPageButton.Name = "_previousPageButton";
            this._previousPageButton.Size = new System.Drawing.Size(150, 30);
            this._previousPageButton.TabIndex = 0;
            this._previousPageButton.Text = "Previous Page";
            this._previousPageButton.UseVisualStyleBackColor = true;
            this._previousPageButton.Click += new System.EventHandler(this.ClickPreviousPageButton);
            // 
            // _nextPageButton
            // 
            this._nextPageButton.Location = new System.Drawing.Point(642, 782);
            this._nextPageButton.Name = "_nextPageButton";
            this._nextPageButton.Size = new System.Drawing.Size(150, 30);
            this._nextPageButton.TabIndex = 1;
            this._nextPageButton.Text = "Next Page";
            this._nextPageButton.UseVisualStyleBackColor = true;
            this._nextPageButton.Click += new System.EventHandler(this.ClickNextPageButton);
            // 
            // _pageNumberLabel
            // 
            this._pageNumberLabel.AutoSize = true;
            this._pageNumberLabel.Location = new System.Drawing.Point(62, 784);
            this._pageNumberLabel.Name = "_pageNumberLabel";
            this._pageNumberLabel.Size = new System.Drawing.Size(87, 18);
            this._pageNumberLabel.TabIndex = 2;
            this._pageNumberLabel.Text = "Page : 1 / 2";
            // 
            // _mealRecordDataGridView
            // 
            this._mealRecordDataGridView.AllowUserToAddRows = false;
            this._mealRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._mealRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mealRecordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumn,
            this._name,
            this._unitPrice,
            this._quantity,
            this._partTotal});
            this._mealRecordDataGridView.Location = new System.Drawing.Point(870, 33);
            this._mealRecordDataGridView.Name = "_mealRecordDataGridView";
            this._mealRecordDataGridView.RowHeadersVisible = false;
            this._mealRecordDataGridView.RowTemplate.Height = 31;
            this._mealRecordDataGridView.Size = new System.Drawing.Size(855, 746);
            this._mealRecordDataGridView.TabIndex = 3;
            // 
            // _totalLabel
            // 
            this._totalLabel.AutoSize = true;
            this._totalLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._totalLabel.ForeColor = System.Drawing.Color.Red;
            this._totalLabel.Location = new System.Drawing.Point(862, 782);
            this._totalLabel.Name = "_totalLabel";
            this._totalLabel.Size = new System.Drawing.Size(243, 40);
            this._totalLabel.TabIndex = 4;
            this._totalLabel.Text = "Tatal : 0 NTD";
            // 
            // _mealGroupBox
            // 
            this._mealGroupBox.Controls.Add(this._mealDescriptionRichTextBox);
            this._mealGroupBox.Controls.Add(this._mealTableLayoutPanel);
            this._mealGroupBox.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._mealGroupBox.Location = new System.Drawing.Point(12, 30);
            this._mealGroupBox.Name = "_mealGroupBox";
            this._mealGroupBox.Size = new System.Drawing.Size(830, 728);
            this._mealGroupBox.TabIndex = 5;
            this._mealGroupBox.TabStop = false;
            this._mealGroupBox.Text = "Meal";
            // 
            // _mealDescriptionRichTextBox
            // 
            this._mealDescriptionRichTextBox.Location = new System.Drawing.Point(18, 564);
            this._mealDescriptionRichTextBox.Name = "_mealDescriptionRichTextBox";
            this._mealDescriptionRichTextBox.ReadOnly = true;
            this._mealDescriptionRichTextBox.Size = new System.Drawing.Size(792, 159);
            this._mealDescriptionRichTextBox.TabIndex = 1;
            this._mealDescriptionRichTextBox.Text = "";
            // 
            // _mealTableLayoutPanel
            // 
            this._mealTableLayoutPanel.ColumnCount = 3;
            this._mealTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.73585F));
            this._mealTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.26415F));
            this._mealTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this._mealTableLayoutPanel.Location = new System.Drawing.Point(18, 55);
            this._mealTableLayoutPanel.Name = "_mealTableLayoutPanel";
            this._mealTableLayoutPanel.RowCount = 3;
            this._mealTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.70588F));
            this._mealTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.29412F));
            this._mealTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this._mealTableLayoutPanel.Size = new System.Drawing.Size(790, 503);
            this._mealTableLayoutPanel.TabIndex = 0;
            // 
            // _deleteColumn
            // 
            this._deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._deleteColumn.Frozen = true;
            this._deleteColumn.HeaderText = "Delete";
            this._deleteColumn.Name = "_deleteColumn";
            this._deleteColumn.ReadOnly = true;
            this._deleteColumn.Width = 113;
            // 
            // _name
            // 
            this._name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._name.Frozen = true;
            this._name.HeaderText = "Name";
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this._name.Width = 114;
            // 
            // _unitPrice
            // 
            this._unitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._unitPrice.Frozen = true;
            this._unitPrice.HeaderText = "Unit Price";
            this._unitPrice.Name = "_unitPrice";
            this._unitPrice.ReadOnly = true;
            this._unitPrice.Width = 113;
            // 
            // _quantity
            // 
            this._quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this._quantity.Frozen = true;
            this._quantity.HeaderText = "Qty";
            this._quantity.Name = "_quantity";
            this._quantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this._quantity.Width = 114;
            // 
            // _subTotal
            // 
            this._partTotal.HeaderText = "SubTotal";
            this._partTotal.Name = "_subTotal";
            this._partTotal.ReadOnly = true;
            // 
            // OrderSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 839);
            this.Controls.Add(this._mealGroupBox);
            this.Controls.Add(this._totalLabel);
            this.Controls.Add(this._mealRecordDataGridView);
            this.Controls.Add(this._pageNumberLabel);
            this.Controls.Add(this._nextPageButton);
            this.Controls.Add(this._previousPageButton);
            this.Name = "OrderSystem";
            this.Text = "POS-Customer Side";
            ((System.ComponentModel.ISupportInitialize)(this._mealRecordDataGridView)).EndInit();
            this._mealGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _previousPageButton;
        private System.Windows.Forms.Button _nextPageButton;
        private System.Windows.Forms.Label _pageNumberLabel;
        private System.Windows.Forms.DataGridView _mealRecordDataGridView;
        private System.Windows.Forms.Label _totalLabel;
        private System.Windows.Forms.GroupBox _mealGroupBox;
        private System.Windows.Forms.TableLayoutPanel _mealTableLayoutPanel;
        private System.Windows.Forms.RichTextBox _mealDescriptionRichTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _unitPrice;
        private DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn _quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _partTotal;
    }
}

