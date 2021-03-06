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
namespace DemoProject1.DTS_FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DeleteWordAndEmailFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "DeleteWordAndEmail.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DeleteWordAndEmail", "\tDelete word and email template from database", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "DeleteWordAndEmail")))
            {
                global::DemoProject1.DTS_FeatureFile.DeleteWordAndEmailFeature.FeatureSetup(null);
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
        
        public virtual void FeatureBackground()
        {
#line 4
    #line 6
     testRunner.Given("I am at the Home Page with url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("1  Ability to delete a email template")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeleteWordAndEmail")]
        public virtual void _1AbilityToDeleteAEmailTemplate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1  Ability to delete a email template", null, ((string[])(null)));
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
    this.FeatureBackground();
#line 9
              testRunner.When("I click on create Email  by hovering the cursor to new template option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
           testRunner.When("I enter the required information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
           testRunner.And("I verify that Attachment Container checkbox is unchecked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
              testRunner.When("I Click On SAVE Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
           testRunner.Then("i should see the success messgage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
              testRunner.When("I search the same email template by name on email template page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
              testRunner.Then("The email template should be present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
              testRunner.When("I delete the email template by clicking on delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
              testRunner.Then("The email template should be deleted from the database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("2  Ability to delete a word template")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DeleteWordAndEmail")]
        public virtual void _2AbilityToDeleteAWordTemplate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2  Ability to delete a word template", null, ((string[])(null)));
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
    this.FeatureBackground();
#line 20
             testRunner.When("I click on create Word by hovering the cursor to new template option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
          testRunner.Then("I should be on Word template page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
          testRunner.When("I enter the required information in word Template field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
          testRunner.When("I attach  File using Attach option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
          testRunner.When("I Click On SAVE Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
          testRunner.Then("i should see the success messgage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
       testRunner.When("I search the same word template by name on home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
             testRunner.Then("The word template should be present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
             testRunner.When("I delete the word template by clicking on delete button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
             testRunner.Then("The word template should be deleted from the database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

