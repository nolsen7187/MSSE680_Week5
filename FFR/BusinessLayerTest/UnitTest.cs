using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Collections;
using System.Xml;

namespace BusinessLayerTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void BusinessLayerRegisterNewCustomerUsingXML()
        {
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;

            string xmlFileName = "CustomerTest.xml";
            XmlWriter xmlWriter = XmlWriter.Create(xmlFileName, xmlSetting);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This Xml is generated when a customer registers on FFR's site");
            xmlWriter.WriteStartElement("Customer");
            xmlWriter.WriteElementString("ObjectType", "Customer");
            xmlWriter.WriteElementString("ActionType", "1");
            xmlWriter.WriteElementString("FirstName", "Business Nick");
            xmlWriter.WriteElementString("LastName", "Olsen");
            xmlWriter.WriteElementString("City", "Parker");
            xmlWriter.WriteElementString("State", "CO");
            xmlWriter.WriteElementString("Zip", "80134");
            xmlWriter.WriteElementString("Phone", "3037181335");
            xmlWriter.WriteElementString("Email", "nolsen@regis.edu");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();

            Facade newFacade = new Facade(xmlWriter, xmlFileName);
            newFacade.RegisterCustomer();
            xmlWriter.Dispose();
            xmlFileName = "";
        }
        [TestMethod]
        public void BusinessLayerCreateItemUsingXML()
        {
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;

            string xmlFileName = "ItemTest.xml";
            XmlWriter xmlWriter = XmlWriter.Create(xmlFileName, xmlSetting);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This Xml is generated when a new Item is added on FFR's site");
            xmlWriter.WriteStartElement("Item");
            xmlWriter.WriteElementString("ObjectType", "Item");
            xmlWriter.WriteElementString("ActionType", "1");
            xmlWriter.WriteElementString("ItemName", "Business FP Green Turbo");
            xmlWriter.WriteElementString("QuantityAvailable", "10");
            xmlWriter.WriteElementString("ItemCost", "10.00");
            xmlWriter.WriteElementString("Price", "20.00");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();

            Facade newFacade = new Facade(xmlWriter, xmlFileName);
            newFacade.RegisterCustomer();
        }
        [TestMethod]
        public void BusinessLayerCreateSalesHeaderUsingXML()
        {
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;

            string xmlFileName = "SalesHeaderTest.xml";
            XmlWriter xmlWriter = XmlWriter.Create(xmlFileName, xmlSetting);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This Xml is generated when a new sales order is added on FFR's site");
            xmlWriter.WriteStartElement("SalesHeader");
            xmlWriter.WriteElementString("ObjectType", "SalesHeader");
            xmlWriter.WriteElementString("ActionType", "1");
            //xmlWriter.WriteElementString("CustomerId", "1");
            xmlWriter.WriteElementString("OrderSalesBalance", "20.00");
            xmlWriter.WriteElementString("OrderTaxAmount", "5.00");
            xmlWriter.WriteElementString("OrderTotal", "25.00");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();

            Facade newFacade = new Facade(xmlWriter, xmlFileName);
            newFacade.RegisterCustomer();
        }
        [TestMethod]
        public void BusinessLayerCreateSalesItemUsingXML()
        {
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;

            string xmlFileName = "SalesItemTest.xml";
            XmlWriter xmlWriter = XmlWriter.Create(xmlFileName, xmlSetting);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This Xml is generated when a new Item is added on FFR's site");
            xmlWriter.WriteStartElement("SalesItem");
            xmlWriter.WriteElementString("ObjectType", "SalesItem");
            xmlWriter.WriteElementString("ActionType", "1");
            xmlWriter.WriteElementString("SalesId", "1");
            xmlWriter.WriteElementString("ItemId", "1");
            xmlWriter.WriteElementString("ItemName", "Business FP Green Turbo");
            xmlWriter.WriteElementString("Qty", "1");
            xmlWriter.WriteElementString("LineAmount", "20.00");
            xmlWriter.WriteElementString("Price", "20.00");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();

            Facade newFacade = new Facade(xmlWriter, xmlFileName);
            newFacade.RegisterCustomer();
        }
        [TestMethod]
        public void BusinessLayerRegisterNewEmployeeUsingXML()
        {
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;

            string xmlFileName = "EmployeeTest.xml";
            XmlWriter xmlWriter = XmlWriter.Create(xmlFileName, xmlSetting);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This Xml is generated when a new Employee registers on FFR's site");
            xmlWriter.WriteStartElement("Employee");
            xmlWriter.WriteElementString("ObjectType", "Employee");
            xmlWriter.WriteElementString("ActionType", "1");
            xmlWriter.WriteElementString("EmployeeFirstName", "BusinessNick");
            xmlWriter.WriteElementString("EmployeeLastName", "Olsen");
            xmlWriter.WriteElementString("EmployeePhone", "3037181335");
            xmlWriter.WriteElementString("Employeetype", "Jedi");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();

            Facade newFacade = new Facade(xmlWriter, xmlFileName);
            newFacade.RegisterCustomer();
        }

    }
}
