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
    /// Controller class for RelTipoPermisoRH
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class RelTipoPermisoRHController
    {
        // Preload our schema..
        RelTipoPermisoRH thisSchemaLoad = new RelTipoPermisoRH();
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
        public RelTipoPermisoRHCollection FetchAll()
        {
            RelTipoPermisoRHCollection coll = new RelTipoPermisoRHCollection();
            Query qry = new Query(RelTipoPermisoRH.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelTipoPermisoRHCollection FetchByID(object IDUser)
        {
            RelTipoPermisoRHCollection coll = new RelTipoPermisoRHCollection().Where("IDUser", IDUser).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public RelTipoPermisoRHCollection FetchByQuery(Query qry)
        {
            RelTipoPermisoRHCollection coll = new RelTipoPermisoRHCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object IDUser)
        {
            return (RelTipoPermisoRH.Delete(IDUser) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object IDUser)
        {
            return (RelTipoPermisoRH.Destroy(IDUser) == 1);
        }
        
        
        
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(int IDUser,int IDPeriodo,int IDano)
        {
            Query qry = new Query(RelTipoPermisoRH.Schema);
            qry.QueryType = QueryType.Delete;
            qry.AddWhere("IDUser", IDUser).AND("IDPeriodo", IDPeriodo).AND("IDano", IDano);
            qry.Execute();
            return (true);
        }        
       
    	
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int IDUser,DateTime? FechaInicio,DateTime? FechaFin,bool? Status,DateTime? FechaCaptura,int IDPeriodo,int IDano,int? IDUserCaptura,string Observaciones,int? Totaldias)
	    {
		    RelTipoPermisoRH item = new RelTipoPermisoRH();
		    
            item.IDUser = IDUser;
            
            item.FechaInicio = FechaInicio;
            
            item.FechaFin = FechaFin;
            
            item.Status = Status;
            
            item.FechaCaptura = FechaCaptura;
            
            item.IDPeriodo = IDPeriodo;
            
            item.IDano = IDano;
            
            item.IDUserCaptura = IDUserCaptura;
            
            item.Observaciones = Observaciones;
            
            item.Totaldias = Totaldias;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,int IDUser,DateTime? FechaInicio,DateTime? FechaFin,bool? Status,DateTime? FechaCaptura,int IDPeriodo,int IDano,int? IDUserCaptura,string Observaciones,int? Totaldias)
	    {
		    RelTipoPermisoRH item = new RelTipoPermisoRH();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.IDUser = IDUser;
				
			item.FechaInicio = FechaInicio;
				
			item.FechaFin = FechaFin;
				
			item.Status = Status;
				
			item.FechaCaptura = FechaCaptura;
				
			item.IDPeriodo = IDPeriodo;
				
			item.IDano = IDano;
				
			item.IDUserCaptura = IDUserCaptura;
				
			item.Observaciones = Observaciones;
				
			item.Totaldias = Totaldias;
				
	        item.Save(UserName);
	    }
    }
}
