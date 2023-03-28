using Syncfusion.UI.Xaml.Charts;
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

namespace Zoom_WPF_Chart_Inside_ScrollViewer
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
    }

    public class ScrollViewerExt: ScrollViewer
    {
        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            //Handle the mouse event for chart to avoid vertical scrolling with mouse wheel.
            //You can just use the scrollbar thumb to achieve vertical scrolling
            if (e.Source is SfChart)
                return;
            
            base.OnMouseWheel(e);
        }
    }
}
