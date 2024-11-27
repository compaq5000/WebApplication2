using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatTipoPlaza_RH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatTipoPlazaRhController
    {
        // Preload our schema..
        CatTipoPlazaRh thisSchemaLoad = new CatTipoPlazaRh();
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
        public CatTipoPlazaRhCollection FetchAll()
        {
            CatTipoPlazaRhCollection coll = new CatTipoPlazaRhCollection();
            Query qry = new Query(CatTipoPlazaRh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoPlazaRhCollection FetchByID(object Id)
        {
            CatTipoPlazaRhCollection coll = new CatTipoPlazaRhCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoPlazaRhCollection FetchByQuery(Query qry)
        {
            CatTipoPlazaRhCollection coll = new CatTipoPlazaRhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatTipoPlazaRh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatTipoPlazaRh.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion)
        {
            CatTipoPlazaRh item = new CatTipoPlazaRh();

            item.Descripcion = Descripcion;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string Descripcion)
        {
            CatTipoPlazaRh item = new CatTipoPlazaRh();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.Save(UserName);
        }
    }
}
