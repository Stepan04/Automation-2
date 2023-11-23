using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Linq.Expressions;
using System.Threading;

public class LoginPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    // Метод для відкриття сторінки в браузері
    public void OpenLoginPage(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    public void ClickLoginAsUser()
    {
        IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='Bank Manager Login']")));
        loginButton.Click();
    }
    public void SelectCustomer()
    {
        // Знайдіть елемент Add Customer за допомогою селектора
        IWebElement customerDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[contains (text(), 'Add Customer')]")));
        customerDropdown.Click();

        IWebElement customerOption1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/form/div[1]/input")));
        customerOption1.SendKeys("Filep");

        IWebElement customerOption2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/form/div[2]/input")));
        customerOption2.SendKeys("Stepan");

        IWebElement customerOption3 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/form/div[3]/input")));
        customerOption3.SendKeys("13");
    }

    public void ClickLogin ()
    {

        IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='Add Customer']")));
        loginButton.Click();

        IWebElement clickclose = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='OK']")));
        clickclose.Click();

    }

    public void CloseDriver()
    {
        driver.Quit();
    }

}
