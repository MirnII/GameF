using MATCH_3._3.figures;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MATCH_3._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        bool SelectOne = false;
        bool SelectTwo = false;
        double CordinateOneX;
        double CordinateOneY;
        double CordinateTwoX;
        double CordinateTwoY;
        square SelectSquare = null;
        cercle SelectCercle = null;
        triangle SelectTriangle = null;
        pentahedron SelectPentahedron = null;
        hexagon SelectHexagon = null;
        string TypeOne = null;
        string TypeTwo = null;
        DispatcherTimer tick = new DispatcherTimer();
        calculations call = new calculations();
        int second;
        
        private void Start_game_Click(object sender, RoutedEventArgs e)
        {
            second = 60; 
            filling_the_board();
            Start_game.IsEnabled = false;
            tick.Interval = TimeSpan.FromSeconds(1);
            tick.Tick += TimerStart;
            tick.Start(); 
        }

        private void TimerStart(object sender, EventArgs e)
        {
            
            second = second-1;
            Time.Text = second.ToString();
            if (second == 0)
            {
                tick.Stop();
                DoubleAnimation restart = new DoubleAnimation();
                restart.To = 1;
                restart.Duration = TimeSpan.FromSeconds(1);
                GameOVER.Visibility = Visibility.Visible;
                GameOVER.BeginAnimation(OpacityProperty ,restart);
                tick.Interval = TimeSpan.FromSeconds(1);
                tick.Tick += Exit;
                tick.Start();
            }
        }

        private void Exit(object sender, EventArgs e)
        {
            Time.Text = "60";
            YourScore.Text = Score.Text;
            Score.Text = "0";
        }
        
        private void filling_the_board()
        {
            int s = 50;
            double x = 0.0;
            int f = -1;
        NEW:
            f++;

            if (f == 8)
            {
                x = x + 50;
                s = 50;
            }
            if (f == 16) 
            {
                x = x + 50;
                s = 50;
            }
            if (f == 24)
            { 
                x = x + 50;
                s = 50;
            }
            if (f == 32)
            { 
                x = x + 50;
                s = 50;
            }
            if (f == 40) 
            {
                x = x + 50;
                s = 50;
            }
            if (f == 48)
            {
                x = x + 50;
                s = 50;
            }
            if (f == 56)
            { 
                x = x + 50;
                s = 50;
            }
            if (f >= 64) goto Exit;
            Storyboard down = new Storyboard();
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.To = game_board.Height - s;
            doubleAnimation.Duration = TimeSpan.FromSeconds(0.5);
            Random r = new Random(f + Environment.TickCount - Environment.ProcessorCount - (int)x);
            switch (r.Next(1, 16))
            {
                
                case 1:
                    cercle cer = new cercle();
                    cer.SetValue(Canvas.LeftProperty, x);
                    cer.SetValue(Canvas.TopProperty, (double) s);
                    game_board.Children.Add(cer);
                    Storyboard.SetTarget(doubleAnimation, cer);
                    Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Top)"));
                    down.Children.Add(doubleAnimation);
                    down.Duration = doubleAnimation.Duration;
                    cer.CordinateX = Canvas.GetLeft(cer);
                    cer.CordinateY = Canvas.GetTop(cer);
                    cer.MouseDown += Cer_MouseDown;
                    down.Begin();
                    s = s + 50;
                    goto NEW;
                case 9: goto case 1;
                case 11: goto case 1;
                case 2:
                    hexagon hex = new hexagon();
                    hex.SetValue(Canvas.LeftProperty, x);
                    hex.SetValue(Canvas.TopProperty, (double) s);
                    game_board.Children.Add(hex);
                    Storyboard.SetTarget(doubleAnimation, hex);
                    Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Top)"));
                    down.Children.Add(doubleAnimation);
                    down.Duration = doubleAnimation.Duration;
                    hex.CordinateX = Canvas.GetLeft(hex);
                    hex.CordinateY = Canvas.GetTop(hex);
                    hex.MouseDown += Hex_MouseDown;
                    down.Begin();
                    s = s + 50;
                    goto NEW;
                case 7: goto case 2;
                case 15: goto case 2;
                case 3:
                    pentahedron pent = new pentahedron();
                    pent.SetValue(Canvas.LeftProperty, x);
                    pent.SetValue(Canvas.TopProperty, (double) s);
                    game_board.Children.Add(pent);
                    Storyboard.SetTarget(doubleAnimation, pent);
                    Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Top)"));
                    down.Children.Add(doubleAnimation);
                    down.Duration = doubleAnimation.Duration;
                    pent.CordinateX = Canvas.GetLeft(pent);
                    pent.CordinateY = Canvas.GetTop(pent);
                    pent.MouseDown += Pent_MouseDown;
                    down.Begin();
                    s = s + 50;
                    goto NEW;
                case 6: goto case 3;
                case 10: goto case 3;
                case 4:
                    square squ = new square();
                    squ.SetValue(Canvas.LeftProperty,x);
                    squ.SetValue(Canvas.TopProperty, (double) s);
                    game_board.Children.Add(squ);
                    Storyboard.SetTarget(doubleAnimation, squ);
                    Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Top)"));
                    down.Children.Add(doubleAnimation);
                    down.Duration = doubleAnimation.Duration;
                    squ.CordinateX = Canvas.GetLeft(squ);
                    squ.CordinateY = Canvas.GetTop(squ);
                    squ.MouseDown += Squ_MouseDown;
                    down.Begin();
                    
                    
                    s = s + 50; 
                    goto NEW;
                case 8: goto case 4;
                case 13: goto case 4;
                case 5:
                    triangle tri = new triangle();
                    tri.SetValue(Canvas.LeftProperty,x);
                    tri.SetValue(Canvas.TopProperty, (double) s);
                    game_board.Children.Add(tri);
                    Storyboard.SetTarget(doubleAnimation, tri);
                    Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(Canvas.Top)"));
                    down.Children.Add(doubleAnimation);
                    down.Duration = doubleAnimation.Duration;
                    tri.CordinateX = Canvas.GetLeft(tri);
                    tri.CordinateY = Canvas.GetTop(tri);
                    tri.MouseDown += Tri_MouseDown;
                    down.Begin();
                    s = s + 50;
                    goto NEW;
                case 14: goto case 5;
                case 12: goto case 5;
            }
        Exit:
            ;


        }

        private void Cer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectCercle = (cercle)sender;
            if (SelectOne == false)
            {
                SelectOne = true;
                CordinateOneX = SelectCercle.CordinateX;
                CordinateOneY = SelectCercle.CordinateY;
                TypeOne = "cercle";

            }
            else if (SelectOne == true)
            {
                SelectTwo = true;
                CordinateTwoX = SelectCercle.CordinateX;
                CordinateTwoY = SelectCercle.CordinateY;
                TypeTwo = "cercle";

                Storyboard down = new Storyboard();
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                
                doubleAnimation.Duration = TimeSpan.FromSeconds(1.5);
                string answ = call.calculatingPathOne(CordinateOneX, CordinateTwoX, CordinateOneY, CordinateTwoY);
                
                Storyboard.SetTarget(doubleAnimation, SelectCercle);
                Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("("+answ+")"));
                down.Children.Add(doubleAnimation);
                down.Duration = doubleAnimation.Duration;
                SelectCercle.CordinateX = Canvas.GetLeft(SelectCercle);
                SelectCercle.CordinateY = Canvas.GetTop(SelectCercle);
                SelectCercle.MouseDown += Cer_MouseDown;

                down.Begin();

                doubleAnimation.To = CordinateTwoY;
                doubleAnimation.Duration = TimeSpan.FromSeconds(1.5);
                if (answ == "Canvas.Left") SelectHexagon.SetValue(Canvas.RightProperty, CordinateOneX);
                if (answ == "Canvas.Top") SelectHexagon.SetValue(Canvas.BottomProperty, CordinateOneY);
                if (answ == "Canvas.Right") SelectHexagon.SetValue(Canvas.LeftProperty, CordinateOneX);
                if (answ == "Canvas.Bottom") SelectHexagon.SetValue(Canvas.TopProperty, CordinateOneY);
                Storyboard.SetTarget(doubleAnimation, SelectHexagon);
                Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath("(" + call.calculationsPathTwo() + ")"));
                down.Children.Add(doubleAnimation);
                down.Duration = doubleAnimation.Duration;
                SelectHexagon.CordinateX = Canvas.GetLeft(SelectHexagon);
                SelectHexagon.CordinateY = Canvas.GetTop(SelectHexagon);
                SelectHexagon.MouseDown += Hex_MouseDown;

                down.Begin();
                SelectOne = false;
                SelectTwo = false;

            }
        }

        private void Hex_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectHexagon = (hexagon)sender;
            if (SelectOne == false)
            {
                SelectOne = true;
                CordinateOneX = SelectHexagon.CordinateX;
                CordinateOneY = SelectHexagon.CordinateY;
                TypeOne = "hexagon";

            }
            else if (SelectOne == true)
            {
                SelectTwo = true;
                CordinateTwoX = SelectHexagon.CordinateX;
                CordinateTwoY = SelectHexagon.CordinateY;
                TypeTwo = "hexagon";
            }
        }

        private void Pent_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectPentahedron = (pentahedron)sender;
            if (SelectOne == false)
            {
                SelectOne = true;
                CordinateOneX = SelectPentahedron.CordinateX;
                CordinateOneY = SelectPentahedron.CordinateY;
                TypeOne = "pentahedron";

            }
            else if (SelectOne == true)
            {
                SelectTwo = true;
                CordinateTwoX = SelectPentahedron.CordinateX;
                CordinateTwoY = SelectPentahedron.CordinateY;
                TypeTwo = "pentahedron";
            }
        }

        private void Tri_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectTriangle = (triangle)sender;
            if (SelectOne == false)
            {
                SelectOne = true;
                CordinateOneX = SelectTriangle.CordinateX;
                CordinateOneY = SelectTriangle.CordinateY;
                TypeOne = "triangle";

            }
            else if (SelectOne == true)
            {
                SelectTwo = true;
                CordinateTwoX = SelectTriangle.CordinateX;
                CordinateTwoY = SelectTriangle.CordinateY;
                TypeTwo = "triangle";
            }
        }

        private void Squ_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SelectSquare = (square)sender;
            if (SelectOne == false)
            {
                SelectOne = true;
                CordinateOneX = SelectSquare.CordinateX;
                CordinateOneY = SelectSquare.CordinateY;
                TypeOne = "square";
            }
            else if (SelectOne == true)
            {
                SelectTwo = true;
                CordinateTwoX = SelectSquare.CordinateX;
                CordinateTwoY = SelectSquare.CordinateY;
                TypeTwo = "square";
            }
        }

       


       

        private void ExitMainMenu_Click(object sender, RoutedEventArgs e)
        {
            Start_game.IsEnabled = true;
            game_board.Children.Clear();
            
        }
    }
}
