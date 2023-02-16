using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        AppiumDriver<AndroidElement> _driver;
        [TestMethod]
        public void TestMethod1()
        {

            //Tested on Samsung A71 Android version 11.0.0
            //This Testing method check if the next button works

            //Set the capabilities
            var appCapabilities = new AppiumOptions();
            //Apk location should be changed to apks absolute path
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, "D:\\banner\\petsi.apk");
            appCapabilities.AddAdditionalCapability("deviceName", "a71");
            appCapabilities.AddAdditionalCapability("platformName", "Android");
            appCapabilities.AddAdditionalCapability("udid", "RZ8NA2GEK5D");
            appCapabilities.AddAdditionalCapability("platformVersion", "11.0.0");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appCapabilities, TimeSpan.FromSeconds(180));
            //Waiting for the Next button to be available
            AndroidElement nextButton = (AndroidElement)new WebDriverWait(
                _driver, TimeSpan.FromSeconds(30)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                    MobileBy.AccessibilityId("Next"))
            );
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //clicked 3 times becouse the app next button is not responsive with one click
            nextButton.Click();
            nextButton.Click();
            nextButton.Click();

            //After next button clicked check if open Feed button available 
            AndroidElement openFeed = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.AccessibilityId("Open Feed"))
            );
            string openFeedText = openFeed.GetAttribute("content-desc");
            Console.WriteLine(openFeedText);
            Assert.AreEqual("Open Feed", openFeedText);




        }
        [TestMethod]
        public void TestMethod2()
        {
            //Testing if Login with Google email works?
            var appCapabilities = new AppiumOptions();
            //Apk location should be changed to apks absolute path
            appCapabilities.AddAdditionalCapability(MobileCapabilityType.App, "D:\\banner\\petsi.apk");
            appCapabilities.AddAdditionalCapability("deviceName", "a71");
            appCapabilities.AddAdditionalCapability("platformName", "Android");
            appCapabilities.AddAdditionalCapability("udid", "RZ8NA2GEK5D");
            appCapabilities.AddAdditionalCapability("platformVersion", "11.0.0");

            _driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appCapabilities, TimeSpan.FromSeconds(180));

            AndroidElement nextButton = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.AccessibilityId("Next"))
           );
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //clicked 3 times becouse the app next button is not responsive with one click
            nextButton.Click();
            nextButton.Click();
            nextButton.Click();

            //Click on Login Button 
            AndroidElement login = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.AccessibilityId("Login"))
            );
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            TouchAction a = new TouchAction(_driver);
            a.Tap(login);

            //login.Click();
            //login.Click();

            //Click on Sign in with Google options
            AndroidElement signWithGoogle = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.AccessibilityId("Sign in with Google"))
            );
            signWithGoogle.Click();

            //Accept Term and conditions
            AndroidElement acceptTerm = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.AccessibilityId("Accept and continue"))
            );
            acceptTerm.Click();

            //Select first email i used xpath selector becouse the app doesn't have accessibility id
            AndroidElement firstEmail = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.support.v7.widget.RecyclerView/android.widget.LinearLayout[1]"))
            );
            firstEmail.Click();

            //Click on humberger icon to check login
            AndroidElement humberger = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.widget.ImageView[1]"))
            );
            humberger.Click();

            //if logout button exists user successfully loggedin
            AndroidElement logout = (AndroidElement)new WebDriverWait(
               _driver, TimeSpan.FromSeconds(30)).Until(
               SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(
                   MobileBy.AccessibilityId("Logout"))
            );
            string logoutText = logout.GetAttribute("content-desc");
            Console.WriteLine(logoutText);
            Assert.AreEqual("Logout", logoutText);










        }


    }
}
