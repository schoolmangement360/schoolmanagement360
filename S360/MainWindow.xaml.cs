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
using S360BusinessLogic;

namespace S360
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            S360Repository test = new S360Repository();
            var testing = S360Repository.FirstStudent();
            firstname.Text = testing.Name;
            FatherName.Text = testing.FatherName;
            RegNo.Text = testing.RegNo;
        }
    }
}
