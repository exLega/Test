using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp7
{
    public partial class RegisterForm : Form
    {
        private pasport _currentPasport = new pasport();
        private pacient _currentPacient = new pacient();
        private insurance_policy _currentPolis = new insurance_policy();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            _currentPasport.name = nameTxtBox.Text;
            _currentPasport.surname = surnameTxtBox.Text;
            _currentPasport.father_name = fatherNameTxtBox.Text;
            _currentPasport.date_birth = dateBirth.Value;
            _currentPasport.gender = genderTxtBox.Text;
            _currentPasport.number = int.Parse(numberPasport.Text);
            _currentPasport.seria = int.Parse(seriaPasport.Text);

            _currentPacient.phone = int.Parse(phoneTxtBox.Text);
            _currentPacient.email = emailTxtBox.Text;
            _currentPacient.address = addressTxtBox.Text;
            _currentPacient.place_work = placeWorkTxtBox.Text;

            _currentPolis.number = NumPolisTxtBox.Text;
            _currentPolis.date_endings = dateEndPolis.Value;
            _currentPolis.company = StPolisCompanyTxtBox.Text;

            if (string.IsNullOrWhiteSpace(_currentPasport.name))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentPasport.surname))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentPasport.father_name))
                errors.AppendLine("Укажите отчество");
            if (string.IsNullOrEmpty(_currentPasport.gender))
                errors.AppendLine("Укажите отчество");
            if (string.IsNullOrWhiteSpace(_currentPacient.email))
                errors.AppendLine("Укажите эл.почту");
            if (string.IsNullOrWhiteSpace(_currentPacient.address))
                errors.AppendLine("Укажите адрес");
            if (string.IsNullOrWhiteSpace(_currentPacient.place_work))
                errors.AppendLine("Укажите место работы");
            if (string.IsNullOrWhiteSpace(_currentPolis.number))
                errors.AppendLine("Укажите номер Ст.Полиса");
            if (string.IsNullOrWhiteSpace(_currentPolis.company))
                errors.AppendLine("Укажите Ст.Компанию");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString().Trim());
                return;
            }

            int pasportId = _currentPasport.id;
            int insuranceId = _currentPolis.id;

            if (_currentPolis.id == 0)
                MedEntities.GetContext().insurance_policy.Add(_currentPolis);

            if (_currentPasport.id == 0)
                MedEntities.GetContext().pasport.Add(_currentPasport);

            _currentPacient.pasport_id = pasportId;
            _currentPacient.insurance_id = insuranceId;

            if (_currentPacient.id == 0)
                MedEntities.GetContext().pacient.Add(_currentPacient);

            try
            {
                if (int.Parse(numberPasport.Text) != _currentPasport.number)
                {
                    MedEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Пациент с такими данными уже существует", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
        }

    }
}
