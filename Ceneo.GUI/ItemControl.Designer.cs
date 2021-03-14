namespace test
{
    partial class ItemControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.txtbItemName = new System.Windows.Forms.TextBox();
            this.txtbItemCategory = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.richTextBoxParameters = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItemImage
            // 
            this.pbItemImage.Location = new System.Drawing.Point(4, 5);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbItemImage.Name = "pbItemImage";
            this.pbItemImage.Size = new System.Drawing.Size(152, 145);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 0;
            this.pbItemImage.TabStop = false;
            this.pbItemImage.WaitOnLoad = true;
            this.pbItemImage.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.pbItemImage.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // ButtonLog
            // 
            this.ButtonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonLog.ForeColor = System.Drawing.Color.White;
            this.ButtonLog.Location = new System.Drawing.Point(709, 102);
            this.ButtonLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(155, 48);
            this.ButtonLog.TabIndex = 6;
            this.ButtonLog.Text = "Porównaj Ceny!";
            this.ButtonLog.UseVisualStyleBackColor = false;
            this.ButtonLog.Click += new System.EventHandler(this.PorownajButton_Click);
            this.ButtonLog.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.ButtonLog.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // txtbItemName
            // 
            this.txtbItemName.BackColor = System.Drawing.Color.White;
            this.txtbItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbItemName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbItemName.Location = new System.Drawing.Point(175, 5);
            this.txtbItemName.Multiline = true;
            this.txtbItemName.Name = "txtbItemName";
            this.txtbItemName.ReadOnly = true;
            this.txtbItemName.Size = new System.Drawing.Size(386, 27);
            this.txtbItemName.TabIndex = 7;
            this.txtbItemName.Text = "Item Name";
            this.txtbItemName.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.txtbItemName.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // txtbItemCategory
            // 
            this.txtbItemCategory.BackColor = System.Drawing.Color.White;
            this.txtbItemCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbItemCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbItemCategory.Location = new System.Drawing.Point(175, 49);
            this.txtbItemCategory.Multiline = true;
            this.txtbItemCategory.Name = "txtbItemCategory";
            this.txtbItemCategory.ReadOnly = true;
            this.txtbItemCategory.Size = new System.Drawing.Size(386, 27);
            this.txtbItemCategory.TabIndex = 8;
            this.txtbItemCategory.Text = "Category";
            this.txtbItemCategory.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.txtbItemCategory.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // txtbPrice
            // 
            this.txtbPrice.BackColor = System.Drawing.Color.White;
            this.txtbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbPrice.Location = new System.Drawing.Point(709, 58);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.ReadOnly = true;
            this.txtbPrice.Size = new System.Drawing.Size(144, 27);
            this.txtbPrice.TabIndex = 9;
            this.txtbPrice.Text = "Price";
            this.txtbPrice.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.txtbPrice.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // richTextBoxParameters
            // 
            this.richTextBoxParameters.BackColor = System.Drawing.Color.White;
            this.richTextBoxParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxParameters.Location = new System.Drawing.Point(175, 84);
            this.richTextBoxParameters.Name = "richTextBoxParameters";
            this.richTextBoxParameters.ReadOnly = true;
            this.richTextBoxParameters.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxParameters.Size = new System.Drawing.Size(386, 66);
            this.richTextBoxParameters.TabIndex = 10;
            this.richTextBoxParameters.Text = "";
            this.richTextBoxParameters.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.richTextBoxParameters.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxParameters);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txtbItemCategory);
            this.Controls.Add(this.txtbItemName);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.pbItemImage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(881, 154);
            this.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            this.Resize += new System.EventHandler(this.SearchControl2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.TextBox txtbItemName;
        private System.Windows.Forms.TextBox txtbItemCategory;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.RichTextBox richTextBoxParameters;
    }
}
