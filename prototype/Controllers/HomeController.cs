using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using prototype.Domain.Abstractions;
using prototype.Domain.Jwt;
using prototype.Models;
using prototype.Persistence.Repository;
using prototype.Service;

namespace prototype.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private UserServices _userServices;

    public HomeController(UserServices userServices)
    {
        _userServices = userServices;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(string login, string password)
    {
        var result = await _userServices.Login(login, password);
        if (result.StatusCode==200)
        {
            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                notBefore: now,
                claims: result.Data.Claims,
                expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            try
            {
                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
                var response = new
                {
                    access_token = encodedJwt,
                    Role = result.Data.Name,
                };
                return Json(response);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        return BadRequest(new {errorText = "Invalid login or password."});
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

