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
    /// Controller class for CatDemandado
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatDemandadoController
    {
        // Preload our schema..
        CatDemandado thisSchemaLoad = new CatDemandado();
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
        public CatDemandadoCollection FetchAll()
        {
            CatDemandadoCollection coll = new CatDemandadoCollection();
            Query qry = new Query(CatDemandado.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatDemandadoCollection FetchByID(object IDDemandado)
        {
            CatDemandadoCollection coll = new CatDemandadoCollection().Where("IDDemandado", IDDemandado).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatDemandadoCollection FetchByQuery(Query qry)
        {
            CatDemandadoCollection coll = new CatDemandadoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IDDemandado)
        {
            return (CatDemandado.Delete(IDDemandado) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IDDemandado)
        {
            return (CatDemandado.Destroy(IDDemandado) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status)
	    {
		    CatDemandado item = new CatDemandado();
		    
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IDDemandado,string Descripcion,bool? Status)
	    {
		    CatDemandado item = new CatDemandado();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IDDemandado = IDDemandado;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
