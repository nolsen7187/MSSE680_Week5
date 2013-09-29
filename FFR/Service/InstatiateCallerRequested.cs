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
        public static Item item;
        public static SalesHeader salesHeader;
        public static SalesItem salesItem;
        public static Employee employee;

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
                    //break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Item")
                {
                    item = Activator.CreateInstance<Item>();
                    //break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "SalesHeader")
                {
                    salesHeader = Activator.CreateInstance<SalesHeader>();
                    //break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "SalesItem")
                {
                    salesItem = Activator.CreateInstance<SalesItem>();
                    //break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Employee")
                {
                    employee = Activator.CreateInstance<Employee>();
                    //break;
                }

                //Throw Exception;
            }
        }
    }
}
