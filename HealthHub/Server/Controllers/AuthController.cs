using Duende.IdentityServer.Models;
using HealthHub.Server.Converters;
using HealthHub.Server.Services;
using HealthHub.Server.Services.Interfaces;
using HealthHub.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HealthHub.Server.Controllers;

[Route("api/v1/user")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IEmailSender _emailSender;
    private readonly IMailService _mailService;

    public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender, IMailService mailService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _signInManager = signInManager;
        _emailSender = emailSender;
        _mailService = mailService;
    }

    [HttpPost]
    public async Task<IActionResult> Save(AddUserViewModel userModel, [FromQuery] string? returnUrl = null)
    {
        var user = userModel.ToApplicationUser();
        var result = await _userManager.CreateAsync(user);
        if (result.Succeeded)
        {
            await _userManager.UpdateNormalizedUserNameAsync(user);
            await _userManager.UpdateNormalizedEmailAsync(user);

            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callback = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = userId, code = code },
                protocol: Request.Scheme);
            var mail = new MailData(new[] { user.Email }, "Confirm your email", $"Please confirm your HealthHub acount by <a href='{HtmlEncoder.Default.Encode(callback)}'>clicking here</a>.");
            await _mailService.SendAsync(mail);
            //await _emailSender.SendEmailAsync(userModel.Email, "Confirm your email", $"Please confirm your HealthHub acount by <a href='{HtmlEncoder.Default.Encode(callback)}'>clicking here</a>.");

            return Ok();
        }
        return LocalRedirect(returnUrl);
    }
}
