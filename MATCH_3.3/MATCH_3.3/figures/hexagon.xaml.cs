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

namespace MATCH_3._3.figures
{
    /// <summary>
    /// Логика взаимодействия для hexagon.xaml
    /// </summary>
    public partial class hexagon : UserControl
    {
        public hexagon()
        {
            InitializeComponent();
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

        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}
