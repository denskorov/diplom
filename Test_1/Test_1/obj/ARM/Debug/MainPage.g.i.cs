﻿#pragma checksum "E:\Бакалаврська\Test_1\Test_1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "46BD39F8CBD210FB16E15474905D55CE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Test_1 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox userName;
        
        internal System.Windows.Controls.Button addUser;
        
        internal System.Windows.Controls.ListBox userList;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton delete;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton addBook;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton show;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem addFriend;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Test_1;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.userName = ((System.Windows.Controls.TextBox)(this.FindName("userName")));
            this.addUser = ((System.Windows.Controls.Button)(this.FindName("addUser")));
            this.userList = ((System.Windows.Controls.ListBox)(this.FindName("userList")));
            this.delete = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("delete")));
            this.addBook = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("addBook")));
            this.show = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("show")));
            this.addFriend = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("addFriend")));
        }
    }
}

