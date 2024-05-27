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
    /// Controller class for CatPeriodoVAcaiones_RH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CatPeriodoVAcaionesRhController
    {
        // Preload our schema..
        CatPeriodoVAcaionesRh thisSchemaLoad = new CatPeriodoVAcaionesRh();
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
        public CatPeriodoVAcaionesRhCollection FetchAll()
        {
            CatPeriodoVAcaionesRhCollection coll = new CatPeriodoVAcaionesRhCollection();
            Query qry = new Query(CatPeriodoVAcaionesRh.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatPeriodoVAcaionesRhCollection FetchByID(object Id)
        {
            CatPeriodoVAcaionesRhCollection coll = new CatPeriodoVAcaionesRhCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CatPeriodoVAcaionesRhCollection FetchByQuery(Query qry)
        {
            CatPeriodoVAcaionesRhCollection coll = new CatPeriodoVAcaionesRhCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (CatPeriodoVAcaionesRh.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (CatPeriodoVAcaionesRh.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion)
	    {
		    CatPeriodoVAcaionesRh item = new CatPeriodoVAcaionesRh();
		    
            item.Descripcion = Descripcion;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Descripcion)
	    {
		    CatPeriodoVAcaionesRh item = new CatPeriodoVAcaionesRh();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
	        item.Save(UserName);
	    }
    }
}
