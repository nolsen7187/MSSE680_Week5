using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Service
{
    class InstatiateCallerRequested
    {
        public void InstantiateCallerRequested(string CallerRequested)
        {
            switch (CallerRequested)
            {
                case "Customer":
                    Customer customer = Activator.CreateInstance<Customer>();
                    break;
                case "Item":
                    Item item = Activator.CreateInstance<Item>();
                    break;
                case "SalesHeader":
                    SalesHeader salesHeader = Activator.CreateInstance<SalesHeader>();
                    break;
                case "SalesItem":
                    SalesItem salesItem = Activator.CreateInstance<SalesItem>();
                    break;
                case "Employee":
                    Employee employee = Activator.CreateInstance<Employee>();
                    break;
                default:
                    return;
            }
        }
    }
}
