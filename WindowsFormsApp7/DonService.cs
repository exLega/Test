using Microsoft.Office.Interop.Word;
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
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp7
{
    public partial class DonService : Form
    {
        public DonService()
        {
            InitializeComponent();
        }

        private void BtnBackClick(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
        }

        private void BtnBrowseClick(object sender, EventArgs e)
        {
            var NameOrg = NameOrgan.Text;
            var fullNamePred = FullNamePred.Text;
            var fullNamePotred = FullNamePotreb.Text;
            var AddressPot = AddressPotreb.Text;
            var DopAddressPot = DopAddressPotreb.Text;
            var phonePot = PhonePotreb.Text;
            var DataPasportPot = PasportPotreb.Text;
            var Znach = Znac.Text;
            var DataBegin = DateBegin.Text;
            var ValLic = ValidityLic.Text;
            var LicOrgn = LicOrg.Text;
            var Val = Validity.Text;
            var ListDocum = LisDoc.Text;
            var srokData = SrokDate.Text;
            var jobTitle = JobTitle.Text;
            var addressOrg = AddressOrg.Text;
            var emailOrg = EmailRab.Text;

            var WordApp = new Word.Application();
            WordApp.Visible = false;

            try
            {
                if (NameOrgan.Text == "" || FullNamePotreb.Text == "" || AddressPotreb.Text == "" || DopAddressPotreb.Text == "" || PhonePotreb.Text == ""
                    || PasportPotreb.Text == "" || Znac.Text == "" || DateBegin.Text == "" || ValidityLic.Text == "" || LicOrg.Text == "" || Validity.Text == ""
                    || LisDoc.Text == "" || SrokDate.Text == "" || JobTitle.Text == "" || AddressOrg.Text == "" || EmailRab.Text == "")
                {
                    MessageBox.Show("Пожалуйста заполните все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var wordDoc = WordApp.Documents.Open(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Resource\Sample1.docx"));

                    ReplaceWord("{NameOrg}", NameOrg, wordDoc);
                    ReplaceWord("{FullNamePred}", fullNamePred, wordDoc);
                    ReplaceWord("{FullNamePotreb}", fullNamePotred, wordDoc);
                    ReplaceWord("{Znach}", Znach, wordDoc);
                    ReplaceWord("{NameOrg}", NameOrg, wordDoc);
                    ReplaceWord("{FullNamePred}", fullNamePred, wordDoc);
                    ReplaceWord("{DateBegin}", DataBegin, wordDoc);
                    ReplaceWord("{ValidityLic}", ValLic, wordDoc);
                    ReplaceWord("{NameAddressPhoneLic}", LicOrgn, wordDoc);
                    ReplaceWord("{Validity}", Val, wordDoc);
                    ReplaceWord("{ListDoc}", ListDocum, wordDoc);
                    ReplaceWord("{SrokDays}", srokData, wordDoc);
                    ReplaceWord("{JobTitle}", jobTitle, wordDoc);
                    ReplaceWord("{ListDoc}", ListDocum, wordDoc);
                    ReplaceWord("{AddressOrg}", addressOrg, wordDoc);
                    ReplaceWord("{EmailOrg}", emailOrg, wordDoc);
                    ReplaceWord("{FullNamePotreb}", fullNamePotred, wordDoc);
                    ReplaceWord("{AddressPotreb}", AddressPot, wordDoc);
                    ReplaceWord("{AddressPotreb2}", DopAddressPot, wordDoc);
                    ReplaceWord("{Pasport}", DataPasportPot, wordDoc);
                    ReplaceWord("{Phone}", phonePot, wordDoc);

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
