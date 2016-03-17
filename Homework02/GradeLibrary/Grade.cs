using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeLibrary
{
    public class Grade
    {
        public double value;
        private string level;
        public string subject;

        public string ToLevel()
        {
            if (this.value >= 90)
                this.level = "A+";
            if (this.value >= 85 && this.value < 90)
                this.level = "A";
            return this.level;
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("科目名稱{0}\n", this.subject);
            result += string.Format("科目分數{0}\n", this.value);
            result += string.Format("科目等第{0}\n", this.ToLevel());
            return result;
        }
    }
}