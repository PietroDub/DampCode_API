using DampCode_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApiMongoDbDemo.Data;

namespace DampCode_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMongoCollection<User> _users;
        public AuthController(MongoDbService mongoDbService)
        {
            _users = mongoDbService.Database?.GetCollection<User>("user");
        }

        //CREATE
        //[HttpPost]
    }
}
