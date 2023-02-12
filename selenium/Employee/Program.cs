using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Employee
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            program.initilize();
        }
        public void initilize()
        {
            var driver = new ChromeDriver(@"C:\Users\willi\source\repos\whatsapp\whatsapp\bin\Debug");
            var currenturl = driver.Url;
            if (currenturl.Contains("https://sparta-pioneer-develop.web.app/") == false)
            {
                driver.Navigate().GoToUrl("https://sparta-pioneer-develop.web.app/");
            }
            Thread.Sleep(2000);
            var email = driver.FindElements(By.XPath("//*[@id='email']")).SingleOrDefault();
            var password = driver.FindElements(By.XPath("//*[@id='password']")).SingleOrDefault();
            var login = driver.FindElements(By.XPath("//*[@id='root']/div[2]/div/form/div/div[4]/button")).SingleOrDefault();
            email.SendKeys("jemal7abdela@gmail.com");
            password.SendKeys("admin");
            login.Click();
            Thread.Sleep(5000);
            var hr = driver.FindElements(By.XPath("//*[@id='root']/main/aside/div[2]/ul/li/a")).SingleOrDefault();
            hr.Click();
            Thread.Sleep(2000);
            var employee = driver.FindElements(By.XPath("//*[@id='navItem-Employees-0']")).SingleOrDefault();
            employee.Click();
            Thread.Sleep(2000);
            var newemployee = driver.FindElements(By.XPath("//*[@id='root']/main/div/div/div/div[3]/button[2]")).SingleOrDefault();
            newemployee.Click();
            Thread.Sleep(2000);
            var first_name = driver.FindElements(By.XPath("//*[@id='first_name']")).SingleOrDefault();
            var father_name = driver.FindElements(By.XPath("//*[@id='father_name']")).SingleOrDefault();
            var grand_father_name = driver.FindElements(By.XPath("//*[@id='grand_father_name']")).SingleOrDefault();
            var gender = driver.FindElements(By.XPath("//*[@id='gender']")).SingleOrDefault();
            var birth_date = driver.FindElements(By.XPath("//*[@id='birth_date']")).SingleOrDefault();
            var place_of_birth = driver.FindElements(By.XPath("//*[@id='place_of_birth']")).SingleOrDefault();
            var marital_status = driver.FindElements(By.XPath("//*[@id='marital_status']")).SingleOrDefault();
            var nationality = driver.FindElements(By.XPath("//*[@id='nationality']")).SingleOrDefault();
            var city = driver.FindElements(By.XPath("//*[@id='city']")).SingleOrDefault();
            var language = driver.FindElements(By.XPath("//*[@id='language']")).SingleOrDefault();
            var is_head_office = driver.FindElements(By.XPath("//*[@id='is_head_office']")).SingleOrDefault();

            var employment_type = driver.FindElements(By.XPath("//*[@id='employment_type']")).SingleOrDefault();
            var employment_start_date = driver.FindElements(By.XPath("//*[@id='employment_start_date']")).SingleOrDefault();
            var employment_end_date = driver.FindElements(By.XPath("//*[@id='employment_end_date']")).SingleOrDefault();
            var department = driver.FindElements(By.XPath("//*[@id='department']")).SingleOrDefault();
            var position = driver.FindElements(By.XPath("//*[@id='position']")).SingleOrDefault();
            var position_level = driver.FindElements(By.XPath("//*[@id='position_level']")).SingleOrDefault();
            var supervisor_no = driver.FindElements(By.XPath("//*[@id='supervisor_no']")).SingleOrDefault();
            var status = driver.FindElements(By.XPath("//*[@id='status']")).SingleOrDefault();

            var bank_account_no = driver.FindElements(By.XPath("//*[@id='bank_account_no']")).SingleOrDefault();
            var bank = driver.FindElements(By.XPath("//*[@id='bank']")).SingleOrDefault();
            var annual_leave_type = driver.FindElements(By.XPath("//*[@id='annual_leave_type']")).SingleOrDefault();
            var remarks = driver.FindElements(By.XPath("//*[@id='remarks']")).SingleOrDefault();

            first_name.SendKeys("William");
            father_name.SendKeys("Mitiku");
            grand_father_name.SendKeys("Geremew");
            birth_date.SendKeys("06/15/1994");
            place_of_birth.SendKeys("Kombolcha");
            var genderlement = new SelectElement(gender);
            genderlement.SelectByIndex(1);
            var language_element = new SelectElement(language);
            language_element.SelectByIndex(1);
            var marital_status_element = new SelectElement(marital_status);
            marital_status_element.SelectByIndex(2);
            var nationality_element = new SelectElement(nationality);
            nationality_element.SelectByIndex(3);
            var city_element = new SelectElement(city);
            city_element.SelectByIndex(7);
            var location_element = new SelectElement(is_head_office);
            location_element.SelectByIndex(1);

            var employee_info = driver.FindElements(By.XPath("/html/body/div[2]/div/div[1]/div/div/div[2]/div/div/form/div[1]/div[14]/details")).SingleOrDefault();
            Thread.Sleep(2000);
            employee_info.Click();
            var employment_type_t = new SelectElement(employment_type);
            employment_type_t.SelectByIndex(1);

            var department_element = new SelectElement(department);
            department_element.SelectByIndex(3);
            var position_element = new SelectElement(position);
            position_element.SelectByIndex(1);
            var position_level_element = new SelectElement(position_level);
            position_level_element.SelectByIndex(1);
            var supervisor_no_element = new SelectElement(supervisor_no);
            supervisor_no_element.SelectByIndex(1);
            var status_t = new SelectElement(status);
            status_t.SelectByIndex(1);
            employment_start_date.SendKeys("05/23/2022");

            employee_info.Click();
            Thread.Sleep(3000);

            var additional_info = driver.FindElements(By.XPath("/html/body/div[2]/div/div[1]/div/div/div[2]/div/div/form/div[1]/div[15]/details/summary/span")).SingleOrDefault();
            Thread.Sleep(2000);
            additional_info.Click();

            bank_account_no.SendKeys("1000253614789");
            var bank_t = new SelectElement(bank);
            bank_t.SelectByIndex(1);
            var annual_leave_type_t = new SelectElement(annual_leave_type);
            annual_leave_type_t.SelectByIndex(1);
            remarks.SendKeys("thak you i'm william");

            var saveBtn = driver.FindElements(By.XPath("/html/body/div[2]/div/div[1]/div/div/div[2]/div/div/form/div[2]/button")).SingleOrDefault();
            saveBtn.Click();
            Thread.Sleep(6000);

            driver.Navigate().GoToUrl("https://sparta-pioneer-develop.web.app/#/employees");
            Thread.Sleep(3000);
            var search = driver.FindElements(By.XPath("//*[@id='root']/main/div/div/div/div[4]/div/div/div[1]/div/div[1]/form/div[1]/input")).SingleOrDefault();
            search.SendKeys("William");
            Thread.Sleep(3000);

            var view = driver.FindElements(By.XPath("//*[@id='root']/main/div/div/div/div[4]/div/div/div[2]/div[1]/table/tbody/tr/td[6]/div/div[1]/a/button")).SingleOrDefault();
            view.Click();
            Thread.Sleep(2000);

            var edit = driver.FindElements(By.XPath("//*[@id='root']/main/div/div/div/div[3]/div/div/div/div[2]/div[1]/div[1]/div/section[1]/section/span[2]/button")).SingleOrDefault();
            edit.Click();
            Thread.Sleep(1000);
            var father_name_edit = driver.FindElements(By.XPath("//*[@id='father_name']")).SingleOrDefault();

            father_name_edit.SendKeys("Mitiku Edited");
            var update = driver.FindElements(By.XPath("/html/body/div[2]/div/div[1]/div/div/div[2]/div/div/form/div[2]/button")).SingleOrDefault();
            update.Click();

            driver.Navigate().GoToUrl("https://sparta-pioneer-develop.web.app/#/employees");
            Thread.Sleep(3000);

            var search_2 = driver.FindElements(By.XPath("//*[@id='root']/main/div/div/div/div[4]/div/div/div[1]/div/div[1]/form/div[1]/input")).SingleOrDefault();
            search_2.SendKeys("William");
            Thread.Sleep(2000);

            var delete = driver.FindElements(By.XPath("//*[@id='root']/main/div/div/div/div[4]/div/div/div[2]/div[1]/table/tbody/tr/td[6]/div/div[2]/button")).SingleOrDefault();
            Thread.Sleep(2000);
            delete.Click();
            Thread.Sleep(1000);
            var confirm = driver.FindElements(By.XPath("//*[@id='react-confirm-alert']/div/div/div/button[1]")).SingleOrDefault();
            Thread.Sleep(2000);
            confirm.Click();













        }
    }
}
