using Rulate_Notifier_v4.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rulate_Notifier_v4.BookClasses;

namespace Rulate_Notifier_v4
{   
    public partial class mainForm : Form
    {
        #region vars
        CancellationTokenSource CheckBookTasks = new CancellationTokenSource();
        CancellationToken Token;
        BookControlForm BookForm;

        #endregion

        public mainForm()
        {
            InitializeComponent();
            Token = CheckBookTasks.Token;

            foreach (Book a in BookControlMenu.LoadFromMemmory())
                BookList.Items.Add(a);
            
            //Task localTask = new Task(() => CheckBook(book, ct));
            //localTask.Start();
            //localTask.Wait();
        }

        private void CheckBook(Book book, CancellationToken cancellationToken)
        {
            int currIndex = 0;
            int endIndex;

            List<BookContainer> cont = BookControlMenu.GetContainersByIndex(book.Index);

            foreach (var a in cont)
            {
                if (a.name.Contains(book.Start))
                    break;
                currIndex++;
            }
            endIndex = currIndex;

            if (cont.ToArray().Length > currIndex)
            {
                while (currIndex != cont.ToArray().Length - 1)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    int percent = 0;
                    if (cont[currIndex].percent != "")
                        percent = int.Parse(cont[currIndex].percent.Split('%')[0].Split('.')[0]);

                    if (percent == 100 || cont[currIndex].status == "редактируется")
                    {
                        Invoke((MethodInvoker)(() => ChaptersList.Items.Add(book.Name + ": " + cont[currIndex].name)));
                        currIndex++;
                    }
                    else break;
                    ///
                }
                Invoke((MethodInvoker)(() => NewChaptersList.Items.Add(book.Name + ": " + (currIndex - endIndex))));
                Invoke((MethodInvoker)(() => ChaptersList.Items.Add("----------------------------------------------------------------------")));
            }
            //
        }
        #region MenuStrips & Events
        private void UpdateList()
        {
            BookList.Items.Clear();
            foreach (Book a in BookControlMenu.LoadFromMemmory())
                BookList.Items.Add(a);
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<Book> lst = new List<Book>();
            foreach (Book bk in BookList.Items)
                lst.Add(bk);

            BookControlMenu.Save(lst);
            CheckBookTasks.Cancel();
        }

        private void cHECKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book a = (Book)BookList.SelectedItem;
            new Task(() => CheckBook(a, Token)).Start();
        }
        private void cHECKINDTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm = new BookControlForm("", "", "", 0);
            BookForm.ShowDialog();
            UpdateList();
        }
        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book a = (Book)BookList.SelectedItem;

            BookForm = new BookControlForm(a.Name, a.Index, a.Start, 1);
            BookForm.ShowDialog();
            UpdateList();
        }
        private void rEMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book a = (Book)BookList.SelectedItem;

            BookControlMenu.Remove(a);
            UpdateList();
        }

        private void BookList_MouseDown(object sender, MouseEventArgs e)
        {
            int index = ((ListBox)sender).IndexFromPoint(e.Location);
            bool go = false;
            if (index != -1) go = ((ListBox)sender).GetSelected(index);
            if (e.Button == MouseButtons.Right && go == true)
            {
                ContextMenuBooks.Show(Cursor.Position);
            }
            else if (e.Button == MouseButtons.Right)
                ContextMenuEmpty.Show(Cursor.Position);
        }
        #endregion

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {

        }
    }

}
