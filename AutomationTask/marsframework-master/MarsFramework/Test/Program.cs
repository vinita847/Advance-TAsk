using MarsFramework.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using MarsFramework.Global;
using System;
using System.Threading;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;

namespace MarsFramework
{
    class Program 
    {
        [TestFixture]
        [Category("Sprint1")]      

        public class User : Base

        {
           //Profile proileObj = new Profile();
            public object ExcelLib { get; private set; }
            [Test]
            public void AddAvailability()
            {

                Profile proileObj = new Profile();
                proileObj.EditAvailability();                            
               
                //start report
                test = extent.StartTest("Edit Availability Test");


                try
                {
                    //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')"), 20);

                    string ActualMessage = proileObj.AvailabilitySuccessMsg.Text;
                    string ExpectedMsg = "Availability updated";
                    Assert.AreEqual(ExpectedMsg, ActualMessage);
                    //log the test
                    test.Log(LogStatus.Pass, "Test Pass, Availability Updated");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Availability");
                    Console.WriteLine("Test Passed:" + " " + ActualMessage);
                }
                catch (Exception e)
                {
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }
            }
            [Test]
            public void AddHours()
            {
                Profile proileObj = new Profile();
                proileObj.EditHours();

                //start report
                test = extent.StartTest("Edit Hours Test");
                try
                {
                    //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')"), 20);

                    string ActualMessage = proileObj.AvailabilitySuccessMsg.Text;
                    string ExpectedMsg = "Availability updated";
                    Assert.AreEqual(ExpectedMsg, ActualMessage);
                    //log the test
                    test.Log(LogStatus.Pass, "Test Pass, Hours Updated");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Hours");
                    Console.WriteLine("Test Passed:" + " " + ActualMessage);
                }
                catch (Exception e)
                {
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }

                               
            }
            [Test]
            public void AddEarnTargets()
            {
                //create an object of the page
                Profile proileObj = new Profile();
                test = extent.StartTest("Edit EarnTargets Test");
                proileObj.EditEarnTargets();
                //start report
                

                try
                {
                    //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("//div[contains(@class,'ns-box ns-growl ns-effect-jelly ns-type-success ns-show')"), 20);

                    string ActualMessage = proileObj.AvailabilitySuccessMsg.Text;
                    string ExpectedMsg = "Availability updated";
                    Assert.AreEqual(ExpectedMsg, ActualMessage);
                    //log the test
                    test.Log(LogStatus.Pass, "Test Pass, Earn Target Updated");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Earn Targets");
                    Console.WriteLine("Test Passed:" + " " + ActualMessage);
                }
                catch (Exception e)
                {
                    Global.Base.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }

            }

            [Test]
            public void AddLanguage()
            {
                test = extent.StartTest("Add a Language test");
                Profile profileObj = new Profile();
                profileObj.AddLanguageSteps();
                try
                { 
                string ExpectedMsg = "Punjabi has been added to your languages";
                string ActualMsg = profileObj.LangAddedSuccessMsg.Text;
                Assert.AreEqual(ExpectedMsg, ActualMsg);
                test.Log(LogStatus.Pass, "Test Pass: Language added to the list");
                GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Language Added");

                    Console.WriteLine(ExpectedMsg);
                }

                catch (NoSuchElementException)
                {
                    Console.Write("Langauges not added");
                    test.Log(LogStatus.Fail, "Test Failed");

                }

            }

