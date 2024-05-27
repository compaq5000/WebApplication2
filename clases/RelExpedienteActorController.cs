using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
namespace SubSonicDB
{
    /// <summary>
    /// Controller class for relExpedienteActor
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelExpedienteActorController
    {
        // Preload our schema..
        RelExpedienteActor thisSchemaLoad = new RelExpedienteActor();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public RelExpedienteActorCollection FetchAll()
        {
            RelExpedienteActorCollection coll = new RelExpedienteActorCollection();
            Query qry = new Query(RelExpedienteActor.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelExpedienteActorCollection FetchByID(object Id)
        {
            RelExpedienteActorCollection coll = new RelExpedienteActorCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelExpedienteActorCollection FetchByQuery(Query qry)
        {
            RelExpedienteActorCollection coll = new RelExpedienteActorCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelExpedienteActor.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelExpedienteActor.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IDAbogado,bool? Status)
	    {
		    RelExpedienteActor item = new RelExpedienteActor();
		    
            item.IDAbogado = IDAbogado;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? IDAbogado,bool? Status)
	    {
		    RelExpedienteActor item = new RelExpedienteActor();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDAbogado = IDAbogado;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
