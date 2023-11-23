using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace YourProjectNamespace
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginSteps()
        {
            // ���������� ������� � �����������
            driver = new ChromeDriver(); // �� ������ ������� ����� ������� �� ��������
            loginPage = new LoginPage(driver);
        }

        [Given(@"I am on the banking website")]
        public void GivenIAmOnTheBankingWebsite()
        {
            loginPage.OpenLoginPage("https://www.globalsqa.com/angularJs-protractor/BankingProject"); // ������ URL �� �������� URL ������ ���-�����
        }

        [When(@"I select ""Login as User"" option")]
        public void WhenISelectLoginAsUserOption()
        {
            loginPage.ClickLoginAsUser();
        }

        [When(@"I select ""Hermoine Granger"" as a customer")]

        public void WhenISelectHarryPotter()
        {
            loginPage.SelectCustomer();
        }

        [When(@"I click Login button")]

        public void WhenIClickLoginButton()
        {
            loginPage.ClickLogin();
        }



        [Then(@"I should close Chrome")]
        public void CloseChrome()
        {
            loginPage.CloseDriver();
        }
    }
}
