﻿#pragma checksum "C:\Users\Jim\documents\visual studio 2015\Projects\PhoneApp1\PhoneApp1\Views\ExpenditureDelete.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "751D9A08684AF4BEAE4FF958F04E8E8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace PhoneApp1.Views {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button deleteButton;
        
        internal System.Windows.Controls.Button backButton;
        
        internal System.Windows.Controls.TextBlock IdTextBlock;
        
        internal System.Windows.Controls.TextBox IdTextBox;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/Views/ExpenditureDelete.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.deleteButton = ((System.Windows.Controls.Button)(this.FindName("deleteButton")));
            this.backButton = ((System.Windows.Controls.Button)(this.FindName("backButton")));
            this.IdTextBlock = ((System.Windows.Controls.TextBlock)(this.FindName("IdTextBlock")));
            this.IdTextBox = ((System.Windows.Controls.TextBox)(this.FindName("IdTextBox")));
        }
    }
}

