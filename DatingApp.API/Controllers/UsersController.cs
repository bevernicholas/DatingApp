using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DatingApp.API.Data;
using System.Threading.Tasks;
using DatingApp.API.Models;
using DatingApp.API.Dtos;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using System.Collections.Generic;

namespace DatingApp.API.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly IDatingRepository _repo;
    private readonly IMapper _mapper;
    public UsersController(IDatingRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _repo.GetUsers();
        var usersToReturn = _mapper.Map<IEnumerable<UserForListDto>>(users);
        return Ok(usersToReturn);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        var user = await _repo.GetUser(id);
        var userToReturn = _mapper.Map<UserForDetailsDto>(user);
        return Ok(userToReturn);
    }
  }
}