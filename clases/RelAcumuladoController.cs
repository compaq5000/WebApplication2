using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for RelAcumulado
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelAcumuladoController
    {
        // Preload our schema..
        RelAcumulado thisSchemaLoad = new RelAcumulado();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
                if (userName.Length == 0)
                {
                    if (System.Web.HttpContext.Current != null)
                    {
                        userName = System.Web.HttpContext.Current.User.Identity.Name;
                    }
                    else
                    {
                        userName = System.Threading.Thread.CurrentPrincipal.Identity.Name;
                    }
                }
                return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public RelAcumuladoCollection FetchAll()
        {
            RelAcumuladoCollection coll = new RelAcumuladoCollection();
            Query qry = new Query(RelAcumulado.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelAcumuladoCollection FetchByID(object Id)
        {
            RelAcumuladoCollection coll = new RelAcumuladoCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelAcumuladoCollection FetchByQuery(Query qry)
        {
            RelAcumuladoCollection coll = new RelAcumuladoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelAcumulado.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelAcumulado.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string IDAcumulado, bool? Status)
        {
            RelAcumulado item = new RelAcumulado();

            item.IDAcumulado = IDAcumulado;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(string IDAcumulado, bool? Status, int Id)
        {
            RelAcumulado item = new RelAcumulado();
            item.MarkOld();
            item.IsLoaded = true;

            item.IDAcumulado = IDAcumulado;

            item.Status = Status;

            item.Id = Id;

            item.Save(UserName);
        }
    }
}
