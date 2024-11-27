using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for TemTipojuicio
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TemTipojuicioController
    {
        // Preload our schema..
        TemTipojuicio thisSchemaLoad = new TemTipojuicio();
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
        public TemTipojuicioCollection FetchAll()
        {
            TemTipojuicioCollection coll = new TemTipojuicioCollection();
            Query qry = new Query(TemTipojuicio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemTipojuicioCollection FetchByID(object IDTipoJuicio)
        {
            TemTipojuicioCollection coll = new TemTipojuicioCollection().Where("IDTipoJuicio", IDTipoJuicio).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemTipojuicioCollection FetchByQuery(Query qry)
        {
            TemTipojuicioCollection coll = new TemTipojuicioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IDTipoJuicio)
        {
            return (TemTipojuicio.Delete(IDTipoJuicio) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IDTipoJuicio)
        {
            return (TemTipojuicio.Destroy(IDTipoJuicio) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion)
        {
            TemTipojuicio item = new TemTipojuicio();

            item.Descripcion = Descripcion;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int IDTipoJuicio, string Descripcion)
        {
            TemTipojuicio item = new TemTipojuicio();
            item.MarkOld();
            item.IsLoaded = true;

            item.IDTipoJuicio = IDTipoJuicio;

            item.Descripcion = Descripcion;

            item.Save(UserName);
        }
    }
}
