using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatTipoPermisoRH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatTipoPermisoRHController
    {
        // Preload our schema..
        CatTipoPermisoRH thisSchemaLoad = new CatTipoPermisoRH();
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
        public CatTipoPermisoRHCollection FetchAll()
        {
            CatTipoPermisoRHCollection coll = new CatTipoPermisoRHCollection();
            Query qry = new Query(CatTipoPermisoRH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoPermisoRHCollection FetchByID(object Id)
        {
            CatTipoPermisoRHCollection coll = new CatTipoPermisoRHCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoPermisoRHCollection FetchByQuery(Query qry)
        {
            CatTipoPermisoRHCollection coll = new CatTipoPermisoRHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatTipoPermisoRH.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatTipoPermisoRH.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status)
        {
            CatTipoPermisoRH item = new CatTipoPermisoRH();

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
            CatTipoPermisoRH item = new CatTipoPermisoRH();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
