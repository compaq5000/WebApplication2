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
    /// Controller class for CatConcepto_Inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatConceptoInventarioController
    {
        // Preload our schema..
        CatConceptoInventario thisSchemaLoad = new CatConceptoInventario();
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
        public CatConceptoInventarioCollection FetchAll()
        {
            CatConceptoInventarioCollection coll = new CatConceptoInventarioCollection();
            Query qry = new Query(CatConceptoInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatConceptoInventarioCollection FetchByID(object Id)
        {
            CatConceptoInventarioCollection coll = new CatConceptoInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatConceptoInventarioCollection FetchByQuery(Query qry)
        {
            CatConceptoInventarioCollection coll = new CatConceptoInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatConceptoInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatConceptoInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Valor,string Descripcion,bool? Status,int? IDCapitulo)
	    {
		    CatConceptoInventario item = new CatConceptoInventario();
		    
            item.Valor = Valor;
            
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
            item.IDCapitulo = IDCapitulo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string Valor,string Descripcion,bool? Status,int Id,int? IDCapitulo)
	    {
		    CatConceptoInventario item = new CatConceptoInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Valor = Valor;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Id = Id;
				
			item.IDCapitulo = IDCapitulo;
				
	        item.Save(UserName);
	    }
    }
}
