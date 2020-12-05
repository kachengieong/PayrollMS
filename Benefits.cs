using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollGoC
{
    class Benefits
    {
        public static double soc_sec_adm(double grossIncomeSSA)
        {
            return grossIncomeSSA -= (0.062 * grossIncomeSSA);  //returns gross pay after SSA withholdings
        }

        public static double medicare(double grossIncomeMED)
        {
            return grossIncomeMED -= (0.0145 * grossIncomeMED); //returns gross pay after medicare witholdings
        }
        public static double healthCoverage(double grossIncomeHealth, string healthCoverage)
        {
            if (healthCoverage == "Premium Pack")
            {
                return grossIncomeHealth -= 30000;
            }

            else if (healthCoverage == "Gold Pack")
            {
                return grossIncomeHealth -= 15000;
            }

            else
            {
                return grossIncomeHealth -= 7000;
            }
        }
        public static double dentalCoverage(double grossIncomeDental, string dentalCoverage)
        {
            if (dentalCoverage == "Premium Pack")
            {
                return grossIncomeDental -= 30000;
            }

            else if (dentalCoverage == "Gold Pack")
            {
                return grossIncomeDental -= 15000;
            }

            else
            {
                return grossIncomeDental -= 7000;
            }
        }
        public static double visionCoverage(double grossIncomeVision, string visionCoverage)
        {
            if (visionCoverage == "Premium Pack")
            {
                return grossIncomeVision -= 30000;
            }

            else if (visionCoverage == "Gold Pack")
            {
                return grossIncomeVision -= 15000;
            }

            else
            {
                return grossIncomeVision -= 7000;
            }
        }

        public static double retirement(double grossIncomeRET)
        {
            return grossIncomeRET -= grossIncomeRET * 0.04;
        }
    }
}

