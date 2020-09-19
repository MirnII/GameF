using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MATCH_3._3
{
    /// <summary>
    /// Логика взаимодействия для square.xaml
    /// </summary>
    public partial class square : UserControl
    { 
        public static readonly DependencyProperty SelectedProperty;
        public square()
        {
            InitializeComponent();
            
        }

        public bool SelectStatus
        {
            get;
            set;
        }
        public double CordinateX
        {
            get;
            set;
        }
        public double CordinateY
        {
            get;
            set;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
            
        }

        
    }
}
