
namespace send_Email
{
    partial class ucAddress
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxMain = new System.Windows.Forms.GroupBox();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lboxAddress = new System.Windows.Forms.ListBox();
            this.gboxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMain
            // 
            this.gboxMain.Controls.Add(this.lboxAddress);
            this.gboxMain.Controls.Add(this.btnAdd);
            this.gboxMain.Controls.Add(this.tboxAddress);
            this.gboxMain.Location = new System.Drawing.Point(3, 3);
            this.gboxMain.Name = "gboxMain";
            this.gboxMain.Size = new System.Drawing.Size(331, 176);
            this.gboxMain.TabIndex = 0;
            this.gboxMain.TabStop = false;
            this.gboxMain.Text = "groupBox1";
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(7, 25);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(254, 25);
            this.tboxAddress.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(267, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lboxAddress
            // 
            this.lboxAddress.FormattingEnabled = true;
            this.lboxAddress.ItemHeight = 15;
            this.lboxAddress.Location = new System.Drawing.Point(7, 56);
            this.lboxAddress.Name = "lboxAddress";
            this.lboxAddress.Size = new System.Drawing.Size(318, 109);
            this.lboxAddress.TabIndex = 2;
            this.lboxAddress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lboxAddress_MouseDoubleClick);
            // 
            // ucAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gboxMain);
            this.Name = "ucAddress";
            this.Size = new System.Drawing.Size(338, 182);
            this.gboxMain.ResumeLayout(false);
            this.gboxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMain;
        private System.Windows.Forms.ListBox lboxAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxAddress;
    }
}
