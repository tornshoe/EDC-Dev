namespace EDC
{
    partial class FormRequest
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxExt = new System.Windows.Forms.TextBox();
            this.textBoxContractNum = new System.Windows.Forms.TextBox();
            this.labelReqDate = new System.Windows.Forms.Label();
            this.textBoxReqDate = new System.Windows.Forms.TextBox();
            this.labelStoreNum = new System.Windows.Forms.Label();
            this.textBoxStoreNum = new System.Windows.Forms.TextBox();
            this.labelCustName = new System.Windows.Forms.Label();
            this.labelCustSSN = new System.Windows.Forms.Label();
            this.labelCheckNum = new System.Windows.Forms.Label();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.textBoxCheckNum = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCustSSN = new System.Windows.Forms.MaskedTextBox();
            this.labelReqBy = new System.Windows.Forms.Label();
            this.labelContractNum = new System.Windows.Forms.Label();
            this.labelExt = new System.Windows.Forms.Label();
            this.labelUrgent = new System.Windows.Forms.Label();
            this.textBoxReqBy = new System.Windows.Forms.TextBox();
            this.checkBoxUrgent = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDesAct = new System.Windows.Forms.TextBox();
            this.labelProblem = new System.Windows.Forms.Label();
            this.labelDesAct = new System.Windows.Forms.Label();
            this.textBoxProblem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubmitReq = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1438, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(290, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(856, 60);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Enter Data Correction Requests";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxExt, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxContractNum, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelReqDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxReqDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelStoreNum, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxStoreNum, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelCustName, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelCustSSN, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelCheckNum, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCustName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxCheckNum, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.maskedTextBoxCustSSN, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelReqBy, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelContractNum, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelExt, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelUrgent, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxReqBy, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxUrgent, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(290, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(856, 234);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBoxExt
            // 
            this.textBoxExt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxExt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt.Enabled = false;
            this.textBoxExt.Location = new System.Drawing.Point(645, 105);
            this.textBoxExt.Name = "textBoxExt";
            this.textBoxExt.ReadOnly = true;
            this.textBoxExt.Size = new System.Drawing.Size(131, 20);
            this.textBoxExt.TabIndex = 17;
            this.textBoxExt.TabStop = false;
            // 
            // textBoxContractNum
            // 
            this.textBoxContractNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxContractNum.Location = new System.Drawing.Point(645, 59);
            this.textBoxContractNum.Name = "textBoxContractNum";
            this.textBoxContractNum.Size = new System.Drawing.Size(131, 20);
            this.textBoxContractNum.TabIndex = 16;
            // 
            // labelReqDate
            // 
            this.labelReqDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelReqDate.AutoSize = true;
            this.labelReqDate.Location = new System.Drawing.Point(138, 16);
            this.labelReqDate.Name = "labelReqDate";
            this.labelReqDate.Size = new System.Drawing.Size(73, 13);
            this.labelReqDate.TabIndex = 0;
            this.labelReqDate.Text = "Request Date";
            // 
            // textBoxReqDate
            // 
            this.textBoxReqDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxReqDate.Enabled = false;
            this.textBoxReqDate.Location = new System.Drawing.Point(217, 13);
            this.textBoxReqDate.Name = "textBoxReqDate";
            this.textBoxReqDate.ReadOnly = true;
            this.textBoxReqDate.Size = new System.Drawing.Size(131, 20);
            this.textBoxReqDate.TabIndex = 1;
            this.textBoxReqDate.TabStop = false;
            // 
            // labelStoreNum
            // 
            this.labelStoreNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStoreNum.AutoSize = true;
            this.labelStoreNum.Location = new System.Drawing.Point(139, 62);
            this.labelStoreNum.Name = "labelStoreNum";
            this.labelStoreNum.Size = new System.Drawing.Size(72, 13);
            this.labelStoreNum.TabIndex = 2;
            this.labelStoreNum.Text = "Store Number";
            // 
            // textBoxStoreNum
            // 
            this.textBoxStoreNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxStoreNum.Location = new System.Drawing.Point(217, 59);
            this.textBoxStoreNum.Name = "textBoxStoreNum";
            this.textBoxStoreNum.Size = new System.Drawing.Size(131, 20);
            this.textBoxStoreNum.TabIndex = 3;
            // 
            // labelCustName
            // 
            this.labelCustName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustName.AutoSize = true;
            this.labelCustName.Location = new System.Drawing.Point(129, 108);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(82, 13);
            this.labelCustName.TabIndex = 4;
            this.labelCustName.Text = "Customer Name";
            // 
            // labelCustSSN
            // 
            this.labelCustSSN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustSSN.AutoSize = true;
            this.labelCustSSN.Location = new System.Drawing.Point(135, 154);
            this.labelCustSSN.Name = "labelCustSSN";
            this.labelCustSSN.Size = new System.Drawing.Size(76, 13);
            this.labelCustSSN.TabIndex = 5;
            this.labelCustSSN.Text = "Customer SSN";
            // 
            // labelCheckNum
            // 
            this.labelCheckNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCheckNum.AutoSize = true;
            this.labelCheckNum.Location = new System.Drawing.Point(163, 202);
            this.labelCheckNum.Name = "labelCheckNum";
            this.labelCheckNum.Size = new System.Drawing.Size(48, 13);
            this.labelCheckNum.TabIndex = 6;
            this.labelCheckNum.Text = "Check #";
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCustName.Location = new System.Drawing.Point(217, 105);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(131, 20);
            this.textBoxCustName.TabIndex = 7;
            // 
            // textBoxCheckNum
            // 
            this.textBoxCheckNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCheckNum.Location = new System.Drawing.Point(217, 199);
            this.textBoxCheckNum.Name = "textBoxCheckNum";
            this.textBoxCheckNum.Size = new System.Drawing.Size(131, 20);
            this.textBoxCheckNum.TabIndex = 10;
            // 
            // maskedTextBoxCustSSN
            // 
            this.maskedTextBoxCustSSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBoxCustSSN.Location = new System.Drawing.Point(217, 151);
            this.maskedTextBoxCustSSN.Mask = "000-00-0000";
            this.maskedTextBoxCustSSN.Name = "maskedTextBoxCustSSN";
            this.maskedTextBoxCustSSN.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBoxCustSSN.TabIndex = 9;
            // 
            // labelReqBy
            // 
            this.labelReqBy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelReqBy.AutoSize = true;
            this.labelReqBy.Location = new System.Drawing.Point(565, 16);
            this.labelReqBy.Name = "labelReqBy";
            this.labelReqBy.Size = new System.Drawing.Size(74, 13);
            this.labelReqBy.TabIndex = 11;
            this.labelReqBy.Text = "Requested By";
            // 
            // labelContractNum
            // 
            this.labelContractNum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelContractNum.AutoSize = true;
            this.labelContractNum.Location = new System.Drawing.Point(582, 62);
            this.labelContractNum.Name = "labelContractNum";
            this.labelContractNum.Size = new System.Drawing.Size(57, 13);
            this.labelContractNum.TabIndex = 12;
            this.labelContractNum.Text = "Contract #";
            // 
            // labelExt
            // 
            this.labelExt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelExt.AutoSize = true;
            this.labelExt.Location = new System.Drawing.Point(552, 108);
            this.labelExt.Name = "labelExt";
            this.labelExt.Size = new System.Drawing.Size(87, 13);
            this.labelExt.TabIndex = 13;
            this.labelExt.Text = "Phone Extension";
            // 
            // labelUrgent
            // 
            this.labelUrgent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUrgent.AutoSize = true;
            this.labelUrgent.Location = new System.Drawing.Point(600, 154);
            this.labelUrgent.Name = "labelUrgent";
            this.labelUrgent.Size = new System.Drawing.Size(39, 13);
            this.labelUrgent.TabIndex = 14;
            this.labelUrgent.Text = "Urgent";
            // 
            // textBoxReqBy
            // 
            this.textBoxReqBy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxReqBy.Enabled = false;
            this.textBoxReqBy.Location = new System.Drawing.Point(645, 13);
            this.textBoxReqBy.Name = "textBoxReqBy";
            this.textBoxReqBy.ReadOnly = true;
            this.textBoxReqBy.Size = new System.Drawing.Size(131, 20);
            this.textBoxReqBy.TabIndex = 15;
            this.textBoxReqBy.TabStop = false;
            // 
            // checkBoxUrgent
            // 
            this.checkBoxUrgent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxUrgent.AutoSize = true;
            this.checkBoxUrgent.Location = new System.Drawing.Point(645, 154);
            this.checkBoxUrgent.Name = "checkBoxUrgent";
            this.checkBoxUrgent.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUrgent.TabIndex = 18;
            this.checkBoxUrgent.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxDesAct, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelProblem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelDesAct, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxProblem, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(290, 303);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(856, 294);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // textBoxDesAct
            // 
            this.textBoxDesAct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDesAct.Location = new System.Drawing.Point(217, 120);
            this.textBoxDesAct.Multiline = true;
            this.textBoxDesAct.Name = "textBoxDesAct";
            this.textBoxDesAct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDesAct.Size = new System.Drawing.Size(559, 111);
            this.textBoxDesAct.TabIndex = 3;
            // 
            // labelProblem
            // 
            this.labelProblem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelProblem.AutoSize = true;
            this.labelProblem.Location = new System.Drawing.Point(166, 52);
            this.labelProblem.Name = "labelProblem";
            this.labelProblem.Size = new System.Drawing.Size(45, 13);
            this.labelProblem.TabIndex = 0;
            this.labelProblem.Text = "Problem";
            // 
            // labelDesAct
            // 
            this.labelDesAct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDesAct.AutoSize = true;
            this.labelDesAct.Location = new System.Drawing.Point(135, 169);
            this.labelDesAct.Name = "labelDesAct";
            this.labelDesAct.Size = new System.Drawing.Size(76, 13);
            this.labelDesAct.TabIndex = 1;
            this.labelDesAct.Text = "Desired Action";
            // 
            // textBoxProblem
            // 
            this.textBoxProblem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxProblem.Location = new System.Drawing.Point(217, 3);
            this.textBoxProblem.Multiline = true;
            this.textBoxProblem.Name = "textBoxProblem";
            this.textBoxProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxProblem.Size = new System.Drawing.Size(559, 111);
            this.textBoxProblem.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonSubmitReq, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonExit, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(217, 237);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(636, 54);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // buttonSubmitReq
            // 
            this.buttonSubmitReq.AutoSize = true;
            this.buttonSubmitReq.Location = new System.Drawing.Point(3, 3);
            this.buttonSubmitReq.Name = "buttonSubmitReq";
            this.buttonSubmitReq.Size = new System.Drawing.Size(92, 23);
            this.buttonSubmitReq.TabIndex = 0;
            this.buttonSubmitReq.Text = "Submit Request";
            this.buttonSubmitReq.UseVisualStyleBackColor = true;
            this.buttonSubmitReq.Click += new System.EventHandler(this.buttonSubmitReq_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(321, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1438, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Requests";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelReqDate;
        private System.Windows.Forms.TextBox textBoxReqDate;
        private System.Windows.Forms.Label labelStoreNum;
        private System.Windows.Forms.TextBox textBoxStoreNum;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Label labelCustSSN;
        private System.Windows.Forms.Label labelCheckNum;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.TextBox textBoxCheckNum;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCustSSN;
        private System.Windows.Forms.TextBox textBoxExt;
        private System.Windows.Forms.TextBox textBoxContractNum;
        private System.Windows.Forms.Label labelReqBy;
        private System.Windows.Forms.Label labelContractNum;
        private System.Windows.Forms.Label labelExt;
        private System.Windows.Forms.Label labelUrgent;
        private System.Windows.Forms.TextBox textBoxReqBy;
        private System.Windows.Forms.CheckBox checkBoxUrgent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxDesAct;
        private System.Windows.Forms.Label labelProblem;
        private System.Windows.Forms.Label labelDesAct;
        private System.Windows.Forms.TextBox textBoxProblem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonSubmitReq;
        private System.Windows.Forms.Button buttonExit;
    }
}