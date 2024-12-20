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
    /// Controller class for CatAcceso
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatAccesoController
    {
        // Preload our schema..
        CatAcceso thisSchemaLoad = new CatAcceso();
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
        public CatAccesoCollection FetchAll()
        {
            CatAccesoCollection coll = new CatAccesoCollection();
            Query qry = new Query(CatAcceso.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAccesoCollection FetchByID(object Id)
        {
            CatAccesoCollection coll = new CatAccesoCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAccesoCollection FetchByQuery(Query qry)
        {
            CatAccesoCollection coll = new CatAccesoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatAcceso.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatAcceso.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Id,string Descripcion,bool? Status)
	    {
		    CatAcceso item = new CatAcceso();
		    
            item.Id = Id;
            
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Id,string Descripcion,bool? Status)
	    {
		    CatAcceso item = new CatAcceso();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
