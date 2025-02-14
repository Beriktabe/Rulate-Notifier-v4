namespace Rulate_Notifier_v4
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BookList = new System.Windows.Forms.ListBox();
            this.ChaptersList = new System.Windows.Forms.ListBox();
            this.NewChaptersList = new System.Windows.Forms.ListBox();
            this.CheckAllBtn = new System.Windows.Forms.Button();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.ContextMenuBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cHECKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHECKINDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEMOVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuEmpty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aDDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuBooks.SuspendLayout();
            this.ContextMenuEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookList
            // 
            this.BookList.FormattingEnabled = true;
            this.BookList.Location = new System.Drawing.Point(12, 12);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(167, 381);
            this.BookList.TabIndex = 0;
            this.BookList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookList_MouseDown);
            // 
            // ChaptersList
            // 
            this.ChaptersList.FormattingEnabled = true;
            this.ChaptersList.Location = new System.Drawing.Point(185, 12);
            this.ChaptersList.Name = "ChaptersList";
            this.ChaptersList.Size = new System.Drawing.Size(207, 381);
            this.ChaptersList.TabIndex = 1;
            // 
            // NewChaptersList
            // 
            this.NewChaptersList.FormattingEnabled = true;
            this.NewChaptersList.Location = new System.Drawing.Point(398, 12);
            this.NewChaptersList.Name = "NewChaptersList";
            this.NewChaptersList.Size = new System.Drawing.Size(174, 381);
            this.NewChaptersList.TabIndex = 2;
            // 
            // CheckAllBtn
            // 
            this.CheckAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckAllBtn.Location = new System.Drawing.Point(12, 399);
            this.CheckAllBtn.Name = "CheckAllBtn";
            this.CheckAllBtn.Size = new System.Drawing.Size(167, 23);
            this.CheckAllBtn.TabIndex = 3;
            this.CheckAllBtn.Text = "CHECK ALL";
            this.CheckAllBtn.UseVisualStyleBackColor = true;
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllBtn.Location = new System.Drawing.Point(185, 399);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(387, 23);
            this.ClearAllBtn.TabIndex = 4;
            this.ClearAllBtn.Text = "CLEAR ALL";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // ContextMenuBooks
            // 
            this.ContextMenuBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHECKToolStripMenuItem,
            this.cHECKINDTToolStripMenuItem,
            this.toolStripSeparator1,
            this.oToolStripMenuItem,
            this.toolStripSeparator2,
            this.aDDToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.rEMOVEToolStripMenuItem});
            this.ContextMenuBooks.Name = "contextMenuStrip1";
            this.ContextMenuBooks.Size = new System.Drawing.Size(142, 148);
            // 
            // cHECKToolStripMenuItem
            // 
            this.cHECKToolStripMenuItem.Name = "cHECKToolStripMenuItem";
            this.cHECKToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cHECKToolStripMenuItem.Text = "CHECK";
            this.cHECKToolStripMenuItem.Click += new System.EventHandler(this.cHECKToolStripMenuItem_Click);
            // 
            // cHECKINDTToolStripMenuItem
            // 
            this.cHECKINDTToolStripMenuItem.Name = "cHECKINDTToolStripMenuItem";
            this.cHECKINDTToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cHECKINDTToolStripMenuItem.Text = "CHECK in DT";
            this.cHECKINDTToolStripMenuItem.Click += new System.EventHandler(this.cHECKINDTToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oToolStripMenuItem.Text = "Open URL";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aDDToolStripMenuItem.Text = "ADD";
            this.aDDToolStripMenuItem.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // rEMOVEToolStripMenuItem
            // 
            this.rEMOVEToolStripMenuItem.Name = "rEMOVEToolStripMenuItem";
            this.rEMOVEToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.rEMOVEToolStripMenuItem.Text = "REMOVE";
            this.rEMOVEToolStripMenuItem.Click += new System.EventHandler(this.rEMOVEToolStripMenuItem_Click);
            // 
            // ContextMenuEmpty
            // 
            this.ContextMenuEmpty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem1});
            this.ContextMenuEmpty.Name = "ContextMenuEmpty";
            this.ContextMenuEmpty.Size = new System.Drawing.Size(99, 26);
            // 
            // aDDToolStripMenuItem1
            // 
            this.aDDToolStripMenuItem1.Name = "aDDToolStripMenuItem1";
            this.aDDToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.aDDToolStripMenuItem1.Text = "ADD";
            this.aDDToolStripMenuItem1.Click += new System.EventHandler(this.aDDToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.ClearAllBtn);
            this.Controls.Add(this.CheckAllBtn);
            this.Controls.Add(this.NewChaptersList);
            this.Controls.Add(this.ChaptersList);
            this.Controls.Add(this.BookList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mainForm";
            this.Text = "Rulate Notifier V4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.ContextMenuBooks.ResumeLayout(false);
            this.ContextMenuEmpty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BookList;
        private System.Windows.Forms.ListBox ChaptersList;
        private System.Windows.Forms.ListBox NewChaptersList;
        private System.Windows.Forms.Button CheckAllBtn;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.ContextMenuStrip ContextMenuBooks;
        private System.Windows.Forms.ToolStripMenuItem cHECKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHECKINDTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEMOVEToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenuEmpty;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem1;
    }
}

