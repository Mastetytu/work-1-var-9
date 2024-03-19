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
        public static AppContext DB { get; set; }
        public static User User { get; internal set; }

        static SingleTon()
        {
            DB = new AppContext("C:\\Users\\aleks\\source\\repos\\work-1-var-9\\Accounts.txt");
        }
    }
}
