using BlazorApp2.Models;
using FluentValidation;

namespace BlazorApp2.FluentValidators
{
    public class TestModelValidator : AbstractValidator<TestModel>
    {
        public TestModelValidator()
        {
            RuleFor(x => x.Letter).NotEmpty();
        }
    }
}
