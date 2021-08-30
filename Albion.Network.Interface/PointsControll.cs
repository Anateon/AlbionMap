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
using Albion.Network.Interface.BinDumps;

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
                    pointArea.Opacity = 0.6;
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
                    if (((ResurseInfo) info.Value).Type != HarvestableTypeResource.FISH)
                    {
                        pointArea.Opacity = 0.5;
                        switch (((ResurseInfo)info.Value).Lvl)
                        {
                            case 0:
                                point.Fill = Brushes.Transparent;
                                break;
                            case 1:
                                Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++);
                                point.Fill = Brushes.DarkGreen;
                                break;
                            case 2:
                                Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++ + 15000);
                                point.Fill = Brushes.Blue;
                                break;
                            case 3:
                                Panel.SetZIndex(pointArea, MainWindow.ZIndexCounter++ + 30000);
                                point.Fill = Brushes.MediumVioletRed;
                                break;
                        }
                    }
                    else
                    {
                        switch (((ResurseInfo)info.Value).Lvl)
                        {
                            case -2:
                                pointArea.Opacity = 0.5;
                                switch (((ResurseInfo)info.Value).Nuber)
                                {
                                    case 1:
                                        point.Fill = Brushes.Black;
                                        pointArea.Opacity = 0.5;
                                        break;
                                    case 2:
                                        point.Fill = Brushes.Red;
                                        pointArea.Opacity = 1;
                                        break;
                                        
                                    case 3:
                                        point.Fill = Brushes.Red;
                                        pointArea.Opacity = 0.5;
                                        break;

                                    case 4:
                                        pointArea.Opacity = 0;
                                        break;
                                }
                                break;
                            default:
                                pointArea.Opacity = 0.5;
                                point.Fill = Brushes.Transparent;
                                break;
                        }
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
            if (info.Value is PlayerInfo)
            {
                return MainWindow.needShowPlayers;
            }
            else if (info.Value is MobInfo)
            {
                if (MainWindow.MobFilter[((MobInfo) info.Value).Tier, ((MobInfo) info.Value).Lvl])
                {
                    switch (MainWindow.filterListMode)
                    {
                        case 1: // white list
                            foreach (var name in MainWindow.listNames)
                            {
                                if (name == ((MobInfo) info.Value).Name)
                                {
                                    return true;
                                }
                            }
                            return false;
                        case 2: // black list
                            foreach (var name in MainWindow.listNames)
                            {
                                if (name == ((MobInfo) info.Value).Name)
                                {
                                    return false;
                                }
                            }
                            break;
                        default:
                            return true;
                    }
                }
                return false;
            }
            else if (info.Value is ResurseInfo)
            {
                if (MainWindow.needHideZeroResouse && ((ResurseInfo) info.Value).Nuber == 0)
                {
                    return false;
                }
                switch (((ResurseInfo)info.Value).Type)
                {
                    case HarvestableTypeResource.FIBER:
                        if (!MainWindow.needShowFiber)
                            return false;
                        break;
                    case HarvestableTypeResource.HIDE:
                        if (!MainWindow.needShowHide)
                            return false;
                        break;
                    case HarvestableTypeResource.ORE:
                        if (!MainWindow.needShowOre)
                            return false;
                        break;
                    case HarvestableTypeResource.ROCK:
                        if (!MainWindow.needShowRock)
                            return false;
                        break;
                    case HarvestableTypeResource.WOOD:
                        if (!MainWindow.needShowWood)
                            return false;
                        break;
                    case HarvestableTypeResource.FISH:
                            return MainWindow.needShowFish;
                }
                return MainWindow.ResurseFilter[((ResurseInfo) info.Value).Tier, ((ResurseInfo) info.Value).Lvl];
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
                        if (info.Value is ResurseInfo &&
                            ((ResurseInfo) info.Value).Type == HarvestableTypeResource.FISH &&
                            ((ResurseInfo) info.Value).Lvl == -2)
                        {
                            ((Grid)radarArea.Children[i]).Opacity = 0;
                        }
                        else
                        {
                            ((Grid)radarArea.Children[i]).Opacity = 0.25;
                        }
                        return true;
                        //((Ellipse)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Yellow;
                    }
                    else
                    {
                        if (info.Value is PlayerInfo)
                        {
                            if (((PlayerInfo)info.Value).PvpMode)
                            {
                                ((Grid)radarArea.Children[i]).Opacity = 0.85;
                                ((Shape)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Red;
                                Panel.SetZIndex(((Grid)radarArea.Children[i]), MainWindow.ZIndexCounter++);
                                ((TextBlock)((Grid)radarArea.Children[i]).Children[1]).FontWeight = FontWeights.Bold;
                            }
                            else
                            {
                                ((Grid)radarArea.Children[i]).Opacity = 0.65;
                                ((Shape)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Blue;
                                ((TextBlock)((Grid)radarArea.Children[i]).Children[1]).FontWeight = FontWeights.Normal;
                            }
                        }
                        else if (info.Value is ResurseInfo)
                        {
                            if (((ResurseInfo) info.Value).Type != HarvestableTypeResource.FISH)
                            {
                                ((Grid)radarArea.Children[i]).Opacity = 0.5;
                            }
                            else
                            {
                                ((Grid)radarArea.Children[i]).Opacity = 0.5;
                                switch (((ResurseInfo)info.Value).Lvl)
                                {
                                    case -2:
                                        switch (((ResurseInfo)info.Value).Nuber)
                                        {
                                            case 1:
                                                ((Shape)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Black;
                                                ((Grid)radarArea.Children[i]).Opacity = 0.5;
                                                break;
                                            case 2:
                                                ((Shape)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Red;
                                                ((Grid)radarArea.Children[i]).Opacity = 1;
                                                break;

                                            case 3:
                                                //((Shape)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Red;
                                                ((Shape)((Grid)radarArea.Children[i]).Children[0]).Fill = Brushes.Transparent;
                                                ((Grid)radarArea.Children[i]).Opacity = 0.5;
                                                break;

                                            case 4:
                                                ((Grid)radarArea.Children[i]).Opacity = 0;
                                                break;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        else if (info.Value is MobInfo)
                        {
                            ((Grid)radarArea.Children[i]).Opacity = 0.6;
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
            if (info.Value is PlayerInfo)
            {
                if (MainWindow.needShowNickname)
                {
                    tmpString += ((PlayerInfo)info.Value).Name;
                }
                if (MainWindow.needShowPlayerHPValuve)
                {
                    tmpString += $" {((LifeObject)info.Value).FullHP}/{((LifeObject)info.Value).NowHP}";
                }
                if (MainWindow.needShowPlayerHPProcent)
                {
                    tmpString +=
                        $" [{Math.Round(((LifeObject)info.Value).NowHP / (double)((LifeObject)info.Value).FullHP * 100.0, 2)}%]";
                }
            }
            else if (info.Value is MobInfo)
            {
                if (MainWindow.needResourseCaption)
                {
                    if (MainWindow.needShowMobName)
                    {
                        tmpString += $"{((MobInfo)info.Value).Name}";
                    }
                    if (MainWindow.needShowMobHPValuve)
                    {
                        tmpString += $" {((LifeObject)info.Value).FullHP}/{((LifeObject)info.Value).NowHP}";
                    }
                    if (MainWindow.needShowMobHPProcent)
                    {
                        tmpString +=
                            $" [{Math.Round(((LifeObject)info.Value).NowHP / (double)((LifeObject)info.Value).FullHP * 100.0, 2)}%]";
                    }
                    if (((MobInfo)info.Value).Lvl != 0)
                    {
                        tmpString += $" T:{((MobInfo)info.Value).Lvl}";
                    }
                }
            }
            else if (info.Value is ResurseInfo)
            {
                if (MainWindow.needResourseCaption)
                {
                    switch (((ResurseInfo)info.Value).Type)
                    {
                        case HarvestableTypeResource.WOOD:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}W{((ResurseInfo)info.Value).Tier}.{((ResurseInfo)info.Value).Lvl}";
                            break;
                        case HarvestableTypeResource.HIDE:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}H{((ResurseInfo)info.Value).Tier}.{((ResurseInfo)info.Value).Lvl}";
                            break;
                        case HarvestableTypeResource.ORE:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}O{((ResurseInfo)info.Value).Tier}.{((ResurseInfo)info.Value).Lvl}";
                            break;
                        case HarvestableTypeResource.ROCK:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}R{((ResurseInfo)info.Value).Tier}.{((ResurseInfo)info.Value).Lvl}";
                            break;
                        case HarvestableTypeResource.FIBER:
                            tmpString = $"{((ResurseInfo)info.Value).Nuber}F{((ResurseInfo)info.Value).Tier}.{((ResurseInfo)info.Value).Lvl}";
                            break;
                        case HarvestableTypeResource.FISH:
                            switch (((ResurseInfo)info.Value).Lvl)
                            {
                                case 0:
                                    tmpString = $"{((ResurseInfo)info.Value).Nuber} FISH";
                                    break;
                                case -1:
                                    tmpString = $"{((ResurseInfo)info.Value).Nuber} FISH AREA";
                                    break;
                                case -2:
                                    break;
                            }
                            break;
                    }
                }

            }
            return tmpString;
        }
    }
}