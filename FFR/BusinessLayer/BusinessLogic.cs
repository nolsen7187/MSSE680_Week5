using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using DAL;
using System.Collections;
//https://www.youtube.com/watch?v=WLjvNpP6yeQ
namespace BusinessLayer
{
    public class Facade
    {
        private InstatiateCallerRequested instatiateCallerRequested = new InstatiateCallerRequested();
        private HandleData handleData = new HandleData();
        private string CallerRequested;
        private ArrayList DataList;

        public Facade(string CallerRequested, ArrayList DataList)
        {
            this.CallerRequested = CallerRequested;
            this.DataList = DataList;
        }

        public void RegisterCustomer()
        {
            instatiateCallerRequested.InstantiateCallerRequested(CallerRequested);
            handleData.setdata(DataList);
        }
    }
}
