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
    /// Controller class for TemAutoridad
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TemAutoridadController
    {
        // Preload our schema..
        TemAutoridad thisSchemaLoad = new TemAutoridad();
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
        public TemAutoridadCollection FetchAll()
        {
            TemAutoridadCollection coll = new TemAutoridadCollection();
            Query qry = new Query(TemAutoridad.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemAutoridadCollection FetchByID(object Idautoridad)
        {
            TemAutoridadCollection coll = new TemAutoridadCollection().Where("IDAUTORIDAD", Idautoridad).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TemAutoridadCollection FetchByQuery(Query qry)
        {
            TemAutoridadCollection coll = new TemAutoridadCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Idautoridad)
        {
            return (TemAutoridad.Delete(Idautoridad) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Idautoridad)
        {
            return (TemAutoridad.Destroy(Idautoridad) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion)
	    {
		    TemAutoridad item = new TemAutoridad();
		    
            item.Descripcion = Descripcion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Idautoridad,string Descripcion)
	    {
		    TemAutoridad item = new TemAutoridad();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Idautoridad = Idautoridad;
				
			item.Descripcion = Descripcion;
				
	        item.Save(UserName);
	    }
    }
}
