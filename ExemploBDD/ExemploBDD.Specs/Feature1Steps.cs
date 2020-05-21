using System;
using TechTalk.SpecFlow;

namespace ExemploBDD.Specs
{
    [Binding]
    public class Feature1Steps
    {
        [Given(@"\[context]")]
        public void GivenContext()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"\[action]")]
        public void WhenAction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"\[outcome]")]
        public void ThenOutcome()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
