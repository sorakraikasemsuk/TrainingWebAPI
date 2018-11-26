using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class UserRepository
    {
        public List<UserModel> user;
        public UserRepository(){

            this.user=new List<UserModel>();
            this.user.Add(new UserModel{
                UserId=1,
                FirstName="Sorakrai",
                LastName="Kasemsuk",
                UserName="Sorakrai",
                Password="123456",
                Email="test@mail.com",
                Tel="123456789"
            });
        }
        public List<UserModel> GetAllUser(){
            return user.ToList();
        }
        public void AddUser(UserModel data){
            user.Add(data);
        }
        public void EditUser(UserModel data){
            var edit=user.Where(user=>user.UserId==data.UserId).FirstOrDefault();
            edit.FirstName=data.FirstName;
            edit.LastName=data.LastName;
            edit.UserName=data.UserName;
            edit.Password=data.Password;
            edit.Email=data.Email;
            edit.Tel=data.Tel;
        }
        public void DeleteUser(UserModel data){
            var delete=user.Where(user=>user.UserId==data.UserId).FirstOrDefault();
            user.Remove(delete); 
        }
    }
}