using System;
using TechTalk.SpecFlow;

namespace Foo.specs
{
    [Binding]
    public class BrushingOfTeethSteps
    {
        [Given(@"there is (.*) gram of brand '(.*)' toothpaste on the brush")]
        public void GivenThereIsGramOfBrandToothpasteOnTheBrush(int grams, string brand)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"i have the following tools:")]
        public void GivenIHaveTheFollowingTools(Table table)
        {
            var firstToolName = table.Rows[0][0];
            var firstToolQuality = table.Rows[0][1];
                        
            var secondToolName = table.Rows[1]["ToolName"];
            var secondToolQuality = table.Rows[1]["ToolQuality"];
            
            var isToolColorColumnSpecified = table.ContainsColumn("Color");
              
            ScenarioContext.Current.Pending();
        }

        
        [Given(@"the mouth is open")]
        public void GivenTheMouthIsOpen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the back teeth are brushed")]
        public void WhenTheBackTeethAreBrushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the front teeth are brushed")]
        public void WhenTheFrontTeethAreBrushed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the teeth look clean")]
        public void ThenTheTeethLookClean()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the mouth feels fresh")]
        public void ThenTheMouthFeelsFresh()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the braces aren't damaged")]
        public void ThenTheBracesArenTDamaged()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
