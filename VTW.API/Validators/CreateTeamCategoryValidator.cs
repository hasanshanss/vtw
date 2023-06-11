using FluentValidation;
using VTW.API.RequestHandlers.Commands.CommandModels;
using VTW.API.Services.Contracts.V1.TeamCategoryContracts.Requests;
using VTW.API.Services.Contracts.V1.TeamContracts.Requests;

namespace VTW.API.Validators
{
    public class CreateTeamCategoryValidator : AbstractValidator<CreateTeamCategoryRequest>
    {
        public CreateTeamCategoryValidator()
        {
            RuleFor(t => t.TeamCategoryName)
                .NotEmpty()
                .WithMessage("The TeamCategoryName shouldn't be empty")
                .Length(1, 10)
                .WithMessage("Length is not correct");
        }
    }
}
