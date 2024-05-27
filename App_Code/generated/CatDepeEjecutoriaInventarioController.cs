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
    /// Controller class for CatDepeEjecutoria_Inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatDepeEjecutoriaInventarioController
    {
        // Preload our schema..
        CatDepeEjecutoriaInventario thisSchemaLoad = new CatDepeEjecutoriaInventario();
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
        public CatDepeEjecutoriaInventarioCollection FetchAll()
        {
            CatDepeEjecutoriaInventarioCollection coll = new CatDepeEjecutoriaInventarioCollection();
            Query qry = new Query(CatDepeEjecutoriaInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatDepeEjecutoriaInventarioCollection FetchByID(object Id)
        {
            CatDepeEjecutoriaInventarioCollection coll = new CatDepeEjecutoriaInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatDepeEjecutoriaInventarioCollection FetchByQuery(Query qry)
        {
            CatDepeEjecutoriaInventarioCollection coll = new CatDepeEjecutoriaInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatDepeEjecutoriaInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatDepeEjecutoriaInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status,string Valor)
	    {
		    CatDepeEjecutoriaInventario item = new CatDepeEjecutoriaInventario();
		    
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
            item.Valor = Valor;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Descripcion,bool? Status,string Valor)
	    {
		    CatDepeEjecutoriaInventario item = new CatDepeEjecutoriaInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Valor = Valor;
				
	        item.Save(UserName);
	    }
    }
}
