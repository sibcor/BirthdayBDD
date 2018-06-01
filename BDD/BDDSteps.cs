using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD
{
    [Binding]
    public class BDDSteps
    {
        Friends friends { get; set; }
        BirthdaySoftware birthdaySoftware { get; set; }
        [Given(@"I have my software Birthday")]
        public void GivenIHaveMySoftwareBirthday()
        {
            birthdaySoftware = new BirthdaySoftware();
        }
        
        [Given(@"I succesed login in system")]
        public void GivenISuccesedLoginInSystem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I fill all data in form")]
        public void WhenIFillAllDataInForm(Table table)
        {
            friends = table.CreateInstance<Friends>();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should add birthday my friend")]
        public void ThenIShouldAddBirthdayMyFriend()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)\.(.*)")]
        public void ThenTheResultShouldBe_(Decimal p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
