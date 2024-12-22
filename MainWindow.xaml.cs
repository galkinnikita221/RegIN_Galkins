using RegIN_Galkins.Classes;
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

namespace RegIN_Galkins
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow mainWindow;
        public User UserLogin = new User();
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            OpenPage(new Pages.Login());
        }

        public void OpenPage(Page page) => Animation.FrameDoubleAnimation(frame, page);
    }
}
