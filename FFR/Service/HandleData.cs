using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
using Service;
using System.Xml;
using System.Data.Entity;

namespace Service
{
    public class HandleData
    {
        public static Int16 actionType;

        public void setdata(XmlWriter localXmlWriter, string xmlFileName)
        {
            if (InstatiateCallerRequested.custRequested)
            {
                foreach (PropertyInfo propertyInfo in typeof(Customer).GetProperties())
                {
                    XmlReader xmlReader = XmlReader.Create(xmlFileName);

                    while (xmlReader.Read())
                    {
                        if (propertyInfo.Name == xmlReader.Name)
                        {
                            xmlReader.Read();
                            if (xmlReader.NodeType == XmlNodeType.Text
                                && xmlReader.NodeType != XmlNodeType.EndElement
                                && xmlReader.Value != "\n")
                            {
                                switch (propertyInfo.Name)
                                {
                                    case "CustomerId":
                                        InstatiateCallerRequested.customer.CustomerId = Convert.ToInt16(xmlReader.Value);
                                        break;
                                    case "FirstName":
                                        InstatiateCallerRequested.customer.FirstName = xmlReader.Value;
                                        break;
                                    case "LastName":
                                        InstatiateCallerRequested.customer.LastName = xmlReader.Value;
                                        break;
                                    case "Address":
                                        InstatiateCallerRequested.customer.Address = xmlReader.Value;
                                        break;
                                    case "City":
                                        InstatiateCallerRequested.customer.City = xmlReader.Value;
                                        break;
                                    case "State":
                                        InstatiateCallerRequested.customer.State = xmlReader.Value;
                                        break;
                                    case "Zip":
                                        InstatiateCallerRequested.customer.Zip = xmlReader.Value;
                                        break;
                                    case "Suite":
                                        InstatiateCallerRequested.customer.Suite = xmlReader.Value;
                                        break;
                                    case "Phone":
                                        InstatiateCallerRequested.customer.Phone = xmlReader.Value;
                                        break;
                                    case "Email":
                                        InstatiateCallerRequested.customer.Email = xmlReader.Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    xmlReader.Close();
                }
            }
            else if (InstatiateCallerRequested.itemRequested)
            {
                foreach (PropertyInfo propertyInfo in typeof(Item).GetProperties())
                {
                    XmlReader xmlReader = XmlReader.Create(xmlFileName);

                    while (xmlReader.Read())
                    {
                        //                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "FirstName")
                        if (propertyInfo.Name == xmlReader.Name)
                        {
                            xmlReader.Read();
                            if (xmlReader.NodeType == XmlNodeType.Text
                                && xmlReader.NodeType != XmlNodeType.EndElement
                                && xmlReader.Value != "\n")
                            {
                                switch (propertyInfo.Name)
                                {
                                    /*case "ItemId":
                                        InstatiateCallerRequested.item.ItemId = Convert.ToInt16(xmlReader.Value);
                                        break;*/
                                    case "ItemName":
                                        InstatiateCallerRequested.item.ItemName = xmlReader.Value;
                                        break;
                                    case "QuantityAvailable":
                                        InstatiateCallerRequested.item.QuantityAvailable = Convert.ToInt16(xmlReader.Value);
                                        break;
                                    case "ItemCost":
                                        InstatiateCallerRequested.item.ItemCost = Convert.ToDecimal(xmlReader.Value);
                                        break;
                                    case "Price":
                                        InstatiateCallerRequested.item.Price = Convert.ToDecimal(xmlReader.Value);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    xmlReader.Close();
                }
            }
            else if (InstatiateCallerRequested.salesHeaderRequested)
            {
                foreach (PropertyInfo propertyInfo in typeof(SalesHeader).GetProperties())
                {
                    XmlReader xmlReader = XmlReader.Create(xmlFileName);

                    while (xmlReader.Read())
                    {
                        if (propertyInfo.Name == xmlReader.Name)
                        {
                            xmlReader.Read();
                            if (xmlReader.NodeType == XmlNodeType.Text
                                && xmlReader.NodeType != XmlNodeType.EndElement
                                && xmlReader.Value != "\n")
                            {
                                switch (propertyInfo.Name)
                                {
                                    case "CustomerId":
                                        InstatiateCallerRequested.salesHeader.CustomerId = Convert.ToInt16(xmlReader.Value);
                                        break;
                                    case "OrderSalesBalance":
                                        InstatiateCallerRequested.salesHeader.OrderSalesBalance = Convert.ToDecimal(xmlReader.Value);
                                        break;
                                    case "OrderTaxAmount":
                                        InstatiateCallerRequested.salesHeader.OrderTaxAmount = Convert.ToDecimal(xmlReader.Value);
                                        break;
                                    case "OrderTotal":
                                        InstatiateCallerRequested.salesHeader.OrderTotal = Convert.ToDecimal(xmlReader.Value);
                                        break;
                                    case "SalesStatus":
                                        InstatiateCallerRequested.salesHeader.SalesStatus = xmlReader.Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    xmlReader.Close();
                }
            }
            else if (InstatiateCallerRequested.salesItemRequested)
            {
                foreach (PropertyInfo propertyInfo in typeof(SalesItem).GetProperties())
                {
                    XmlReader xmlReader = XmlReader.Create(xmlFileName);

                    while (xmlReader.Read())
                    {
                        if (propertyInfo.Name == xmlReader.Name)
                        {
                            xmlReader.Read();
                            if (xmlReader.NodeType == XmlNodeType.Text
                                && xmlReader.NodeType != XmlNodeType.EndElement
                                && xmlReader.Value != "\n")
                            {
                                switch (propertyInfo.Name)
                                {
                                    case "SalesId":
                                        InstatiateCallerRequested.salesItem.SalesId = Convert.ToInt16(xmlReader.Value);
                                        break;
                                    case "ItemId":
                                        InstatiateCallerRequested.salesItem.ItemId = Convert.ToInt16(xmlReader.Value);
                                        break;
                                    case "Qty":
                                        InstatiateCallerRequested.salesItem.Qty = Convert.ToInt16(xmlReader.Value);
                                        break;
                                    case "Price":
                                        InstatiateCallerRequested.salesItem.Price = Convert.ToDecimal(xmlReader.Value);
                                        break;
                                    case "LineAmount":
                                        InstatiateCallerRequested.salesItem.LineAmount = Convert.ToDecimal(xmlReader.Value);
                                        break;
                                    case "ItemName":
                                        InstatiateCallerRequested.salesItem.ItemName = xmlReader.Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    xmlReader.Close();
                }
            }
            else if (InstatiateCallerRequested.employeeRequested)
            {
                foreach (PropertyInfo propertyInfo in typeof(Employee).GetProperties())
                {
                    XmlReader xmlReader = XmlReader.Create(xmlFileName);

                    while (xmlReader.Read())
                    {
                        //                if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "FirstName")
                        if (propertyInfo.Name == xmlReader.Name)
                        {
                            xmlReader.Read();
                            if (xmlReader.NodeType == XmlNodeType.Text
                                && xmlReader.NodeType != XmlNodeType.EndElement
                                && xmlReader.Value != "\n")
                            {
                                switch (propertyInfo.Name)
                                {
                                    case "EmployeeId":
                                        InstatiateCallerRequested.employee.EmployeeId = Convert.ToInt16(xmlReader.Value);
                                        break;
                                    case "EmployeeFirstName":
                                        InstatiateCallerRequested.employee.EmployeeFirstName = xmlReader.Value;
                                        break;
                                    case "EmployeeLastName":
                                        InstatiateCallerRequested.employee.EmployeeLastName = xmlReader.Value;
                                        break;
                                    case "EmployeePhone":
                                        InstatiateCallerRequested.employee.EmployeePhone = xmlReader.Value;
                                        break;
                                    case "Employeetype":
                                        InstatiateCallerRequested.employee.Employeetype = xmlReader.Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                    xmlReader.Close();
                }
            }
        }
    }
}
/*
 *     public class Program
    {
        public static void Main()
        {
            XmlReader xmlReader = XmlReader.Create("Products.xml");

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
 * 
            //localArrayList = DataList;
            //foreach (PropertyInfo propertyInfo in typeof(Customer).GetProperties())
            /*foreach (string datafield in localArrayList)
            {
                Console.WriteLine(datafield);
                foreach (PropertyInfo propertyInfo in typeof(Customer).GetProperties())
                {
                    counter++;

                    Console.WriteLine(propertyInfo);
                }
                /*InstatiateCallerRequested.customer.FirstName = datafield;
                InstatiateCallerRequested.customer = datafield;
                InstatiateCallerRequested.customer.FirstName = datafield;
                InstatiateCallerRequested.customer.FirstName = datafield;
                InstatiateCallerRequested.customer.FirstName = datafield;
                InstatiateCallerRequested.customer.FirstName = datafield;
                InstatiateCallerRequested.customer.FirstName = datafield;
                

                dataList.Add("City=Parker");
                dataList.Add("State=CO");
                dataList.Add("Zip=80134");
                dataList.Add("Phone=3037181335");
                dataList.Add("Email=nolsen@regis.edu");
                //Console.WriteLine(datafield);
                //foreach (PropertyInfo propertyInfo in typeof(Customer).GetProperties())
                //                test = "test";
                //counter++;
            }
            //Console.WriteLine(test + counter.ToString());
            //Console.ReadLine();
            //return;
            //spin through list, look up field names and set fields in model to data passed in. For each field model in list set field in model object
        }
    }
}*/
