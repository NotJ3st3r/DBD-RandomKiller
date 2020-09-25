namespace DBDKillers
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_chooseRDMKiller = new System.Windows.Forms.Button();
            this.lbl_killerName = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lbl_killerNickname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_chooseRDMKiller
            // 
            this.btn_chooseRDMKiller.BackColor = System.Drawing.Color.Black;
            this.btn_chooseRDMKiller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chooseRDMKiller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chooseRDMKiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_chooseRDMKiller.ForeColor = System.Drawing.Color.White;
            this.btn_chooseRDMKiller.Location = new System.Drawing.Point(12, 446);
            this.btn_chooseRDMKiller.Name = "btn_chooseRDMKiller";
            this.btn_chooseRDMKiller.Size = new System.Drawing.Size(263, 48);
            this.btn_chooseRDMKiller.TabIndex = 0;
            this.btn_chooseRDMKiller.Text = "Randomize Killer";
            this.btn_chooseRDMKiller.UseVisualStyleBackColor = false;
            this.btn_chooseRDMKiller.Click += new System.EventHandler(this.Btn_chooseRDMKiller_Click);
            // 
            // lbl_killerName
            // 
            this.lbl_killerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_killerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_killerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_killerName.ForeColor = System.Drawing.Color.Silver;
            this.lbl_killerName.Location = new System.Drawing.Point(12, 358);
            this.lbl_killerName.Name = "lbl_killerName";
            this.lbl_killerName.Size = new System.Drawing.Size(263, 23);
            this.lbl_killerName.TabIndex = 1;
            this.lbl_killerName.Text = "label1";
            this.lbl_killerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBar
            // 
            this.pBar.BackColor = System.Drawing.Color.Maroon;
            this.pBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBar.Location = new System.Drawing.Point(12, 417);
            this.pBar.Maximum = 50;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(263, 23);
            this.pBar.Step = 1;
            this.pBar.TabIndex = 2;
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox.ErrorImage = null;
            this.picBox.InitialImage = null;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(263, 290);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // lbl_killerNickname
            // 
            this.lbl_killerNickname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_killerNickname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_killerNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_killerNickname.ForeColor = System.Drawing.Color.Silver;
            this.lbl_killerNickname.Location = new System.Drawing.Point(12, 313);
            this.lbl_killerNickname.Name = "lbl_killerNickname";
            this.lbl_killerNickname.Size = new System.Drawing.Size(263, 45);
            this.lbl_killerNickname.TabIndex = 4;
            this.lbl_killerNickname.Text = "label1";
            this.lbl_killerNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(287, 506);
            this.Controls.Add(this.lbl_killerNickname);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.lbl_killerName);
            this.Controls.Add(this.btn_chooseRDMKiller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DeathByDaylight Random Killer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_chooseRDMKiller;
        private System.Windows.Forms.Label lbl_killerName;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbl_killerNickname;
    }
}

