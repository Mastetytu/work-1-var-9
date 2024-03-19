using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using work_1_var_9;

namespace work_1_var_9
{
    public static class SingleTon
    {
        public static User User{ get; set; }
        public static AppContext DB { get; set; }
        static SingleTon()
        {
            DB = new AppContext("Accounts.txt");
        }
    }
}
