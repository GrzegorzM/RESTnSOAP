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
            this.label2.Location = new System.Drawing.Point(391, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numerator:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Denominator:";
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(394, 104);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(100, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // tbNumerator
            // 
            this.tbNumerator.Location = new System.Drawing.Point(394, 72);
            this.tbNumerator.Name = "tbNumerator";
            this.tbNumerator.Size = new System.Drawing.Size(100, 20);
            this.tbNumerator.TabIndex = 7;
            // 
            // tbDenominator
            // 
            this.tbDenominator.Location = new System.Drawing.Point(506, 72);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

