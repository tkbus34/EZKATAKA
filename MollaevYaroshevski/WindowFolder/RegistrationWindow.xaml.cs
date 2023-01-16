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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegBTN_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTB.Text))
            {
                MBClass.ErrorMB("Login");
                LoginTB.Focus();
            }
            else if(DBEnities.GetContext().User.FirstOrDefault(u=>u.Login==LoginTB.Text) != null)
            {
                MBClass.ErrorMB("Существует");
                LoginTB.Focus();
            }
            else if(string.IsNullOrWhiteSpace(PasswordPSB.Password))
            {
                MBClass.ErrorMB("НЕту");
                
            }
            else if (string.IsNullOrWhiteSpace(RepeatPasswordPSB.Password))
            {
                MBClass.ErrorMB("Нету");
            }
            else
            {

            }
        }
    }
}
