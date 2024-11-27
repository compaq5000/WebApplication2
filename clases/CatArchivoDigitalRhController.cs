using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatArchivoDigital_RH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatArchivoDigitalRhController
    {
        // Preload our schema..
        CatArchivoDigitalRh thisSchemaLoad = new CatArchivoDigitalRh();
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
        public CatArchivoDigitalRhCollection FetchAll()
        {
            CatArchivoDigitalRhCollection coll = new CatArchivoDigitalRhCollection();
            Query qry = new Query(CatArchivoDigitalRh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatArchivoDigitalRhCollection FetchByID(object Id)
        {
            CatArchivoDigitalRhCollection coll = new CatArchivoDigitalRhCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatArchivoDigitalRhCollection FetchByQuery(Query qry)
        {
            CatArchivoDigitalRhCollection coll = new CatArchivoDigitalRhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatArchivoDigitalRh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatArchivoDigitalRh.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status)
        {
            CatArchivoDigitalRh item = new CatArchivoDigitalRh();

            item.Descripcion = Descripcion;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string Descripcion, bool? Status)
        {
            CatArchivoDigitalRh item = new CatArchivoDigitalRh();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
