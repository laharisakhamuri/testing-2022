
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify the username text box and enter valid username
IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

// identify the password text box and enter valid password
IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

// identify login button and click on it
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\'loginForm\']/form/div[3]/input[1]"));
loginbutton.Click();

//check if user logged in succesfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\'logoutForm\']/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("logged in successfully, test passed");
}
else 
{
    Console.WriteLine("login failed, test failed");
}