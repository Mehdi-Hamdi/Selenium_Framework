using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SL_Pom_Framework_Test.lib.pages;

public class SL_Website<IWebDriver>
{
    public IWebDriver SeleniumDriver { get; internal set; }
    public HomePage SL_HomePage { get; internal set; }

    public SL_Website()
    {
    }

}
