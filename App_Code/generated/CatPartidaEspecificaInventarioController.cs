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
    /// Controller class for CatPartidaEspecifica_Inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatPartidaEspecificaInventarioController
    {
        // Preload our schema..
        CatPartidaEspecificaInventario thisSchemaLoad = new CatPartidaEspecificaInventario();
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
        public CatPartidaEspecificaInventarioCollection FetchAll()
        {
            CatPartidaEspecificaInventarioCollection coll = new CatPartidaEspecificaInventarioCollection();
            Query qry = new Query(CatPartidaEspecificaInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatPartidaEspecificaInventarioCollection FetchByID(object Id)
        {
            CatPartidaEspecificaInventarioCollection coll = new CatPartidaEspecificaInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatPartidaEspecificaInventarioCollection FetchByQuery(Query qry)
        {
            CatPartidaEspecificaInventarioCollection coll = new CatPartidaEspecificaInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatPartidaEspecificaInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatPartidaEspecificaInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Valor,string Descripcion,bool? Status,int? IDPartidaGnerica)
	    {
		    CatPartidaEspecificaInventario item = new CatPartidaEspecificaInventario();
		    
            item.Valor = Valor;
            
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
            item.IDPartidaGnerica = IDPartidaGnerica;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Valor,string Descripcion,bool? Status,int Id,int? IDPartidaGnerica)
	    {
		    CatPartidaEspecificaInventario item = new CatPartidaEspecificaInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Valor = Valor;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Id = Id;
				
			item.IDPartidaGnerica = IDPartidaGnerica;
				
	        item.Save(UserName);
	    }
    }
}
