namespace WebCam
{
    partial class ReplayTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplayTree));
            this.filesTree = new System.Windows.Forms.TreeView();
            this.axVLCRT = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCRT)).BeginInit();
            this.SuspendLayout();
            // 
            // filesTree
            // 
            this.filesTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.filesTree.Location = new System.Drawing.Point(1, 0);
            this.filesTree.Name = "filesTree";
            this.filesTree.Size = new System.Drawing.Size(213, 560);
            this.filesTree.TabIndex = 0;
            this.filesTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.filesTree_MouseDoubleClick);
            // 
            // axVLCRT
            // 
            this.axVLCRT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLCRT.Enabled = true;
            this.axVLCRT.Location = new System.Drawing.Point(220, 0);
            this.axVLCRT.Name = "axVLCRT";
            this.axVLCRT.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCRT.OcxState")));
            this.axVLCRT.Size = new System.Drawing.Size(787, 560);
            this.axVLCRT.TabIndex = 1;
            // 
            // ReplayTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.axVLCRT);
            this.Controls.Add(this.filesTree);
            this.Name = "ReplayTree";
            this.Text = "ReplayTree";
            this.Load += new System.EventHandler(this.ReplayTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCRT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView filesTree;
        private AxAXVLC.AxVLCPlugin2 axVLCRT;
    }
}