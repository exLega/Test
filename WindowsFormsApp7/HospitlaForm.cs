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
    public partial class HospitlaForm : Form
    {
        private Host _currentHost = new Host();
        private pasport _currentPasport = new pasport();
        private pacient _currentPacient = new pacient();
        private insurance_policy _currentPolis = new insurance_policy();

        public HospitlaForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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

            _currentHost.code = int.Parse(HospCodeTxtBox.Text);
            _currentHost.dateTimeBegin = dateTimeBegin.Value;
            _currentHost.dateTimeEnd = dateTimeEnd.Value;
            _currentHost.departament = deportamentTxtBox.Text;
            _currentHost.diagnos = DiagnosTxtBox.Text;
            _currentHost.goal = GoalTxtBox.Text;

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
            int pacientId = _currentPacient.id;

            if (_currentPolis.id == 0)
                MedEntities.GetContext().insurance_policy.Add(_currentPolis);

            if (_currentPasport.id == 0)
                MedEntities.GetContext().pasport.Add(_currentPasport);

            _currentPacient.pasport_id = pasportId;
            _currentPacient.insurance_id = insuranceId;
            _currentHost.pacient_id = pacientId;

            if (_currentPacient.id == 0)
                MedEntities.GetContext().pacient.Add(_currentPacient);

            if (_currentHost.id == 0)
                MedEntities.GetContext().Host.Add(_currentHost);

            try
            {
                MedEntities.GetContext().SaveChanges();
                MessageBox.Show("Пациент успешно записан на госпитализацию");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            Close();
            MainForm mainForm = new MainForm();
            mainForm.Visible = true;
        }

        private void SearchBtnClick(object sender, EventArgs e)
        {
            int HospCode = int.Parse(searchCodeHosp.Text);

            var Host = MedEntities.GetContext().Host.FirstOrDefault(h => h.code == HospCode);

            if (Host != null) 
            {
                string hospitalInfo = $"Код госпитализации: {Host.code}\n" +
                                        $"Дата Начала: {Host.dateTimeBegin}\n" +
                                        $"Дата Окончания: {Host.dateTimeEnd}\n" +
                                        $"Дата Отделения: {Host.departament}\n" +
                                        $"Диагноз: {Host.diagnos}\n" +
                                        $"Цель: {Host.goal}";

                var pacient = MedEntities.GetContext().pacient.FirstOrDefault(p => p.id == Host.pacient_id);

                if (pacient != null) 
                {
                    string pacientInfo = $"Телефон: {pacient.phone}\n" +
                                            $"Почта: {pacient.email}\n" +
                                            $"Адрес: {pacient.address}\n" +
                                            $"Место работы: {pacient.place_work}";

                    var pasport = MedEntities.GetContext().pasport.FirstOrDefault(p => p.id == pacient.pasport_id);

                    if (pasport != null)
                    {
                        string pasportInfo = $"Фамилия: {pasport.surname}\n" +
                                                $"Имя: {pasport.name}\n" +
                                                $"Отчество: {pasport.father_name}\n" +
                                                $"Дата рождения: {pasport.date_birth}\n" +
                                                $"Пол: {pasport.date_birth}\n" +
                                                $"Номер паспорта: {pasport.number}\n" +
                                                $"Серия паспорта: {pasport.seria}";

                        MessageBox.Show($"{hospitalInfo}\n\n{pasportInfo}\n\n{pacientInfo}");
                    }
                }
            }
        }
    }
}
