using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Collections;

namespace BusinessLayerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            ArrayList dataList = new ArrayList();

            dataList.Add("FirstName=Nick");
            dataList.Add("LastName=Olsen");
            dataList.Add("City=Parker");
            dataList.Add("State=CO");
            dataList.Add("Zip=80134");
            dataList.Add("Phone=3037181335");
            dataList.Add("Email=nolsen@regis.edu");
            //Customer customer = new Customer();
            /*customer.CustomerId = 1;
            customer.FirstName = "Nick";
            customer.LastName = "Olsen";
            customer.City = "Parker";
            customer.State = "CO";
            customer.Zip = "80134";
            //Need to Add Street Name and Suite Fields
            customer.Address = customer.FirstName + " " + customer.LastName + "11321 Lovage Way " + customer.City + ", " + customer.State + " " + customer.Zip;
            customer.Phone = "3037181336";
            customer.Email = "nolsen@regis.edu";*/

            Facade newFacade = new Facade("Customer", dataList);

            newFacade.RegisterCustomer();
        }
    }
}
