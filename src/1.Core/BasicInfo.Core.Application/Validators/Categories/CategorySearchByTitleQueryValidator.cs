namespace BasicInfo.Core.Application.Validators.Categories;

using FluentValidation;
using Contract.Service.Query.Categories;

public class CategorySearchByTitleQueryValidator : AbstractValidator<CategorySearchByTitleQuery>
{
    public CategorySearchByTitleQueryValidator()
    {

    }
}
