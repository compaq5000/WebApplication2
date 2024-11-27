using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for Cat_TipoContacto_fortamun
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatTipoContactoFortamunController
    {
        // Preload our schema..
        CatTipoContactoFortamun thisSchemaLoad = new CatTipoContactoFortamun();
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
        public CatTipoContactoFortamunCollection FetchAll()
        {
            CatTipoContactoFortamunCollection coll = new CatTipoContactoFortamunCollection();
            Query qry = new Query(CatTipoContactoFortamun.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoContactoFortamunCollection FetchByID(object Id)
        {
            CatTipoContactoFortamunCollection coll = new CatTipoContactoFortamunCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoContactoFortamunCollection FetchByQuery(Query qry)
        {
            CatTipoContactoFortamunCollection coll = new CatTipoContactoFortamunCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatTipoContactoFortamun.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatTipoContactoFortamun.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status)
        {
            CatTipoContactoFortamun item = new CatTipoContactoFortamun();

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
            CatTipoContactoFortamun item = new CatTipoContactoFortamun();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
