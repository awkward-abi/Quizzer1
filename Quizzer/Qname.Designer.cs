namespace Quizzer
{
    partial class Questionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionnaire));
            this.profile = new System.Windows.Forms.PictureBox();
            this.btnAddQN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxQName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtbxQ = new System.Windows.Forms.RichTextBox();
            this.txtbxAns = new System.Windows.Forms.TextBox();
            this.btnAddQ = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.Transparent;
            this.profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile.BackgroundImage")));
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profile.Location = new System.Drawing.Point(707, 12);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(44, 49);
            this.profile.TabIndex = 26;
            this.profile.TabStop = false;
            // 
            // btnAddQN
            // 
            this.btnAddQN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddQN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddQN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQN.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddQN.Location = new System.Drawing.Point(536, 154);
            this.btnAddQN.Name = "btnAddQN";
            this.btnAddQN.Size = new System.Drawing.Size(98, 30);
            this.btnAddQN.TabIndex = 25;
            this.btnAddQN.Text = "Add";
            this.btnAddQN.UseVisualStyleBackColor = false;
            this.btnAddQN.Click += new System.EventHandler(this.btnAddQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 80);
            this.label2.TabIndex = 24;
            this.label2.Text = "Q U I Z Z E R";
            // 
            // txtbxQName
            // 
            this.txtbxQName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxQName.Location = new System.Drawing.Point(289, 154);
            this.txtbxQName.Name = "txtbxQName";
            this.txtbxQName.Size = new System.Drawing.Size(216, 27);
            this.txtbxQName.TabIndex = 21;
            this.txtbxQName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enter Name of Questionnaire : ";
            // 
            // rtxtbxQ
            // 
            this.rtxtbxQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtbxQ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtbxQ.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rtxtbxQ.Location = new System.Drawing.Point(93, 197);
            this.rtxtbxQ.Name = "rtxtbxQ";
            this.rtxtbxQ.Size = new System.Drawing.Size(346, 191);
            this.rtxtbxQ.TabIndex = 28;
            this.rtxtbxQ.Text = "";
            // 
            // txtbxAns
            // 
            this.txtbxAns.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxAns.Location = new System.Drawing.Point(483, 215);
            this.txtbxAns.Name = "txtbxAns";
            this.txtbxAns.Size = new System.Drawing.Size(206, 27);
            this.txtbxAns.TabIndex = 29;
            // 
            // btnAddQ
            // 
            this.btnAddQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQ.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAddQ.Location = new System.Drawing.Point(483, 269);
            this.btnAddQ.Name = "btnAddQ";
            this.btnAddQ.Size = new System.Drawing.Size(206, 48);
            this.btnAddQ.TabIndex = 30;
            this.btnAddQ.Text = "Add to Questionnaire";
            this.btnAddQ.UseVisualStyleBackColor = false;
            this.btnAddQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(483, 333);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(206, 41);
            this.btnDone.TabIndex = 31;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(763, 417);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddQ);
            this.Controls.Add(this.txtbxAns);
            this.Controls.Add(this.rtxtbxQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.btnAddQN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxQName);
            this.Name = "Questionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qname";
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox profile;
        private Button btnAddQN;
        private Label label2;
        private TextBox txtbxQName;
        private Label label1;
        private RichTextBox rtxtbxQ;
        private TextBox txtbxAns;
        private Button btnAddQ;
        private Button btnDone;
    }
}