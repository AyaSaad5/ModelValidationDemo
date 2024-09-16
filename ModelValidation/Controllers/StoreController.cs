using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;

[ApiController]
[Route("api/[controller]")]
public class StoreController : ControllerBase
{
    private readonly IValidator<StoreRequestModel> _validator;

    public StoreController(IValidator<StoreRequestModel> validator)
    {
        _validator = validator;
    }

    [HttpPost]
    public IActionResult CreateStore([FromBody] StoreRequestModel store)
    {
        var result = _validator.Validate(store);

        if (!result.IsValid)
        {
            var errors = result.Errors;
            return BadRequest(errors);
        }

        // Create user
        return Ok("User created successfully");
    }
}