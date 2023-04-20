﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsQA_1.Feature.ProfileDetailsFeature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Languages")]
    public partial class LanguagesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Languages.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Feature/ProfileDetailsFeature", "Languages", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line hidden
#line 6
 testRunner.Given("I am on the Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And("I am under the tab Languages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Language")]
        [NUnit.Framework.CategoryAttribute("tag5")]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", "French", "Basic", null)]
        [NUnit.Framework.TestCaseAttribute("Hindi", "Conversational", "Telugu", "Native/Bilingual", null)]
        [NUnit.Framework.TestCaseAttribute("French", "Basic", "Spanish", "Conversational", null)]
        public void AddLanguage(string language, string level, string newLanguage, string newLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag5"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            argumentsOfScenario.Add("New language", newLanguage);
            argumentsOfScenario.Add("New level", newLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Language", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 12
 testRunner.When("I click on Add New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And(string.Format("I enter \"{0}\" in the Language text field", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("I select \"{0}\" in the Level select field", level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("I click on Add button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then(string.Format("\"{0}\" and \"{1}\" should be dispalyed as a record under the Language tab", language, level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.And(string.Format("A popup with message \' \"{0}\" has been added to your languages\' should appear at t" +
                            "he top right corner of the page", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Make Language editable")]
        [NUnit.Framework.CategoryAttribute("tag6")]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", "French", "Basic", null)]
        [NUnit.Framework.TestCaseAttribute("Hindi", "Conversational", "Telugu", "Native/Bilingual", null)]
        [NUnit.Framework.TestCaseAttribute("French", "Basic", "Spanish", "Conversational", null)]
        public void MakeLanguageEditable(string language, string level, string newLanguage, string newLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag6"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            argumentsOfScenario.Add("New language", newLanguage);
            argumentsOfScenario.Add("New level", newLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make Language editable", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 27
 testRunner.Given(string.Format("I see the record with \"{0}\" displayed", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
 testRunner.When("I click on the Pencil icon for that record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then(string.Format("The fields with values \"{0}\" and \"{1}\" should become editable", language, level), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Save updated Language")]
        [NUnit.Framework.CategoryAttribute("tag7")]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", "French", "Basic", null)]
        [NUnit.Framework.TestCaseAttribute("Hindi", "Conversational", "Telugu", "Native/Bilingual", null)]
        [NUnit.Framework.TestCaseAttribute("French", "Basic", "Spanish", "Conversational", null)]
        public void SaveUpdatedLanguage(string language, string level, string newLanguage, string newLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag7"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            argumentsOfScenario.Add("New language", newLanguage);
            argumentsOfScenario.Add("New level", newLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Save updated Language", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 39
 testRunner.Given(string.Format("I see the record \"{0}\" in editable mode", language), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
 testRunner.When(string.Format("I change \"{0}\" to \"{1}\"", language, newLanguage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.And(string.Format("I change \"{0}\" to \"{1}\"", level, newLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("I click on Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.Then(string.Format("The record should be updated with \"{0}\" and \"{1}\"", newLanguage, newLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.And(string.Format("A popup with message \' \"{0}\" has been updated to your languages\" should appear at" +
                            " the top right corner of the page", newLanguage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Language")]
        [NUnit.Framework.CategoryAttribute("tag8")]
        [NUnit.Framework.TestCaseAttribute("English", "Fluent", "French", "Basic", null)]
        [NUnit.Framework.TestCaseAttribute("Hindi", "Conversational", "Telugu", "Native/Bilingual", null)]
        [NUnit.Framework.TestCaseAttribute("French", "Basic", "Spanish", "Conversational", null)]
        public void DeleteLanguage(string language, string level, string newLanguage, string newLevel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "tag8"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Language", language);
            argumentsOfScenario.Add("Level", level);
            argumentsOfScenario.Add("New language", newLanguage);
            argumentsOfScenario.Add("New level", newLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Language", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
#line 54
 testRunner.Given(string.Format("I see the record with \"{0}\" as Language displayed", newLanguage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 55
 testRunner.When("I click on x icon for that record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then(string.Format("The record with values \"{0}\" and \"<New Level>\" should disappear", newLanguage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.And(string.Format("A popup with message \' \"{0}\" is deleted from your languages\' should appear at the" +
                            " top right corner of the page", newLanguage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
