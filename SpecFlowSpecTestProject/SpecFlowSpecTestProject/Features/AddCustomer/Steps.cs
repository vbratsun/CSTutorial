using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowSpecTestProject.Features.AddCustomer
{
    [Binding]
    public class Steps
    {
        [Given(@"a user has entered information about a customer")]
        public void GivenAUserHasEnteredInformationAboutACustomer()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"she has provided a first name and a last name as required")]
        public void GivenSheHasProvidedAFirstNameAndALastNameAsRequired()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"she completes entering more information")]
        public void WhenSheCompletesEnteringMoreInformation()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"that customer should be stored in the system")]
        public void ThenThatCustomerShouldBeStoredInTheSystem()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"she has not provided the first name and last name")]
        public void GivenSheHasNotProvidedTheFirstNameAndLastName()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"that user will be notified about the missing data")]
        public void ThenThatUserWillBeNotifiedAboutTheMissingData()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the customer will not be stored into the system")]
        public void ThenTheCustomerWillNotBeStoredIntoTheSystem()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
