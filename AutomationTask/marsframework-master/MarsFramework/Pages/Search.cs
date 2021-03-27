using MarsFramework.Global;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace MarsFramework.Pages
{
    class Search
    {
        public Search()
        {
            PageFactory.InitElements(GlobalDefinitions.driver, this);
        }

        //Tesct box for search
        [FindsBy (How = How.XPath, Using = "(//input[@placeholder='Search skills'])[1]")]
        private IWebElement SearchTextBox { get; set; }

        //SearchIcon
        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement SearchIcon { get; set; }

        //Rsult on using category: Music & Audio Category
        [FindsBy (How = How.XPath, Using = "//div[@class='ui link list']//span[contains (text(), '4')]")]
        public IWebElement CategoryMusic { get; set; }

        //Filter by Online
        [FindsBy(How = How.XPath, Using = "//div[@class='ui buttons']/button[contains(text(), 'Online')]")]
        private IWebElement OnlineOpt { get; set; }

        //Filter by OnSite
        [FindsBy(How = How.XPath, Using = "//div[@class='ui buttons']/button[contains(text(), 'Onsite')]")]
        private IWebElement OnsiteOpt { get; set; }

        //Total count of skills
        [FindsBy (How = How.XPath, Using = "//div[@class='ui link list']//b/following-sibling::span")]
        private IWebElement TotalSkillCount { get; set; }

        //PAgination last button sign
        [FindsBy(How = How.XPath, Using = "//div[@class='ui buttons semantic-ui-react-button-pagination']//button[contains(text(), '>')]")]
        private IWebElement NextPageBtn { get; set; }

        //First page(Page 1)
        [FindsBy(How = How.XPath, Using = "//button[@class='ui button otherPage'][contains(., '1')][1]")]
        private IWebElement FirstPage { get; set; }

        

        public void SearchSkillByCatg()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SearchSkill" );
            SearchTextBox.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category Name"));
            SearchIcon.Click();

        }

        public void FilterOnline()
        {
            OnlineOpt.Click();

        }


        public void FilterOnsite()
        {
            OnsiteOpt.Click();
        }
    }
}
