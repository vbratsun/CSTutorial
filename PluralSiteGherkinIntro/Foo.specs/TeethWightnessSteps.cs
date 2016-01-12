using System;
using TechTalk.SpecFlow;

namespace Foo.specs
{
    [Binding]
    public class TeethWightnessSteps
    {
        //string _brand;

        [Given(@"I'm using ""(.*)"" brand toothpaste")]
        public void GivenIMUsingBrandToothpaste(string brand)
        {
            ScenarioContext.Current.Add("brand name",brand);
            //or this can be done this way for private field _brand
            //_brand = brand;
        }
        
        [When(@"i brush  for (.*) minutes")]
        public void WhenIBrushForMinutes(int p0)
        {
            var brandName = ScenarioContext.Current["brand name"];
            //var brandName = _brand;
        }
        
        [Then(@"the teeth look (.*) white")]
        public void ThenTheTeethLookWhite(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
