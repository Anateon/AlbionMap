using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Albion.Network.Interface
{
    public static class PointsControll
    {
        public static Grid radarArea;

        public enum PointTypes
        {
            Player,
            Mob
        }
        private static void AddPoint(KeyValuePair<int, ChelInfo> info, PointTypes types)
        {
            Grid pointArea = new Grid()
            {
                Margin = new Thickness((info.Value.X - MainWindow.MyInfo.X) * MainWindow.scale, 0, 0,
                    (info.Value.Y - MainWindow.MyInfo.Y) * MainWindow.scale),
                Name = $"ID{info.Key}",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                RenderTransformOrigin = new Point(0.5,0.5),
            };
            Ellipse point = new Ellipse()
            {
                Stroke = Brushes.Black
            };

            //Label caption2 = new Label()
            //{
            //    HorizontalAlignment = HorizontalAlignment.Center,
            //    VerticalAlignment = VerticalAlignment.Bottom,
            //    Margin = new Thickness(0, 25, 0, 0),
            //    Content = Math.Round(info.Value.NowHP / (double)info.Value.FullHP * 100.0, 2) + "%"
            //};

            TextBlock caption = new TextBlock()
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Bottom,
                Margin = new Thickness(0, 23, 0, 0),
                Text = GetInfoString(info)
            };


            switch (types)
            {
                case PointTypes.Mob:
                    pointArea.Opacity = 0.5;
                    point.Height = point.Width = 7;
                    point.Fill = Brushes.Blue;
                    break;
                case PointTypes.Player:
                    pointArea.Opacity = 0.65;
                    point.Height = point.Width = 10;
                    point.Fill = Brushes.Red;
                    break;
            }
            pointArea.Children.Add(point);
            pointArea.Children.Add(caption);
            pointArea.RenderTransform = new RotateTransform(-45);
            radarArea.Children.Add(pointArea);
        }
        public static void DelPoint(int ID)
        {
            foreach (Grid pointsChild in radarArea.Children)
            {
                if (pointsChild.Name == $"ID{ID}")
                {
                    pointsChild.Children.Clear();
                    radarArea.Children.Remove(pointsChild);
                    return;
                }
            }
        }
        public static void UpdatePoints(KeyValuePair<int, ChelInfo> info)
        {
            if (!ChangeIfCreated(info))
            {
                if (info.Value.isMob)
                {
                    AddPoint(info, PointTypes.Mob);
                }
                else
                {
                    AddPoint(info, PointTypes.Player);
                }
            }
        }
        private static bool ChangeIfCreated(KeyValuePair<int, ChelInfo> info)
        {
            for (int i = 0; i < radarArea.Children.Count; i++)
            {
                if (((Grid) radarArea.Children[i]).Name == $"ID{info.Key}")
                {
                    ((Grid) radarArea.Children[i]).Margin = new Thickness((info.Value.X - MainWindow.MyInfo.X) * MainWindow.scale, 0, 0,
                        (info.Value.Y - MainWindow.MyInfo.Y) * MainWindow.scale);
                    ((TextBlock)((Grid) radarArea.Children[i]).Children[1]).Text = GetInfoString(info);


                    if (info.Value.leave)
                    {
                        ((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Yellow;
                    }
                    else
                    {
                        switch (info.Value.isMob)
                        {
                            case true:
                                ((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Blue;
                                break;
                            case false:
                                ((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Red;
                                break;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        private static string GetInfoString(KeyValuePair<int, ChelInfo> info)
        {
            string tmpString = "";
            if (MainWindow.needNickname)
            {
                tmpString += info.Value.name;
            }

            if (MainWindow.needHPValuve)
            {
                tmpString += $" {info.Value.FullHP}/{info.Value.NowHP}"; 
            }

            if (MainWindow.needHPProcent)
            {
                tmpString += $" [{Math.Round(info.Value.NowHP / (double)info.Value.FullHP * 100.0, 2)}%]";
            }
            return tmpString;
        }

    }
}