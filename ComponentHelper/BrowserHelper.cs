﻿using DemoProject1.Setting;
using log4net;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProject1.ComponentHelper
{
    public class BrowserHelper
    {
        private static readonly ILog Logger = Log4NetHelper.GetLogger(typeof(BrowserHelper));
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
            Logger.Info("Browser Maximize");
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
            Logger.Info("Navigate to backword");
        }

        public static void Forward()
        {
            ObjectRepository.Driver.Navigate().Forward();
            Logger.Info("navigate to forword");
        }

        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();
            Logger.Info("Browser Refreshed");
        }

        public static void SwitchToWindow(int index=0)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;

            if (windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Winddow Index" + index);
            }
            Thread.Sleep(1000);
            ObjectRepository.Driver.SwitchTo().Window(windows[index]);
            Logger.Info("Switch to window" +index);
            Thread.Sleep(1000);
            BrowserMaximize();
        }
        public static void SwitchToParent()
        {
            var windowids = ObjectRepository.Driver.WindowHandles;


            for (int i = windowids.Count - 1; i > 0;)
            {
                ObjectRepository.Driver.Close();
                i = i - 1;
                Thread.Sleep(2000);
                ObjectRepository.Driver.SwitchTo().Window(windowids[i]);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowids[0]);
            Logger.Info("Switch to parrent window");


        }

        public static void SwitchToFrame(By locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(locator));
            Logger.Info("Switch to frame" + locator);
        }
    }
}

