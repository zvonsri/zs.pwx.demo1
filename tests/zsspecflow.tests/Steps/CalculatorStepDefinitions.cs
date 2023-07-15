using NUnit.Framework;
using TechTalk.SpecFlow;
using zslib;

namespace zsspecflow.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int firstNum;
        private int secondNum;
        private int actual = 0;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            firstNum = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            secondNum = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            actual = Calculator.Add(firstNum, secondNum);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(actual, result);
        }
    }
}
