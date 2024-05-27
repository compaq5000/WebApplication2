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
    /// Controller class for CatTipoUser
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatTipoUserController
    {
        // Preload our schema..
        CatTipoUser thisSchemaLoad = new CatTipoUser();
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
        public CatTipoUserCollection FetchAll()
        {
            CatTipoUserCollection coll = new CatTipoUserCollection();
            Query qry = new Query(CatTipoUser.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoUserCollection FetchByID(object Id)
        {
            CatTipoUserCollection coll = new CatTipoUserCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoUserCollection FetchByQuery(Query qry)
        {
            CatTipoUserCollection coll = new CatTipoUserCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatTipoUser.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatTipoUser.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatTipoUser item = new CatTipoUser();
		    
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Descripcion,bool? Status)
	    {
		    CatTipoUser item = new CatTipoUser();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
