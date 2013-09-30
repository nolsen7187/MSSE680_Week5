using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Collections;
using System.Xml;

namespace BusinessLayerTest
{
    [TestClass]
    public class UnitTest3
    {

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
            xmlWriter.WriteElementString("CustomerId", "1");
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
    }
}
