using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatTomos
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatTomoController
    {
        // Preload our schema..
        CatTomo thisSchemaLoad = new CatTomo();
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
        public CatTomoCollection FetchAll()
        {
            CatTomoCollection coll = new CatTomoCollection();
            Query qry = new Query(CatTomo.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTomoCollection FetchByID(object Descripcion)
        {
            CatTomoCollection coll = new CatTomoCollection().Where("descripcion", Descripcion).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTomoCollection FetchByQuery(Query qry)
        {
            CatTomoCollection coll = new CatTomoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Descripcion)
        {
            return (CatTomo.Delete(Descripcion) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Descripcion)
        {
            return (CatTomo.Destroy(Descripcion) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status)
        {
            CatTomo item = new CatTomo();

            item.Descripcion = Descripcion;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(string Descripcion, bool? Status, int Id)
        {
            CatTomo item = new CatTomo();
            item.MarkOld();
            item.IsLoaded = true;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Id = Id;

            item.Save(UserName);
        }
    }
}
