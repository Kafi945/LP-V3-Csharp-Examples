## LicensePoint.Net Key Login Example

# Initialize:

Add this to your login page: static readonly LP api = new LP("Your App Name", "Your App Secret", "App Version");

Then on same page under public login function add this

public Login()
   {
     InitializeComponent();
     //Connect the App
      api.Connect();
   }
   
   And Under Login Button you need to use this:
   
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
