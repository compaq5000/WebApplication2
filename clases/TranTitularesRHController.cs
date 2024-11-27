using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for TranTitularesRH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TranTitularesRHController
    {
        // Preload our schema..
        TranTitularesRH thisSchemaLoad = new TranTitularesRH();
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
        public TranTitularesRHCollection FetchAll()
        {
            TranTitularesRHCollection coll = new TranTitularesRHCollection();
            Query qry = new Query(TranTitularesRH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranTitularesRHCollection FetchByID(object Id)
        {
            TranTitularesRHCollection coll = new TranTitularesRHCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranTitularesRHCollection FetchByQuery(Query qry)
        {
            TranTitularesRHCollection coll = new TranTitularesRHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TranTitularesRH.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TranTitularesRH.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, int? IDStatusNombramiento, bool? Status, int? IDTitular)
        {
            TranTitularesRH item = new TranTitularesRH();

            item.Descripcion = Descripcion;

            item.IDStatusNombramiento = IDStatusNombramiento;

            item.Status = Status;

            item.IDTitular = IDTitular;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string Descripcion, int? IDStatusNombramiento, bool? Status, int? IDTitular)
        {
            TranTitularesRH item = new TranTitularesRH();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.IDStatusNombramiento = IDStatusNombramiento;

            item.Status = Status;

            item.IDTitular = IDTitular;

            item.Save(UserName);
        }
    }
}
