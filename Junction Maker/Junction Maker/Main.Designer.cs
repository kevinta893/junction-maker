namespace Junction_Maker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtTargetDirectory = new System.Windows.Forms.TextBox();
            this.lblTargetPrompt = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnMakeLink = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lblLinkNamePrompt = new System.Windows.Forms.Label();
            this.txtLinkName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTargetDirectory
            // 
            this.txtTargetDirectory.Location = new System.Drawing.Point(12, 71);
            this.txtTargetDirectory.Name = "txtTargetDirectory";
            this.txtTargetDirectory.Size = new System.Drawing.Size(282, 20);
            this.txtTargetDirectory.TabIndex = 0;
            // 
            // lblTargetPrompt
            // 
            this.lblTargetPrompt.AutoSize = true;
            this.lblTargetPrompt.Location = new System.Drawing.Point(12, 55);
            this.lblTargetPrompt.Name = "lblTargetPrompt";
            this.lblTargetPrompt.Size = new System.Drawing.Size(65, 13);
            this.lblTargetPrompt.TabIndex = 1;
            this.lblTargetPrompt.Text = "Target path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(300, 66);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 25);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnMakeLink
            // 
            this.btnMakeLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeLink.Location = new System.Drawing.Point(285, 155);
            this.btnMakeLink.Name = "btnMakeLink";
            this.btnMakeLink.Size = new System.Drawing.Size(87, 45);
            this.btnMakeLink.TabIndex = 3;
            this.btnMakeLink.Text = "Make Link";
            this.btnMakeLink.UseVisualStyleBackColor = true;
            this.btnMakeLink.Click += new System.EventHandler(this.btnMakeLink_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(15, 133);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(264, 70);
            this.lblOutput.TabIndex = 4;
            // 
            // lblLinkNamePrompt
            // 
            this.lblLinkNamePrompt.AutoSize = true;
            this.lblLinkNamePrompt.Location = new System.Drawing.Point(12, 9);
            this.lblLinkNamePrompt.Name = "lblLinkNamePrompt";
            this.lblLinkNamePrompt.Size = new System.Drawing.Size(59, 13);
            this.lblLinkNamePrompt.TabIndex = 6;
            this.lblLinkNamePrompt.Text = "Link name:";
            // 
            // txtLinkName
            // 
            this.txtLinkName.Location = new System.Drawing.Point(12, 25);
            this.txtLinkName.Name = "txtLinkName";
            this.txtLinkName.Size = new System.Drawing.Size(282, 20);
            this.txtLinkName.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.lblLinkNamePrompt);
            this.Controls.Add(this.txtLinkName);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnMakeLink);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblTargetPrompt);
            this.Controls.Add(this.txtTargetDirectory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Directory Junction Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTargetDirectory;
        private System.Windows.Forms.Label lblTargetPrompt;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnMakeLink;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lblLinkNamePrompt;
        private System.Windows.Forms.TextBox txtLinkName;
    }
}

