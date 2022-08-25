
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turnup portal

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// identify the username text box and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify the password text box and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\'loginForm\']/form/div[3]/input[1]"));
loginButton.Click();

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
//create new record
IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationButton.Click();

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createnewButton.Click();

IWebElement typecodeTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodeTextbox.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();

IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("test2022");

IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("test2022");

IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
price.Click();

IWebElement PriceTextbox = driver.FindElement(By.Id("Price"));
PriceTextbox.SendKeys("20");

IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

Thread.Sleep(3000);

IWebElement gotoLastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastpage.Click();

IWebElement newrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if(newrecord.Text == "test2022")
{
    Console.WriteLine("New Record is created");
}
else
{
    Console.WriteLine("New Record is not created");
}



