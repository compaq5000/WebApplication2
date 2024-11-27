using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for Historialnavegacion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class HistorialnavegacionController
    {
        // Preload our schema..
        Historialnavegacion thisSchemaLoad = new Historialnavegacion();
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
        public HistorialnavegacionCollection FetchAll()
        {
            HistorialnavegacionCollection coll = new HistorialnavegacionCollection();
            Query qry = new Query(Historialnavegacion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HistorialnavegacionCollection FetchByID(object Id)
        {
            HistorialnavegacionCollection coll = new HistorialnavegacionCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public HistorialnavegacionCollection FetchByQuery(Query qry)
        {
            HistorialnavegacionCollection coll = new HistorialnavegacionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (Historialnavegacion.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (Historialnavegacion.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int? IDUsuario, int? IDCarpeta, bool? Status)
        {
            Historialnavegacion item = new Historialnavegacion();

            item.IDUsuario = IDUsuario;

            item.IDCarpeta = IDCarpeta;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int? IDUsuario, int? IDCarpeta, int Id, bool? Status)
        {
            Historialnavegacion item = new Historialnavegacion();
            item.MarkOld();
            item.IsLoaded = true;

            item.IDUsuario = IDUsuario;

            item.IDCarpeta = IDCarpeta;

            item.Id = Id;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
