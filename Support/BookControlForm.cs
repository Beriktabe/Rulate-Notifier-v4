using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rulate_Notifier_v4.BookClasses;

namespace Rulate_Notifier_v4.Support
{
    public partial class BookControlForm : Form
    {
        string name;
        string index;
        string start;
        int mode;

        public BookControlForm(string name, string index, string start, int mode)
        {
            InitializeComponent();

            this.name = name;
            this.index = index;
            this.start = start;
            this.mode = mode;

            textBox1.Text = name;
            textBox2.Text = index;
            textBox3.Text = start;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    {
                        foreach(Book a in BookControlMenu.LoadFromMemmory())
                            if(a.Name == name) { MessageBox.Show("Нельзя создать 2 книги с одним названием"); return; }
                        if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text)) { MessageBox.Show("Введите название книги"); return; }
                        BookControlMenu.AddNew(new Book() { Index = textBox2.Text, Name = textBox1.Text, Start = textBox3.Text });
                        break;
                    }
                case 1:
                    {
                        BookControlMenu.Remove(new Book() {Index = index, Name = name, Start = start });
                        foreach (Book a in BookControlMenu.LoadFromMemmory())
                            if (a.Name == name) { MessageBox.Show("Нельзя создать 2 книги с одним названием"); return; }
                        if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text)) { MessageBox.Show("Введите название книги"); return; }
                        BookControlMenu.AddNew(new Book() { Index = textBox2.Text, Name = textBox1.Text, Start = textBox3.Text });
                        break;
                    }
            }
            this.Close();
        }
    }
}
