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
    /// Controller class for TableBitacora
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TableBitacoraController
    {
        // Preload our schema..
        TableBitacora thisSchemaLoad = new TableBitacora();
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
        public TableBitacoraCollection FetchAll()
        {
            TableBitacoraCollection coll = new TableBitacoraCollection();
            Query qry = new Query(TableBitacora.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TableBitacoraCollection FetchByID(object Id)
        {
            TableBitacoraCollection coll = new TableBitacoraCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TableBitacoraCollection FetchByQuery(Query qry)
        {
            TableBitacoraCollection coll = new TableBitacoraCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TableBitacora.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TableBitacora.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int? TipoOperacion,string Descripcion,bool? Status,DateTime? Fecha,int? IDUser,string Ip,string Mac)
	    {
		    TableBitacora item = new TableBitacora();
		    
            item.TipoOperacion = TipoOperacion;
            
            item.Descripcion = Descripcion;
            
            item.Status = Status;
            
            item.Fecha = Fecha;
            
            item.IDUser = IDUser;
            
            item.Ip = Ip;
            
            item.Mac = Mac;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int? TipoOperacion,string Descripcion,bool? Status,DateTime? Fecha,int? IDUser,string Ip,string Mac)
	    {
		    TableBitacora item = new TableBitacora();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.TipoOperacion = TipoOperacion;
				
			item.Descripcion = Descripcion;
				
			item.Status = Status;
				
			item.Fecha = Fecha;
				
			item.IDUser = IDUser;
				
			item.Ip = Ip;
				
			item.Mac = Mac;
				
	        item.Save(UserName);
	    }
    }
}
