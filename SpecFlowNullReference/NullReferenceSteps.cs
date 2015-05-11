using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace SpecFlowNullReference
{
    [Binding]
    public class NullReferenceSteps
    {
        private const string Key = "SomeKey";
        private object value;
        private NullReferenceException exception;

        [Given(@"I set null value to ScenarioContext")]
        public void GivenISetNullValueToScenarioContext()
        {
            ScenarioContext.Current.Set<object>(null, Key);
        }

        [When(@"I get value from ScenarioContext")]
        public void WhenIGetValueFromScenarioContext()
        {
            try
            {
                value = ScenarioContext.Current.Get<object>(Key);
            }
            catch (NullReferenceException e)
            {
                exception = e;
            }
        }

        [Then(@"NullReferenceException is thrown")]
        public void ThenNullReferenceExceptionIsThrown()
        {
            Assert.IsNull(value);
            Assert.IsNotNull(exception);
        }
    }
}