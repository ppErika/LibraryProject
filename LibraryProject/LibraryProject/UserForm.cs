using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

            //Lable 값 매칭

            //DataGrid 매칭
            dataGridViewUsers.DataSource = DataManager.Users;
            dataGridViewUsers.CurrentCellChanged += dataGridViewUsers_CurrentCellChanged;
        }

        private void dataGridViewUsers_CurrentCellChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
