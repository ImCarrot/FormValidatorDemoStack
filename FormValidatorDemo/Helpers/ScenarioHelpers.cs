using System;
using System.Collections.Generic;

namespace FormValidatorDemo.Helpers
{
    public static class ScenarioHelpers
    {
        public const string ProjectTarget = "Form Validation";

        public static List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Quick & Dirty", ClassType=typeof(View.QuickAndDirty)},
            new Scenario() { Title="Recommended", ClassType=typeof(View.OrganizedAndDynamic)},
        };
    }
    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
