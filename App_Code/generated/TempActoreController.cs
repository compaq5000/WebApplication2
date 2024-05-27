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
    /// Controller class for TempActores
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TempActoreController
    {
        // Preload our schema..
        TempActore thisSchemaLoad = new TempActore();
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
        public TempActoreCollection FetchAll()
        {
            TempActoreCollection coll = new TempActoreCollection();
            Query qry = new Query(TempActore.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TempActoreCollection FetchByID(object Idactor)
        {
            TempActoreCollection coll = new TempActoreCollection().Where("IDACTOR", Idactor).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TempActoreCollection FetchByQuery(Query qry)
        {
            TempActoreCollection coll = new TempActoreCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Idactor)
        {
            return (TempActore.Delete(Idactor) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Idactor)
        {
            return (TempActore.Destroy(Idactor) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Expediente,string Nombreactor)
	    {
		    TempActore item = new TempActore();
		    
            item.Expediente = Expediente;
            
            item.Nombreactor = Nombreactor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Expediente,int Idactor,string Nombreactor)
	    {
		    TempActore item = new TempActore();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Expediente = Expediente;
				
			item.Idactor = Idactor;
				
			item.Nombreactor = Nombreactor;
				
	        item.Save(UserName);
	    }
    }
}
