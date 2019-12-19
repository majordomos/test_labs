﻿using OpenQA.Selenium;
using System;
using System.IO;

namespace RailEurope.Utils
{
    public class ScreenshotCreator
    {
        public static void SaveScreenShot(IWebDriver driver)
        {
            ITakesScreenshot scrShot = ((ITakesScreenshot)driver);
            DirectoryInfo directory = Directory.CreateDirectory(@".\framework\Screenshots\" + DateTime.Now.ToString("dd_MM_yyyy") + @"\");
            scrShot.GetScreenshot().SaveAsFile(directory.FullName + @"\" + DateTime.Now.ToString("HH_mm_ss") + ".png", ScreenshotImageFormat.Png);
        }
    }
}
