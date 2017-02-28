using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHandin2
{
    public class Reimbursement
    {
        /// <summary>
        /// Insert "d" or "doctor" for a doctors visit
        /// Insert "h" or "hospital" for a hospital visit
        /// </summary>
        /// <param name="deductableMet"></param>
        /// <param name="TypeOfVisit"></param>
        /// <returns></returns>
        public int reimbursementPercentage(bool deductableMet, string TypeOfVisit)
        {
            TypeOfVisit = TypeOfVisit.ToLower();
            
            if (!deductableMet) return 0;
            else if (TypeOfVisit == "d" || TypeOfVisit == "doctor") return 50;
            else if (TypeOfVisit == "h" || TypeOfVisit == "hospital") return 80;
            else return 0;
        }

    }
}
