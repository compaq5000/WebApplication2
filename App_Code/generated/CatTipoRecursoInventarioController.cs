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
    /// Controller class for CatTipoRecurso_Inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatTipoRecursoInventarioController
    {
        // Preload our schema..
        CatTipoRecursoInventario thisSchemaLoad = new CatTipoRecursoInventario();
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
        public CatTipoRecursoInventarioCollection FetchAll()
        {
            CatTipoRecursoInventarioCollection coll = new CatTipoRecursoInventarioCollection();
            Query qry = new Query(CatTipoRecursoInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoRecursoInventarioCollection FetchByID(object Id)
        {
            CatTipoRecursoInventarioCollection coll = new CatTipoRecursoInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatTipoRecursoInventarioCollection FetchByQuery(Query qry)
        {
            CatTipoRecursoInventarioCollection coll = new CatTipoRecursoInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatTipoRecursoInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatTipoRecursoInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatTipoRecursoInventario item = new CatTipoRecursoInventario();
		    
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
		    CatTipoRecursoInventario item = new CatTipoRecursoInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
