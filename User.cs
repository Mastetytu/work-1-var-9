using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace work_1_var_9
{
    public class User
    {
        public int Id{get;set;}
        public string Name { get; set; }
        public string Password { get; set; }
        public User(string name,string password) { 
            this.Name = name.ToString();
            this.Password = password.ToString();
        }   
    }
}
