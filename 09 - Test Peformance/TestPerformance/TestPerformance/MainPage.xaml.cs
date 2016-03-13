﻿using System;
using System.Diagnostics;
using System.Text;

namespace TestPerformance
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Debug.WriteLine("Start the test");
            //Test the string concat
            for (int i = 0; i < 1000000; i++)
            {
                string s = "Tuan Tran Van";
                s += " welcome to my test";
                s += " and hello world";
                s += i;

                //StringBuilder s = new StringBuilder();
                //s.Append("Tuan Tran Van");
                //s.Append(" welcome to my test");
                //s.Append(" and hello world");
                //s.Append(i);

                //string s = string.Concat("Tuan Tran Van", " welcome to my test", " and hello world", i);

            }
            Debug.WriteLine("Test end");
        }
    }
}
