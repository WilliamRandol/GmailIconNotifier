namespace QuickSend
{
    partial class QuickSend
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sendButton = new System.Windows.Forms.Button();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.ccTextBox = new System.Windows.Forms.TextBox();
            this.bccTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.toButton = new System.Windows.Forms.Button();
            this.ccButton = new System.Windows.Forms.Button();
            this.bccButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.attachmentOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.attachButton = new System.Windows.Forms.Button();
            this.attachmentDataGrid = new System.Windows.Forms.DataGridView();
            this.attachmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachmentTable = new System.Data.DataTable();
            this.attachmentPathColumn = new System.Data.DataColumn();
            this.contactTable = new System.Data.DataTable();
            this.contactGridToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toDataGrid = new System.Windows.Forms.DataGridView();
            this.ccDataGrid = new System.Windows.Forms.DataGridView();
            this.bccDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bccDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(414, 474);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send Email";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // toTextBox
            // 
            this.toTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toTextBox.Location = new System.Drawing.Point(69, 12);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(502, 20);
            this.toTextBox.TabIndex = 1;
            // 
            // ccTextBox
            // 
            this.ccTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ccTextBox.Location = new System.Drawing.Point(69, 39);
            this.ccTextBox.Name = "ccTextBox";
            this.ccTextBox.Size = new System.Drawing.Size(502, 20);
            this.ccTextBox.TabIndex = 2;
            // 
            // bccTextBox
            // 
            this.bccTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bccTextBox.Location = new System.Drawing.Point(69, 65);
            this.bccTextBox.Name = "bccTextBox";
            this.bccTextBox.Size = new System.Drawing.Size(502, 20);
            this.bccTextBox.TabIndex = 3;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Location = new System.Drawing.Point(69, 90);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(502, 20);
            this.subjectTextBox.TabIndex = 4;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Location = new System.Drawing.Point(12, 254);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(558, 214);
            this.messageTextBox.TabIndex = 5;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(9, 97);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 9;
            this.subjectLabel.Text = "Subject:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Location = new System.Drawing.Point(12, 238);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 13);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "Message:";
            // 
            // toButton
            // 
            this.toButton.Location = new System.Drawing.Point(12, 10);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(50, 23);
            this.toButton.TabIndex = 11;
            this.toButton.Text = "To:";
            this.toButton.UseVisualStyleBackColor = true;
            this.toButton.Click += new System.EventHandler(this.toButton_Click);
            // 
            // ccButton
            // 
            this.ccButton.Location = new System.Drawing.Point(12, 37);
            this.ccButton.Name = "ccButton";
            this.ccButton.Size = new System.Drawing.Size(50, 23);
            this.ccButton.TabIndex = 12;
            this.ccButton.Text = "CC:";
            this.ccButton.UseVisualStyleBackColor = true;
            this.ccButton.Click += new System.EventHandler(this.ccButton_Click);
            // 
            // bccButton
            // 
            this.bccButton.Location = new System.Drawing.Point(12, 64);
            this.bccButton.Name = "bccButton";
            this.bccButton.Size = new System.Drawing.Size(50, 23);
            this.bccButton.TabIndex = 13;
            this.bccButton.Text = "BCC:";
            this.bccButton.UseVisualStyleBackColor = true;
            this.bccButton.Click += new System.EventHandler(this.bccButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(495, 474);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // attachmentOpenFileDialog
            // 
            this.attachmentOpenFileDialog.Multiselect = true;
            this.attachmentOpenFileDialog.SupportMultiDottedExtensions = true;
            this.attachmentOpenFileDialog.Title = "Add Attachment";
            // 
            // attachButton
            // 
            this.attachButton.BackColor = System.Drawing.Color.Transparent;
            this.attachButton.BackgroundImage = global::Gmail_Integration_Helper.Properties.Resources.paperclip;
            this.attachButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.attachButton.Location = new System.Drawing.Point(12, 115);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(50, 49);
            this.attachButton.TabIndex = 18;
            this.attachButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.attachButton.UseVisualStyleBackColor = true;
            this.attachButton.Click += new System.EventHandler(this.attachButton_Click);
            // 
            // attachmentDataGrid
            // 
            this.attachmentDataGrid.AllowDrop = true;
            this.attachmentDataGrid.AllowUserToAddRows = false;
            this.attachmentDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentDataGrid.AutoGenerateColumns = false;
            this.attachmentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attachmentDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.attachmentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.attachmentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attachmentDataGrid.ColumnHeadersVisible = false;
            this.attachmentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attachmentsDataGridViewTextBoxColumn});
            this.attachmentDataGrid.DataSource = this.attachmentTable;
            this.attachmentDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.attachmentDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.attachmentDataGrid.Location = new System.Drawing.Point(70, 116);
            this.attachmentDataGrid.Name = "attachmentDataGrid";
            this.attachmentDataGrid.RowHeadersVisible = false;
            this.attachmentDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.attachmentDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attachmentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attachmentDataGrid.ShowCellErrors = false;
            this.attachmentDataGrid.Size = new System.Drawing.Size(500, 114);
            this.attachmentDataGrid.TabIndex = 19;
            this.attachmentDataGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.attachmentGridView_DragEnter);
            this.attachmentDataGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.attachmentGridView_DragDrop);
            // 
            // attachmentsDataGridViewTextBoxColumn
            // 
            this.attachmentsDataGridViewTextBoxColumn.DataPropertyName = "Attachments";
            this.attachmentsDataGridViewTextBoxColumn.HeaderText = "Attachments";
            this.attachmentsDataGridViewTextBoxColumn.Name = "attachmentsDataGridViewTextBoxColumn";
            // 
            // attachmentTable
            // 
            this.attachmentTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.attachmentPathColumn});
            this.attachmentTable.TableName = "Attachments";
            // 
            // attachmentPathColumn
            // 
            this.attachmentPathColumn.AllowDBNull = false;
            this.attachmentPathColumn.ColumnName = "Attachments";
            this.attachmentPathColumn.DefaultValue = "Add an attachment.";
            // 
            // toDataGrid
            // 
            this.toDataGrid.AllowUserToAddRows = false;
            this.toDataGrid.AllowUserToDeleteRows = false;
            this.toDataGrid.AllowUserToOrderColumns = true;
            this.toDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.toDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.toDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.toDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.toDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.toDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.toDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.toDataGrid.GridColor = System.Drawing.SystemColors.Window;
            this.toDataGrid.Location = new System.Drawing.Point(70, 31);
            this.toDataGrid.MultiSelect = false;
            this.toDataGrid.Name = "toDataGrid";
            this.toDataGrid.ReadOnly = true;
            this.toDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.toDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.toDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toDataGrid.ShowCellErrors = false;
            this.toDataGrid.ShowCellToolTips = false;
            this.toDataGrid.ShowEditingIcon = false;
            this.toDataGrid.ShowRowErrors = false;
            this.toDataGrid.Size = new System.Drawing.Size(501, 437);
            this.toDataGrid.TabIndex = 20;
            this.toDataGrid.Visible = false;
            this.toDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.toDataGrid.Leave += new System.EventHandler(this.dataGridView_Leave);
            this.toDataGrid.MouseHover += new System.EventHandler(this.dataGridView_MouseHover);
            // 
            // ccDataGrid
            // 
            this.ccDataGrid.AllowUserToAddRows = false;
            this.ccDataGrid.AllowUserToDeleteRows = false;
            this.ccDataGrid.AllowUserToOrderColumns = true;
            this.ccDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ccDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ccDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ccDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ccDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ccDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ccDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ccDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ccDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ccDataGrid.GridColor = System.Drawing.SystemColors.Window;
            this.ccDataGrid.Location = new System.Drawing.Point(70, 58);
            this.ccDataGrid.Name = "ccDataGrid";
            this.ccDataGrid.ReadOnly = true;
            this.ccDataGrid.RowHeadersVisible = false;
            this.ccDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ccDataGrid.ShowCellErrors = false;
            this.ccDataGrid.ShowCellToolTips = false;
            this.ccDataGrid.ShowEditingIcon = false;
            this.ccDataGrid.ShowRowErrors = false;
            this.ccDataGrid.Size = new System.Drawing.Size(501, 410);
            this.ccDataGrid.TabIndex = 21;
            this.ccDataGrid.Visible = false;
            this.ccDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.ccDataGrid.Leave += new System.EventHandler(this.dataGridView_Leave);
            this.ccDataGrid.MouseHover += new System.EventHandler(this.dataGridView_MouseHover);
            // 
            // bccDataGrid
            // 
            this.bccDataGrid.AllowUserToAddRows = false;
            this.bccDataGrid.AllowUserToDeleteRows = false;
            this.bccDataGrid.AllowUserToOrderColumns = true;
            this.bccDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.bccDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bccDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bccDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bccDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.bccDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.bccDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bccDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bccDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bccDataGrid.GridColor = System.Drawing.SystemColors.Window;
            this.bccDataGrid.Location = new System.Drawing.Point(70, 83);
            this.bccDataGrid.Name = "bccDataGrid";
            this.bccDataGrid.ReadOnly = true;
            this.bccDataGrid.RowHeadersVisible = false;
            this.bccDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bccDataGrid.ShowCellErrors = false;
            this.bccDataGrid.ShowCellToolTips = false;
            this.bccDataGrid.ShowEditingIcon = false;
            this.bccDataGrid.ShowRowErrors = false;
            this.bccDataGrid.Size = new System.Drawing.Size(501, 385);
            this.bccDataGrid.TabIndex = 22;
            this.bccDataGrid.Visible = false;
            this.bccDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.bccDataGrid.Leave += new System.EventHandler(this.dataGridView_Leave);
            this.bccDataGrid.MouseHover += new System.EventHandler(this.dataGridView_MouseHover);
            // 
            // QuickSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(583, 509);
            this.Controls.Add(this.bccDataGrid);
            this.Controls.Add(this.ccDataGrid);
            this.Controls.Add(this.toDataGrid);
            this.Controls.Add(this.attachmentDataGrid);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.bccButton);
            this.Controls.Add(this.ccButton);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.bccTextBox);
            this.Controls.Add(this.ccTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.sendButton);
            this.Icon = global::Gmail_Integration_Helper.Properties.Resources.gmail;
            this.MinimumSize = new System.Drawing.Size(197, 400);
            this.Name = "QuickSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send to Gmail recipient";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.attachmentGridView_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.attachmentGridView_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.attachmentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bccDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox ccTextBox;
        private System.Windows.Forms.TextBox bccTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.Button ccButton;
        private System.Windows.Forms.Button bccButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.OpenFileDialog attachmentOpenFileDialog;
        private System.Windows.Forms.DataGridView attachmentDataGrid;
        private System.Data.DataTable attachmentTable;
        private System.Data.DataColumn attachmentPathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView toDataGrid;
        private System.Windows.Forms.DataGridView ccDataGrid;
        private System.Windows.Forms.DataGridView bccDataGrid;
        private System.Windows.Forms.ToolTip contactGridToolTip;
        private System.Data.DataTable contactTable;
        private string user;
        private string pass;
        private string email;
    }
}