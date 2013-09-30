using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using System.Collections;
using System.Xml;

namespace BusinessLayer
{
    public class Facade
    {
        private InstatiateCallerRequested instatiateCallerRequested = new InstatiateCallerRequested();
        private HandleData handleData = new HandleData();
        private PerformAction performAction = new PerformAction();
        //private string CallerRequested;
        //private ArrayList DataList;
        private XmlWriter localXmlWriter;
        private string localxmlFileName = "";

        //public Facade(string CallerRequested, ArrayList DataList)
        public Facade(XmlWriter xmlWriter, string xmlFileName)
        {
            //this.CallerRequested = CallerRequested;
            //this.DataList = DataList;
            this.localXmlWriter = xmlWriter;
            this.localxmlFileName = xmlFileName;
        }

        public void RegisterCustomer()
        {
            instatiateCallerRequested.InstantiateCallerRequested(localXmlWriter, localxmlFileName);
            handleData.setdata(localXmlWriter, localxmlFileName);
            performAction.Action(localXmlWriter, localxmlFileName);

            this.localXmlWriter.Dispose();
            this.localxmlFileName = "";
                
        }
    }
}
