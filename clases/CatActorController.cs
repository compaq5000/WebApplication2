using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatActor
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatActorController
    {
        // Preload our schema..
        CatActor thisSchemaLoad = new CatActor();
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
        public CatActorCollection FetchAll()
        {
            CatActorCollection coll = new CatActorCollection();
            Query qry = new Query(CatActor.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatActorCollection FetchByID(object IDActor)
        {
            CatActorCollection coll = new CatActorCollection().Where("IDActor", IDActor).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatActorCollection FetchByQuery(Query qry)
        {
            CatActorCollection coll = new CatActorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IDActor)
        {
            return (CatActor.Delete(IDActor) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IDActor)
        {
            return (CatActor.Destroy(IDActor) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status)
        {
            CatActor item = new CatActor();

            item.Descripcion = Descripcion;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(string Descripcion, int IDActor, bool? Status)
        {
            CatActor item = new CatActor();
            item.MarkOld();
            item.IsLoaded = true;

            item.Descripcion = Descripcion;

            item.IDActor = IDActor;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
