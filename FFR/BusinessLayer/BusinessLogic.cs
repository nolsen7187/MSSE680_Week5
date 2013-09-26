using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using FFR;

namespace BusinessLayer
{
    public class Facade
    {
        //public[
        public void InstantiateCallerRequested(string CallerRequested)
        {
            switch (CallerRequested)
            {
                case "Customer":
                    return;
                default:
                    return;


            }   
        }
    }
}
