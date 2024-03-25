using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    struct Linear
    {
        double k;
        double b;
        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;                
        }
        public string Root()
        {
            if (k == 0 && b != 0)
                return "Решений нет";
            if (k == 0 && b == 0)
                return "Бесконечно много решений";
            double r1 = -b / k;
            return $"Решение: {r1}";
        }
    }
}
