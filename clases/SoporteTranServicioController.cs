using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for Soporte_Tran_servicio
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class SoporteTranServicioController
    {
        // Preload our schema..
        SoporteTranServicio thisSchemaLoad = new SoporteTranServicio();
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
        public SoporteTranServicioCollection FetchAll()
        {
            SoporteTranServicioCollection coll = new SoporteTranServicioCollection();
            Query qry = new Query(SoporteTranServicio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SoporteTranServicioCollection FetchByID(object Id)
        {
            SoporteTranServicioCollection coll = new SoporteTranServicioCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SoporteTranServicioCollection FetchByQuery(Query qry)
        {
            SoporteTranServicioCollection coll = new SoporteTranServicioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (SoporteTranServicio.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (SoporteTranServicio.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, int? IDUser, DateTime? FechaAlta, DateTime? FechaAtencion, bool? Status, int? IDSoporte)
        {
            SoporteTranServicio item = new SoporteTranServicio();

            item.Descripcion = Descripcion;

            item.IDUser = IDUser;

            item.FechaAlta = FechaAlta;

            item.FechaAtencion = FechaAtencion;

            item.Status = Status;

            item.IDSoporte = IDSoporte;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string Descripcion, int? IDUser, DateTime? FechaAlta, DateTime? FechaAtencion, bool? Status, int? IDSoporte)
        {
            SoporteTranServicio item = new SoporteTranServicio();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.IDUser = IDUser;

            item.FechaAlta = FechaAlta;

            item.FechaAtencion = FechaAtencion;

            item.Status = Status;

            item.IDSoporte = IDSoporte;

            item.Save(UserName);
        }
    }
}
