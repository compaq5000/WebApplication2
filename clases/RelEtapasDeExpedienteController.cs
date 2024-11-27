using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for RelEtapasDeExpediente
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelEtapasDeExpedienteController
    {
        // Preload our schema..
        RelEtapasDeExpediente thisSchemaLoad = new RelEtapasDeExpediente();
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
        public RelEtapasDeExpedienteCollection FetchAll()
        {
            RelEtapasDeExpedienteCollection coll = new RelEtapasDeExpedienteCollection();
            Query qry = new Query(RelEtapasDeExpediente.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelEtapasDeExpedienteCollection FetchByID(object Id)
        {
            RelEtapasDeExpedienteCollection coll = new RelEtapasDeExpedienteCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelEtapasDeExpedienteCollection FetchByQuery(Query qry)
        {
            RelEtapasDeExpedienteCollection coll = new RelEtapasDeExpedienteCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelEtapasDeExpediente.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelEtapasDeExpediente.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int? IDTipoExpediente, string Descripcion)
        {
            RelEtapasDeExpediente item = new RelEtapasDeExpediente();

            item.IDTipoExpediente = IDTipoExpediente;

            item.Descripcion = Descripcion;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, int? IDTipoExpediente, string Descripcion)
        {
            RelEtapasDeExpediente item = new RelEtapasDeExpediente();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.IDTipoExpediente = IDTipoExpediente;

            item.Descripcion = Descripcion;

            item.Save(UserName);
        }
    }
}
