
namespace GUI
{
    partial class ListItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(8, 11);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(190, 153);
            this.pbItemImage.TabIndex = 0;
            this.pbItemImage.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(230, 28);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(83, 20);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(230, 66);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(103, 20);
            this.lblItemCategory.TabIndex = 2;
            this.lblItemCategory.Text = "Item Category";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(717, 47);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(41, 20);
            this.lblItemPrice.TabIndex = 3;
            this.lblItemPrice.Text = "Price";
            // 
            // ListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemCategory);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.pbItemImage);
            this.Name = "ListItemControl";
            this.Size = new System.Drawing.Size(823, 173);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.Label lblItemPrice;
    }
}
