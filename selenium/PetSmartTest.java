package com.kifiya;


import java.awt.Desktop;
import java.io.File;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import org.testng.Assert;
import org.testng.annotations.Test;
import org.openqa.selenium.JavascriptExecutor;

import com.aventstack.extentreports.ExtentReports;
import com.aventstack.extentreports.ExtentTest;
import com.aventstack.extentreports.Status;
import com.aventstack.extentreports.markuputils.ExtentColor;
import com.aventstack.extentreports.markuputils.MarkupHelper;
import com.aventstack.extentreports.reporter.ExtentSparkReporter;

public class PetSmartTest {

    static ExtentSparkReporter htmlReporter;
    static ExtentReports extent;
    static ExtentTest test;

    public static void main(String[] args) throws InterruptedException {

       //  String timeStamp = new SimpleDateFormat("yyyy.MM.dd.HH.mm.ss").format(new Date());
       // String reportName = "PetSmartReport_" + timeStamp + ".html";
    	
    	ExtentReports extent = new ExtentReports();
        ExtentSparkReporter spark = new ExtentSparkReporter("report.html");
        extent.attachReporter(spark);

        test = extent.createTest("PetSmartTest", "Testing PetSmart website functionality");

        System.setProperty("webdriver.chrome.driver", "C://Users//Willi//Desktop//Kf//chromedriver_win32//chromedriver.exe");
           WebDriver driver = new ChromeDriver();
           JavascriptExecutor js = (JavascriptExecutor) driver;
       	js.executeScript("window.scrollBy(0,document.body.scrollHeight)", "");
        driver.manage().window().maximize();
        driver.get("https://www.petsmart.com/");

        String pageTitle = driver.getTitle();
        Assert.assertEquals(pageTitle, "Pet Supplies, Accessories and Products Online | PetSmart");
        
        if (pageTitle.equals("Pet Supplies, Accessories and Products Online | PetSmart")) {
         test.log(Status.PASS, "Test Passed, The title displayed Corrcely");
        	} 
        else {
        	test.log(Status.FAIL, "Failed, The title not displayed correctly");
        }
     
        ExtentTest test2 = extent.createTest("Testing Shooping By Brands", " Testing Shooping By Brands");
     
     
        driver.findElement(By.xpath("//*[@id=\"shop-by-brand\"]/a")).click();
       
        test2.log(Status.INFO, "OnGoing,  Product Brand Selected");
        
        
        
        driver.findElement(By.xpath("//*[@id=\"a\"]/div[2]/ul/li[1]/a")).click();
        test2.log(Status.INFO, "OnGoing, Clicked A_E Brands");
        
       
        //js.executeScript("window.scrollBy(0,document.body.scrollHeight)");
        
        
        
        
        String TextA=driver.findElement(By.xpath("//*[@id=\"primary\"]/div[1]/p/span")).getText();
        Assert.assertEquals(TextA, "A&E");
        
        if (TextA.equals("A&E")) {
            test.log(Status.PASS, "Test Passed, A&E displayed Corrcely");
           	} 
           else {
           	test.log(Status.FAIL, "Failed,  not displayed correctly");
           }
        test2.log(Status.INFO, "  Passed");
        
        js.executeScript("window.scrollBy(0,document.body.scrollHeight)");
      driver.findElement(By.xpath("//*[@id=\"b0a8d81dc8a10d477612406192\"]/div[1]/div[1]/img")).click();
        test2.log(Status.INFO, "  Single Product Selcted");
        
        
        driver.findElement(By.xpath("//*[@id=\"one-time-purchase-radio\"]")).click();
        test2.log(Status.INFO, "  Radio Button Product Selcted");
        
      
        driver.findElement(By.xpath("//*[@id=\"react-pdp-root\"]/div/div/div[2]/div[4]/div/div/div[6]/div/div[2]/div[2]/div[4]/button")).click();
        test2.log(Status.PASS, "  Added to the Cart");
        
        
        
        
        driver.quit();

        extent.flush();
        try {
            Desktop.getDesktop().browse(new File("report.html").toURI());
          } catch (IOException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
          }
    }
}
