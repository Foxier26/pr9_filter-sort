using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pr9_sakharov.DBContext;

namespace pr9_sakharov
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        ModelEF model = new ModelEF();
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewPersons.DataSource = model.Users.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddUsers formAddUsers = new FormAddUsers();
            formAddUsers.ShowDialog();
            dataGridViewPersons.DataSource = model.Users.ToList();
        }
    }
}
