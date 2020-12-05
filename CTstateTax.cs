using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGoC
{
    class CTstateTax
    {
        public static double PayRateCT(double GrossIncome)
        {
            if (GrossIncome <= 10000)
            {
                return GrossIncome -= (0.030 * GrossIncome);
            }

            else if (GrossIncome >= 10001 && GrossIncome <= 50000)
            {
                return GrossIncome -= (0.050 * GrossIncome);
            }

            else if (GrossIncome >= 50001 & GrossIncome <= 100000)
            {
                return GrossIncome -= (0.055 * GrossIncome);
            }
            else if (GrossIncome >= 100001 && GrossIncome <= 200000)
            {
                return GrossIncome -= (0.060 * GrossIncome);
            }
            else if (GrossIncome >= 200001 && GrossIncome <= 250000)
            {
                return GrossIncome -= (0.0650);
            }
            else if (GrossIncome >= 250001 && GrossIncome <= 500000)
            {
                return GrossIncome -= (0.0690);
            }
            else
            {
                return GrossIncome -= (0.0699);
            }
        }
        /*
        public static double MarriedPayRateCT(double grossIncomeMarried, string MarriedRate)
        {
            if (MarriedPayRateCT == "TaxBracket1")
            {
                return grossIncomeMarried -= (0.03 * grossIncomeMarried);
            }

            else if (MarriedPayRateCT == "TaxBracket2")
            {
                return grossIncomeMarried -= (0.05 * grossIncomeMarried);
            }

            else if (MarriedPayRateCT == "TaxBracket3")
            {
                return grossIncomeMarried -= (0.055 * grossIncomeMarried);
            }
            else if (MarriedPayRateCT == "TaxBracket4")
            {
                return grossIncomeMarried -= (0.060 * grossIncomeMarried);
            }
            else
            {
                return grossIncomeMarried -= (0.065 * grossIncomeMarried)
            }
        }
        */

    }
}
