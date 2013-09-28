using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Xml;

namespace Service
{
    public class InstatiateCallerRequested
    {
        public static Customer customer;

//        public void InstantiateCallerRequested(string CallerRequested)
        public void InstantiateCallerRequested(XmlWriter localXmlWriter)
        {
            XmlReader xmlReader = XmlReader.Create("Register.xml");
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Customer")
                {
                    customer = Activator.CreateInstance<Customer>();
                    break;
                }
            }

            /*switch (localXmlWriter)
            {
                case "Customer":
                    customer = Activator.CreateInstance<Customer>();
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
                default:*/
                    return;
            //}
        }
    }
}
