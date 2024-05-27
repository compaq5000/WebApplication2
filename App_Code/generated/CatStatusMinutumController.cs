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
    /// Controller class for CatStatusMinuta
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatStatusMinutumController
    {
        // Preload our schema..
        CatStatusMinutum thisSchemaLoad = new CatStatusMinutum();
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
        public CatStatusMinutumCollection FetchAll()
        {
            CatStatusMinutumCollection coll = new CatStatusMinutumCollection();
            Query qry = new Query(CatStatusMinutum.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatStatusMinutumCollection FetchByID(object IntX)
        {
            CatStatusMinutumCollection coll = new CatStatusMinutumCollection().Where("int", IntX).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatStatusMinutumCollection FetchByQuery(Query qry)
        {
            CatStatusMinutumCollection coll = new CatStatusMinutumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IntX)
        {
            return (CatStatusMinutum.Delete(IntX) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IntX)
        {
            return (CatStatusMinutum.Destroy(IntX) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Nvarchar,bool? Status)
	    {
		    CatStatusMinutum item = new CatStatusMinutum();
		    
            item.Nvarchar = Nvarchar;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IntX,string Nvarchar,bool? Status)
	    {
		    CatStatusMinutum item = new CatStatusMinutum();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IntX = IntX;
				
			item.Nvarchar = Nvarchar;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
