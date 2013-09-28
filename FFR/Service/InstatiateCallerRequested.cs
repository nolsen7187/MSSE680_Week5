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

            /*switch (xmlReader.Name)
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
                    //return;
            //}
        }
    }
    public class Program
    {
        public static void Main()
        {
            XmlReader reader = XmlReader.Create("Products.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                && reader.Name == "Product")
                {
                    Console.WriteLine("ID = " + reader.GetAttribute(0));
                    Console.WriteLine("Name = " + reader.GetAttribute(1));

                    while (reader.NodeType != XmlNodeType.EndElement)
                    {
                        reader.Read();
                        if (reader.Name == "Price")
                        {
                            while (reader.NodeType != XmlNodeType.EndElement)
                            {
                                reader.Read();
                                if (reader.NodeType == XmlNodeType.Text)
                                {
                                    Console.WriteLine("Price = {0:C}", Double.Parse(reader.Value));
                                }
                            }

                            reader.Read();

                        } //end if

                        if (reader.Name == "OtherDetails")
                        {
                            while (reader.NodeType != XmlNodeType.EndElement)
                            {
                                reader.Read();
                                if (reader.Name == "BrandName")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                        {
                                            Console.WriteLine("Brand Name = " + reader.Value);
                                        }
                                    }
                                    reader.Read();
                                } //end if

                                if (reader.Name == "Manufacturer")
                                {
                                    while (reader.NodeType != XmlNodeType.EndElement)
                                    {
                                        reader.Read();
                                        if (reader.NodeType == XmlNodeType.Text)
                                        {
                                            Console.WriteLine("Manufacturer = " + reader.Value);
                                        }
                                    }

                                } //end if
                            }
                        } //end if
                    } //end while
                } //end if

            } //end while
        }
    }

}
