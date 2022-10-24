using FluentValidation;
using VTW.API.Services.Contracts.Team.Requests;

namespace VTW.API.Validators
{
    public class CreateTeamRequestValidator : AbstractValidator<CreateTeamRequest>
    {
        public CreateTeamRequestValidator()
        {
            RuleFor(t => t.TeamName)
                .NotEmpty()
                .WithMessage("The TeamName shouldn't be empty")
                .Length(1, 5)
                .WithMessage("Length is not correct");

            RuleFor(t => t.TeamCategoryId)
                .NotEmpty();
        }
    }
}
