using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void Application(ICreditManager creditManager, ILoggerService logegerService)
        {
            creditManager.Calculate();
            logegerService.Log();
        }

        public void CreditInfo(List<ICreditManager> Credits)
        {
            foreach (var credit in Credits)
            {
                credit.Calculate();
            }
        }
    }
}
