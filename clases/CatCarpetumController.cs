using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatCarpeta
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatCarpetumController
    {
        // Preload our schema..
        CatCarpetum thisSchemaLoad = new CatCarpetum();
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
        public CatCarpetumCollection FetchAll()
        {
            CatCarpetumCollection coll = new CatCarpetumCollection();
            Query qry = new Query(CatCarpetum.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatCarpetumCollection FetchByID(object Id)
        {
            CatCarpetumCollection coll = new CatCarpetumCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatCarpetumCollection FetchByQuery(Query qry)
        {
            CatCarpetumCollection coll = new CatCarpetumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatCarpetum.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatCarpetum.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int? Iddepende, string Descripcion, bool? Status)
        {
            CatCarpetum item = new CatCarpetum();

            item.Iddepende = Iddepende;

            item.Descripcion = Descripcion;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, int? Iddepende, string Descripcion, bool? Status)
        {
            CatCarpetum item = new CatCarpetum();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Iddepende = Iddepende;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
