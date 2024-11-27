using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for CatOrigenCorrespondencia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatOrigenCorrespondenciumController
    {
        // Preload our schema..
        CatOrigenCorrespondencium thisSchemaLoad = new CatOrigenCorrespondencium();
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
        public CatOrigenCorrespondenciumCollection FetchAll()
        {
            CatOrigenCorrespondenciumCollection coll = new CatOrigenCorrespondenciumCollection();
            Query qry = new Query(CatOrigenCorrespondencium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatOrigenCorrespondenciumCollection FetchByID(object Id)
        {
            CatOrigenCorrespondenciumCollection coll = new CatOrigenCorrespondenciumCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatOrigenCorrespondenciumCollection FetchByQuery(Query qry)
        {
            CatOrigenCorrespondenciumCollection coll = new CatOrigenCorrespondenciumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatOrigenCorrespondencium.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatOrigenCorrespondencium.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool Status)
        {
            CatOrigenCorrespondencium item = new CatOrigenCorrespondencium();

            item.Descripcion = Descripcion;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string Descripcion, bool Status)
        {
            CatOrigenCorrespondencium item = new CatOrigenCorrespondencium();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
