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
    /// Controller class for CatEjercicio_Inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatEjercicioInventarioController
    {
        // Preload our schema..
        CatEjercicioInventario thisSchemaLoad = new CatEjercicioInventario();
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
        public CatEjercicioInventarioCollection FetchAll()
        {
            CatEjercicioInventarioCollection coll = new CatEjercicioInventarioCollection();
            Query qry = new Query(CatEjercicioInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatEjercicioInventarioCollection FetchByID(object Id)
        {
            CatEjercicioInventarioCollection coll = new CatEjercicioInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatEjercicioInventarioCollection FetchByQuery(Query qry)
        {
            CatEjercicioInventarioCollection coll = new CatEjercicioInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatEjercicioInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatEjercicioInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Valor,string Descripcion,bool? Staus)
	    {
		    CatEjercicioInventario item = new CatEjercicioInventario();
		    
            item.Valor = Valor;
            
            item.Descripcion = Descripcion;
            
            item.Staus = Staus;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Valor,string Descripcion,bool? Staus,int Id)
	    {
		    CatEjercicioInventario item = new CatEjercicioInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Valor = Valor;
				
			item.Descripcion = Descripcion;
				
			item.Staus = Staus;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
