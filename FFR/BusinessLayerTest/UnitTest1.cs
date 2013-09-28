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
        public void RegisterNewCustomerUsingXML()
        {
            XmlWriterSettings xmlSetting = new XmlWriterSettings();
            xmlSetting.Indent = true;

            XmlWriter xmlWriter = XmlWriter.Create("Register.xml", xmlSetting);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteComment("This Xml is generated when a customer registers on FFR's site");
            xmlWriter.WriteStartElement("Customer");
            xmlWriter.WriteAttributeString("ActionType", "1");
            xmlWriter.WriteAttributeString("FirstName", "Nick");
            xmlWriter.WriteAttributeString("LastName", "Olsen");
            xmlWriter.WriteAttributeString("City", "Parker");
            xmlWriter.WriteAttributeString("State", "CO");
            xmlWriter.WriteAttributeString("Zip", "80134");
            xmlWriter.WriteAttributeString("Phone", "3037181335");
            xmlWriter.WriteAttributeString("Email", "nolsen@regis.edu");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.Flush();
            xmlWriter.Close();

            Facade newFacade = new Facade(xmlWriter);
           /* ArrayList dataList = new ArrayList();
            dataList.Add(1);
            dataList.Add("FirstName=Nick");
            dataList.Add("LastName=Olsen");
            dataList.Add("City=Parker");
            dataList.Add("State=CO");
            dataList.Add("Zip=80134");
            dataList.Add("Phone=3037181335");
            dataList.Add("Email=nolsen@regis.edu");*/


//            Facade newFacade = new Facade("Customer", dataList);

            newFacade.RegisterCustomer();
        }
    }
}
