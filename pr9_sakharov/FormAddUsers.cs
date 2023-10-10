using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr9_sakharov.DBContext;

namespace pr9_sakharov
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }
        ModelEF model = new ModelEF();

        private void FormAddUsers_Load(object sender, EventArgs e)
        {
            bindingSourceRole.DataSource = model.Roles.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$", RegexOptions.IgnoreCase);
            if (!regex.IsMatch(emailTextBox.Text))
            {
                MessageBox.Show("Почта не соответствуют требованиям, @!");
                return;
            }
            if (!passwordTextBox.Text.Equals(passwordTextBox2.Text))
            {
                MessageBox.Show("Пароли не равны, логин неполноценный");
            }
            if (String.IsNullOrWhiteSpace(loginTextBox.Text) || String.IsNullOrWhiteSpace(passwordTextBox.Text) || 
                String.IsNullOrWhiteSpace(first_NameTextBox.Text) || String.IsNullOrWhiteSpace(second_NameTextBox.Text) || !PhonemaskedTextBox.MaskCompleted)
            {
                MessageBox.Show("Заполни все поля, дебил!");
            }

            Users users = new Users();
            users.ID = 0;
            users.Login = loginTextBox.Text;
            users.Password = passwordTextBox.Text;
            users.Email = emailTextBox.Text;
            users.Phone = PhonemaskedTextBox.Text;
            users.First_Name = first_NameTextBox.Text;
            users.Second_Name = second_NameTextBox.Text;
            users.RoleID = (int)roleIDcomboBox.SelectedValue;
            users.Gender = radioButtonMen.Checked ? "" : "";

            try
            {
                model.Users.Add(users);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Данные добавлены!");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
