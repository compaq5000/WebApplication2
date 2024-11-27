using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for TRAN__PERMISOS
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TranPermisoController
    {
        // Preload our schema..
        TranPermiso thisSchemaLoad = new TranPermiso();
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
        public TranPermisoCollection FetchAll()
        {
            TranPermisoCollection coll = new TranPermisoCollection();
            Query qry = new Query(TranPermiso.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranPermisoCollection FetchByID(object Id)
        {
            TranPermisoCollection coll = new TranPermisoCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranPermisoCollection FetchByQuery(Query qry)
        {
            TranPermisoCollection coll = new TranPermisoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TranPermiso.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TranPermiso.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int? IDExpediente, string IDPermiso, int? IDUser, bool? Status)
        {
            TranPermiso item = new TranPermiso();

            item.IDExpediente = IDExpediente;

            item.IDPermiso = IDPermiso;

            item.IDUser = IDUser;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, int? IDExpediente, string IDPermiso, int? IDUser, bool? Status)
        {
            TranPermiso item = new TranPermiso();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.IDExpediente = IDExpediente;

            item.IDPermiso = IDPermiso;

            item.IDUser = IDUser;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
