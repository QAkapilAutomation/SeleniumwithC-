﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DemoProject1.FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class MergeEmailAndTemplateFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Merge Email And Template.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Merge Email And Template", "Given the template page is open", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Merge Email And Template")))
            {
                global::DemoProject1.FeatureFile.MergeEmailAndTemplateFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Template listing should get displayed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Merge Email And Template")]
        public virtual void TemplateListingShouldGetDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Template listing should get displayed", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
testRunner.Given("the template page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
testRunner.When("a user selects Email template option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
testRunner.Then("all list of the Email template appears", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Template Listing with Sorting and Filtering")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Merge Email And Template")]
        public virtual void TemplateListingWithSortingAndFiltering()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Template Listing with Sorting and Filtering", null, ((string[])(null)));
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
testRunner.Given("the template page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 12
testRunner.Given("the Email template page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
testRunner.When("a user selects Email template option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
testRunner.Then("template listing along with Filter and Sorting option appear.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Email Composer page should display with Merged Data and Filled Properties")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Merge Email And Template")]
        public virtual void EmailComposerPageShouldDisplayWithMergedDataAndFilledProperties()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Email Composer page should display with Merged Data and Filled Properties", null, ((string[])(null)));
#line 16
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 17
testRunner.Given("the template page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 18
testRunner.When("a user selects Merge and Email option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
testRunner.Then("the Email Composer page appears with Merged Data and Filled Properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Test for Edit")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Merge Email And Template")]
        public virtual void TestForEdit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test for Edit", null, ((string[])(null)));
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
testRunner.Given("the template page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
testRunner.Given("the Merge And Email Composer page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
testRunner.When("user selects any of the given properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.Then("user can change or Edit the pre-filled data.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

