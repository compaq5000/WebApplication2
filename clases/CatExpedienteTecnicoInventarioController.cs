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
    /// Controller class for CatExpedienteTecnico_Inventarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatExpedienteTecnicoInventarioController
    {
        // Preload our schema..
        CatExpedienteTecnicoInventario thisSchemaLoad = new CatExpedienteTecnicoInventario();
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
        public CatExpedienteTecnicoInventarioCollection FetchAll()
        {
            CatExpedienteTecnicoInventarioCollection coll = new CatExpedienteTecnicoInventarioCollection();
            Query qry = new Query(CatExpedienteTecnicoInventario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatExpedienteTecnicoInventarioCollection FetchByID(object Id)
        {
            CatExpedienteTecnicoInventarioCollection coll = new CatExpedienteTecnicoInventarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatExpedienteTecnicoInventarioCollection FetchByQuery(Query qry)
        {
            CatExpedienteTecnicoInventarioCollection coll = new CatExpedienteTecnicoInventarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatExpedienteTecnicoInventario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatExpedienteTecnicoInventario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatExpedienteTecnicoInventario item = new CatExpedienteTecnicoInventario();
		    
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
		    CatExpedienteTecnicoInventario item = new CatExpedienteTecnicoInventario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
