using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGoC
{
    class NJstateTax
    {
        public static double PayRateNJ(double GrossIncome)
        {
            if (GrossIncome <= 19999)
            {
                return GrossIncome -= (0.014 * GrossIncome);

            }

            else if (GrossIncome >= 20000 && GrossIncome <= 34999)
            {
                return GrossIncome -= (0.0175 * GrossIncome);
            }

            else if (GrossIncome >= 35000 && GrossIncome <= 39999)
            {
                return GrossIncome -= (0.035 * GrossIncome);
            }
            else if (GrossIncome >= 40000 && GrossIncome <= 75000)
            {
                return GrossIncome -= (0.0553 * GrossIncome);
            }
            else if (GrossIncome >= 75001 && GrossIncome <= 499999)
            {
                return GrossIncome -= (0.0673 * GrossIncome);
            }
            else if (GrossIncome >= 500000 && GrossIncome <= 4999999)
            {
                return GrossIncome -= (0.0897 * GrossIncome);
            }
            else
            {
                return GrossIncome -= (0.1075 * GrossIncome);
            }
        }
        /*
        public static double MarriedPayRateCT(double grossIncomeMarried, string MarriedRate)
        {
            if (MarriedPayRateCT == "TaxBracket1")
            {
                return grossIncomeMarried -= (0.014 * grossIncomeMarried);
            }

            else if (MarriedPayRateCT == "TaxBracket2")
            {
                return grossIncomeMarried -= (0.0175 * grossIncomeMarried);
            }

            else if (MarriedPayRateCT == "TaxBracket3")
            {
                return grossIncomeMarried -= (0.0245 * grossIncomeMarried);
            }
            else if (MarriedPayRateCT == "TaxBracket4")
            {
                return grossIncomeMarried -= (0.035 * grossIncomeMarried);
            }
            else if (MarriedPayRateCT == "TaxBracket5")
            {
                return grossIncomeMarried -= (0.0553 * grossIncomeMarried);
            }
            else if (MarriedPayRateCT == "TaxBracket6")
            {
                return grossIncomeMarried -= (0.0637 * grossIncomeMarried);
            }
            else
            {
                return grossIncomeMarried -= (0.0897 * grossIncomeMarried);
            }
        }

        */
    }
}
