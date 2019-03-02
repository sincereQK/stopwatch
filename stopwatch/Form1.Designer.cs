namespace stopwatch
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
            this.components = new System.ComponentModel.Container();
            this.lblST = new System.Windows.Forms.Label();
            this.buttStart = new System.Windows.Forms.Button();
            this.buttCancel = new System.Windows.Forms.Button();
            this.timerST = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblST
            // 
            this.lblST.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblST.Font = new System.Drawing.Font("굴림", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblST.ForeColor = System.Drawing.SystemColors.Control;
            this.lblST.Location = new System.Drawing.Point(32, 84);
            this.lblST.Name = "lblST";
            this.lblST.Size = new System.Drawing.Size(481, 82);
            this.lblST.TabIndex = 0;
            this.lblST.Text = "00:00:00.0000000";
            this.lblST.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttStart
            // 
            this.buttStart.BackColor = System.Drawing.Color.Lavender;
            this.buttStart.Location = new System.Drawing.Point(542, 84);
            this.buttStart.Name = "buttStart";
            this.buttStart.Size = new System.Drawing.Size(109, 38);
            this.buttStart.TabIndex = 1;
            this.buttStart.Text = "Start";
            this.buttStart.UseVisualStyleBackColor = false;
            this.buttStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttCancel
            // 
            this.buttCancel.BackColor = System.Drawing.Color.Red;
            this.buttCancel.Location = new System.Drawing.Point(542, 128);
            this.buttCancel.Name = "buttCancel";
            this.buttCancel.Size = new System.Drawing.Size(109, 38);
            this.buttCancel.TabIndex = 2;
            this.buttCancel.Text = "Cancel";
            this.buttCancel.UseVisualStyleBackColor = false;
            // 
            // timerST
            // 
            this.timerST.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 495);
            this.Controls.Add(this.buttCancel);
            this.Controls.Add(this.buttStart);
            this.Controls.Add(this.lblST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblST;
        private System.Windows.Forms.Button buttStart;
        private System.Windows.Forms.Button buttCancel;
        private System.Windows.Forms.Timer timerST;
    }
}

