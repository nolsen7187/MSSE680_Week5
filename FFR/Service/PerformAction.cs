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
        //public CRUDRepositoryConcreteFactory cruddy = new CRUDRepositoryConcreteFactory();
        public bool Action(XmlWriter localXmlWriter )
        {
        getActionType(localXmlWriter);

            if (InstatiateCallerRequested.custRequested)
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Customer>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.customer);// = new DataRepository<Customer>();
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
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Item>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.item);// = new DataRepository<Customer>();
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
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesHeader>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.salesHeader);// = new DataRepository<Customer>();
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
            else if (InstatiateCallerRequested.itemRequested)
            {
                var Repo = CRUDRepositoryConcreteFactory.CRUD<SalesItem>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.salesItem);// = new DataRepository<Customer>();
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
                var Repo = CRUDRepositoryConcreteFactory.CRUD<Employee>();
                switch (actionType)
                {
                    case 1://Create
                        Repo.Create(InstatiateCallerRequested.employee);// = new DataRepository<Customer>();
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
            return;
        }
        public static void getActionType(XmlWriter localXmlWriter)
        {

        XmlReader xmlReader = XmlReader.Create("Register.xml");

            while (xmlReader.Read())
            {
                if (xmlReader.Name == "ActionType" && xmlReader.Value != "\n" && xmlReader.NodeType != XmlNodeType.EndElement)
                {
                    xmlReader.Read();
                    actionType = Convert.ToInt16(xmlReader.Value);
                    break;
                }
            }
        }
    }

}
