namespace NotesApp
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
            this.noteTitle = new System.Windows.Forms.Label();
            this.descripLab = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.descripTxt = new System.Windows.Forms.TextBox();
            this.noteList = new System.Windows.Forms.DataGridView();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newFormBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noteList)).BeginInit();
            this.SuspendLayout();
            // 
            // noteTitle
            // 
            this.noteTitle.AutoSize = true;
            this.noteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTitle.Location = new System.Drawing.Point(75, 46);
            this.noteTitle.Name = "noteTitle";
            this.noteTitle.Size = new System.Drawing.Size(43, 20);
            this.noteTitle.TabIndex = 0;
            this.noteTitle.Text = "Title";
            // 
            // descripLab
            // 
            this.descripLab.AutoSize = true;
            this.descripLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripLab.Location = new System.Drawing.Point(18, 73);
            this.descripLab.Name = "descripLab";
            this.descripLab.Size = new System.Drawing.Size(100, 20);
            this.descripLab.TabIndex = 1;
            this.descripLab.Text = "Description";
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxt.Location = new System.Drawing.Point(124, 46);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(181, 23);
            this.titleTxt.TabIndex = 2;
            // 
            // descripTxt
            // 
            this.descripTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripTxt.Location = new System.Drawing.Point(124, 75);
            this.descripTxt.Multiline = true;
            this.descripTxt.Name = "descripTxt";
            this.descripTxt.Size = new System.Drawing.Size(200, 200);
            this.descripTxt.TabIndex = 3;
            // 
            // noteList
            // 
            this.noteList.AllowUserToAddRows = false;
            this.noteList.AllowUserToDeleteRows = false;
            this.noteList.AllowUserToResizeColumns = false;
            this.noteList.AllowUserToResizeRows = false;
            this.noteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.noteList.ColumnHeadersVisible = false;
            this.noteList.Location = new System.Drawing.Point(351, 75);
            this.noteList.Name = "noteList";
            this.noteList.ReadOnly = true;
            this.noteList.RowHeadersVisible = false;
            this.noteList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteList.Size = new System.Drawing.Size(150, 200);
            this.noteList.TabIndex = 4;
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(27, 305);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 25);
            this.newBtn.TabIndex = 5;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(161, 305);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 25);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(297, 305);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(75, 25);
            this.readBtn.TabIndex = 7;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(426, 305);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 25);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Notes";
            // 
            // newFormBtn
            // 
            this.newFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFormBtn.Location = new System.Drawing.Point(367, 12);
            this.newFormBtn.Name = "newFormBtn";
            this.newFormBtn.Size = new System.Drawing.Size(115, 25);
            this.newFormBtn.TabIndex = 10;
            this.newFormBtn.Text = "Open new form";
            this.newFormBtn.UseVisualStyleBackColor = true;
            this.newFormBtn.Click += new System.EventHandler(this.newFormBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.newFormBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.noteList);
            this.Controls.Add(this.descripTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.descripLab);
            this.Controls.Add(this.noteTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noteList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noteTitle;
        private System.Windows.Forms.Label descripLab;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox descripTxt;
        private System.Windows.Forms.DataGridView noteList;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newFormBtn;
    }
}

