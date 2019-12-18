namespace Zalgen
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
            this.text = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.strengthBar = new System.Windows.Forms.TrackBar();
            this.refSheet = new System.Windows.Forms.Button();
            this.fuck_down = new System.Windows.Forms.CheckBox();
            this.fuck_up = new System.Windows.Forms.CheckBox();
            this.fuck_mid = new System.Windows.Forms.CheckBox();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(800, 450);
            this.text.TabIndex = 0;
            this.text.Text = "To invoke the hive-mind representing chaos.\r\nInvoking the feeling of chaos.\r\nWith" +
    " out order.\r\nThe Nezperdian hive-mind of chaos. Zalgo.\r\nHe who Waits Behind The " +
    "Wall.\r\nZALGO!";
            // 
            // run
            // 
            this.run.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.run.Location = new System.Drawing.Point(700, 2);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(98, 23);
            this.run.TabIndex = 1;
            this.run.Text = "HE COMES...";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.strengthLabel);
            this.controlPanel.Controls.Add(this.strengthBar);
            this.controlPanel.Controls.Add(this.refSheet);
            this.controlPanel.Controls.Add(this.fuck_down);
            this.controlPanel.Controls.Add(this.fuck_up);
            this.controlPanel.Controls.Add(this.fuck_mid);
            this.controlPanel.Controls.Add(this.run);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 398);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(800, 52);
            this.controlPanel.TabIndex = 2;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(141, 18);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(50, 13);
            this.strengthLabel.TabIndex = 10;
            this.strengthLabel.Text = "Strength:";
            // 
            // strengthBar
            // 
            this.strengthBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.strengthBar.Location = new System.Drawing.Point(197, 13);
            this.strengthBar.Maximum = 20;
            this.strengthBar.Minimum = 1;
            this.strengthBar.Name = "strengthBar";
            this.strengthBar.Size = new System.Drawing.Size(499, 45);
            this.strengthBar.TabIndex = 9;
            this.strengthBar.Value = 5;
            // 
            // refSheet
            // 
            this.refSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refSheet.Location = new System.Drawing.Point(700, 27);
            this.refSheet.Name = "refSheet";
            this.refSheet.Size = new System.Drawing.Size(98, 23);
            this.refSheet.TabIndex = 8;
            this.refSheet.Text = "Reference Sheet";
            this.refSheet.UseVisualStyleBackColor = true;
            this.refSheet.Click += new System.EventHandler(this.refSheet_Click);
            // 
            // fuck_down
            // 
            this.fuck_down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fuck_down.AutoSize = true;
            this.fuck_down.Checked = true;
            this.fuck_down.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fuck_down.Location = new System.Drawing.Point(4, 34);
            this.fuck_down.Name = "fuck_down";
            this.fuck_down.Size = new System.Drawing.Size(120, 17);
            this.fuck_down.TabIndex = 7;
            this.fuck_down.Text = "fuck up going down";
            this.fuck_down.UseVisualStyleBackColor = true;
            // 
            // fuck_up
            // 
            this.fuck_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fuck_up.AutoSize = true;
            this.fuck_up.Location = new System.Drawing.Point(4, 3);
            this.fuck_up.Name = "fuck_up";
            this.fuck_up.Size = new System.Drawing.Size(106, 17);
            this.fuck_up.TabIndex = 6;
            this.fuck_up.Text = "fuck up going up";
            this.fuck_up.UseVisualStyleBackColor = true;
            // 
            // fuck_mid
            // 
            this.fuck_mid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fuck_mid.AutoSize = true;
            this.fuck_mid.Checked = true;
            this.fuck_mid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fuck_mid.Location = new System.Drawing.Point(4, 19);
            this.fuck_mid.Name = "fuck_mid";
            this.fuck_mid.Size = new System.Drawing.Size(113, 17);
            this.fuck_mid.TabIndex = 5;
            this.fuck_mid.Text = "fuck up the middle";
            this.fuck_mid.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ZalGen";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.CheckBox fuck_down;
        private System.Windows.Forms.CheckBox fuck_up;
        private System.Windows.Forms.CheckBox fuck_mid;
        private System.Windows.Forms.Button refSheet;
        private System.Windows.Forms.TrackBar strengthBar;
        private System.Windows.Forms.Label strengthLabel;
    }
}

