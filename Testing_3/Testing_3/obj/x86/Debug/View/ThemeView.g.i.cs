﻿#pragma checksum "E:\Diplom\Testing_3\Testing_3\View\ThemeView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3F30EC852A97F940F0DC4DD861D1E976"
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


namespace Testing_3.View {
    
    
    public partial class ThemeView : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ListBox ThemeList;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem select_all;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem unselect;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Testing_3;component/View/ThemeView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ThemeList = ((System.Windows.Controls.ListBox)(this.FindName("ThemeList")));
            this.select_all = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("select_all")));
            this.unselect = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("unselect")));
        }
    }
}

