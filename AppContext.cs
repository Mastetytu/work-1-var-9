using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace work_1_var_9
{
    
    public class AppContext
    {
        public  List<User> Users {  get; set; }
        
        public string fileName {get;set;}

        
        public AppContext(string fileName)
        {
            this.fileName = fileName;
            var user1  = File.ReadAllText(fileName).ToList();
            
        }
        public void Add(User stroka) 
        {

            Users.Add(stroka);
            File.WriteAllText(fileName, Users.ToString());
        }
    }
}
