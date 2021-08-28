using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using System.Windows.Threading;

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
                    pointArea.Opacity = 0.55;
                    break;
                case PointTypes.Player:
                    point = new Ellipse()
                    {
                        Stroke = Brushes.Black,
                        Height = 10,
                        Width = 10
                    };
                    if (((PlayerInfo)info.Value).PvpMode)
                    {
                        pointArea.Opacity = 0.85;
                        Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++ + 45000);
                        point.Fill = Brushes.Red;
                        caption.FontWeight = FontWeights.Bold;
                    }
                    else
                    {
                        pointArea.Opacity = 0.70;
                        point.Fill = Brushes.Blue;
                    }
                    break;
                case PointTypes.Resurse:
                    point = new Rectangle()
                    {
                        Height = 6,
                        Width = 6,
                        Fill = Brushes.Gray,
                        Stroke = Brushes.Black
                    };
                    switch (((ResurseInfo)info.Value).Lvl)
                    {
                        case 0:
                            pointArea.Opacity = 0.5;
                            point.Fill = Brushes.Transparent;
                            break;
                        case 1:
                            pointArea.Opacity = 0.52;
                            Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++);
                            point.Fill = Brushes.Lime;
                            break;
                        case 2:
                            pointArea.Opacity = 0.54;
                            Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++ + 15000);
                            point.Fill = Brushes.Blue;
                            break;
                        case 3:
                            pointArea.Opacity = 0.56;
                            Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++ + 30000);
                            point.Fill = Brushes.Magenta;
                            break;
                    }
                    break;
            }
            pointArea.Children.Add(point);
            pointArea.Children.Add(caption);
            pointArea.RenderTransform = new RotateTransform(-45);
            radarArea.Children.Add(pointArea);
        }
        public static void DelPoint(int ID, bool dellAll = false)
        {
            if (dellAll)
            {
                //for (int i = 0; i < radarArea.Children.Count; i++)
                //{
                //    radarArea.Children.Remove(radarArea.Children[i]);
                //}
                //return;
            }
            foreach (Grid pointsChild in radarArea.Children)
            {
                if  (pointsChild.Name == $"ID{ID}")
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
                if (((ResurseInfo)info.Value).Lvl >= MainWindow.tierFileter &&
                    ((ResurseInfo)info.Value).Tier >= MainWindow.lvlFilter)
                {
                    if (MainWindow.needHideZeroResouse)
                    {
                        if (((ResurseInfo)info.Value).Nuber == 0)
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
                    if (info.Value.Leave)
                    {
                        ((Grid) radarArea.Children[i]).Opacity = 0.25;
                        //((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Yellow;
                    }
                    else
                    {
                        if (info.Value is PlayerInfo)
                        {
                            if (((PlayerInfo)info.Value).PvpMode)
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
                    switch (((ResurseInfo)info.Value).Type)
                    {
                        case HarvestableTypeResource.WOOD:
                            tmpString = $"{((ResurseInfo) info.Value).Nuber}/W{((ResurseInfo) info.Value).Tier}";
                            break;
                        case HarvestableTypeResource.HIDE:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}/H{((ResurseInfo)info.Value).Tier}";
                            break;
                        case HarvestableTypeResource.ORE:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}/O{((ResurseInfo)info.Value).Tier}";
                            break;
                        case HarvestableTypeResource.ROCK:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}/R{((ResurseInfo)info.Value).Tier}";
                            break;
                        case HarvestableTypeResource.FIBER:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}/F{((ResurseInfo)info.Value).Tier}";
                            break;
                    }
                    //if (((ResurseInfo)info.Value).isStone)
                    //{
                    //    tmpString = $"КАМЕНЬ lvl:{((ResurseInfo)info.Value).Tier} num:{((ResurseInfo)info.Value).nuber} tier:{((ResurseInfo)info.Value).Lvl}";
                    //}
                    //else if (((ResurseInfo)info.Value).isAnimal)
                    //{
                    //    tmpString = $"L:{((ResurseInfo)info.Value).Tier} N:{((ResurseInfo)info.Value).nuber} T:{((ResurseInfo)info.Value).Lvl}";
                    //}
                    //else if (((ResurseInfo)info.Value).isTree)
                    //{
                    //    tmpString = $"ДЕРЕВО lvl:{((ResurseInfo)info.Value).Tier} num:{((ResurseInfo)info.Value).nuber} tier:{((ResurseInfo)info.Value).Lvl}";
                    //}
                    //else
                    //{
                    //    tmpString = $"{((ResurseInfo)info.Value).resurseType}/{(NewSimpleHarvestableObjectListEventHandler.HarvestableType)((ResurseInfo)info.Value).resurseType}";
                    //}
                }
            }
            return tmpString;
        }

    }
}