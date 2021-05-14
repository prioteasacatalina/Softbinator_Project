using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Softbinator_Project.DTOs;
using Softbinator_Project.Entities;
using Softbinator_Project.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Softbinator_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        
        private readonly UserManager<User> _userManager; //folosim clasa Manager care creaza direct User-ul in baza
        private readonly SignInManager<User> _signInManager; //folosit pentru Register
        private readonly TokenManager _tokenManager;
        public AuthenticateController(UserManager<User> userManager, SignInManager<User> signInManager, TokenManager tokenManager)
        {
            _userManager = userManager; //initializam in constructor campul privat
            _signInManager = signInManager;
            _tokenManager = tokenManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerdto)
        {
            var user = new User
            {
                Email = registerdto.Email,
                UserName = registerdto.Email
            };

            var result = await _userManager.CreateAsync(user, registerdto.Password); //rezultatul crearii user-ului; parola este criptata si pusa in baza

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, registerdto.Role);
                return Ok();
            }

            return BadRequest("Something went wrong when creating the account");
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDTO)
        {
            var user = await _userManager.FindByNameAsync(loginDTO.Email); //cautam user ul cu e-mail ul respectiv

            if (user == null) //nu gaseste user ul
                return NotFound();
            else
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false); //verificare parola


                if (result.Succeeded)
                {
                    var accessToken = await _tokenManager.CreateAccessToken(user);
                    var refreshToken = _tokenManager.CreateRefreshToken();

                    user.RefreshToken = refreshToken;

                    await _userManager.UpdateAsync(user);

                    return Ok(new
                    {
                        AccessToken = accessToken,
                        RefreshToken = refreshToken
                    });
                }
                else
                    return BadRequest("It cannot Login");
            }
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshDto refreshDto)
        {
            var principal = _tokenManager.GetPrincipalFromExpiredToken(refreshDto.AccessToken);
            var username = principal.Identity.Name;

            var user = await _userManager.FindByEmailAsync(username);

            if (user.RefreshToken != refreshDto.RefreshToken)
                return BadRequest("Bad refreshToken");

            var newJwtToken = await _tokenManager.CreateAccessToken(user);

            return Ok(new
            {
                Token = newJwtToken
            });
        }

    }
}
