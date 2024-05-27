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
    /// Controller class for CatRHJustificar
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatRHJustificarController
    {
        // Preload our schema..
        CatRHJustificar thisSchemaLoad = new CatRHJustificar();
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
        public CatRHJustificarCollection FetchAll()
        {
            CatRHJustificarCollection coll = new CatRHJustificarCollection();
            Query qry = new Query(CatRHJustificar.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatRHJustificarCollection FetchByID(object Id)
        {
            CatRHJustificarCollection coll = new CatRHJustificarCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatRHJustificarCollection FetchByQuery(Query qry)
        {
            CatRHJustificarCollection coll = new CatRHJustificarCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatRHJustificar.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatRHJustificar.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatRHJustificar item = new CatRHJustificar();
		    
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
		    CatRHJustificar item = new CatRHJustificar();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
