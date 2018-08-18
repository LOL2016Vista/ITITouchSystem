﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITITouch.Education
{
    public delegate void showPostCSHandle();
    public delegate void showPostSWHandle();
    public delegate void showPostRCHandle();
    public delegate void showPostCTHandle();

    /// <summary>
    /// NaviPage2.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage2 : Page
    {
        public showPostCSHandle showPostCSFunction;
        public showPostCTHandle showPostCTFunction;
        public showPostSWHandle showPostSWHandle;
        public showPostRCHandle showPostRCHandle;
        public NaviPage2()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showPostCSFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showPostCTFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showPostSWHandle();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            showPostRCHandle();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
        }

        public void Initialation() 
        {
            bt1_Click(this,null);
        }
    }
}
