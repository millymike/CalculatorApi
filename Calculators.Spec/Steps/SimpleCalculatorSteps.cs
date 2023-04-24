using Calculators.Features;
using FluentAssertions;

namespace Calculators.Spec.Steps;

[Binding]
public class SimpleCalculatorSteps
{
    private readonly ISimpleCalculator<decimal> calculator;
    private decimal result;
    private readonly ScenarioContext context;

    public SimpleCalculatorSteps(ScenarioContext context)
    {
        this.context = context;
        calculator = new SimpleCalculator<decimal>();
    }

    [When(@"I call Add with arguments (.*) and (.*)")]
    public void WhenICallAddWithArgumentsAnd(decimal a, decimal b)
    {
        result = calculator.Add(a, b);
    }

    [When(@"I call Subtract with arguments (.*) and (.*)")]
    public void WhenICallSubtractWithArgumentsAnd(decimal a, decimal b)
    {
        result = calculator.Subtract(a, b);
    }

    [When(@"I call Multiply with arguments (.*) and (.*)")]
    public void WhenICallMultiplyWithArgumentsAnd(decimal a, decimal b)
    {
        result = calculator.Multiply(a, b);
    }

    [When(@"I call Divide with arguments (.*) and (.*)")]
    public void WhenICallDivideWithArgumentsAnd(decimal a, decimal b)
    {
        try
        {
            result = calculator.Divide(a, b);
        }
        catch (DivideByZeroException ex)
        {
            context["exception"] = ex;
        }
    }

    [Then(@"the returned value should be (.*)")]
    public void ThenTheReturnedValueShouldBe(decimal expected)
    {
        result.Should().Be(expected);
    }

    [Then(@"a DivideByZeroException should be thrown")]
    public void ThenADivideByZeroExceptionShouldBeThrown()
    {
        context.ContainsKey("exception").Should().BeTrue();
        context["exception"].Should().BeOfType<DivideByZeroException>();
    }
}
