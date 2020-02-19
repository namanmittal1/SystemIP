using System;
using System.Windows;
using System.Net;
using System.Timers;
using System.Windows.Threading;
using System.Windows.Media.Animation;
using System.Windows.Controls;
using System.Collections.Generic;

namespace System_IP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            try
            {                
                this.IPAddress.Content = Dns.GetHostByName(Dns.GetHostName().ToString()).AddressList[0].ToString();
                this.Time.Content = DateTime.Now.ToString("h:mm:ss tt");
                System.Timers.Timer time = new System.Timers.Timer();
                time.Start();
                time.Interval = 1000;
                time.Elapsed -= time_elapsed;
                time.Elapsed += time_elapsed;
            }
            catch (Exception e)
            {

            }
        }

        public void time_elapsed(object sender, ElapsedEventArgs e)
        {
            counter = counter + 1;
            if (counter == 30)
            {
                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => this.IPAddress.Content = Dns.GetHostByName(Dns.GetHostName().ToString()).AddressList[0].ToString()));
                counter = 0;
            }
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() => this.Time.Content = DateTime.Now.ToString("h:mm:ss tt")));
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width - 500;
            this.Top = desktopWorkingArea.Bottom - this.Height - 650;
            
            /* Horizontal 1*/
           DoubleAnimation myDoubleAnimation1 = new DoubleAnimation();
           myDoubleAnimation1.From = 2;  
           myDoubleAnimation1.To = 60; 
           myDoubleAnimation1.Duration = new Duration(TimeSpan.FromSeconds(2)); 
           myDoubleAnimation1.AutoReverse = true;  
           myDoubleAnimation1.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation1, "Hr1");  
           Storyboard.SetTargetProperty(myDoubleAnimation1,new PropertyPath(Canvas.TopProperty));
           Storyboard myStoryboard1 = new Storyboard();  
           myStoryboard1.Children.Add(myDoubleAnimation1);  
           myStoryboard1.Begin(Hr1);

           /* Horizontal 2*/
           DoubleAnimation myDoubleAnimation2 = new DoubleAnimation();
           myDoubleAnimation2.From = 50;
           myDoubleAnimation2.To = 5;
           myDoubleAnimation2.Duration = new Duration(TimeSpan.FromSeconds(2));
           myDoubleAnimation2.AutoReverse = true;
           myDoubleAnimation2.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation2, "Hr2");
           Storyboard.SetTargetProperty(myDoubleAnimation2, new PropertyPath(Canvas.TopProperty));
           Storyboard myStoryboard2 = new Storyboard();
           myStoryboard2.Children.Add(myDoubleAnimation2);
           myStoryboard2.Begin(Hr2);

           /* Horizontal 3*/
           DoubleAnimation myDoubleAnimation3 = new DoubleAnimation();
           myDoubleAnimation3.From = 30;
           myDoubleAnimation3.To = -40;
           myDoubleAnimation3.Duration = new Duration(TimeSpan.FromSeconds(2));
           myDoubleAnimation3.AutoReverse = true;
           myDoubleAnimation3.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation3, "Hr3");
           Storyboard.SetTargetProperty(myDoubleAnimation3, new PropertyPath(Canvas.TopProperty));
           Storyboard myStoryboard3 = new Storyboard();
           myStoryboard3.Children.Add(myDoubleAnimation3);
           myStoryboard3.Begin(Hr3);

           /* Horizontal 4*/
           DoubleAnimation myDoubleAnimation4 = new DoubleAnimation();
           myDoubleAnimation4.From = -5;
           myDoubleAnimation4.To = 50;
           myDoubleAnimation4.Duration = new Duration(TimeSpan.FromSeconds(2));
           myDoubleAnimation4.AutoReverse = true;
           myDoubleAnimation4.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation4, "Hr4");
           Storyboard.SetTargetProperty(myDoubleAnimation4, new PropertyPath(Canvas.TopProperty));
           Storyboard myStoryboard4 = new Storyboard();
           myStoryboard4.Children.Add(myDoubleAnimation4);
           myStoryboard4.Begin(Hr4);

           /* Vertical 1*/
           DoubleAnimation myDoubleAnimation5 = new DoubleAnimation();
           myDoubleAnimation5.From = 0;
           myDoubleAnimation5.To = 270;
           myDoubleAnimation5.Duration = new Duration(TimeSpan.FromSeconds(3));
           myDoubleAnimation5.AutoReverse = true;
           myDoubleAnimation5.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation5, "Vr1");
           Storyboard.SetTargetProperty(myDoubleAnimation5, new PropertyPath(Canvas.LeftProperty));
           Storyboard myStoryboard5 = new Storyboard();
           myStoryboard5.Children.Add(myDoubleAnimation5);
           myStoryboard5.Begin(Vr1);

           /* Vertical 2*/
           DoubleAnimation myDoubleAnimation6 = new DoubleAnimation();
           myDoubleAnimation6.From = 0;
           myDoubleAnimation6.To = -270;
           myDoubleAnimation6.Duration = new Duration(TimeSpan.FromSeconds(3));
           myDoubleAnimation6.AutoReverse = true;
           myDoubleAnimation6.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation6, "Vr2");
           Storyboard.SetTargetProperty(myDoubleAnimation6, new PropertyPath(Canvas.LeftProperty));
           Storyboard myStoryboard6 = new Storyboard();
           myStoryboard6.Children.Add(myDoubleAnimation6);
           myStoryboard6.Begin(Vr2);

           /* Vertical 3*/
           DoubleAnimation myDoubleAnimation7 = new DoubleAnimation();
           myDoubleAnimation7.From = -130;
           myDoubleAnimation7.To = 120;
           myDoubleAnimation7.Duration = new Duration(TimeSpan.FromSeconds(2));
           myDoubleAnimation7.AutoReverse = true;
           myDoubleAnimation7.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation7, "Vr3");
           Storyboard.SetTargetProperty(myDoubleAnimation7, new PropertyPath(Canvas.LeftProperty));
           Storyboard myStoryboard7 = new Storyboard();
           myStoryboard7.Children.Add(myDoubleAnimation7);
           myStoryboard7.Begin(Vr3);

           /* Vertical 4*/
           DoubleAnimation myDoubleAnimation8 = new DoubleAnimation();
           myDoubleAnimation8.From = 140;
           myDoubleAnimation8.To = -110;
           myDoubleAnimation8.Duration = new Duration(TimeSpan.FromSeconds(2));
           myDoubleAnimation8.AutoReverse = true;
           myDoubleAnimation8.RepeatBehavior = RepeatBehavior.Forever;
           Storyboard.SetTargetName(myDoubleAnimation8, "Vr4");
           Storyboard.SetTargetProperty(myDoubleAnimation8, new PropertyPath(Canvas.LeftProperty));
           Storyboard myStoryboard8 = new Storyboard();
           myStoryboard8.Children.Add(myDoubleAnimation8);
           myStoryboard8.Begin(Vr4);
        }


       
    }
}
