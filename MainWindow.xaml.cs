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

namespace WpfApp2
{
  
    public partial class MainWindow : Window
    {
        List<Book> Books = new List<Book>();

        public MainWindow()
        {
            InitializeComponent();
            List();
        }

        public void List()
        {
            Book b = new Book();
            b.ISBN = "1001";
            b.Title = "C# Step by Step";
            b.AFirstN = "Bill";
            b.ALastN = "Gates";
            this.UILIST.Items.Add(b);

            Book c = new Book();
            c.ISBN = "1002";
            c.Title = "Der Name Der Rose";
            c.AFirstN = "Umberto";
            c.ALastN = "Eco";
            this.UILIST.Items.Add(c);

            Book d = new Book();
            d.ISBN = "1003";
            d.Title = "Resturlaub";
            d.AFirstN = "Eco";
            d.ALastN = "Jaud";
            this.UILIST.Items.Add(d);


            UILIST.Items.Refresh();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            Book selectedbuch = (Book)UILIST.SelectedItem;
            selectedbuch.ALastN = tbLastname.Text;
            selectedbuch.AFirstN = tbfirstname.Text;
            selectedbuch.ISBN = tbISBN.Text;
            selectedbuch.Title = tbtitle.Text;

            UILIST.Items.Refresh();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            int selected_book = UILIST.SelectedIndex;

            UILIST.Items.RemoveAt(selected_book);
            UILIST.Items.Refresh();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Book B = new Book();
            B.Title = tbtitle.Text;
            B.ISBN = tbISBN.Text;
            B.AFirstN = tbfirstname.Text;
            B.ALastN = tbLastname.Text;
            this.UILIST.Items.Add(B);
            UILIST.Items.Refresh();
        }

        private void UILIST_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
            Book selectedbuch = (Book)UILIST.SelectedItem;

            if (selectedbuch != null)
            {
                tbfirstname.Text = selectedbuch.AFirstN;
                tbISBN.Text = selectedbuch.ISBN;
                tbLastname.Text = selectedbuch.AFirstN;
                tbtitle.Text = selectedbuch.Title;
            }
            

        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            UILIST.SelectedItem = "0";
            tbfirstname.Text = "";
            tbISBN.Text = "";
            tbLastname.Text = "";
            tbtitle.Text = "";
        }
    }
}