            [Test]
            public void AddASkill()
            {
                test = extent.StartTest("Add a Skill Test");
                Profile profile = new Profile();
                profile.AddSkillSteps();
                try
                {
                    string ExpectedMsg = "Agile has been added to your skills";
                    string ActualMsg = profile.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Skill added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Skill Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch(Exception e)
                {
                    Console.Write("Skill not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }

            }
            [Test]
            public void AddEducation()
            {
                test = extent.StartTest("Add Education Test");
                Profile profile = new Profile();
                profile.AddEducationSteps();
                try
                {
                    string ExpectedMsg = "Education has been added";
                    string ActualMsg = profile.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Education added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Education Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch (Exception e)
                {
                    Console.Write("Education not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }

            }

            [Test]
            public void AddCertificate()
            {
                test = extent.StartTest("Add Certification Test");
                Profile proObj = new Profile();
                proObj.AddCertificationSteps();
                try
                {
                    string ExpectedMsg = "ISTQB has been added to your certification";
                    string ActualMsg = proObj.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Certification added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Certification Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch (Exception e)
                {
                    Console.Write("Certificate not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }


            }

            [Test]
            public void AddDescription()
            {
                test = extent.StartTest("Add Description Test");
                Profile proObj = new Profile();
                proObj.AddDescriptionSteps();
                try
                {
                    string ExpectedMsg = "Description has been saved successfully";
                    string ActualMsg = proObj.LangAddedSuccessMsg.Text;
                    Assert.AreEqual(ExpectedMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Description added to the list");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Description Added");

                    Console.WriteLine(ExpectedMsg);

                }
                catch (Exception e)
                {
                    Console.Write("Description not added");
                    test.Log(LogStatus.Fail, "Test Failed");
                }
            }

            [Test]
            public void AddSkill()
            
            {
                ShareSkill AddShareSkill = new ShareSkill();
                AddShareSkill.AddSkill();
                //Thread.Sleep(2000);
                try
                {
                    string ExpectedMsg = "Service Listing Added successfully";
                    GlobalDefinitions.wait(10);
                    string ActulaMsg = AddShareSkill.SkillAddedSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedMsg, ActulaMsg);
                    Console.WriteLine(ExpectedMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Skill Add element not found");
                }

                
            }

            [Test]
            public void UpdateSkill()
            {
                ManageListings SkillEdit = new ManageListings();
                SkillEdit.EditExistingSkill();

                try
                {
                    string ExpectedUpdateMsg = "Service Listing Updated successfully";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = SkillEdit.SuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    Console.WriteLine(ExpectedUpdateMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Skill Update element not found");
                }
            }


            [Test]

            public void DeleteSkill()
            {
                ManageListings SkillDelete = new ManageListings();
                SkillDelete.DeleteExistingSkill();
                //Thread.Sleep(2000);
                string ExpectedUpdateMsg = "Selenium has been deleted";
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                string ActualMsg = SkillDelete.SuccessMsg.Text;

                Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                Console.WriteLine(ExpectedUpdateMsg);
            }

            [Test]
            public void ChangePassword()
            {
                test = extent.StartTest("Change Password");
                Profile proObj = new Profile();
                proObj.ChangePwdSteps();


                try
                {
                    string ExpectedUpdateMsg = "Password Changed Successfully";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = proObj.AvailabilitySuccessMsg.Text;                       
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Password changed successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Password Changed");

                    Console.WriteLine(ExpectedUpdateMsg);

                }
                catch (NoSuchElementException)
                {
                    Console.Write("Test Failed");
                    test.Log(LogStatus.Fail, "Test Failed");

                }
            }

            [Test]
            public void ReceiveRequestAccept()
            {
                 
                test = extent.StartTest("Accept a Received request");
                Profile proObj = new Profile();
                proObj.ReceivedRequestsSteps();
                ReceivedRequests recReqObj = new ReceivedRequests();
                recReqObj.RequestAccept();
                //recReqObj.RequestCompleted();

                try
                {
                    string ExpectedUpdateMsg = "Service has been updated";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = recReqObj.ReqSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Request accepted successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Accepted");

                    Console.WriteLine(ExpectedUpdateMsg);              


                }
                catch (NoSuchElementException)
                {
                    Console.Write("Element not found");
                }




            }

            [Test]
            public void ReceiveRequestDecline()
            {
                test = extent.StartTest("Decline a Received request");
                Profile proObj = new Profile();
                proObj.ReceivedRequestsSteps();
                ReceivedRequests recReqObj = new ReceivedRequests();
                recReqObj.RequestDecline();
                //recReqObj.RequestCompleted();

                try
                {
                    string ExpectedUpdateMsg = "Service has been updated";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = recReqObj.ReqSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Request Declined successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Declined");

                    Console.WriteLine(ExpectedUpdateMsg);


                }
                catch (NoSuchElementException)
                {
                    Console.Write("Element not found");
                }
            }
            [Test]
            public void WithdrawSentRequest()
            {
                test = extent.StartTest("Request Sent Test");
                Profile proObj = new Profile();
                proObj.SentRequestsSteps();
                SentRequests sentReqObj = new SentRequests();
                sentReqObj.WithdrawSentRequest();

                try
                {
                    string ExpectedUpdateMsg = "Request has been withdrawn";
                    GlobalDefinitions.wait(20);

                    string ActualMsg = proObj.LangAddedSuccessMsg.Text;
                    GlobalDefinitions.wait(10);

                    Assert.AreEqual(ExpectedUpdateMsg, ActualMsg);
                    test.Log(LogStatus.Pass, "Test Pass: Request Withdrwn successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Withdraw");

                    Console.WriteLine(ExpectedUpdateMsg);


                }

                catch (NoSuchElementException)
                {
                    Console.Write("Element not found");

                }

            }
            [Test]
            public void SeachCategory()
            {
                test = extent.StartTest("Test for search by category: Music & Audio");
                Profile proObj = new Profile();
                GlobalDefinitions.wait(10);
                proObj.ClickonSearch();
                GlobalDefinitions.wait(10);

                Search searchObj = new Search();
                searchObj.SearchSkillByCatg();
                GlobalDefinitions.wait(10);

                try
                {
                var actualValue = searchObj.CategoryMusic.Text;
                var expectedValue = "41";
                 
                Assert.AreEqual(actualValue, expectedValue);
                Console.WriteLine("Test pass");
                test.Log(LogStatus.Pass, "Test Pass");
                GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(GlobalDefinitions.driver, "Request Withdraw");

                }
                catch (ElementNotVisibleException)
                {
                    Console.WriteLine("Test failed");
                    test.Log(LogStatus.Fail, "Test Failed");

                }


            }

            public void FilterByOnline()
            {
                Search SearchObj = new Search();
                SearchObj.FilterOnline();
            }
            public void FilterByOnsite()
            {
                Search SearchObj = new Search();
                SearchObj.FilterOnsite();
            }

        }



        
    }
}