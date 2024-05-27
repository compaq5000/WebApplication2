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
namespace SubSonicDB{
    public partial class SPs{
        
        /// <summary>
        /// Creates an object wrapper for the ArboladoGridSPD Procedure
        /// </summary>
        public static StoredProcedure ArboladoGridSPD(int? IDUser, int? IDDepende)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("ArboladoGridSPD", DataService.GetInstance("Default"), "dbo");
        	
            sp.Command.AddParameter("@IDUser", IDUser, DbType.Int32, 0, 10);
        	
            sp.Command.AddParameter("@IDDepende", IDDepende, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the Storearbolado Procedure
        /// </summary>
        public static StoredProcedure Storearbolado(DateTime? FECHAINICIO, DateTime? FECHAFIN)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("Storearbolado", DataService.GetInstance("Default"), "dbo");
        	
            sp.Command.AddParameter("@FECHAINICIO", FECHAINICIO, DbType.DateTime, null, null);
        	
            sp.Command.AddParameter("@FECHAFIN", FECHAFIN, DbType.DateTime, null, null);
        	
            return sp;
        }
        
        /// <summary>
        /// Creates an object wrapper for the StoreArbolado1 Procedure
        /// </summary>
        public static StoredProcedure StoreArbolado1(int? IDD)
        {
            SubSonic.StoredProcedure sp = new SubSonic.StoredProcedure("StoreArbolado1", DataService.GetInstance("Default"), "dbo");
        	
            sp.Command.AddParameter("@IDD", IDD, DbType.Int32, 0, 10);
        	
            return sp;
        }
        
    }
    
}
