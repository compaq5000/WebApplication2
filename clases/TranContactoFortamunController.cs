using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for Tran_Contacto_fortamun
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TranContactoFortamunController
    {
        // Preload our schema..
        TranContactoFortamun thisSchemaLoad = new TranContactoFortamun();
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
        public TranContactoFortamunCollection FetchAll()
        {
            TranContactoFortamunCollection coll = new TranContactoFortamunCollection();
            Query qry = new Query(TranContactoFortamun.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranContactoFortamunCollection FetchByID(object Id)
        {
            TranContactoFortamunCollection coll = new TranContactoFortamunCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranContactoFortamunCollection FetchByQuery(Query qry)
        {
            TranContactoFortamunCollection coll = new TranContactoFortamunCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TranContactoFortamun.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TranContactoFortamun.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(string Descripcion, bool? Status, int? IDMunicipio, string Email, string Movil, string OtroTel, int? IDTipoContacto)
        {
            TranContactoFortamun item = new TranContactoFortamun();

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.IDMunicipio = IDMunicipio;

            item.Email = Email;

            item.Movil = Movil;

            item.OtroTel = OtroTel;

            item.IDTipoContacto = IDTipoContacto;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, string Descripcion, bool? Status, int? IDMunicipio, string Email, string Movil, string OtroTel, int? IDTipoContacto)
        {
            TranContactoFortamun item = new TranContactoFortamun();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.Descripcion = Descripcion;

            item.Status = Status;

            item.IDMunicipio = IDMunicipio;

            item.Email = Email;

            item.Movil = Movil;

            item.OtroTel = OtroTel;

            item.IDTipoContacto = IDTipoContacto;

            item.Save(UserName);
        }
    }
}
