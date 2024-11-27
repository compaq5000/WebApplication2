using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for ArchivoCorrespondencia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ArchivoCorrespondenciumController
    {
        // Preload our schema..
        ArchivoCorrespondencium thisSchemaLoad = new ArchivoCorrespondencium();
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
        public ArchivoCorrespondenciumCollection FetchAll()
        {
            ArchivoCorrespondenciumCollection coll = new ArchivoCorrespondenciumCollection();
            Query qry = new Query(ArchivoCorrespondencium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ArchivoCorrespondenciumCollection FetchByID(object Id)
        {
            ArchivoCorrespondenciumCollection coll = new ArchivoCorrespondenciumCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ArchivoCorrespondenciumCollection FetchByQuery(Query qry)
        {
            ArchivoCorrespondenciumCollection coll = new ArchivoCorrespondenciumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (ArchivoCorrespondencium.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (ArchivoCorrespondencium.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Nombre, string Extencion, bool? Status, int? IDExpediente, DateTime? DateX, int? IDTipo, string Descripcion, int? IDUserCarga, bool? StatusCorresponde, int? IDInventario)
        {
            ArchivoCorrespondencium item = new ArchivoCorrespondencium();

            item.Nombre = Nombre;

            item.Extencion = Extencion;

            item.Status = Status;

            item.IDExpediente = IDExpediente;

            item.DateX = DateX;

            item.IDTipo = IDTipo;

            item.Descripcion = Descripcion;

            item.IDUserCarga = IDUserCarga;

            item.StatusCorresponde = StatusCorresponde;

            item.IDInventario = IDInventario;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(string Nombre, string Extencion, bool? Status, int? IDExpediente, DateTime? DateX, int? IDTipo, string Descripcion, int? IDUserCarga, bool? StatusCorresponde, int Id, int? IDInventario)
        {
            ArchivoCorrespondencium item = new ArchivoCorrespondencium();
            item.MarkOld();
            item.IsLoaded = true;

            item.Nombre = Nombre;

            item.Extencion = Extencion;

            item.Status = Status;

            item.IDExpediente = IDExpediente;

            item.DateX = DateX;

            item.IDTipo = IDTipo;

            item.Descripcion = Descripcion;

            item.IDUserCarga = IDUserCarga;

            item.StatusCorresponde = StatusCorresponde;

            item.Id = Id;

            item.IDInventario = IDInventario;

            item.Save(UserName);
        }
    }
}
