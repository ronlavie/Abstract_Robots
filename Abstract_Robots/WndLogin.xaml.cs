using Abstract_Robots;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים


        public MainWindow()
        {
            InitializeComponent();
            workers = workerList();
            activeRobots = RobotList();
            activeMissions = MissonsList();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:", "Good bye", MessageBoxButton.OK);
            this.Close();
        }

        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        private List<Worker> workerList()
        {
            workers = new List<Worker>();
            workers.Add(new GeneralManager("j4", "2222", new DateTime(11 / 1 / 2000), "1234", 3336.0, 370.0));
            workers.Add(new Worker("j2", "2522", new DateTime(11 / 3 / 2000), "1254", 3336.0, 370.0));
            workers.Add(new OperationalWorker("j1", "2222", new DateTime(11 / 2 / 2000), "1214", 3336.0, 370.0));
            workers.Add(new Worker("j3", "2322", new DateTime(11 / 4 / 2000), "3334", 22, 370.0));
            workers.Add(new Worker("j5", "622", new DateTime(11 / 5 / 2000), "1239", 3336.0, 370.0));
            workers.Add(new Worker("abdul",)
            workers.Add(new OperationManager("gamzo", "453643", new DateTime(5 / 5 / 3312), "12347", 1244, 180, 151));
            workers.Add(new OperationManager("kirill", "45643", new DateTime(5 / 3 / 2312), "124747", 1264, 180, 1516));
            workers.Add(new OperationalWorker("kir", "36985", new DateTime(7 / 6 / 2100), "2221", 145, 333));

            return workers;
        }
        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        private List<RobotSpy> RobotList()
        {
            activeRobots = new List<RobotSpy>();
            activeRobots.Add(new RobotQuad("kq4", new DateTime(1 / 5 / 2200), 12));
            activeRobots.Add(new RobotQuad("q4", new DateTime(1 / 5 / 2200), 12));
            activeRobots.Add(new RobotQuad("kq", new DateTime(3 / 5 / 2200), 19));
            activeRobots.Add(new RobotQuad("k", new DateTime(1 / 5 / 2200), 12));
            activeRobots.Add(new RobotQuad("q", new DateTime(1 / 5 / 2200), 12));
            activeRobots.Add(new RobotQuad("k4", new DateTime(5 / 5 / 2200), 100));
            activeRobots.Add(new RobotQuad("4", new DateTime(1 / 5 / 2200), 12));
            activeRobots.Add(new RobotQuad("k14", new DateTime(1 / 5 / 2200), 16));

            return activeRobots;
        }
        //משימה 3

        private List<Mission> MissonsList()
        {
            activeMissions = new List<Mission>();
            activeMissions.Add(new Mission(new DateTime(6 / 5 / 2011), "Collecting monkeys"));
            activeMissions.Add(new Mission(new DateTime(1 / 1 / 2014), "Collecting Bananas"));
            activeMissions.Add(new Mission(new DateTime(5 / 2 / 2013), "Being a spy"));
            activeMissions.Add(new Mission(new DateTime(8 / 4 / 2001), "Shooting potatoes"));
            activeMissions.Add(new Mission(new DateTime(1 / 2 / 2021), "Eating chips"));

            return activeMissions;
        }        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        //

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;
            workers.ForEach(worker =>
            {
                if (tbxID.Text.Equals(worker.getId()) && tbxPassword.Password.Equals(worker.getpass()))
                {
                    WndMain main = new WndMain(worker, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                    found = true;
                    return;
                }
            });
            if (!found)
                MessageBox.Show("you are not in the list");

        }
    }
}
