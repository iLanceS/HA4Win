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

namespace ha4win.Controls
{
    /// <summary>
    /// DoubleTextBox.xaml 的交互逻辑
    /// </summary>
    public partial class DoubleTextBox : UserControl
    {
        public DoubleTextBox()
        {
            InitializeComponent();
        }


        public String V1
        {
            get { return (String)GetValue(V1Property); }
            set { SetValue(V1Property, value); }
        }

        // Using a DependencyProperty as the backing store for V1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty V1Property = DependencyProperty.Register("V1", typeof(String), typeof(DoubleTextBox), new PropertyMetadata(""));





        public String V2
        {
            get { return (String)GetValue(v2Property); }
            set { SetValue(v2Property, value); }
        }

        // Using a DependencyProperty as the backing store for v2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty v2Property = DependencyProperty.Register("V2", typeof(String), typeof(DoubleTextBox), new PropertyMetadata(""));
    }
}
