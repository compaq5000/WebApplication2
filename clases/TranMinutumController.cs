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
    /// Controller class for TranMinuta
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TranMinutumController
    {
        // Preload our schema..
        TranMinutum thisSchemaLoad = new TranMinutum();
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
        public TranMinutumCollection FetchAll()
        {
            TranMinutumCollection coll = new TranMinutumCollection();
            Query qry = new Query(TranMinutum.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranMinutumCollection FetchByID(object Id)
        {
            TranMinutumCollection coll = new TranMinutumCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TranMinutumCollection FetchByQuery(Query qry)
        {
            TranMinutumCollection coll = new TranMinutumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TranMinutum.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TranMinutum.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IDUser,bool? Staus,string Folio,string Para,string En,string Asunto,string Contenido,int? StatusMinuta,int? IDExpediente)
	    {
		    TranMinutum item = new TranMinutum();
		    
            item.IDUser = IDUser;
            
            item.Staus = Staus;
            
            item.Folio = Folio;
            
            item.Para = Para;
            
            item.En = En;
            
            item.Asunto = Asunto;
            
            item.Contenido = Contenido;
            
            item.StatusMinuta = StatusMinuta;
            
            item.IDExpediente = IDExpediente;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? IDUser,bool? Staus,string Folio,string Para,string En,string Asunto,string Contenido,int? StatusMinuta,int? IDExpediente)
	    {
		    TranMinutum item = new TranMinutum();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDUser = IDUser;
				
			item.Staus = Staus;
				
			item.Folio = Folio;
				
			item.Para = Para;
				
			item.En = En;
				
			item.Asunto = Asunto;
				
			item.Contenido = Contenido;
				
			item.StatusMinuta = StatusMinuta;
				
			item.IDExpediente = IDExpediente;
				
	        item.Save(UserName);
	    }
    }
}
