using Films.Managers;
using Films.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Films.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthorizationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Registration")]
        public Response Registration(Registration registration)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("FilmDB").ToString());
            Authorization dal = new Authorization();
            response = dal.Registration(registration, connection);

            return response;
        }

        [HttpPost]
        [Route("Login")]
        public Response Login(UsersLogins usersLogin)
        {
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("FilmDB").ToString());
            Authorization dal = new Authorization();
            response = dal.Login(usersLogin, connection);

            return response;
        }
    }
}
