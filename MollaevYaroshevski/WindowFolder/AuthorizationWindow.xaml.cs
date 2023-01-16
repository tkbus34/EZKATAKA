using MollaevYaroshevski.ClassFolder;
using MollaevYaroshevski.DataFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MollaevYaroshevski.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordPSB.Password))
            {
                MBClass.ErrorMB("Password");
                PasswordPSB.Focus();
            }
            else
            {
                try
                {
                    var user = DBEnities.GetContext().User.FirstOrDefault(u => u.Login == LOginText.Text);
                    if (user == null)
                    {
                        MBClass.ErrorMB("Incorect Login");
                        return;
                    }
                    if (user.Password != PasswordPSB.Password)
                    {
                        MBClass.ErrorMB("Incorect PAssword");
                        return;
                    }
                    else
                    {
                        switch (user.IdRole)
                        {
                            case 1:
                                new admin().Show();
                                break;
                            case 2:
                                MBClass.InfoMB("Rab");
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
