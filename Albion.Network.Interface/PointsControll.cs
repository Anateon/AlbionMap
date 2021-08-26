using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace Albion.Network.Interface
{
    public static class PointsControll
    {
        public static Grid radarArea;

        public enum PointTypes
        {
            Player,
            Mob,
            Resurse
        }
        private static void AddPoint(KeyValuePair<int, ObjectInfo> info, PointTypes types)
        {
            if (!NeedShow(info))
            {
                return;
            }
            Grid pointArea = new Grid()
            {
                Margin = new Thickness((info.Value.X - MainWindow.MyInfo.X) * MainWindow.scale, 0, 0,
                    (info.Value.Y - MainWindow.MyInfo.Y) * MainWindow.scale),
                Name = $"ID{info.Key}",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                RenderTransformOrigin = new Point(0.5,0.5),
            };
            Shape point = null;

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
                    point = new Ellipse()
                    {
                        Stroke = Brushes.Black,
                        Height = 7,
                        Width = 7,
                        Fill = Brushes.Yellow
                    };
                    pointArea.Opacity = 0.5;
                    break;
                case PointTypes.Player:
                    point = new Ellipse()
                    {
                        Stroke = Brushes.Black,
                        Height = 10,
                        Width = 10
                    };
                    if (((PlayerInfo)info.Value).pvpMode)
                    {
                        pointArea.Opacity = 0.85;
                        Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++);
                        point.Fill = Brushes.Red;
                        caption.FontWeight = FontWeights.Bold;
                    }
                    else
                    {
                        pointArea.Opacity = 0.65;
                        point.Fill = Brushes.Blue;
                    }
                    break;
                case PointTypes.Resurse:
                    point = new Rectangle()
                    {
                        Height = 6,
                        Width = 6,
                        Fill = Brushes.Green,
                        Stroke = Brushes.Black
                    };
                    pointArea.Opacity = 0.5;
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
        public static void UpdatePoints(KeyValuePair<int, ObjectInfo> info)
        {
            if (!ChangeIfCreated(info))
            {
                if (info.Value is PlayerInfo)
                {
                    AddPoint(info, PointTypes.Player);
                }
                else if(info.Value is MobInfo)
                {
                    AddPoint(info, PointTypes.Mob);
                }
                else
                {
                    AddPoint(info, PointTypes.Resurse);
                }
            }
        }

        private static bool NeedShow(KeyValuePair<int, ObjectInfo> info)
        {
            if (info.Value is MobInfo)
            {
                if (!(((MobInfo)info.Value).FullHP == MainWindow.moobNeedHP || MainWindow.moobNeedHP == 0))
                {
                    return false;
                }

                if (!(((MobInfo)info.Value).Tier >= MainWindow.tierFileter))
                {
                    return false;
                }
            }

            if (info.Value is ResurseInfo)
            {
                if (((ResurseInfo)info.Value).Tier >= MainWindow.tierFileter &&
                    ((ResurseInfo)info.Value).Lvl >= MainWindow.lvlFilter)
                {
                    if (MainWindow.needHideZeroResouse)
                    {
                        if (((ResurseInfo)info.Value).nuber == 0)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        private static bool ChangeIfCreated(KeyValuePair<int, ObjectInfo> info)
        {
            bool needDelete = false;
            if (!NeedShow(info))
            {
                needDelete = true;
            }

            for (int i = 0; i < radarArea.Children.Count; i++)
            {
                if (((Grid) radarArea.Children[i]).Name == $"ID{info.Key}")
                {
                    if (needDelete)
                    {
                        DelPoint(info.Key);
                        return true;
                    }
                    ((Grid) radarArea.Children[i]).Margin = new Thickness((info.Value.X - MainWindow.MyInfo.X) * MainWindow.scale, 0, 0,
                        (info.Value.Y - MainWindow.MyInfo.Y) * MainWindow.scale);
                    ((TextBlock)((Grid) radarArea.Children[i]).Children[1]).Text = GetInfoString(info);
                    if (info.Value.leave)
                    {
                        ((Grid) radarArea.Children[i]).Opacity = 0.25;
                        //((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Yellow;
                    }
                    else
                    {
                        if (info.Value is PlayerInfo)
                        {
                            if (((PlayerInfo)info.Value).pvpMode)
                            {
                                ((Grid)radarArea.Children[i]).Opacity = 0.85;
                                ((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Red;
                                Panel.SetZIndex(((Grid)radarArea.Children[i]), MainWindow.ZIndexCounter++);
                                ((TextBlock)((Grid)radarArea.Children[i]).Children[1]).FontWeight = FontWeights.Bold;
                            }
                            else
                            {
                                ((Grid)radarArea.Children[i]).Opacity = 0.65;
                                ((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Blue;
                                ((TextBlock)((Grid)radarArea.Children[i]).Children[1]).FontWeight = FontWeights.Normal;
                            }
                        }
                        else
                        {
                            ((Grid)radarArea.Children[i]).Opacity = 0.5;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        private static string GetInfoString(KeyValuePair<int, ObjectInfo> info)
        {
            string tmpString = "";
            if (!(info.Value is ResurseInfo))
            {
                if (info.Value is MobInfo)
                {
                    tmpString += $"T:{((MobInfo)info.Value).Tier}";
                }
                if (info.Value is PlayerInfo && MainWindow.needNickname)
                {
                    tmpString += ((PlayerInfo)info.Value).Name;
                }

                if (MainWindow.needHPValuve)
                {
                    tmpString += $" {((LifeObject)info.Value).FullHP}/{((LifeObject)info.Value).NowHP}";
                }

                if (MainWindow.needHPProcent)
                {
                    tmpString += $" [{Math.Round(((LifeObject)info.Value).NowHP / (double)((LifeObject)info.Value).FullHP * 100.0, 2)}%]";
                }
                }
            else
            {
                if (MainWindow.needResourseCaption)
                {
                    if (((ResurseInfo)info.Value).isStone)
                    {
                        tmpString = $"КАМЕНЬ lvl:{((ResurseInfo)info.Value).Lvl} num:{((ResurseInfo)info.Value).nuber} tier:{((ResurseInfo)info.Value).Tier}";
                    }
                    else if (((ResurseInfo)info.Value).isAnimal)
                    {
                        tmpString = $"L:{((ResurseInfo)info.Value).Lvl} N:{((ResurseInfo)info.Value).nuber} T:{((ResurseInfo)info.Value).Tier}";
                    }
                    else if (((ResurseInfo)info.Value).isTree)
                    {
                        tmpString = $"ДЕРЕВО lvl:{((ResurseInfo)info.Value).Lvl} num:{((ResurseInfo)info.Value).nuber} tier:{((ResurseInfo)info.Value).Tier}";
                    }
                    else
                    {
                        tmpString = $"WTF!!!!!!! lvl:{((ResurseInfo)info.Value).Lvl} num:{((ResurseInfo)info.Value).nuber} tier:{((ResurseInfo)info.Value).Tier}";
                    }
                }
            }
            return tmpString;
        }

    }
}