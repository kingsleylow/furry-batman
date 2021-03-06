﻿using OpenQA.Selenium;

namespace Alpari.QA.Webdriver.Core
{
    public interface IPageBase
    {
        //TODO: - Change to Property?
        bool IsDisplayed();
    }

    public abstract class PageBase : IPageBase
    {
        protected By Displayed;
        protected IWebdriverCore WebdriverCore { get; set; }

        protected PageBase(IWebdriverCore webdriverCore)
        {
            WebdriverCore = webdriverCore;
        }

        public bool IsDisplayed()
        {
            var element = WebdriverCore.FindElement(Displayed);
            return element != null && element.Displayed;
        }
    }
}