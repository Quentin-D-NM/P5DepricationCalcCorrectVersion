using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P5DepricationCalc.Pages
{
    public partial class InvestmentCalculator
    {
        int years;
        double interest;
        double principle;
        int cmpPerYr;
        double futureValue;
        string result = "none";
        string investCalcParams = "initial";
        string error = "none";
        string errorMessage = "";

        private void ClickBtn()
        {
            if (!(principle >= 0 && principle <= Double.MaxValue))
            {
                errorMessage += "| Principle must be within 0 and 1.7976931348623157E+308 ";
                error = "initial";
            }
            if(!(years > 0 && years <= 30))
            {
                errorMessage += "| Years must be within 1 and 30 ";
                error = "initial";
            }
            if(!(interest >= 0 && interest <= 100))
            {
                errorMessage += "| Intrest must be within 0 and 100 ";
                error = "initial";
            }
            if(!(cmpPerYr >= 1 && cmpPerYr <= 24))
            {
                errorMessage += "| Compounds per year must be within 1 and 24 ";
                error = "initial";
            }
            if(cmpPerYr >= 1 && cmpPerYr <= 24 && interest >= 0 && interest <= 100 && years > 0 && years <= 30 && principle >= 0 && principle <= Double.MaxValue)
            {
                error = "none";
                InvestmentCalc investmentCalc = new InvestmentCalc(principle, years, interest, cmpPerYr);
                futureValue = investmentCalc.FutureValue;
                investCalcParams = "none";
                result = "initial";
            }

        }
        
    }
    public partial class InvestmentCalc
    {

        private int cmpPerYr;
        private double interest;
        private double principle;
        private int years;

        public int CmpPerYr { get { return cmpPerYr; } set { cmpPerYr = value; Calc(); } }
        public double FutureValue { get; set; }
        public double Interest { get { return interest; } set { interest = value; Calc(); } }
        public double Principle { get { return principle; } set { principle = value; Calc(); } }
        public int Years { get { return years; } set { years = value; Calc(); } }


        public InvestmentCalc()
        {
            Principle = 0.0;
            CmpPerYr = 0;
            Interest = 0.0;
            Years = 0;
        }

        public InvestmentCalc(double principle, int years, double interest, int numTimes)
        {
            Principle = principle;
            Years = years;
            Interest = interest;
            CmpPerYr = numTimes;
        }

        public void Calc()
        {
            FutureValue = Principle * Math.Pow((1 + (Interest / CmpPerYr)), (CmpPerYr * Years));
            FutureValue = Math.Round(FutureValue, 2);
        }

    }

}
