namespace ClientWindowsForms
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblGetMessageResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.tbNumerator = new System.Windows.Forms.TextBox();
            this.tbDenominator = new System.Windows.Forms.TextBox();
            this.lblResultDivide = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonRequestReplyOperation = new System.Windows.Forms.Button();
            this.buttonRequestReplyOperationThrowException = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRequestReplyOperationAsync = new System.Windows.Forms.Button();
            this.buttonOneWayOperation = new System.Windows.Forms.Button();
            this.buttonOneWayOperation_ThrowsException = new System.Windows.Forms.Button();
            this.buttonProcessReport = new System.Windows.Forms.Button();
            this.textBoxProgress = new System.Windows.Forms.TextBox();
            this.buttonDownloadFile = new System.Windows.Forms.Button();
            this.buttonServiceBehavior = new System.Windows.Forms.Button();
            this.buttonSessionId = new System.Windows.Forms.Button();
            this.buttonGetEvenNumbers = new System.Windows.Forms.Button();
            this.buttonOddNumbers = new System.Windows.Forms.Button();
            this.listBoxEvenNumbers = new System.Windows.Forms.ListBox();
            this.listBoxOddNumbers = new System.Windows.Forms.ListBox();
            this.buttonClearResults = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.buttonProcessReportReentrant = new System.Windows.Forms.Button();
            this.textBoxProgressReentrant = new System.Windows.Forms.TextBox();
            this.buttonDoWork = new System.Windows.Forms.Button();
            this.buttonGetMessage = new System.Windows.Forms.Button();
            this.buttonGetSignedMessage = new System.Windows.Forms.Button();
            this.buttonGetSignedEncryptedMessage = new System.Windows.Forms.Button();
            this.buttonAuthentication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(56, 85);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(109, 42);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Get Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(127, 39);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // lblGetMessageResult
            // 
            this.lblGetMessageResult.AutoSize = true;
            this.lblGetMessageResult.Location = new System.Drawing.Point(427, 97);
            this.lblGetMessageResult.Name = "lblGetMessageResult";
            this.lblGetMessageResult.Size = new System.Drawing.Size(0, 13);
            this.lblGetMessageResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numerator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Denominator:";
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(484, 51);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // tbNumerator
            // 
            this.tbNumerator.Location = new System.Drawing.Point(430, 25);
            this.tbNumerator.Name = "tbNumerator";
            this.tbNumerator.Size = new System.Drawing.Size(100, 20);
            this.tbNumerator.TabIndex = 7;
            // 
            // tbDenominator
            // 
            this.tbDenominator.Location = new System.Drawing.Point(539, 25);
            this.tbDenominator.Name = "tbDenominator";
            this.tbDenominator.Size = new System.Drawing.Size(100, 20);
            this.tbDenominator.TabIndex = 8;
            // 
            // lblResultDivide
            // 
            this.lblResultDivide.AutoSize = true;
            this.lblResultDivide.Location = new System.Drawing.Point(506, 104);
            this.lblResultDivide.Name = "lblResultDivide";
            this.lblResultDivide.Size = new System.Drawing.Size(0, 13);
            this.lblResultDivide.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(654, 147);
            this.listBox1.TabIndex = 10;
            // 
            // buttonRequestReplyOperation
            // 
            this.buttonRequestReplyOperation.Location = new System.Drawing.Point(56, 357);
            this.buttonRequestReplyOperation.Name = "buttonRequestReplyOperation";
            this.buttonRequestReplyOperation.Size = new System.Drawing.Size(234, 23);
            this.buttonRequestReplyOperation.TabIndex = 11;
            this.buttonRequestReplyOperation.Text = "Request Reply Operation";
            this.buttonRequestReplyOperation.UseVisualStyleBackColor = true;
            this.buttonRequestReplyOperation.Click += new System.EventHandler(this.buttonRequestReplyOperation_Click);
            // 
            // buttonRequestReplyOperationThrowException
            // 
            this.buttonRequestReplyOperationThrowException.Location = new System.Drawing.Point(56, 386);
            this.buttonRequestReplyOperationThrowException.Name = "buttonRequestReplyOperationThrowException";
            this.buttonRequestReplyOperationThrowException.Size = new System.Drawing.Size(234, 23);
            this.buttonRequestReplyOperationThrowException.TabIndex = 12;
            this.buttonRequestReplyOperationThrowException.Text = "Request Reply Operation - Throw Exception";
            this.buttonRequestReplyOperationThrowException.UseVisualStyleBackColor = true;
            this.buttonRequestReplyOperationThrowException.Click += new System.EventHandler(this.buttonRequestReplyOperationThrowException_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(56, 415);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(234, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRequestReplyOperationAsync
            // 
            this.buttonRequestReplyOperationAsync.Location = new System.Drawing.Point(296, 357);
            this.buttonRequestReplyOperationAsync.Name = "buttonRequestReplyOperationAsync";
            this.buttonRequestReplyOperationAsync.Size = new System.Drawing.Size(210, 23);
            this.buttonRequestReplyOperationAsync.TabIndex = 14;
            this.buttonRequestReplyOperationAsync.Text = "Request Reply Operation Async";
            this.buttonRequestReplyOperationAsync.UseVisualStyleBackColor = true;
            this.buttonRequestReplyOperationAsync.Click += new System.EventHandler(this.buttonRequestReplyOperationAsync_ClickAsync);
            // 
            // buttonOneWayOperation
            // 
            this.buttonOneWayOperation.Location = new System.Drawing.Point(296, 386);
            this.buttonOneWayOperation.Name = "buttonOneWayOperation";
            this.buttonOneWayOperation.Size = new System.Drawing.Size(210, 23);
            this.buttonOneWayOperation.TabIndex = 15;
            this.buttonOneWayOperation.Text = "One Way Operation";
            this.buttonOneWayOperation.UseVisualStyleBackColor = true;
            this.buttonOneWayOperation.Click += new System.EventHandler(this.buttonOneWayOperation_Click);
            // 
            // buttonOneWayOperation_ThrowsException
            // 
            this.buttonOneWayOperation_ThrowsException.Location = new System.Drawing.Point(296, 415);
            this.buttonOneWayOperation_ThrowsException.Name = "buttonOneWayOperation_ThrowsException";
            this.buttonOneWayOperation_ThrowsException.Size = new System.Drawing.Size(210, 23);
            this.buttonOneWayOperation_ThrowsException.TabIndex = 16;
            this.buttonOneWayOperation_ThrowsException.Text = "One Way Operation - Throws Exception";
            this.buttonOneWayOperation_ThrowsException.UseVisualStyleBackColor = true;
            this.buttonOneWayOperation_ThrowsException.Click += new System.EventHandler(this.buttonOneWayOperation_ThrowsException_Click);
            // 
            // buttonProcessReport
            // 
            this.buttonProcessReport.Location = new System.Drawing.Point(626, 72);
            this.buttonProcessReport.Name = "buttonProcessReport";
            this.buttonProcessReport.Size = new System.Drawing.Size(110, 23);
            this.buttonProcessReport.TabIndex = 17;
            this.buttonProcessReport.Text = "Process Report";
            this.buttonProcessReport.UseVisualStyleBackColor = true;
            this.buttonProcessReport.Click += new System.EventHandler(this.buttonProcessReport_Click);
            // 
            // textBoxProgress
            // 
            this.textBoxProgress.Location = new System.Drawing.Point(626, 101);
            this.textBoxProgress.Name = "textBoxProgress";
            this.textBoxProgress.Size = new System.Drawing.Size(110, 20);
            this.textBoxProgress.TabIndex = 18;
            // 
            // buttonDownloadFile
            // 
            this.buttonDownloadFile.Location = new System.Drawing.Point(626, 151);
            this.buttonDownloadFile.Name = "buttonDownloadFile";
            this.buttonDownloadFile.Size = new System.Drawing.Size(110, 23);
            this.buttonDownloadFile.TabIndex = 19;
            this.buttonDownloadFile.Text = "Download File";
            this.buttonDownloadFile.UseVisualStyleBackColor = true;
            this.buttonDownloadFile.Click += new System.EventHandler(this.buttonDownloadFile_Click);
            // 
            // buttonServiceBehavior
            // 
            this.buttonServiceBehavior.Location = new System.Drawing.Point(523, 357);
            this.buttonServiceBehavior.Name = "buttonServiceBehavior";
            this.buttonServiceBehavior.Size = new System.Drawing.Size(187, 23);
            this.buttonServiceBehavior.TabIndex = 20;
            this.buttonServiceBehavior.Text = "Per Call / Per Session / Single";
            this.buttonServiceBehavior.UseVisualStyleBackColor = true;
            this.buttonServiceBehavior.Click += new System.EventHandler(this.buttonServiceBehavior_Click);
            // 
            // buttonSessionId
            // 
            this.buttonSessionId.Location = new System.Drawing.Point(523, 386);
            this.buttonSessionId.Name = "buttonSessionId";
            this.buttonSessionId.Size = new System.Drawing.Size(187, 23);
            this.buttonSessionId.TabIndex = 21;
            this.buttonSessionId.Text = "Retrive SessionId";
            this.buttonSessionId.UseVisualStyleBackColor = true;
            this.buttonSessionId.Click += new System.EventHandler(this.buttonSessionId_Click);
            // 
            // buttonGetEvenNumbers
            // 
            this.buttonGetEvenNumbers.Location = new System.Drawing.Point(216, 68);
            this.buttonGetEvenNumbers.Name = "buttonGetEvenNumbers";
            this.buttonGetEvenNumbers.Size = new System.Drawing.Size(117, 23);
            this.buttonGetEvenNumbers.TabIndex = 22;
            this.buttonGetEvenNumbers.Text = "Get Even Numbers";
            this.buttonGetEvenNumbers.UseVisualStyleBackColor = true;
            this.buttonGetEvenNumbers.Click += new System.EventHandler(this.buttonGetEvenNumbers_Click);
            // 
            // buttonOddNumbers
            // 
            this.buttonOddNumbers.Location = new System.Drawing.Point(339, 68);
            this.buttonOddNumbers.Name = "buttonOddNumbers";
            this.buttonOddNumbers.Size = new System.Drawing.Size(120, 23);
            this.buttonOddNumbers.TabIndex = 23;
            this.buttonOddNumbers.Text = "Get Odd Numbers";
            this.buttonOddNumbers.UseVisualStyleBackColor = true;
            this.buttonOddNumbers.Click += new System.EventHandler(this.buttonOddNumbers_Click);
            // 
            // listBoxEvenNumbers
            // 
            this.listBoxEvenNumbers.FormattingEnabled = true;
            this.listBoxEvenNumbers.Location = new System.Drawing.Point(216, 97);
            this.listBoxEvenNumbers.Name = "listBoxEvenNumbers";
            this.listBoxEvenNumbers.Size = new System.Drawing.Size(117, 82);
            this.listBoxEvenNumbers.TabIndex = 24;
            // 
            // listBoxOddNumbers
            // 
            this.listBoxOddNumbers.FormattingEnabled = true;
            this.listBoxOddNumbers.Location = new System.Drawing.Point(339, 97);
            this.listBoxOddNumbers.Name = "listBoxOddNumbers";
            this.listBoxOddNumbers.Size = new System.Drawing.Size(120, 82);
            this.listBoxOddNumbers.TabIndex = 25;
            // 
            // buttonClearResults
            // 
            this.buttonClearResults.Location = new System.Drawing.Point(216, 180);
            this.buttonClearResults.Name = "buttonClearResults";
            this.buttonClearResults.Size = new System.Drawing.Size(243, 21);
            this.buttonClearResults.TabIndex = 26;
            this.buttonClearResults.Text = "Clear Result";
            this.buttonClearResults.UseVisualStyleBackColor = true;
            this.buttonClearResults.Click += new System.EventHandler(this.buttonClearResults_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // buttonProcessReportReentrant
            // 
            this.buttonProcessReportReentrant.Location = new System.Drawing.Point(771, 22);
            this.buttonProcessReportReentrant.Name = "buttonProcessReportReentrant";
            this.buttonProcessReportReentrant.Size = new System.Drawing.Size(141, 23);
            this.buttonProcessReportReentrant.TabIndex = 27;
            this.buttonProcessReportReentrant.Text = "Process Report Reentrant";
            this.buttonProcessReportReentrant.UseVisualStyleBackColor = true;
            this.buttonProcessReportReentrant.Click += new System.EventHandler(this.buttonProcessReportReentrant_Click);
            // 
            // textBoxProgressReentrant
            // 
            this.textBoxProgressReentrant.Location = new System.Drawing.Point(771, 51);
            this.textBoxProgressReentrant.Name = "textBoxProgressReentrant";
            this.textBoxProgressReentrant.Size = new System.Drawing.Size(141, 20);
            this.textBoxProgressReentrant.TabIndex = 28;
            // 
            // buttonDoWork
            // 
            this.buttonDoWork.Location = new System.Drawing.Point(771, 92);
            this.buttonDoWork.Name = "buttonDoWork";
            this.buttonDoWork.Size = new System.Drawing.Size(75, 23);
            this.buttonDoWork.TabIndex = 29;
            this.buttonDoWork.Text = "Do Work";
            this.buttonDoWork.UseVisualStyleBackColor = true;
            this.buttonDoWork.Click += new System.EventHandler(this.buttonDoWork_Click);
            // 
            // buttonGetMessage
            // 
            this.buttonGetMessage.Location = new System.Drawing.Point(771, 132);
            this.buttonGetMessage.Name = "buttonGetMessage";
            this.buttonGetMessage.Size = new System.Drawing.Size(248, 23);
            this.buttonGetMessage.TabIndex = 30;
            this.buttonGetMessage.Text = "Get Message - Not Signed and Not Encrypted";
            this.buttonGetMessage.UseVisualStyleBackColor = true;
            this.buttonGetMessage.Click += new System.EventHandler(this.buttonGetMessage_Click);
            // 
            // buttonGetSignedMessage
            // 
            this.buttonGetSignedMessage.Location = new System.Drawing.Point(771, 161);
            this.buttonGetSignedMessage.Name = "buttonGetSignedMessage";
            this.buttonGetSignedMessage.Size = new System.Drawing.Size(248, 23);
            this.buttonGetSignedMessage.TabIndex = 31;
            this.buttonGetSignedMessage.Text = "Get Message - Signed but Not Encrypted";
            this.buttonGetSignedMessage.UseVisualStyleBackColor = true;
            this.buttonGetSignedMessage.Click += new System.EventHandler(this.buttonGetSignedMessage_Click);
            // 
            // buttonGetSignedEncryptedMessage
            // 
            this.buttonGetSignedEncryptedMessage.Location = new System.Drawing.Point(771, 190);
            this.buttonGetSignedEncryptedMessage.Name = "buttonGetSignedEncryptedMessage";
            this.buttonGetSignedEncryptedMessage.Size = new System.Drawing.Size(248, 23);
            this.buttonGetSignedEncryptedMessage.TabIndex = 32;
            this.buttonGetSignedEncryptedMessage.Text = "Get Message - Signed and Encrypted";
            this.buttonGetSignedEncryptedMessage.UseVisualStyleBackColor = true;
            this.buttonGetSignedEncryptedMessage.Click += new System.EventHandler(this.buttonGetSignedEncryptedMessage_Click);
            // 
            // buttonAuthentication
            // 
            this.buttonAuthentication.Location = new System.Drawing.Point(771, 241);
            this.buttonAuthentication.Name = "buttonAuthentication";
            this.buttonAuthentication.Size = new System.Drawing.Size(130, 23);
            this.buttonAuthentication.TabIndex = 33;
            this.buttonAuthentication.Text = "Authentication WCF";
            this.buttonAuthentication.UseVisualStyleBackColor = true;
            this.buttonAuthentication.Click += new System.EventHandler(this.buttonAuthentication_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.buttonAuthentication);
            this.Controls.Add(this.buttonGetSignedEncryptedMessage);
            this.Controls.Add(this.buttonGetSignedMessage);
            this.Controls.Add(this.buttonGetMessage);
            this.Controls.Add(this.buttonDoWork);
            this.Controls.Add(this.textBoxProgressReentrant);
            this.Controls.Add(this.buttonProcessReportReentrant);
            this.Controls.Add(this.buttonClearResults);
            this.Controls.Add(this.listBoxOddNumbers);
            this.Controls.Add(this.listBoxEvenNumbers);
            this.Controls.Add(this.buttonOddNumbers);
            this.Controls.Add(this.buttonGetEvenNumbers);
            this.Controls.Add(this.buttonSessionId);
            this.Controls.Add(this.buttonServiceBehavior);
            this.Controls.Add(this.buttonDownloadFile);
            this.Controls.Add(this.textBoxProgress);
            this.Controls.Add(this.buttonProcessReport);
            this.Controls.Add(this.buttonOneWayOperation_ThrowsException);
            this.Controls.Add(this.buttonOneWayOperation);
            this.Controls.Add(this.buttonRequestReplyOperationAsync);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRequestReplyOperationThrowException);
            this.Controls.Add(this.buttonRequestReplyOperation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblResultDivide);
            this.Controls.Add(this.tbDenominator);
            this.Controls.Add(this.tbNumerator);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGetMessageResult);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblGetMessageResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox tbNumerator;
        private System.Windows.Forms.TextBox tbDenominator;
        private System.Windows.Forms.Label lblResultDivide;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonRequestReplyOperation;
        private System.Windows.Forms.Button buttonRequestReplyOperationThrowException;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRequestReplyOperationAsync;
        private System.Windows.Forms.Button buttonOneWayOperation;
        private System.Windows.Forms.Button buttonOneWayOperation_ThrowsException;
        private System.Windows.Forms.Button buttonProcessReport;
        private System.Windows.Forms.TextBox textBoxProgress;
        private System.Windows.Forms.Button buttonDownloadFile;
        private System.Windows.Forms.Button buttonServiceBehavior;
        private System.Windows.Forms.Button buttonSessionId;
        private System.Windows.Forms.Button buttonGetEvenNumbers;
        private System.Windows.Forms.Button buttonOddNumbers;
        private System.Windows.Forms.ListBox listBoxEvenNumbers;
        private System.Windows.Forms.ListBox listBoxOddNumbers;
        private System.Windows.Forms.Button buttonClearResults;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button buttonProcessReportReentrant;
        private System.Windows.Forms.TextBox textBoxProgressReentrant;
        private System.Windows.Forms.Button buttonDoWork;
        private System.Windows.Forms.Button buttonGetMessage;
        private System.Windows.Forms.Button buttonGetSignedMessage;
        private System.Windows.Forms.Button buttonGetSignedEncryptedMessage;
        private System.Windows.Forms.Button buttonAuthentication;
    }
}

