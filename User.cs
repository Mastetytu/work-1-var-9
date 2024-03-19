using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_1_var_9
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public User(string _name,string _pass) {
            this.Name = _name;
            this.Password = _pass;
            
        }
    }
}
