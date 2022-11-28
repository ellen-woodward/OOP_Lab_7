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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Q2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int numberMembers = 0;
        static List<Member> members = new List<Member>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ClearWarning();

            string name = tbxName.Text;
            string type = cbxMemberType.Text;

            DateTime date = CheckDate();

            if (name != "" && type != "")
            {
                Member newMember = new Member() { Name = name, Type = type, DateJoined = date };
                members.Add(newMember);
                numberMembers++;
            }
            else if (name == "" || type == "")
            {
                tbxWarning.Text = "Please enter all fields";
                tbxWarning.Background = Brushes.Red;
            }

            lbxMembers.ItemsSource = null;
            lbxMembers.ItemsSource = members;

            tblkNoMembers.Text = numberMembers.ToString();
        }

        private DateTime CheckDate()
        {
            DateTime date;
            if (dpkDate.SelectedDate.HasValue)
                date = (DateTime)dpkDate.SelectedDate.Value;
            else
                date = DateTime.Now;
            return date;
        }

        private void ClearWarning()
        {
            tbxWarning.Background = Brushes.White;
            tbxWarning.Text = "";
        }
    }
}
