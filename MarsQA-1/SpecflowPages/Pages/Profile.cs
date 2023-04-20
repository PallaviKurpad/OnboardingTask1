﻿

using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Profile
    {
        public void goToCertificationsTab(IWebDriver driver)
        {
            IWebElement certificationsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationsTab.Click();
        }

        public void addCertification(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();

            IWebElement certificateTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificateTextBox.SendKeys("SSDD");

            IWebElement certifiedFromTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromTextBox.SendKeys("Wert");

            IWebElement yearSelectBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yearSelectBox.Click();

            IWebElement option2020 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[5]"));
            option2020.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

            Thread.Sleep(2000);

            IWebElement newCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));

            if (newCertification.Text == "SSDD")
            {
                Assert.Pass("Certification record created successfully.");
            }
            else
            {
                Assert.Fail("Certification record not created");
            }

        }


        public void updateCertification(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
            editButton.Click();

            IWebElement certificateTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[2]/input"));
            certificateTextBox.Clear();
            certificateTextBox.SendKeys("Wertu");

            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            updateButton.Click();
            Thread.Sleep(3000);

            IWebElement newCertifiedFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));

            if (newCertifiedFrom.Text == "Wertu")
            {
                try
                {
                    Assert.Pass("Certification record updated successfully.");
                }
                catch(SuccessException e)
                {
                    return;
                }
            }
            else
            {
                Assert.Fail("Certification record not updated");
            }
        }


        public void deleteCertification(IWebDriver driver)
        {           
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
            deleteButton.Click();

            Thread.Sleep(2000);
            IWebElement certification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));

            if (certification.Text == "SSDD")
            {
                Assert.Fail("Certification record not deleted successfully");
            }
            else
            {
                Assert.Pass("Certification record not deleted successfully");
            }
        }
    }
}