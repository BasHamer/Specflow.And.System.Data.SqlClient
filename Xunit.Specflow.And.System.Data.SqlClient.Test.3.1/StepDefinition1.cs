using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specflow.And.SystemDataSqlClient.Test
{
    [Binding]
    public sealed class StepDefinition1
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public StepDefinition1(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given("bob")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator()
        {
            SqlConnection connection = new SqlConnection("bob");
        }

        
    }
}
