namespace WebCam
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnScreenShot = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.axVLCPlayer = new AxAXVLC.AxVLCPlugin2();
            this.btnReplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(209, 527);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnScreenShot
            // 
            this.btnScreenShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnScreenShot.Location = new System.Drawing.Point(543, 527);
            this.btnScreenShot.Name = "btnScreenShot";
            this.btnScreenShot.Size = new System.Drawing.Size(75, 23);
            this.btnScreenShot.TabIndex = 2;
            this.btnScreenShot.Text = "截屏(&C)";
            this.btnScreenShot.UseVisualStyleBackColor = true;
            this.btnScreenShot.Click += new System.EventHandler(this.btnScreenShot_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(376, 527);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // axVLCPlayer
            // 
            this.axVLCPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLCPlayer.Enabled = true;
            this.axVLCPlayer.Location = new System.Drawing.Point(-1, 0);
            this.axVLCPlayer.Name = "axVLCPlayer";
            this.axVLCPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlayer.OcxState")));
            this.axVLCPlayer.Size = new System.Drawing.Size(1008, 519);
            this.axVLCPlayer.TabIndex = 0;
            // 
            // btnReplay
            // 
            this.btnReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplay.Location = new System.Drawing.Point(725, 527);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(75, 23);
            this.btnReplay.TabIndex = 4;
            this.btnReplay.Text = "回放(&R)";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnScreenShot);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.axVLCPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebCamera (by Group607)";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnScreenShot;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReplay;
    }
}

