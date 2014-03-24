using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
        }

        private void button3_Click(object sender, RoutedEventArgs e) {
            Random r = new Random(DateTime.Now.Second);
            for (int iAngle = 0; iAngle <= 360; iAngle += 1) {
                //grdMainGrid.RenderTransform = new RotateTransform(iAngle == 360 ? 0 : r.Next(iAngle), grdMainGrid.Width / 2, grdMainGrid.Height / 2);
                foreach (object o in grdMainGrid.Children) {
                    if (o is Control) {
                        Control c = (Control)o;
                        if (!(c is System.Windows.Controls.Primitives.StatusBar)) {
                            c.RenderTransform = new RotateTransform(iAngle == 360 ? 0 : r.Next(iAngle), c.Width / 2, c.Height / 2);
                        }
                    }
                }
                this.Refresh();
                System.Threading.Thread.Sleep(1);
            }
        }

        private void upButton_Click(object sender, RoutedEventArgs e) {
        }

        private void downButton_Click(object sender, RoutedEventArgs e) {
        }

        private void leftButton_Click(object sender, RoutedEventArgs e) {
        }

        private void rightButton_Click(object sender, RoutedEventArgs e) {
        }
    }

    public static class ExtensionMethods {
        private static Action EmptyDelegate = delegate() { };

        public static void Refresh(this UIElement uiElement) {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }

}
