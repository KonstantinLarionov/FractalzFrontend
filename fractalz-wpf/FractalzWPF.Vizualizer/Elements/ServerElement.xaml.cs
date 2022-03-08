using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Entities.Voice;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using FractalzWPF.Infrastructure.Application.Events;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    public partial class ServerElement : UserControl
    {
        public readonly int _id;
        private readonly INavigatorControls _controls;
        private readonly INavigatorHandlers _handlers;
        private readonly NotifyHandler _noty;

        public ServerElement(int id, string name, 
            List<VoiceRoom> rooms, 
            Dictionary<int, List<User>>userrooms, 
            INavigatorControls controls, 
            INavigatorHandlers handlers,
            NotifyHandler noty)
        {
            InitializeComponent();
            _id = id;
            _controls = controls;
            _handlers = handlers;
            _noty = noty;
            this.ContextMenu = CreateContextMenu();
            
            nameServer.Content = name;
            for (int i = 0; i < rooms.Count; i++)
                treeViewRooms.Items.Add(CreateUIRoom(rooms[i].Id, rooms[i].Name,
                    userrooms.FirstOrDefault(x=>x.Key == rooms[i].Id).Value));
        }

        #region [ContextMenuServer]
        private ContextMenu CreateContextMenu()
        {
            var cm = new ContextMenu();
            var mi = new MenuItem();
            mi.Header = "Создать комнату";
            mi.Click += CreateRoom;
            cm.Items.Add(mi);
            var mi2 = new MenuItem();
            mi2.Header = "Удалить сервер";
            mi2.Click += DeleteServer;
            cm.Items.Add(mi2);
            return cm;
        }

        private void DeleteServer(object sender, RoutedEventArgs e)
        {
            var result = _handlers.DeleteMyServerHandler.Do(_id);
            if (result.Success)
            {
                _noty.Show("Удаление сервера", "Сервер успешно удален", null, NotificationType.Success);
                VoiceEvents.DeleteEventInvoke(this);
            }
            else
            {
                _noty.Show("Удаление сервера", result.Message, null, NotificationType.Error);
            }
        }

        private void CreateRoom(object sender, RoutedEventArgs e)
        {
            var wnd = new VoiceRoomCreateWindow(this._id, _noty, _handlers);
            wnd.ShowDialog();
        }
        #endregion
    

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) => 
            tree.Visibility = tree.Visibility == Visibility.Visible 
            ? Visibility.Collapsed 
            : Visibility.Visible;
        
        public ContextMenu CreateMenuRoom(string id)
        {
            var cm = new ContextMenu();
            var mi = new MenuItem();
            mi.Header = "Подключиться";
            mi.Tag = id;
            mi.Click += MiOnMouseDown;
            cm.Items.Add(mi);
            var mi2 = new MenuItem();
            mi2.Header = "Отключиться";
            mi2.Tag = id;
            mi2.Click += Mi2OnClick;
            cm.Items.Add(mi2);
            var mi3 = new MenuItem();
            mi3.Header = "Удалить комнату";
            mi3.Tag = id;
            mi3.Click += Mi3OnClick;
            cm.Items.Add(mi3);
            return cm;
        }

        private void Mi3OnClick(object sender, RoutedEventArgs e)
        { 
            var mi = (MenuItem)sender;
            var result = _handlers.DeleteRoomHandler.Do(this._id, (int)mi.Tag);
            if(result.Success)
            {
                _noty.Show("Удаление комнаты", "Вы успешно удалили комнату", null, NotificationType.Success);}
            else
            {
                _noty.Show("Удаление комнаты", "Не удалось удалить комнату", null, NotificationType.Error);
            }
        }

        private void Mi2OnClick(object sender, RoutedEventArgs e)
        {
            var mi = (MenuItem)sender;
            var result = _handlers.DeleteUserFromRoomHandler.Do(_handlers.UserData.Id, Convert.ToInt32(mi.Tag));
            if(result.Success)
            {
                _noty.Show("Отключение от сервера", "Вы успешно отключились", null, NotificationType.Success);}
            else
            {
                _noty.Show("Отключение от сервера", result.Message, null, NotificationType.Error);
            }
        }

        private void MiOnMouseDown(object sender, RoutedEventArgs e)
        {
            var mi = (MenuItem)sender;
            var result = _handlers.InsertUserInRoomHandler.Do(Convert.ToInt32(mi.Tag), _handlers.UserData.Id);
            if(result.Success)
            {
                _noty.Show("Подключение к серверу", "Вы успешно подключились", null, NotificationType.Success);}
            else
            {
                _noty.Show("Подключение к серверу", "Не удалось подключится к комнате", null, NotificationType.Error);
            }
        }

        public TreeViewItem CreateUIRoom(int id, string name, List<User> users)
        {
            var room = new TreeViewItem()
            {
                Tag = id.ToString(),
                Header = name,
                ContextMenu = CreateMenuRoom(id.ToString())
            };
            
            if (users != null)
            {
                foreach (var user in users)
                {
                    var tvUser = new TreeViewItem()
                    {
                        Tag = user.Id,
                        Header = user.Login,
                    };
                    room.Items.Add(tvUser);
                }
            }

            return room;
        }
    }
}