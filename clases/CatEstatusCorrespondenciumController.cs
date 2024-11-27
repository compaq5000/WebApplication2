using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatEstatusCorrespondencia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatEstatusCorrespondenciumController
    {
        // Preload our schema..
        CatEstatusCorrespondencium thisSchemaLoad = new CatEstatusCorrespondencium();
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
        public CatEstatusCorrespondenciumCollection FetchAll()
        {
            CatEstatusCorrespondenciumCollection coll = new CatEstatusCorrespondenciumCollection();
            Query qry = new Query(CatEstatusCorrespondencium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatEstatusCorrespondenciumCollection FetchByID(object Id)
        {
            CatEstatusCorrespondenciumCollection coll = new CatEstatusCorrespondenciumCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatEstatusCorrespondenciumCollection FetchByQuery(Query qry)
        {
            CatEstatusCorrespondenciumCollection coll = new CatEstatusCorrespondenciumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatEstatusCorrespondencium.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatEstatusCorrespondencium.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status)
        {
            CatEstatusCorrespondencium item = new CatEstatusCorrespondencium();

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
            CatEstatusCorrespondencium item = new CatEstatusCorrespondencium();
            item.MarkOld();
            item.IsLoaded = true;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Id = Id;

            item.Save(UserName);
        }
    }
}
