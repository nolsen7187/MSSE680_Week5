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
        public static bool custRequested = false, itemRequested, salesHeaderRequested, salesItemRequested, employeeRequested;

        public void InstantiateCallerRequested(XmlWriter localXmlWriter, string xmlFileName)
        {
            XmlReader xmlReader = XmlReader.Create(xmlFileName);
            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Customer")
                {
                    customer = Activator.CreateInstance<Customer>();
                    custRequested = true;
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Item")
                {
                    item = Activator.CreateInstance<Item>();
                    itemRequested = true;
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "SalesHeader")
                {
                    salesHeader = Activator.CreateInstance<SalesHeader>();
                    salesHeaderRequested = true;
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "SalesItem")
                {
                    salesItem = Activator.CreateInstance<SalesItem>();
                    salesItemRequested = true;
                    break;
                }
                if (xmlReader.NodeType == XmlNodeType.Element
                    && xmlReader.Name == "Employee")
                {
                    employee = Activator.CreateInstance<Employee>();
                    employeeRequested = true;
                    break;
                }
                //throw Exception("No Caller Requested found in XML");

            }
            xmlReader.Close();
        }
    }
}
