namespace BasicInfo.Endpoint.Controllers;

using Microsoft.AspNetCore.Mvc;
using Sky.App.Endpoint.Api.Controller;
using Core.Contract.Service.Command.Keywords;
using Core.Contract.Service.Query.Keywords;

[ApiController]
[Route("api/[Conteroller]")]
public class KeywordController : ApiController
{
    [HttpPost("/list-keyword")]
    public async Task<IActionResult> SearchByTitleAndStatusAsync(KeywordSearchByTitleAndStatusQuery source) =>
        await GetAsync<KeywordSearchByTitleAndStatusQuery, KeywordSearchByTitleAndStatusPayload>(source);

    [HttpPost("/add-keyword")]
    public async Task<IActionResult> CreateAsync(KeywordCreateCommand source) =>
        await AddAsync<KeywordCreateCommand, KeywordCreatePayload>(source);

    [HttpPost("/edit-keyword")]
    public async Task<IActionResult> EditAsync(KeywordEditCommand source) =>
        await EditAsync<KeywordEditCommand, KeywordEditPayload>(source);

    [HttpPost("/remove-keyword")]
    public async Task<IActionResult> RemoveAsync(KeywordRemoveCommand source) =>
       await RemoveAsync<KeywordRemoveCommand>(source);
}
