namespace GUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtbItemName = new System.Windows.Forms.TextBox();
            this.txtbItemCategory = new System.Windows.Forms.TextBox();
            this.richTextBoxParameters = new System.Windows.Forms.RichTextBox();
            this.pbItemImage = new System.Windows.Forms.PictureBox();
            this.btnGoToShop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27855F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.72145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtbItemName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbItemCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxParameters, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbItemImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGoToShop, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(707, 73);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(171, 27);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.Text = "Price";
            this.txtPrice.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.txtPrice.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // txtbItemName
            // 
            this.txtbItemName.BackColor = System.Drawing.Color.White;
            this.txtbItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbItemName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbItemName.Location = new System.Drawing.Point(181, 3);
            this.txtbItemName.Multiline = true;
            this.txtbItemName.Name = "txtbItemName";
            this.txtbItemName.ReadOnly = true;
            this.txtbItemName.Size = new System.Drawing.Size(389, 34);
            this.txtbItemName.TabIndex = 14;
            this.txtbItemName.Text = "Item Name";
            this.txtbItemName.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.txtbItemName.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // txtbItemCategory
            // 
            this.txtbItemCategory.BackColor = System.Drawing.Color.White;
            this.txtbItemCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbItemCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbItemCategory.Location = new System.Drawing.Point(181, 43);
            this.txtbItemCategory.Multiline = true;
            this.txtbItemCategory.Name = "txtbItemCategory";
            this.txtbItemCategory.ReadOnly = true;
            this.txtbItemCategory.Size = new System.Drawing.Size(389, 24);
            this.txtbItemCategory.TabIndex = 15;
            this.txtbItemCategory.Text = "Category";
            this.txtbItemCategory.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.txtbItemCategory.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // richTextBoxParameters
            // 
            this.richTextBoxParameters.BackColor = System.Drawing.Color.White;
            this.richTextBoxParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxParameters.Location = new System.Drawing.Point(181, 73);
            this.richTextBoxParameters.Name = "richTextBoxParameters";
            this.richTextBoxParameters.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.richTextBoxParameters, 2);
            this.richTextBoxParameters.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxParameters.Size = new System.Drawing.Size(389, 84);
            this.richTextBoxParameters.TabIndex = 17;
            this.richTextBoxParameters.Text = "";
            this.richTextBoxParameters.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.richTextBoxParameters.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // pbItemImage
            // 
            this.pbItemImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbItemImage.Location = new System.Drawing.Point(4, 5);
            this.pbItemImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbItemImage.Name = "pbItemImage";
            this.tableLayoutPanel1.SetRowSpan(this.pbItemImage, 4);
            this.pbItemImage.Size = new System.Drawing.Size(170, 150);
            this.pbItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbItemImage.TabIndex = 12;
            this.pbItemImage.TabStop = false;
            this.pbItemImage.WaitOnLoad = true;
            this.pbItemImage.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.pbItemImage.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // btnGoToShop
            // 
            this.btnGoToShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.btnGoToShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoToShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoToShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGoToShop.ForeColor = System.Drawing.Color.White;
            this.btnGoToShop.Location = new System.Drawing.Point(708, 105);
            this.btnGoToShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoToShop.Name = "btnGoToShop";
            this.btnGoToShop.Size = new System.Drawing.Size(169, 50);
            this.btnGoToShop.TabIndex = 18;
            this.btnGoToShop.Text = "Przejdz do sklepu";
            this.btnGoToShop.UseVisualStyleBackColor = false;
            this.btnGoToShop.Click += new System.EventHandler(this.GoToShopButton_Click);
            this.btnGoToShop.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.btnGoToShop.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(881, 154);
            this.MouseEnter += new System.EventHandler(this.ItemControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ItemControl_MouseLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbItemImage;
        private System.Windows.Forms.TextBox txtbItemName;
        private System.Windows.Forms.TextBox txtbItemCategory;
        private System.Windows.Forms.RichTextBox richTextBoxParameters;
        private System.Windows.Forms.Button btnGoToShop;
        private System.Windows.Forms.TextBox txtPrice;
    }
}
