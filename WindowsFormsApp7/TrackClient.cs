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

namespace WindowsFormsApp7
{
    public partial class TrackClient : Form
    {
        public TrackClient()
        {
            InitializeComponent();
            AddDelPeopleSkud(1, 1, "in", "клиент");
            AddDelPeopleSkud(2, 2, "in", "клиент");
            AddDelPeopleSkud(3, 3, "in", "клиент");
            AddDelPeopleSkud(5, 5, "in", "клиент");
            AddDelPeopleSkud(6, 6, "in", "клиент");
            AddDelPeopleSkud(7, 7, "in", "клиент");
            AddDelPeopleSkud(16, 16, "in", "клиент");
            AddDelPeopleSkud(23, 23, "in", "клиент");
            AddDelPeopleSkud(7, 7, "in", "сотрудник");
            AddDelPeopleSkud(16, 16, "in", "сотрудник");
            AddDelPeopleSkud(23, 23, "in", "сотрудник");
        }

        private void AddDelPeopleSkud(int number, int personCode, string direction, string role)
        {

            string targetString = "Skud" + number;
            Control targetSkud = this.Controls[targetString];

            PictureBox pictureBox = new PictureBox();

            string targetPerson = "Person" + personCode;

            pictureBox.Width = 18;
            pictureBox.Height = 18;

            pictureBox.Name = targetPerson;

            switch (role)
            {
                case "клиент":
                    pictureBox.BackColor = Color.Green;
                    break;
                case "сотрудник":
                    pictureBox.BackColor = Color.Blue;
                    break;
            }

            switch (direction)
            {
                case "in":
                    targetSkud.Controls.Add(pictureBox);
                    break;
                case "out":
                    Control c = targetSkud.Controls[targetPerson];
                    targetSkud.Controls.Remove(c);
                    break;
            }

        }
    }
}
