using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Collections;
using System.Xml;

namespace BusinessLayerTest
{
    [TestClass]
    public class UnitTest1
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
            xmlWriter.WriteElementString("FirstName", "BusinessNick");
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
        }
        

    }
}
