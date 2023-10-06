using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using System.Windows.Forms;

namespace WGP.WebOperation.Console
{
    /// <summary>
    /// bilibili主页视频Title获取器
    /// </summary>
    public class BilibiliHomePageVideoTitleGetter
    {
        public bool TryGetTitles()
        {
            bool result = true;
            ChromeOptions options = new ChromeOptions();
            IWebDriver driver = new ChromeDriver(options);
            try
            {
                driver.Navigate().GoToUrl("https://www.bilibili.com/");
                IWebElement parentElement = driver.FindElement(By.CssSelector(".container.is-version8"));
                List<IWebElement> elements = parentElement.FindElements(By.XPath(".//h3[contains(@class, 'bili-video-card__info--tit')]")).ToList();
                foreach (IWebElement element in elements)
                {
                    System.Console.WriteLine($"title：{element.Text}");
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"错误：{ex.Message}");
                result = false;
            }
            finally
            {
                driver.Quit();
            }
            return result;
        }
        public void GetTitles()
        {
            WebBrowser
        }
    }
}
