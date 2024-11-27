using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for TempExpedientes
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TempExpedienteController
    {
        // Preload our schema..
        TempExpediente thisSchemaLoad = new TempExpediente();
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
        public TempExpedienteCollection FetchAll()
        {
            TempExpedienteCollection coll = new TempExpedienteCollection();
            Query qry = new Query(TempExpediente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TempExpedienteCollection FetchByID(object Id)
        {
            TempExpedienteCollection coll = new TempExpedienteCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TempExpedienteCollection FetchByQuery(Query qry)
        {
            TempExpedienteCollection coll = new TempExpedienteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TempExpediente.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TempExpediente.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Idcarpeta, string Ruta, string NombreExpe, string NoEXPEDIENTE, int? Idactor, string Nombredelactor, int? Idabogado, string Abogadodelactor, int? Iddemandado, string Demandado, int? Idautoridadconocecaso, string Autoridadconocecaso, string Causamotivajuicio, int? Idtipojuicio, string Tipojuicio, string Etapa, string Dependencia, string Fecha, string Observaciones, string Monto)
        {
            TempExpediente item = new TempExpediente();

            item.Idcarpeta = Idcarpeta;

            item.Ruta = Ruta;

            item.NombreExpe = NombreExpe;

            item.NoEXPEDIENTE = NoEXPEDIENTE;

            item.Idactor = Idactor;

            item.Nombredelactor = Nombredelactor;

            item.Idabogado = Idabogado;

            item.Abogadodelactor = Abogadodelactor;

            item.Iddemandado = Iddemandado;

            item.Demandado = Demandado;

            item.Idautoridadconocecaso = Idautoridadconocecaso;

            item.Autoridadconocecaso = Autoridadconocecaso;

            item.Causamotivajuicio = Causamotivajuicio;

            item.Idtipojuicio = Idtipojuicio;

            item.Tipojuicio = Tipojuicio;

            item.Etapa = Etapa;

            item.Dependencia = Dependencia;

            item.Fecha = Fecha;

            item.Observaciones = Observaciones;

            item.Monto = Monto;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(string Idcarpeta, string Ruta, string NombreExpe, string NoEXPEDIENTE, int? Idactor, string Nombredelactor, int? Idabogado, string Abogadodelactor, int? Iddemandado, string Demandado, int? Idautoridadconocecaso, string Autoridadconocecaso, string Causamotivajuicio, int? Idtipojuicio, string Tipojuicio, string Etapa, string Dependencia, string Fecha, string Observaciones, string Monto, int Id)
        {
            TempExpediente item = new TempExpediente();
            item.MarkOld();
            item.IsLoaded = true;

            item.Idcarpeta = Idcarpeta;

            item.Ruta = Ruta;

            item.NombreExpe = NombreExpe;

            item.NoEXPEDIENTE = NoEXPEDIENTE;

            item.Idactor = Idactor;

            item.Nombredelactor = Nombredelactor;

            item.Idabogado = Idabogado;

            item.Abogadodelactor = Abogadodelactor;

            item.Iddemandado = Iddemandado;

            item.Demandado = Demandado;

            item.Idautoridadconocecaso = Idautoridadconocecaso;

            item.Autoridadconocecaso = Autoridadconocecaso;

            item.Causamotivajuicio = Causamotivajuicio;

            item.Idtipojuicio = Idtipojuicio;

            item.Tipojuicio = Tipojuicio;

            item.Etapa = Etapa;

            item.Dependencia = Dependencia;

            item.Fecha = Fecha;

            item.Observaciones = Observaciones;

            item.Monto = Monto;

            item.Id = Id;

            item.Save(UserName);
        }
    }
}
