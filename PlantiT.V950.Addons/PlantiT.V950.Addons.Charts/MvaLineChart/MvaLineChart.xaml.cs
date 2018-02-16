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

using PlantiT.Forms.Host.Models;

namespace PlantiT.Forms.Host
{   
    /// <summary>
    /// Interaction logic for MvaLineChart.xaml
    /// </summary>
    public partial class MvaLineChart : UserControl
    {       
        public MvaLineChart()
        {
            InitializeComponent();
            ConnectionViewModel vm = new ConnectionViewModel();
            DataContext = vm;
        }   
    }
}
