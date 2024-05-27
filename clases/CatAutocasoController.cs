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
    /// Controller class for CatAutocaso
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatAutocasoController
    {
        // Preload our schema..
        CatAutocaso thisSchemaLoad = new CatAutocaso();
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
        public CatAutocasoCollection FetchAll()
        {
            CatAutocasoCollection coll = new CatAutocasoCollection();
            Query qry = new Query(CatAutocaso.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAutocasoCollection FetchByID(object IDAutocaso)
        {
            CatAutocasoCollection coll = new CatAutocasoCollection().Where("IDAutocaso", IDAutocaso).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAutocasoCollection FetchByQuery(Query qry)
        {
            CatAutocasoCollection coll = new CatAutocasoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IDAutocaso)
        {
            return (CatAutocaso.Delete(IDAutocaso) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IDAutocaso)
        {
            return (CatAutocaso.Destroy(IDAutocaso) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatAutocaso item = new CatAutocaso();
		    
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IDAutocaso,string Descripcion,bool? Status)
	    {
		    CatAutocaso item = new CatAutocaso();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IDAutocaso = IDAutocaso;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
