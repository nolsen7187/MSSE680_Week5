using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using DAL;
//https://www.youtube.com/watch?v=WLjvNpP6yeQ
namespace BusinessLayer
{
    public class Facade
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
        public void SetData(List<Customer>_Data)
        {
            //spin through list, look up field names and set fields in model to data passed in. For each field model in list set field in model object
        }
        public void GetDataRepository()
        {
            //var customerRepository = Service.CRUDRepositoryConcreteFactory.CRUD<Customer>();
            //get repository using the factory from last week
        }
        public bool PerformAction(Int16 _actionType)
        {
            switch (_actionType)
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
                    return true;
            } //customerRepo.Create(createCustomer);
            return true;
            //attempt to perform most likely CRUD and return value based on success. Don't forget to use exception handling.
        }

    }
}
