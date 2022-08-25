
namespace send_Email
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxBody = new System.Windows.Forms.TextBox();
            this.tboxSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucRef = new send_Email.ucAddress();
            this.ucHide = new send_Email.ucAddress();
            this.ucSend = new send_Email.ucAddress();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lboxQueueData = new System.Windows.Forms.ListBox();
            this.lblQueueCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDBSelect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgEMailInfo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEMailInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxBody);
            this.groupBox1.Controls.Add(this.tboxSubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail";
            // 
            // tboxBody
            // 
            this.tboxBody.Location = new System.Drawing.Point(74, 63);
            this.tboxBody.Multiline = true;
            this.tboxBody.Name = "tboxBody";
            this.tboxBody.Size = new System.Drawing.Size(431, 444);
            this.tboxBody.TabIndex = 3;
            // 
            // tboxSubject
            // 
            this.tboxSubject.Location = new System.Drawing.Point(74, 31);
            this.tboxSubject.Name = "tboxSubject";
            this.tboxSubject.Size = new System.Drawing.Size(431, 25);
            this.tboxSubject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Body";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // ucRef
            // 
            this.ucRef.Location = new System.Drawing.Point(537, 223);
            this.ucRef.Name = "ucRef";
            this.ucRef.Size = new System.Drawing.Size(298, 153);
            this.ucRef.TabIndex = 1;
            // 
            // ucHide
            // 
            this.ucHide.Location = new System.Drawing.Point(537, 382);
            this.ucHide.Name = "ucHide";
            this.ucHide.Size = new System.Drawing.Size(298, 153);
            this.ucHide.TabIndex = 2;
            // 
            // ucSend
            // 
            this.ucSend.Location = new System.Drawing.Point(537, 64);
            this.ucSend.Name = "ucSend";
            this.ucSend.Size = new System.Drawing.Size(298, 153);
            this.ucSend.TabIndex = 3;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(537, 25);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(289, 33);
            this.btnSendMail.TabIndex = 4;
            this.btnSendMail.Text = "Mail Send (DB 저장)";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboxQueueData);
            this.groupBox2.Controls.Add(this.lblQueueCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(833, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 258);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Queue Status";
            // 
            // lboxQueueData
            // 
            this.lboxQueueData.FormattingEnabled = true;
            this.lboxQueueData.ItemHeight = 15;
            this.lboxQueueData.Location = new System.Drawing.Point(6, 50);
            this.lboxQueueData.Name = "lboxQueueData";
            this.lboxQueueData.Size = new System.Drawing.Size(292, 199);
            this.lboxQueueData.TabIndex = 2;
            // 
            // lblQueueCount
            // 
            this.lblQueueCount.AutoSize = true;
            this.lblQueueCount.Location = new System.Drawing.Point(119, 25);
            this.lblQueueCount.Name = "lblQueueCount";
            this.lblQueueCount.Size = new System.Drawing.Size(15, 15);
            this.lblQueueCount.TabIndex = 1;
            this.lblQueueCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Queue Count: ";
            // 
            // btnDBSelect
            // 
            this.btnDBSelect.Location = new System.Drawing.Point(848, 501);
            this.btnDBSelect.Name = "btnDBSelect";
            this.btnDBSelect.Size = new System.Drawing.Size(289, 33);
            this.btnDBSelect.TabIndex = 6;
            this.btnDBSelect.Text = "DB 조회";
            this.btnDBSelect.UseVisualStyleBackColor = true;
            this.btnDBSelect.Click += new System.EventHandler(this.btnDBSelect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgEMailInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 542);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1125, 297);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "E-Mail Info Data";
            // 
            // dgEMailInfo
            // 
            this.dgEMailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEMailInfo.Location = new System.Drawing.Point(7, 25);
            this.dgEMailInfo.Name = "dgEMailInfo";
            this.dgEMailInfo.RowHeadersWidth = 51;
            this.dgEMailInfo.RowTemplate.Height = 27;
            this.dgEMailInfo.Size = new System.Drawing.Size(1112, 266);
            this.dgEMailInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 851);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDBSelect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.ucSend);
            this.Controls.Add(this.ucHide);
            this.Controls.Add(this.ucRef);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEMailInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxBody;
        private System.Windows.Forms.TextBox tboxSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ucAddress ucRef;
        private ucAddress ucHide;
        private ucAddress ucSend;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblQueueCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxQueueData;
        private System.Windows.Forms.Button btnDBSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgEMailInfo;
    }
}

