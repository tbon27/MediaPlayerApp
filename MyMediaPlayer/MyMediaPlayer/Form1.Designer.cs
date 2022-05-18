
namespace MyMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ss = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this._mPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this._mPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(9, 73);
            this.ss.Margin = new System.Windows.Forms.Padding(0);
            this.ss.Multiline = true;
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(545, 36);
            this.ss.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse Files";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Media File to Play";
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(191, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(306, 29);
            this.Title.TabIndex = 4;
            this.Title.Text = "Bongy\'s Media Player 2022";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _mPlayer
            // 
            this._mPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._mPlayer.Enabled = true;
            this._mPlayer.Location = new System.Drawing.Point(9, 126);
            this._mPlayer.Margin = new System.Windows.Forms.Padding(0);
            this._mPlayer.MaximumSize = new System.Drawing.Size(664, 464);
            this._mPlayer.MinimumSize = new System.Drawing.Size(664, 464);
            this._mPlayer.Name = "_mPlayer";
            this._mPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("_mPlayer.OcxState")));
            this._mPlayer.Size = new System.Drawing.Size(664, 464);
            this._mPlayer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ss);
            this.Controls.Add(this._mPlayer);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._mPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer _mPlayer;
        private System.Windows.Forms.TextBox ss;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
    }
}

