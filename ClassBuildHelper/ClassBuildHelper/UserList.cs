using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassBuildHelper
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            string[] FN = FirstName.Lines;
            string[] LN = LastName.Lines;
            string[] EM = EmailListBox.Lines;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\" + ClassCodeBox.Text + ".ps1", true))
            {
                file.WriteLine("Import-Module ActiveDirectory");
                file.WriteLine("New-ADOrginizationalUnit \"" + ClassCodeBox.Text + "\" -path \"OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org\"");
                file.WriteLine("New-ADOrginizationalUnit \"Students\" -path \"OU=" + ClassCodeBox.Text +",OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org\"");
                file.WriteLine("New-ADGroup -name \"" + ClassCodeBox.Text + "\" -groupscope Global -path \"OU=" + ClassCodeBox.Text + ",OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org\"");
                for (int i = 0; i < FN.GetLength(0); i = i + 1)
                {
                    file.WriteLine("New-ADUser -Name " + FN[i] + LN[i] +
                        " -Path \"OU=Students,OU=" + ClassCodeBox.Text + ",OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org\" " +
                        " -UserPrincipalName " + FN[i][0] + LN[i] +
                        " -AccountPassword(ConvertTo-SecureString 1*Changeme -AsPlainText -Force)" +
                        " -ChangePasswordAtLogon $true -Enabled $true -EmailAddress " + EM[i] +
                        " -accountExpirationDate \"" + EndDate.SelectionEnd.ToString() +
                        " -GivenName " + FN[i] + " -Surname " + LN[i]);
                    file.WriteLine("Add-ADGroupMember \"" + ClassCodeBox.Text + "\" " + FN[i][0] + LN[i] + ";");
                }
            }
      }
    }
}
