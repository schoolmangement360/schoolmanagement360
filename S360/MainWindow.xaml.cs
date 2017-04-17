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
using S360Logging;

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StudentBusinessLogic test = new StudentBusinessLogic();
            var testing = test.FirstStudent();
            firstname.Text = testing.Name;
            FatherName.Text = testing.FatherName;
            RegNo.Text = testing.RegNo;

            ////try
            ////{
            ////    S360Log.Instance.Debug("We're going to throw an exception now.");
            ////    S360Log.Instance.Warn("It's gonna happen!!");
            ////    throw new ApplicationException();
            ////}
            ////catch (ApplicationException ae)
            ////{
            ////    S360Log.Instance.ErrorException("Error doing something...", ae);
            ////}
        }
    }
}
