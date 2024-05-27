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
    /// Controller class for CatAdscripcion_RH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatAdscripcionRhController
    {
        // Preload our schema..
        CatAdscripcionRh thisSchemaLoad = new CatAdscripcionRh();
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
        public CatAdscripcionRhCollection FetchAll()
        {
            CatAdscripcionRhCollection coll = new CatAdscripcionRhCollection();
            Query qry = new Query(CatAdscripcionRh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAdscripcionRhCollection FetchByID(object Id)
        {
            CatAdscripcionRhCollection coll = new CatAdscripcionRhCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAdscripcionRhCollection FetchByQuery(Query qry)
        {
            CatAdscripcionRhCollection coll = new CatAdscripcionRhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatAdscripcionRh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatAdscripcionRh.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status,string Clave,string IDTitular)
	    {
		    CatAdscripcionRh item = new CatAdscripcionRh();
		    
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
            item.Clave = Clave;
            
            item.IDTitular = IDTitular;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Descripcion,bool? Status,string Clave,string IDTitular)
	    {
		    CatAdscripcionRh item = new CatAdscripcionRh();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Clave = Clave;
				
			item.IDTitular = IDTitular;
				
	        item.Save(UserName);
	    }
    }
}
