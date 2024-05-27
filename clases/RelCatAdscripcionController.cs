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
    /// Controller class for RelCatAdscripcion
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelCatAdscripcionController
    {
        // Preload our schema..
        RelCatAdscripcion thisSchemaLoad = new RelCatAdscripcion();
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
        public RelCatAdscripcionCollection FetchAll()
        {
            RelCatAdscripcionCollection coll = new RelCatAdscripcionCollection();
            Query qry = new Query(RelCatAdscripcion.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatAdscripcionCollection FetchByID(object Id)
        {
            RelCatAdscripcionCollection coll = new RelCatAdscripcionCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelCatAdscripcionCollection FetchByQuery(Query qry)
        {
            RelCatAdscripcionCollection coll = new RelCatAdscripcionCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (RelCatAdscripcion.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (RelCatAdscripcion.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? IDAdscripcion,int? IDUsuario,bool? Status)
	    {
		    RelCatAdscripcion item = new RelCatAdscripcion();
		    
            item.IDAdscripcion = IDAdscripcion;
            
            item.IDUsuario = IDUsuario;
            
            item.Status = Status;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? IDAdscripcion,int? IDUsuario,bool? Status)
	    {
		    RelCatAdscripcion item = new RelCatAdscripcion();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDAdscripcion = IDAdscripcion;
				
			item.IDUsuario = IDUsuario;
				
			item.Status = Status;
				
	        item.Save(UserName);
	    }
    }
}
