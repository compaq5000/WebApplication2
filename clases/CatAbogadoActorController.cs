using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatAbogadoActor
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatAbogadoActorController
    {
        // Preload our schema..
        CatAbogadoActor thisSchemaLoad = new CatAbogadoActor();
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
        public CatAbogadoActorCollection FetchAll()
        {
            CatAbogadoActorCollection coll = new CatAbogadoActorCollection();
            Query qry = new Query(CatAbogadoActor.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAbogadoActorCollection FetchByID(object IDAbogadoActor)
        {
            CatAbogadoActorCollection coll = new CatAbogadoActorCollection().Where("IDAbogadoActor", IDAbogadoActor).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAbogadoActorCollection FetchByQuery(Query qry)
        {
            CatAbogadoActorCollection coll = new CatAbogadoActorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IDAbogadoActor)
        {
            return (CatAbogadoActor.Delete(IDAbogadoActor) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IDAbogadoActor)
        {
            return (CatAbogadoActor.Destroy(IDAbogadoActor) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status)
        {
            CatAbogadoActor item = new CatAbogadoActor();

            item.Descripcion = Descripcion;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(string Descripcion, int IDAbogadoActor, bool? Status)
        {
            CatAbogadoActor item = new CatAbogadoActor();
            item.MarkOld();
            item.IsLoaded = true;

            item.Descripcion = Descripcion;

            item.IDAbogadoActor = IDAbogadoActor;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
