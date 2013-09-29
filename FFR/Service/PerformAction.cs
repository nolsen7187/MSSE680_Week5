using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using System.Data.Entity;
using DAL;

namespace Service
{
    public class PerformAction
    {
        //public CRUDRepositoryConcreteFactory cruddy = new CRUDRepositoryConcreteFactory();
        public bool Action(Int16 _actionType)
        {
            var customerRepo = CRUDRepositoryConcreteFactory.CRUD<Customer>();//cruddy.CRUD<Customer>();
        customerRepo.Create(InstatiateCallerRequested.customer);
        return true;// = new DataRepository<Customer>();
            /*switch (_actionType)
            {
                case 1://Create
                    //customerRepository.Create(customer);// = new DataRepository<Customer>();
                    break;
                case 2://Update
                    //Repository.Update(createCustomer);
                    break;
                case 3://Delete
                    //Repository.Delete(createCustomer);
                    break;
                default:
                    //Repository = new DataRepository<Customer>();
                    //Assert.AreEqual(savedCustomer.CustomerId, 1);
                    break;
            } //customerRepo.Create(createCustomer);
            return true;*/
            //attempt to perform most likely CRUD and return value based on success. Don't forget to use exception handling.
        }
    }
}
