﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Foo.specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Brushing Of Teeth")]
    public partial class BrushingOfTeethFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BrushingOfTeeth.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Brushing Of Teeth", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sucsessfull brushing")]
        public virtual void SucsessfullBrushing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sucsessfull brushing", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("there is 1 gram of brand \'X\' toothpaste on the brush", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
testRunner.And("the mouth is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
testRunner.When("the back teeth are brushed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
testRunner.And("the front teeth are brushed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.Then("the teeth look clean", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
testRunner.And("the mouth feels fresh", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.But("the braces aren\'t damaged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Sucsessfull brushing with tools")]
        public virtual void SucsessfullBrushingWithTools()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Sucsessfull brushing with tools", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "ToolName",
                        "ToolQuality"});
            table1.AddRow(new string[] {
                        "paste",
                        "medium"});
            table1.AddRow(new string[] {
                        "water",
                        "low"});
            table1.AddRow(new string[] {
                        "brush",
                        "high"});
#line 13
testRunner.Given("i have the following tools:", ((string)(null)), table1, "Given ");
#line 18
testRunner.And("the mouth is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
testRunner.When("the back teeth are brushed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
testRunner.And("the front teeth are brushed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
testRunner.Then("the teeth look clean", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
testRunner.And("the mouth feels fresh", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
testRunner.But("the braces aren\'t damaged", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
