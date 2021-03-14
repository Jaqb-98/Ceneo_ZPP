
namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flItemListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtbSearchBar = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flItemListPanel
            // 
            this.flItemListPanel.AutoScroll = true;
            this.flItemListPanel.Location = new System.Drawing.Point(12, 121);
            this.flItemListPanel.Name = "flItemListPanel";
            this.flItemListPanel.Size = new System.Drawing.Size(1006, 474);
            this.flItemListPanel.TabIndex = 0;
            // 
            // txtbSearchBar
            // 
            this.txtbSearchBar.Location = new System.Drawing.Point(15, 17);
            this.txtbSearchBar.Name = "txtbSearchBar";
            this.txtbSearchBar.Size = new System.Drawing.Size(526, 27);
            this.txtbSearchBar.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(554, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 706);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbSearchBar);
            this.Controls.Add(this.flItemListPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flItemListPanel;
        private System.Windows.Forms.TextBox txtbSearchBar;
        private System.Windows.Forms.Button btnSearch;
    }
}

