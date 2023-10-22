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

namespace TelegramMailPageWPF
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

        private void mouse_enter_to_search(object sender, MouseEventArgs e)
        {
            search_textbox.Text = "";
        }

        private void mouse_leave_to_search(object sender, MouseEventArgs e)
        {
            search_textbox.Text = "Search";
        }

        private void mouse_enter_to_write_message(object sender, MouseEventArgs e)
        {
            write_message_txtbox.Text = string.Empty;
        }

        private void mouse_leave_to_write_message(object sender, MouseEventArgs e)
        {
            write_message_txtbox.Text = "Write a message . . .";
        }
    }
}
