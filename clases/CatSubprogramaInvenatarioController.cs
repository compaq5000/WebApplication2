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
    /// Controller class for CatSubprograma_Invenatarios
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatSubprogramaInvenatarioController
    {
        // Preload our schema..
        CatSubprogramaInvenatario thisSchemaLoad = new CatSubprogramaInvenatario();
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
        public CatSubprogramaInvenatarioCollection FetchAll()
        {
            CatSubprogramaInvenatarioCollection coll = new CatSubprogramaInvenatarioCollection();
            Query qry = new Query(CatSubprogramaInvenatario.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatSubprogramaInvenatarioCollection FetchByID(object Id)
        {
            CatSubprogramaInvenatarioCollection coll = new CatSubprogramaInvenatarioCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatSubprogramaInvenatarioCollection FetchByQuery(Query qry)
        {
            CatSubprogramaInvenatarioCollection coll = new CatSubprogramaInvenatarioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatSubprogramaInvenatario.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatSubprogramaInvenatario.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string ValueX,string Descripcion,bool? Status)
	    {
		    CatSubprogramaInvenatario item = new CatSubprogramaInvenatario();
		    
            item.ValueX = ValueX;
            
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(string ValueX,string Descripcion,bool? Status,int Id)
	    {
		    CatSubprogramaInvenatario item = new CatSubprogramaInvenatario();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.ValueX = ValueX;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Id = Id;
				
	        item.Save(UserName);
	    }
    }
}
