namespace Quizzer
{
    partial class Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQnames = new System.Windows.Forms.ComboBox();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 80);
            this.label2.TabIndex = 12;
            this.label2.Text = "Q U I Z Z E R";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbQnames
            // 
            this.cmbQnames.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbQnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQnames.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbQnames.FormattingEnabled = true;
            this.cmbQnames.Location = new System.Drawing.Point(280, 170);
            this.cmbQnames.Name = "cmbQnames";
            this.cmbQnames.Size = new System.Drawing.Size(241, 28);
            this.cmbQnames.TabIndex = 13;
            this.cmbQnames.SelectedIndexChanged += new System.EventHandler(this.cmbQnames_SelectedIndexChanged);
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.Transparent;
            this.btnQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuiz.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnQuiz.Location = new System.Drawing.Point(322, 485);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(183, 45);
            this.btnQuiz.TabIndex = 17;
            this.btnQuiz.Text = "Take Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(106, 215);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 240);
            this.listView1.TabIndex = 19;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(763, 567);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.cmbQnames);
            this.Controls.Add(this.label2);
            this.Name = "Review";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private ComboBox cmbQnames;
        private Button btnQuiz;
        private ListView listView1;
    }
}