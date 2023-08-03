namespace BasicInfo.Endpoint.Controllers;

using Microsoft.AspNetCore.Mvc;
using Sky.App.Endpoint.Api.Controller;
using Core.Application.Command.Keywords;

[ApiController]
[Route("api/[Conteroller]")]
public class KeywordController : ApiController
{
    [HttpGet("/fetch-all")]
    public async Task<IActionResult> ListAsync()
    {
        // query dispatcher...

        return Ok();
    }

    [HttpPost("/create-keyword")]
    public async Task<IActionResult> CreateAsync(KeywordCreateCommand source) =>
        await AddAsync<KeywordCreateCommand, KeywordCreateData>(source);

    [HttpPost("/edit-keyword")]
    public async Task<IActionResult> EditAsync(KeywordEditCommand source) =>
        await EditAsync<KeywordEditCommand, KeywordEditData>(source);

    [HttpPost("/remove-keyword")]
    public async Task<IActionResult> RemoveAsync(KeywordRemoveCommand source) =>
       await RemoveAsync<KeywordRemoveCommand>(source);
}
