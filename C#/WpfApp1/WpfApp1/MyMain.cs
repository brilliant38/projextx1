using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    class MyMain : Application
    {
        [STAThread]
        public static void Main()
        {
            MyMain app = new MyMain();
            //app.ShutdownMode = ShutdownMode.OnMainWindowClose; //Main이 꺼질때 같이 꺼짐
            app.Run(); //화면에 안 보임.
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // main window
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown; //델리게이트
            mainWindow.Show();

            //sub windows
            for (int i = 0; i < 2; i++)
            {
                Window win = new Window();
                win.Title = "Extra Windows No." + (i + 1);
                win.ShowInTaskbar = false;
                win.Owner = mainWindow; //sub window를 main에 종속시킴
                win.Show();
            }
        }

        private void WinMouseDown(object sender, MouseEventArgs e)
        {
            Window win = new Window();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += Button_Click;
            
            win.Content = b;
            win.ShowDialog(); //Modal 형태
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
