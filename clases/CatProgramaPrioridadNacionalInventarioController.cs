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
    /// Controller class for CatProgramaPrioridadNacional_inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatProgramaPrioridadNacionalInventarioController
    {
        // Preload our schema..
        CatProgramaPrioridadNacionalInventario thisSchemaLoad = new CatProgramaPrioridadNacionalInventario();
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
        public CatProgramaPrioridadNacionalInventarioCollection FetchAll()
        {
            CatProgramaPrioridadNacionalInventarioCollection coll = new CatProgramaPrioridadNacionalInventarioCollection();
            Query qry = new Query(CatProgramaPrioridadNacionalInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatProgramaPrioridadNacionalInventarioCollection FetchByID(object Id)
        {
            CatProgramaPrioridadNacionalInventarioCollection coll = new CatProgramaPrioridadNacionalInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatProgramaPrioridadNacionalInventarioCollection FetchByQuery(Query qry)
        {
            CatProgramaPrioridadNacionalInventarioCollection coll = new CatProgramaPrioridadNacionalInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatProgramaPrioridadNacionalInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatProgramaPrioridadNacionalInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int Id,string Descripcion,bool? Status)
	    {
		    CatProgramaPrioridadNacionalInventario item = new CatProgramaPrioridadNacionalInventario();
		    
            item.Id = Id;
            
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
		    CatProgramaPrioridadNacionalInventario item = new CatProgramaPrioridadNacionalInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
