using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Demo_Specflow.test.Steps
{
    [Binding]
    public class CalculatorAddSteps
    {
        readonly Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) and (.*) into the calculator")]
        public void GivenIHaveEnteredAndIntoTheCalculator(int p0, int p1)
        {
            this.calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            int result = this.calculator.Result;
            Assert.AreEqual(p0, result);
        }
    }
}
