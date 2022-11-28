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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static List<Expense> expenses = new List<Expense>();
        static decimal total = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Expense e1 = new Expense() { Category = "Travel", Amount = 19.95m, ExpenseDate = new DateTime(2022, 11, 28) };
            Expense e2 = new Expense() { Category = "Entertainment", Amount = 27.99m, ExpenseDate = new DateTime(2022, 1, 9) };
            Expense e3 = new Expense() { Category = "Office", Amount = 50.80m, ExpenseDate = new DateTime(2022, 12, 1) };

            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);

            lbxExpenses.ItemsSource = expenses;

            foreach (Expense expense in expenses)
            {
                total += expense.Amount;
            }

            PrintTotal();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            Expense newExpense = new Expense() { Category = "Other", Amount = (decimal)rng.Next(1, 101), ExpenseDate = DateTime.Today};

            expenses.Add(newExpense);
            lbxExpenses.ItemsSource = null;
            lbxExpenses.ItemsSource = expenses;

            total += newExpense.Amount;
            PrintTotal();
        }

        private void PrintTotal()
        {
            tblkTotal.Text = $"{total:c}";
        }
    }
}
