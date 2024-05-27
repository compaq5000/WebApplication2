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
    /// Controller class for CattipoJuicio
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class CattipoJuicioController
    {
        // Preload our schema..
        CattipoJuicio thisSchemaLoad = new CattipoJuicio();
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
        public CattipoJuicioCollection FetchAll()
        {
            CattipoJuicioCollection coll = new CattipoJuicioCollection();
            Query qry = new Query(CattipoJuicio.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public CattipoJuicioCollection FetchByID(object IDTipojuicio)
        {
            CattipoJuicioCollection coll = new CattipoJuicioCollection().Where("IDTipojuicio", IDTipojuicio).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public CattipoJuicioCollection FetchByQuery(Query qry)
        {
            CattipoJuicioCollection coll = new CattipoJuicioCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IDTipojuicio)
        {
            return (CattipoJuicio.Delete(IDTipojuicio) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IDTipojuicio)
        {
            return (CattipoJuicio.Destroy(IDTipojuicio) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripocion,bool? Status)
	    {
		    CattipoJuicio item = new CattipoJuicio();
		    
            item.Descripocion = Descripocion;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int IDTipojuicio,string Descripocion,bool? Status)
	    {
		    CattipoJuicio item = new CattipoJuicio();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.IDTipojuicio = IDTipojuicio;
				
			item.Descripocion = Descripocion;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
