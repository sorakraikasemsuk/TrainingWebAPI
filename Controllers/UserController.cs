using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserRepository userRepo;
        public UserController(UserRepository userRepo){
            this.userRepo=userRepo;
        }
        [HttpGet]
        public List<UserModel> GetAllUser(){
            return userRepo.GetAllUser();
        }
        [HttpPost]
        public void AddUser([FromForm]UserModel data){
            userRepo.AddUser(data);
        }
        [HttpPost]
        public void EditUser([FromForm]UserModel data){
            userRepo.EditUser(data);
        }
        [HttpPost]
        public void DeleteUser([FromForm]UserModel data){
            userRepo.DeleteUser(data);
        }
    }
}