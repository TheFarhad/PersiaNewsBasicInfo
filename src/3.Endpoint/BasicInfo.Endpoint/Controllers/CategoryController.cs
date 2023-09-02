namespace BasicInfo.Endpoint.Controllers;

using Microsoft.AspNetCore.Mvc;
using Sky.App.Endpoint.Api.Controller;
using Core.Contract.Service.Command.Categories;
using Core.Contract.Service.Query.Categories;

[ApiController]
[Route("api/[Controller]")]
public class CategoryController : ApiController
{
    [HttpGet("/list-category")]
    public async Task<IActionResult> SearchByTitleAsync(CategorySearchByTitleQuery source) =>
        await GetAsync<CategorySearchByTitleQuery, CategorySearchByTitlePayload>(source);

    [HttpPost("/add-category")]
    public async Task<IActionResult> AddAsync(CategoryCreateCommand source) =>
        await AddAsync<CategoryCreateCommand, CategoryCreatePayload>(source);

    [HttpPost("/edit-category")]
    public async Task<IActionResult> EditAsync(CategoryEditCommand source) =>
       await EditAsync<CategoryEditCommand, CategoryEditPayload>(source);

    [HttpPost("/remove-category")]
    public async Task<IActionResult> RemoveAsync(CategoryRemoveCommand source) =>
     await RemoveAsync<CategoryRemoveCommand, CategoryRemovePayload>(source);
}
