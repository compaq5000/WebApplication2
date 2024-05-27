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
	/// Strongly-typed collection for the CatPeriodoVAcaionesRh class.
	/// </summary>
    [Serializable]
	public partial class CatPeriodoVAcaionesRhCollection : ActiveList<CatPeriodoVAcaionesRh, CatPeriodoVAcaionesRhCollection>
	{	   
		public CatPeriodoVAcaionesRhCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CatPeriodoVAcaionesRhCollection</returns>
		public CatPeriodoVAcaionesRhCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CatPeriodoVAcaionesRh o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the CatPeriodoVAcaiones_RH table.
	/// </summary>
	[Serializable]
	public partial class CatPeriodoVAcaionesRh : ActiveRecord<CatPeriodoVAcaionesRh>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public CatPeriodoVAcaionesRh()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public CatPeriodoVAcaionesRh(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public CatPeriodoVAcaionesRh(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public CatPeriodoVAcaionesRh(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("CatPeriodoVAcaiones_RH", TableType.Table, DataService.GetInstance("Default"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarDescripcion = new TableSchema.TableColumn(schema);
				colvarDescripcion.ColumnName = "Descripcion";
				colvarDescripcion.DataType = DbType.String;
				colvarDescripcion.MaxLength = 10;
				colvarDescripcion.AutoIncrement = false;
				colvarDescripcion.IsNullable = true;
				colvarDescripcion.IsPrimaryKey = false;
				colvarDescripcion.IsForeignKey = false;
				colvarDescripcion.IsReadOnly = false;
				colvarDescripcion.DefaultSetting = @"";
				colvarDescripcion.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDescripcion);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Default"].AddSchema("CatPeriodoVAcaiones_RH",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("Descripcion")]
		[Bindable(true)]
		public string Descripcion 
		{
			get { return GetColumnValue<string>(Columns.Descripcion); }
			set { SetColumnValue(Columns.Descripcion, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public SubSonicDB.RelTipoPermisoRHCollection RelTipoPermisoRHRecords()
		{
			return new SubSonicDB.RelTipoPermisoRHCollection().Where(RelTipoPermisoRH.Columns.IDPeriodo, Id).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		#region Many To Many Helpers
		
		 
		public SubSonicDB.CatAnoVacacionesRhCollection GetCatAnoVacacionesRhCollection() { return CatPeriodoVAcaionesRh.GetCatAnoVacacionesRhCollection(this.Id); }
		public static SubSonicDB.CatAnoVacacionesRhCollection GetCatAnoVacacionesRhCollection(int varId)
		{
		    SubSonic.QueryCommand cmd = new SubSonic.QueryCommand("SELECT * FROM [dbo].[CatAnoVacaciones_RH] INNER JOIN [RelTipoPermisoRH] ON [CatAnoVacaciones_RH].[ID] = [RelTipoPermisoRH].[IDano] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmd.AddParameter("@IDPeriodo", varId, DbType.Int32);
			IDataReader rdr = SubSonic.DataService.GetReader(cmd);
			CatAnoVacacionesRhCollection coll = new CatAnoVacacionesRhCollection();
			coll.LoadAndCloseReader(rdr);
			return coll;
		}
		
		public static void SaveCatAnoVacacionesRhMap(int varId, CatAnoVacacionesRhCollection items)
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (CatAnoVacacionesRh item in items)
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDPeriodo", varId);
				varRelTipoPermisoRH.SetColumnValue("IDano", item.GetPrimaryKeyValue());
				varRelTipoPermisoRH.Save();
			}
		}
		public static void SaveCatAnoVacacionesRhMap(int varId, System.Web.UI.WebControls.ListItemCollection itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (System.Web.UI.WebControls.ListItem l in itemList) 
			{
				if (l.Selected) 
				{
					RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
					varRelTipoPermisoRH.SetColumnValue("IDPeriodo", varId);
					varRelTipoPermisoRH.SetColumnValue("IDano", l.Value);
					varRelTipoPermisoRH.Save();
				}
			}
		}
		public static void SaveCatAnoVacacionesRhMap(int varId , int[] itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (int item in itemList) 
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDPeriodo", varId);
				varRelTipoPermisoRH.SetColumnValue("IDano", item);
				varRelTipoPermisoRH.Save();
			}
		}
		
		public static void DeleteCatAnoVacacionesRhMap(int varId) 
		{
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			DataService.ExecuteQuery(cmdDel);
		}
		
		 
		public SubSonicDB.CatUsuarioCollection GetCatUsuarioCollection() { return CatPeriodoVAcaionesRh.GetCatUsuarioCollection(this.Id); }
		public static SubSonicDB.CatUsuarioCollection GetCatUsuarioCollection(int varId)
		{
		    SubSonic.QueryCommand cmd = new SubSonic.QueryCommand("SELECT * FROM [dbo].[CatUsuarios] INNER JOIN [RelTipoPermisoRH] ON [CatUsuarios].[ID] = [RelTipoPermisoRH].[IDUser] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmd.AddParameter("@IDPeriodo", varId, DbType.Int32);
			IDataReader rdr = SubSonic.DataService.GetReader(cmd);
			CatUsuarioCollection coll = new CatUsuarioCollection();
			coll.LoadAndCloseReader(rdr);
			return coll;
		}
		
		public static void SaveCatUsuarioMap(int varId, CatUsuarioCollection items)
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (CatUsuario item in items)
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDPeriodo", varId);
				varRelTipoPermisoRH.SetColumnValue("IDUser", item.GetPrimaryKeyValue());
				varRelTipoPermisoRH.Save();
			}
		}
		public static void SaveCatUsuarioMap(int varId, System.Web.UI.WebControls.ListItemCollection itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (System.Web.UI.WebControls.ListItem l in itemList) 
			{
				if (l.Selected) 
				{
					RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
					varRelTipoPermisoRH.SetColumnValue("IDPeriodo", varId);
					varRelTipoPermisoRH.SetColumnValue("IDUser", l.Value);
					varRelTipoPermisoRH.Save();
				}
			}
		}
		public static void SaveCatUsuarioMap(int varId , int[] itemList) 
		{
			QueryCommandCollection coll = new SubSonic.QueryCommandCollection();
			//delete out the existing
			 QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			coll.Add(cmdDel);
			DataService.ExecuteTransaction(coll);
			foreach (int item in itemList) 
			{
				RelTipoPermisoRH varRelTipoPermisoRH = new RelTipoPermisoRH();
				varRelTipoPermisoRH.SetColumnValue("IDPeriodo", varId);
				varRelTipoPermisoRH.SetColumnValue("IDUser", item);
				varRelTipoPermisoRH.Save();
			}
		}
		
		public static void DeleteCatUsuarioMap(int varId) 
		{
			QueryCommand cmdDel = new QueryCommand("DELETE FROM [RelTipoPermisoRH] WHERE [RelTipoPermisoRH].[IDPeriodo] = @IDPeriodo", CatPeriodoVAcaionesRh.Schema.Provider.Name);
			cmdDel.AddParameter("@IDPeriodo", varId, DbType.Int32);
			DataService.ExecuteQuery(cmdDel);
		}
		
		#endregion
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDescripcion)
		{
			CatPeriodoVAcaionesRh item = new CatPeriodoVAcaionesRh();
			
			item.Descripcion = varDescripcion;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varDescripcion)
		{
			CatPeriodoVAcaionesRh item = new CatPeriodoVAcaionesRh();
			
				item.Id = varId;
			
				item.Descripcion = varDescripcion;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DescripcionColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Descripcion = @"Descripcion";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}