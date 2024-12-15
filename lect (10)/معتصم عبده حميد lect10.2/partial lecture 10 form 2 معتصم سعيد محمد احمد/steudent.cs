using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_lecture_10_form_2_معتصم_عبده_حميد_يحيى
{
    public class steudent
    {
        private int number;
        private string name;
        private string birthday;
        private string imagpath;
        public void setnumber(int num)
        {
            this.number = num;

        }
        public void setname(string na)
        {
            this.name = na;
        }
        public void sitbirthday(string birth)
        {
            this.birthday = birth;
        }
        public void setimagebath(string bathimg)
        {
            this.imagpath = bathimg;
        }
        public int getnumber() => number;
        public string getname() => name;
        public string getbirthday() => birthday;
        public string getimagpath() => imagpath;

    }
}
