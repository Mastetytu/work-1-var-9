using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_1_var_9
{
    public class AppContext
    {
        public static List<User> user = new List<User>();
        public delegate void OnListChanged();
        public string fileName;
        public OnListChanged listChanged;

        //public static List<User> DataSource { get; set; }

        public AppContext(string fileName) 
        {
            this.fileName = fileName;
            user = File.ReadAllText(fileName).ToList();

        }
        public void Add(User stroka) 
        {
            user.Add(stroka);
            if (listChanged != null) 
            {
                listChanged();
            }
            File.WriteAllText(fileName, user.ToString());
        }
    }
}
