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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UcWorker : UserControl
    {
        public UcWorker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;
            LbId.Content = worker.getId();
            LbBday.Content = worker.getBirth().ToShortDateString();
            if (worker is GeneralManager)
            {
                LbRole.Content = "Big Boss";
            }
            else if (worker is OperationalWorker)
            {
                LbRole.Content = "OpWorker";
            }
            else
            {
                LbRole.Content = "Worker";
            }
        }

    }
}
