using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Rate : IPayroll
    {
        float IPayroll.Earnings(float rateMonth, int rateDay, int dayWorked)
        {
            return (rateMonth * rateDay * dayWorked);
        }
    }
}
