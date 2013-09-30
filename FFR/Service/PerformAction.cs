using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using System.Data.Entity;
using DAL;
using System.Xml;

namespace Service
{
    public class PerformAction
    {
        private static Int16 actionType;

        public bool Action(XmlWriter localXmlWriter, string xmlFileName)
        {
            getActionType(localXmlWriter, xmlFileName);

            if (InstatiateCallerRequested.custRequested)
            {
                InstatiateCallerRequested.custRequested = false;//Initializing Value after run to prevent repeat for multiple unit tests
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Customer>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.customer);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.customer);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.customer);
                        break;
                    default:
                        break;
                }
            }
            else if (InstatiateCallerRequested.itemRequested)
            {
                InstatiateCallerRequested.itemRequested = false;//Initializing Value after run to prevent repeat for multiple unit tests
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Item>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.item);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.item);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.item);
                        break;
                    default:
                        break;
                }
            }
            else if (InstatiateCallerRequested.salesHeaderRequested)
            {
                InstatiateCallerRequested.salesHeaderRequested = false;//Initializing Value after run to prevent repeat for multiple unit tests
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesHeader>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.salesHeader);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.salesHeader);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.salesHeader);
                        break;
                    default:
                        break;
                }
            }
            else if (InstatiateCallerRequested.salesItemRequested)
            {
                InstatiateCallerRequested.salesItemRequested = false;//Initializing Value after run to prevent repeat for multiple unit tests
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesItem>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.salesItem);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.salesItem);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.salesItem);
                        break;
                    default:
                        break;
                }
            }
            else if (InstatiateCallerRequested.employeeRequested)
            {
                InstatiateCallerRequested.employeeRequested = false;//Initializing Value after run to prevent repeat for multiple unit tests
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Employee>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.employee);
                        break;
                    case 2://Update
                        Repo.Update(InstatiateCallerRequested.employee);
                        break;
                    case 3://Delete
                        Repo.Delete(InstatiateCallerRequested.employee);
                        break;
                    default:
                        break;
                }
            }
            return false; ;
        }
        public static void getActionType(XmlWriter localXmlWriter, string xmlFileName)
        {

            XmlReader xmlReader = XmlReader.Create(xmlFileName);

            while (xmlReader.Read())
            {
                if (xmlReader.Name == "ActionType" && xmlReader.Value != "\n" && xmlReader.NodeType != XmlNodeType.EndElement)
                {
                    xmlReader.Read();
                    actionType = Convert.ToInt16(xmlReader.Value);
                    break;
                }
            }
            xmlReader.Close();
        }
    }

}
