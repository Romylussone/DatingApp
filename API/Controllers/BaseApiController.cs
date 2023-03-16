using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")] // api/users
    public class BaseApiController : Controller
    {
        protected readonly DataContext _context;
        protected readonly ITokenService _tokenService;
        public BaseApiController(DataContext context, ITokenService tokenService = null)
        {
            _context = context;
            _tokenService = tokenService;
        }
    }
}