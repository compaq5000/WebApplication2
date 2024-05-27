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
    /// Controller class for CatCapitulo_Inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatCapituloInventarioController
    {
        // Preload our schema..
        CatCapituloInventario thisSchemaLoad = new CatCapituloInventario();
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
        public CatCapituloInventarioCollection FetchAll()
        {
            CatCapituloInventarioCollection coll = new CatCapituloInventarioCollection();
            Query qry = new Query(CatCapituloInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatCapituloInventarioCollection FetchByID(object Id)
        {
            CatCapituloInventarioCollection coll = new CatCapituloInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatCapituloInventarioCollection FetchByQuery(Query qry)
        {
            CatCapituloInventarioCollection coll = new CatCapituloInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatCapituloInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatCapituloInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Valor,string Descripcion,bool? Status)
	    {
		    CatCapituloInventario item = new CatCapituloInventario();
		    
            item.Valor = Valor;
            
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Valor,string Descripcion,bool? Status,int Id)
	    {
		    CatCapituloInventario item = new CatCapituloInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Valor = Valor;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
