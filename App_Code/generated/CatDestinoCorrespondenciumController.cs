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
    /// Controller class for CatDestinoCorrespondencia
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatDestinoCorrespondenciumController
    {
        // Preload our schema..
        CatDestinoCorrespondencium thisSchemaLoad = new CatDestinoCorrespondencium();
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
        public CatDestinoCorrespondenciumCollection FetchAll()
        {
            CatDestinoCorrespondenciumCollection coll = new CatDestinoCorrespondenciumCollection();
            Query qry = new Query(CatDestinoCorrespondencium.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatDestinoCorrespondenciumCollection FetchByID(object Id)
        {
            CatDestinoCorrespondenciumCollection coll = new CatDestinoCorrespondenciumCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatDestinoCorrespondenciumCollection FetchByQuery(Query qry)
        {
            CatDestinoCorrespondenciumCollection coll = new CatDestinoCorrespondenciumCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatDestinoCorrespondencium.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatDestinoCorrespondencium.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatDestinoCorrespondencium item = new CatDestinoCorrespondencium();
		    
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
		    CatDestinoCorrespondencium item = new CatDestinoCorrespondencium();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
