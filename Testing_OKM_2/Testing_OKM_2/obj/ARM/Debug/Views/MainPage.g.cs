﻿#pragma checksum "E:\Бакалаврська\Testing_OKM_2\Testing_OKM_2\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "54C5016B63D2C664F47E782850E66EF5"
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


namespace Testing_OKM_2.Views {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid RootContent;
        
        internal Microsoft.Phone.Controls.LongListMultiSelector ListItems;
        
        internal System.Windows.Controls.Primitives.Popup addPopup;
        
        internal System.Windows.Controls.TextBox PopupName;
        
        internal System.Windows.Controls.Button PopupButtonAdd;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Add;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton Select;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem addModule;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem startTesting;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Testing_OKM_2;component/Views/MainPage.xaml", System.UriKind.Relative));
            this.RootContent = ((System.Windows.Controls.Grid)(this.FindName("RootContent")));
            this.ListItems = ((Microsoft.Phone.Controls.LongListMultiSelector)(this.FindName("ListItems")));
            this.addPopup = ((System.Windows.Controls.Primitives.Popup)(this.FindName("addPopup")));
            this.PopupName = ((System.Windows.Controls.TextBox)(this.FindName("PopupName")));
            this.PopupButtonAdd = ((System.Windows.Controls.Button)(this.FindName("PopupButtonAdd")));
            this.Add = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Add")));
            this.Select = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("Select")));
            this.addModule = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("addModule")));
            this.startTesting = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("startTesting")));
        }
    }
}

