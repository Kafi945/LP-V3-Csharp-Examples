using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicensePoint
{
    public partial class Login : Form
    {
        static readonly LP api = new LP("My First App", "mD0zOOJS9GIK59QKwqZgYyuHwNrnEGi0jiA87j1g0J15T", "1.0");


        public Login()
        {
            InitializeComponent();

            api.Connect();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
           

            if (api.licenseLogin(textBox1.Text))
            {
                MessageBox.Show("Successfully logged in!" +Info.Expires, Auth.appName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Log In", Auth.appName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
