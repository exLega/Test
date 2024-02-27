using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Register(object sender, EventArgs e)
        {
            Visible = false;
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void HostipalBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            HospitlaForm hospitlaForm = new HospitlaForm();
            hospitlaForm.Show();
        }

        private void BtnDataWord(object sender, EventArgs e)
        {
            Visible = false;
            WordExport wordExport = new WordExport();
            wordExport.Show();
        }

        private void BtnMedService(object sender, EventArgs e)
        {
            Visible = false;
            DonService donService = new DonService();
            donService.Show();
        }

        private void TrackBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            TrackClient trackClient = new TrackClient();
            trackClient.Show();
        }

        private void BtnStatonaryClick(object sender, EventArgs e)
        {
            Visible = false;
            Stationary stationary = new Stationary();
            stationary.Show();
        }
    }
}
