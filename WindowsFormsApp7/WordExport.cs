using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp7
{
    public partial class WordExport : Form
    {
        public WordExport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
        }

        private void BtnBrowseFile(object sender, EventArgs e)
        {
            var FullName = SurnameTxt.Text + " " + NameTxt.Text + " " + FatherNameTxt.Text;
            var Pasport = SeriaPasport.Text + NumberTxt.Text;
            var PasportInfo = IssuedPasportTxt.Text + " " + WhoIssuedTxt.Text;
            var Address = AddressTxt.Text;

            var WordApp = new Word.Application();
            WordApp.Visible = false;

            try 
            {
                if (SurnameTxt.Text == "" || NameTxt.Text == "" || FatherNameTxt.Text == "" || NumberTxt.Text == "" || SeriaPasport.Text == "" 
                    || IssuedPasportTxt.Text == "" || WhoIssuedTxt.Text == "")
                {
                    MessageBox.Show("Пожалуйста заполните все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    var wordDoc = WordApp.Documents.Open(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Resource\Sample.docx"));

                    ReplaceWord("{FullName}", FullName, wordDoc);
                    ReplaceWord("{Pasport}", Pasport, wordDoc);
                    ReplaceWord("{PasportInfo}", PasportInfo, wordDoc);
                    ReplaceWord("{Address}", Address, wordDoc);

                    WordApp.Visible = true;
                }

            }
            catch 
            {
                MessageBox.Show("Произошла Ошибка!");
            }

        }

        private void ReplaceWord(string Replace, string Text, Word.Document wordDoc) 
        {
            var range = wordDoc.Content;
            range.Find.ClearFormatting(); 
            range.Find.Execute(FindText: Replace, ReplaceWith: Text);
        }

    }
}
