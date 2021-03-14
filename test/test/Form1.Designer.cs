namespace test
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.TextNameLogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.mainControl1 = new test.MainControl(this);
            this.loginControl1 = new test.LoginControl();
            this.searchControl2 = new test.KontrolkaSzukaj_tlo();
            this.compareControl1 = new test.KontrolkaPorownaj_tlo();
            this.compareControl2 = new test.KontrolkaPorownaj_tlo();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 500);
            this.panel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 42);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Kategorie:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 26);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(724, 32);
            this.textBox2.TabIndex = 3;
            // 
            // ButtonLog
            // 
            this.ButtonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonLog.Location = new System.Drawing.Point(942, 26);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(100, 31);
            this.ButtonLog.TabIndex = 5;
            this.ButtonLog.Text = "Zaloguj się!";
            this.ButtonLog.UseVisualStyleBackColor = false;
            this.ButtonLog.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TextNameLogin
            // 
            this.TextNameLogin.Location = new System.Drawing.Point(942, 69);
            this.TextNameLogin.Multiline = true;
            this.TextNameLogin.Name = "TextNameLogin";
            this.TextNameLogin.Size = new System.Drawing.Size(100, 31);
            this.TextNameLogin.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(807, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Szukaj!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.szukaj_click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.mainControl1);
            this.MainPanel.Controls.Add(this.loginControl1);
            this.MainPanel.Controls.Add(this.searchControl2);
            this.MainPanel.Controls.Add(this.compareControl1);
            this.MainPanel.Controls.Add(this.compareControl2);
            this.MainPanel.Location = new System.Drawing.Point(193, 69);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(724, 500);
            this.MainPanel.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Krokiet";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.KrokietButton_Click);
            // 
            // mainControl1
            // 
            this.mainControl1.Location = new System.Drawing.Point(0, -3);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(724, 500);
            this.mainControl1.TabIndex = 0;
            // 
            // loginControl1
            // 
            this.loginControl1.Location = new System.Drawing.Point(3, 0);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(724, 500);
            this.loginControl1.TabIndex = 2;
            // 
            // searchControl2
            // 
            this.searchControl2.AutoScroll = true;
            this.searchControl2.ileOkienek = 0;
            this.searchControl2.Location = new System.Drawing.Point(0, 0);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Size = new System.Drawing.Size(721, 497);
            this.searchControl2.TabIndex = 3;
            this.searchControl2.test2 = 0;
            // 
            // compareControl1
            // 
            this.compareControl1.AutoScroll = true;
            this.compareControl1.Location = new System.Drawing.Point(3, -3);
            this.compareControl1.Name = "compareControl1";
            this.compareControl1.Size = new System.Drawing.Size(724, 500);
            this.compareControl1.TabIndex = 4;
            // 
            // compareControl2
            // 
            this.compareControl2.AutoScroll = true;
            this.compareControl2.Location = new System.Drawing.Point(3, 0);
            this.compareControl2.Name = "compareControl2";
            this.compareControl2.Size = new System.Drawing.Size(724, 500);
            this.compareControl2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1056, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextNameLogin);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korkiet_aplikacja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.TextBox TextNameLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MainPanel;
        private MainControl mainControl1;
        private KontrolkaSzukaj_tlo searchControl1;
        private System.Windows.Forms.Button button2;
        private LoginControl loginControl1;
        private KontrolkaSzukaj_tlo searchControl2;
        private KontrolkaPorownaj_tlo compareControl1;
        private KontrolkaPorownaj_tlo compareControl2;
    }
}

