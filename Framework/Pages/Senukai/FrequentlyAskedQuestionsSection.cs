﻿namespace Framework.Pages.Senukai
{
    public class FrequentlyAskedQuestionsSection
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.senukai.lt/");
        }

        public static void ClickFieldDUK()
        {
            Common.ClickElement(Locators.FrequentlyAskedQuestionsSection.fieldDUK);
        }

        public static void ClickFieldSearchQuestion()
        {
            Common.ClickElement(Locators.FrequentlyAskedQuestionsSection.inputSearchQuestion);
        }

        public static void EnterQuestion(string valueInputQuestion)
        {
            Common.SendKeys(Locators.FrequentlyAskedQuestionsSection.inputSearchQuestion, valueInputQuestion);
        }

        public static void ClickTheSelectionFieldInDropdownList(string sectionText)
        {
            string locator = $"{Locators.FrequentlyAskedQuestionsSection.selectionFieldInDropdownList}//*[contains(text(), '{sectionText}')]";
            Common.ClickElement(locator);
        }

        public static string GetSectionOutput()
        {
            return Common.GetElementText(Locators.FrequentlyAskedQuestionsSection.sectionWhenWillIReceiveMyOrder);
        }
    }
}
