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
    /// Controller class for imprimirinsidencias
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class ImprimirinsidenciaController
    {
        // Preload our schema..
        Imprimirinsidencia thisSchemaLoad = new Imprimirinsidencia();
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
        public ImprimirinsidenciaCollection FetchAll()
        {
            ImprimirinsidenciaCollection coll = new ImprimirinsidenciaCollection();
            Query qry = new Query(Imprimirinsidencia.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public ImprimirinsidenciaCollection FetchByID(object Id)
        {
            ImprimirinsidenciaCollection coll = new ImprimirinsidenciaCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public ImprimirinsidenciaCollection FetchByQuery(Query qry)
        {
            ImprimirinsidenciaCollection coll = new ImprimirinsidenciaCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (Imprimirinsidencia.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (Imprimirinsidencia.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string Descripcion,bool? Status,int? Idadscripcion,int? Recibo)
	    {
		    Imprimirinsidencia item = new Imprimirinsidencia();
		    
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
            item.Idadscripcion = Idadscripcion;
            
            item.Recibo = Recibo;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Descripcion,bool? Status,int? Idadscripcion,int? Recibo)
	    {
		    Imprimirinsidencia item = new Imprimirinsidencia();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Idadscripcion = Idadscripcion;
				
			item.Recibo = Recibo;
				
	        item.Save(UserName);
	    }
    }
}
