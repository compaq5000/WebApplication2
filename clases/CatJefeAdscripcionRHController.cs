using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatJefeAdscripcionRH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatJefeAdscripcionRHController
    {
        // Preload our schema..
        CatJefeAdscripcionRH thisSchemaLoad = new CatJefeAdscripcionRH();
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
        public CatJefeAdscripcionRHCollection FetchAll()
        {
            CatJefeAdscripcionRHCollection coll = new CatJefeAdscripcionRHCollection();
            Query qry = new Query(CatJefeAdscripcionRH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatJefeAdscripcionRHCollection FetchByID(object Id)
        {
            CatJefeAdscripcionRHCollection coll = new CatJefeAdscripcionRHCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatJefeAdscripcionRHCollection FetchByQuery(Query qry)
        {
            CatJefeAdscripcionRHCollection coll = new CatJefeAdscripcionRHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatJefeAdscripcionRH.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatJefeAdscripcionRH.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int? IDAdscripcion, string Descripcion, bool? Status)
        {
            CatJefeAdscripcionRH item = new CatJefeAdscripcionRH();

            item.IDAdscripcion = IDAdscripcion;

            item.Descripcion = Descripcion;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, int? IDAdscripcion, string Descripcion, bool? Status)
        {
            CatJefeAdscripcionRH item = new CatJefeAdscripcionRH();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.IDAdscripcion = IDAdscripcion;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
