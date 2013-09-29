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

namespace Service
{
    public class HandleData
    {
        //private static string test, passedinstring;
       // private static Int16 counter;
        //private static string fieldName;
        //private static string fieldValue;
        //private static ArrayList localArrayList;
        //private static object obj;

        //XmlElement elementXMl = XmlElement.Load(@

        
//        public void setdata(ArrayList DataList)
        public void setdata(XmlWriter localXmlWriter)
        {
            foreach (PropertyInfo propertyInfo in typeof(Customer).GetProperties())
            {
                XmlReader xmlReader = XmlReader.Create("Register.xml");

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
