using MarsQA_1.Helpers;
using System;
using TechTalk.SpecFlow;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1
{
    [Binding]
    public class CertificationsStepDefinitions : Driver
    {
        Profile profile = new Profile();

        [When(@"I go to the tab Certifications")]
        public void WhenIGoToTheTabCertifications()
        {
            profile.goToCertificationsTab(driver);
        }


        [When(@"I add a new Certification record")]
        public void WhenIAddANewCertificationRecord()
        {
            profile.addCertification(driver);
        }


        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
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


        [When(@"I update '([^']*)' on an existing Certifications record")]
        public void WhenIUpdateAnExistingCertificationsRecord(string certifiedFrom)
        {
            profile.updateCertification(driver, certifiedFrom);
        }


        [Then(@"The record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string certifiedFrom)
        {
            Thread.Sleep(3000);

            IWebElement newCertifiedFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[2]"));

            if (newCertifiedFrom.Text == certifiedFrom)
            {
                try
                {
                    Assert.Pass("Certification record updated successfully.");
                }
                catch (SuccessException e)
                {
                    return;
                }
            }
            else
            {
                Assert.Fail("Certification record not updated");
            }
        }


        [When(@"I delete an existing Certification record")]
        public void WhenIDeleteAnExistingCertificationRecord()
        {
            profile.deleteCertification(driver);
        }


        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
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
