using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using DAL;
using System.Collections;
using System.Xml;


//https://www.youtube.com/watch?v=WLjvNpP6yeQ
namespace BusinessLayer
{
    public class Facade
    {
        private InstatiateCallerRequested instatiateCallerRequested = new InstatiateCallerRequested();
        private HandleData handleData = new HandleData();
        private PerformAction performAction = new PerformAction();
        private string CallerRequested;
        private ArrayList DataList;
        private XmlWriter localXmlWriter;

        //public Facade(string CallerRequested, ArrayList DataList)
        public Facade(XmlWriter xmlWriter)
        {
            //this.CallerRequested = CallerRequested;
            //this.DataList = DataList;
            this.localXmlWriter = xmlWriter;
        }

        public void RegisterCustomer()
        {
            instatiateCallerRequested.InstantiateCallerRequested(localXmlWriter);
            handleData.setdata(localXmlWriter);
            performAction.Action(1);
        }
    }
}
