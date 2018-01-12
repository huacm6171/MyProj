namespace WebCam
{
    partial class Replay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replay));
            this.videoList = new System.Windows.Forms.ListView();
            this.axVLCReplay = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCReplay)).BeginInit();
            this.SuspendLayout();
            // 
            // videoList
            // 
            this.videoList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.videoList.FullRowSelect = true;
            this.videoList.GridLines = true;
            this.videoList.Location = new System.Drawing.Point(0, -1);
            this.videoList.MultiSelect = false;
            this.videoList.Name = "videoList";
            this.videoList.Size = new System.Drawing.Size(165, 560);
            this.videoList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.videoList.TabIndex = 0;
            this.videoList.UseCompatibleStateImageBehavior = false;
            this.videoList.View = System.Windows.Forms.View.Details;
            this.videoList.SelectedIndexChanged += new System.EventHandler(this.videoList_SelectedIndexChanged);
            this.videoList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.videoList_MouseDoubleClick);
            // 
            // axVLCReplay
            // 
            this.axVLCReplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLCReplay.Enabled = true;
            this.axVLCReplay.Location = new System.Drawing.Point(171, -1);
            this.axVLCReplay.Name = "axVLCReplay";
            this.axVLCReplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCReplay.OcxState")));
            this.axVLCReplay.Size = new System.Drawing.Size(837, 560);
            this.axVLCReplay.TabIndex = 1;
            // 
            // Replay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.axVLCReplay);
            this.Controls.Add(this.videoList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Replay";
            this.Text = "Replay";
            this.Load += new System.EventHandler(this.Replay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCReplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView videoList;
        private AxAXVLC.AxVLCPlugin2 axVLCReplay;
    }
}