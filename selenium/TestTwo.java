package com.kifiya;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.Test;

public class TestTwo {
    @Test
    public void testAddToCart() {
        WebDriver driver = new ChromeDriver();
        driver.get("https://www.petsmart.com/");

        WebElement deals = driver.findElement(By.xpath("//*[@id=\"dp-header\"]/div[1]/div[2]/div[3]/ul/li[4]/a"));
        deals.click();

        WebElement dealsText = driver.findElement(By.xpath("//*[@id=\"root\"]/div/div/section[1]/div/header/div/h1"));
        String textDeals = dealsText.getText();
        Assert.assertEquals(textDeals, "Deals by pet");

        WebElement dealsByDog = driver.findElement(By.xpath("//*[@id=\"root\"]/div/div/section[1]/div/div/div/div[1]/ol/li[1]/a/img"));
        dealsByDog.click();

        WebElement dealsByDogText = driver.findElement(By.xpath("//*[@id=\"root\"]/div/div/section[1]/div/div/a/div/div/div/h2"));
        String TextDogDeals = dealsByDogText.getText();
        Assert.assertEquals(TextDogDeals, "Dog deals");

        driver.quit();
    }
}