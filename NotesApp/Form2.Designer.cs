namespace NotesApp
{
    partial class Form2
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
            this.descripTxt = new System.Windows.Forms.TextBox();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.descripLab = new System.Windows.Forms.Label();
            this.noteTitle = new System.Windows.Forms.Label();
            this.newFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descripTxt
            // 
            this.descripTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripTxt.Location = new System.Drawing.Point(141, 75);
            this.descripTxt.Multiline = true;
            this.descripTxt.Name = "descripTxt";
            this.descripTxt.Size = new System.Drawing.Size(200, 200);
            this.descripTxt.TabIndex = 7;
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(141, 46);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(181, 23);
            this.titleTxt.TabIndex = 6;
            // 
            // descripLab
            // 
            this.descripLab.AutoSize = true;
            this.descripLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripLab.Location = new System.Drawing.Point(35, 73);
            this.descripLab.Name = "descripLab";
            this.descripLab.Size = new System.Drawing.Size(100, 20);
            this.descripLab.TabIndex = 5;
            this.descripLab.Text = "Description";
            // 
            // noteTitle
            // 
            this.noteTitle.AutoSize = true;
            this.noteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitle.Location = new System.Drawing.Point(92, 46);
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.Size = new System.Drawing.Size(43, 20);
            this.noteTitle.TabIndex = 4;
            this.noteTitle.Text = "Title";
            // 
            // newFormBtn
            // 
            this.newFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFormBtn.Location = new System.Drawing.Point(428, 12);
            this.newFormBtn.Name = "newFormBtn";
            this.newFormBtn.Size = new System.Drawing.Size(75, 25);
            this.newFormBtn.TabIndex = 11;
            this.newFormBtn.Text = "Go Back";
            this.newFormBtn.UseVisualStyleBackColor = true;
            this.newFormBtn.Click += new System.EventHandler(this.newFormBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.newFormBtn);
            this.Controls.Add(this.descripTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.descripLab);
            this.Controls.Add(this.noteTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label descripLab;
        private System.Windows.Forms.Label noteTitle;
        private System.Windows.Forms.Button newFormBtn;
        public System.Windows.Forms.TextBox descripTxt;
        public System.Windows.Forms.TextBox titleTxt;
    }
}