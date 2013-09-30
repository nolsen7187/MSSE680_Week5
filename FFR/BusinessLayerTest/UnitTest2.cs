using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Collections;
using System.Xml;

namespace BusinessLayerTest
{
    [TestClass]
    public class UnitTest2
    {
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
            xmlWriter.WriteElementString("ObjectType", "BusinessItem");
            xmlWriter.WriteElementString("ActionType", "1");
            xmlWriter.WriteElementString("ItemName", "FP Green Turbo");
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
        
    }
}
