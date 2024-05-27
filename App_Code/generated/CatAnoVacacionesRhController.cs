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
    /// Controller class for CatAnoVacaciones_RH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatAnoVacacionesRhController
    {
        // Preload our schema..
        CatAnoVacacionesRh thisSchemaLoad = new CatAnoVacacionesRh();
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
        public CatAnoVacacionesRhCollection FetchAll()
        {
            CatAnoVacacionesRhCollection coll = new CatAnoVacacionesRhCollection();
            Query qry = new Query(CatAnoVacacionesRh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAnoVacacionesRhCollection FetchByID(object Id)
        {
            CatAnoVacacionesRhCollection coll = new CatAnoVacacionesRhCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatAnoVacacionesRhCollection FetchByQuery(Query qry)
        {
            CatAnoVacacionesRhCollection coll = new CatAnoVacacionesRhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatAnoVacacionesRh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatAnoVacacionesRh.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion)
	    {
		    CatAnoVacacionesRh item = new CatAnoVacacionesRh();
		    
            item.Descripcion = Descripcion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Descripcion)
	    {
		    CatAnoVacacionesRh item = new CatAnoVacacionesRh();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
	        item.Save(UserName);
	    }
    }
}
