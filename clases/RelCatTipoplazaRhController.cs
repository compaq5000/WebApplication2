using SubSonic;
using System;
using System.ComponentModel;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for RelCatTipoplaza_RH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelCatTipoplazaRhController
    {
        // Preload our schema..
        RelCatTipoplazaRh thisSchemaLoad = new RelCatTipoplazaRh();
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
        public RelCatTipoplazaRhCollection FetchAll()
        {
            RelCatTipoplazaRhCollection coll = new RelCatTipoplazaRhCollection();
            Query qry = new Query(RelCatTipoplazaRh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatTipoplazaRhCollection FetchByID(object Id)
        {
            RelCatTipoplazaRhCollection coll = new RelCatTipoplazaRhCollection().Where("ID", Id).Load();
            return coll;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatTipoplazaRhCollection FetchByQuery(Query qry)
        {
            RelCatTipoplazaRhCollection coll = new RelCatTipoplazaRhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelCatTipoplazaRh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelCatTipoplazaRh.Destroy(Id) == 1);
        }



        /// <summary>
        /// Inserts a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void Insert(int? IDTipoPlaza, int? IDUsuario, bool? Status)
        {
            RelCatTipoplazaRh item = new RelCatTipoplazaRh();

            item.IDTipoPlaza = IDTipoPlaza;

            item.IDUsuario = IDUsuario;

            item.Status = Status;


            item.Save(UserName);
        }

        /// <summary>
        /// Updates a record, can be used with the Object Data Source
        /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void Update(int Id, int? IDTipoPlaza, int? IDUsuario, bool? Status)
        {
            RelCatTipoplazaRh item = new RelCatTipoplazaRh();
            item.MarkOld();
            item.IsLoaded = true;

            item.Id = Id;

            item.IDTipoPlaza = IDTipoPlaza;

            item.IDUsuario = IDUsuario;

            item.Status = Status;

            item.Save(UserName);
        }
    }
}
