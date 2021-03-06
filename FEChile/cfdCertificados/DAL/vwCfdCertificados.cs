/*
'===============================================================================
'  Generated From - CSharp_dOOdads_View.vbgen
'
'  The supporting base class SqlClientEntity is in the 
'  Architecture directory in "dOOdads".
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace cfd.FacturaElectronica
{
	public class vwCfdCertificados : SqlClientEntity
	{
		public vwCfdCertificados()
		{
			this.QuerySource = "vwCfdCertificados";
			this.MappingName = "vwCfdCertificados";
		}	
        //30/1/14 jcf Crea constructor con cadena de conexi�n
        public vwCfdCertificados(string connstr)
        {
            this.ConnectionString = connstr;
            this.QuerySource = "vwCfdCertificados";
            this.MappingName = "vwCfdCertificados";
        }	
	
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			return base.Query.Load();
		}
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
	
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter USERID
			{
				get
				{
					return new SqlParameter("@USERID", SqlDbType.Char, 35);
				}
			}
			
			public static SqlParameter ACA_RUT
			{
				get
				{
					return new SqlParameter("@ACA_RUT", SqlDbType.VarChar, 8000);
				}
			}
			
			public static SqlParameter Fecha_vig_desde
			{
				get
				{
					return new SqlParameter("@Fecha_vig_desde", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Fecha_vig_hasta
			{
				get
				{
					return new SqlParameter("@Fecha_vig_hasta", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter Ruta_certificado
			{
				get
				{
					return new SqlParameter("@Ruta_certificado", SqlDbType.Char, 255);
				}
			}
			
			public static SqlParameter Ruta_clave
			{
				get
				{
					return new SqlParameter("@Ruta_clave", SqlDbType.Char, 255);
				}
			}
			
			public static SqlParameter Contrasenia_clave
			{
				get
				{
					return new SqlParameter("@Contrasenia_clave", SqlDbType.Char, 20);
				}
			}
			
			public static SqlParameter ACA_SolicitaFolio
			{
				get
				{
					return new SqlParameter("@ACA_SolicitaFolio", SqlDbType.TinyInt, 0);
				}
			}
			
			public static SqlParameter ACA_AnulaDocumentos
			{
				get
				{
					return new SqlParameter("@ACA_AnulaDocumentos", SqlDbType.TinyInt, 0);
				}
			}
			
			public static SqlParameter ACA_EnviaDocumentos
			{
				get
				{
					return new SqlParameter("@ACA_EnviaDocumentos", SqlDbType.TinyInt, 0);
				}
			}
			
			public static SqlParameter ACA_FirmaDocumentos
			{
				get
				{
					return new SqlParameter("@ACA_FirmaDocumentos", SqlDbType.TinyInt, 0);
				}
			}
			
			public static SqlParameter ACTIVE
			{
				get
				{
					return new SqlParameter("@ACTIVE", SqlDbType.TinyInt, 0);
				}
			}
			
			public static SqlParameter NroResol
			{
				get
				{
					return new SqlParameter("@NroResol", SqlDbType.VarChar, 8000);
				}
			}
			
			public static SqlParameter FchResol
			{
				get
				{
					return new SqlParameter("@FchResol", SqlDbType.VarChar, 8000);
				}
			}
			
		}
		#endregion	
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string USERID = "USERID";
            public const string ACA_RUT = "ACA_RUT";
            public const string Fecha_vig_desde = "fecha_vig_desde";
            public const string Fecha_vig_hasta = "fecha_vig_hasta";
            public const string Ruta_certificado = "ruta_certificado";
            public const string Ruta_clave = "ruta_clave";
            public const string Contrasenia_clave = "contrasenia_clave";
            public const string ACA_SolicitaFolio = "ACA_SolicitaFolio";
            public const string ACA_AnulaDocumentos = "ACA_AnulaDocumentos";
            public const string ACA_EnviaDocumentos = "ACA_EnviaDocumentos";
            public const string ACA_FirmaDocumentos = "ACA_FirmaDocumentos";
            public const string ACTIVE = "ACTIVE";
            public const string NroResol = "nroResol";
            public const string FchResol = "fchResol";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[USERID] = vwCfdCertificados.PropertyNames.USERID;
					ht[ACA_RUT] = vwCfdCertificados.PropertyNames.ACA_RUT;
					ht[Fecha_vig_desde] = vwCfdCertificados.PropertyNames.Fecha_vig_desde;
					ht[Fecha_vig_hasta] = vwCfdCertificados.PropertyNames.Fecha_vig_hasta;
					ht[Ruta_certificado] = vwCfdCertificados.PropertyNames.Ruta_certificado;
					ht[Ruta_clave] = vwCfdCertificados.PropertyNames.Ruta_clave;
					ht[Contrasenia_clave] = vwCfdCertificados.PropertyNames.Contrasenia_clave;
					ht[ACA_SolicitaFolio] = vwCfdCertificados.PropertyNames.ACA_SolicitaFolio;
					ht[ACA_AnulaDocumentos] = vwCfdCertificados.PropertyNames.ACA_AnulaDocumentos;
					ht[ACA_EnviaDocumentos] = vwCfdCertificados.PropertyNames.ACA_EnviaDocumentos;
					ht[ACA_FirmaDocumentos] = vwCfdCertificados.PropertyNames.ACA_FirmaDocumentos;
					ht[ACTIVE] = vwCfdCertificados.PropertyNames.ACTIVE;
					ht[NroResol] = vwCfdCertificados.PropertyNames.NroResol;
					ht[FchResol] = vwCfdCertificados.PropertyNames.FchResol;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string USERID = "USERID";
            public const string ACA_RUT = "ACA_RUT";
            public const string Fecha_vig_desde = "Fecha_vig_desde";
            public const string Fecha_vig_hasta = "Fecha_vig_hasta";
            public const string Ruta_certificado = "Ruta_certificado";
            public const string Ruta_clave = "Ruta_clave";
            public const string Contrasenia_clave = "Contrasenia_clave";
            public const string ACA_SolicitaFolio = "ACA_SolicitaFolio";
            public const string ACA_AnulaDocumentos = "ACA_AnulaDocumentos";
            public const string ACA_EnviaDocumentos = "ACA_EnviaDocumentos";
            public const string ACA_FirmaDocumentos = "ACA_FirmaDocumentos";
            public const string ACTIVE = "ACTIVE";
            public const string NroResol = "NroResol";
            public const string FchResol = "FchResol";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[USERID] = vwCfdCertificados.ColumnNames.USERID;
					ht[ACA_RUT] = vwCfdCertificados.ColumnNames.ACA_RUT;
					ht[Fecha_vig_desde] = vwCfdCertificados.ColumnNames.Fecha_vig_desde;
					ht[Fecha_vig_hasta] = vwCfdCertificados.ColumnNames.Fecha_vig_hasta;
					ht[Ruta_certificado] = vwCfdCertificados.ColumnNames.Ruta_certificado;
					ht[Ruta_clave] = vwCfdCertificados.ColumnNames.Ruta_clave;
					ht[Contrasenia_clave] = vwCfdCertificados.ColumnNames.Contrasenia_clave;
					ht[ACA_SolicitaFolio] = vwCfdCertificados.ColumnNames.ACA_SolicitaFolio;
					ht[ACA_AnulaDocumentos] = vwCfdCertificados.ColumnNames.ACA_AnulaDocumentos;
					ht[ACA_EnviaDocumentos] = vwCfdCertificados.ColumnNames.ACA_EnviaDocumentos;
					ht[ACA_FirmaDocumentos] = vwCfdCertificados.ColumnNames.ACA_FirmaDocumentos;
					ht[ACTIVE] = vwCfdCertificados.ColumnNames.ACTIVE;
					ht[NroResol] = vwCfdCertificados.ColumnNames.NroResol;
					ht[FchResol] = vwCfdCertificados.ColumnNames.FchResol;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string USERID = "s_USERID";
            public const string ACA_RUT = "s_ACA_RUT";
            public const string Fecha_vig_desde = "s_Fecha_vig_desde";
            public const string Fecha_vig_hasta = "s_Fecha_vig_hasta";
            public const string Ruta_certificado = "s_Ruta_certificado";
            public const string Ruta_clave = "s_Ruta_clave";
            public const string Contrasenia_clave = "s_Contrasenia_clave";
            public const string ACA_SolicitaFolio = "s_ACA_SolicitaFolio";
            public const string ACA_AnulaDocumentos = "s_ACA_AnulaDocumentos";
            public const string ACA_EnviaDocumentos = "s_ACA_EnviaDocumentos";
            public const string ACA_FirmaDocumentos = "s_ACA_FirmaDocumentos";
            public const string ACTIVE = "s_ACTIVE";
            public const string NroResol = "s_NroResol";
            public const string FchResol = "s_FchResol";

		}
		#endregion	
		
		#region Properties
			public virtual string USERID
	    {
			get
	        {
				return base.Getstring(ColumnNames.USERID);
			}
			set
	        {
				base.Setstring(ColumnNames.USERID, value);
			}
		}

		public virtual string ACA_RUT
	    {
			get
	        {
				return base.Getstring(ColumnNames.ACA_RUT);
			}
			set
	        {
				base.Setstring(ColumnNames.ACA_RUT, value);
			}
		}

		public virtual DateTime Fecha_vig_desde
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fecha_vig_desde);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fecha_vig_desde, value);
			}
		}

		public virtual DateTime Fecha_vig_hasta
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.Fecha_vig_hasta);
			}
			set
	        {
				base.SetDateTime(ColumnNames.Fecha_vig_hasta, value);
			}
		}

		public virtual string Ruta_certificado
	    {
			get
	        {
				return base.Getstring(ColumnNames.Ruta_certificado);
			}
			set
	        {
				base.Setstring(ColumnNames.Ruta_certificado, value);
			}
		}

		public virtual string Ruta_clave
	    {
			get
	        {
				return base.Getstring(ColumnNames.Ruta_clave);
			}
			set
	        {
				base.Setstring(ColumnNames.Ruta_clave, value);
			}
		}

		public virtual string Contrasenia_clave
	    {
			get
	        {
				return base.Getstring(ColumnNames.Contrasenia_clave);
			}
			set
	        {
				base.Setstring(ColumnNames.Contrasenia_clave, value);
			}
		}

		public virtual byte ACA_SolicitaFolio
	    {
			get
	        {
				return base.Getbyte(ColumnNames.ACA_SolicitaFolio);
			}
			set
	        {
				base.Setbyte(ColumnNames.ACA_SolicitaFolio, value);
			}
		}

		public virtual byte ACA_AnulaDocumentos
	    {
			get
	        {
				return base.Getbyte(ColumnNames.ACA_AnulaDocumentos);
			}
			set
	        {
				base.Setbyte(ColumnNames.ACA_AnulaDocumentos, value);
			}
		}

		public virtual byte ACA_EnviaDocumentos
	    {
			get
	        {
				return base.Getbyte(ColumnNames.ACA_EnviaDocumentos);
			}
			set
	        {
				base.Setbyte(ColumnNames.ACA_EnviaDocumentos, value);
			}
		}

		public virtual byte ACA_FirmaDocumentos
	    {
			get
	        {
				return base.Getbyte(ColumnNames.ACA_FirmaDocumentos);
			}
			set
	        {
				base.Setbyte(ColumnNames.ACA_FirmaDocumentos, value);
			}
		}

		public virtual byte ACTIVE
	    {
			get
	        {
				return base.Getbyte(ColumnNames.ACTIVE);
			}
			set
	        {
				base.Setbyte(ColumnNames.ACTIVE, value);
			}
		}

		public virtual string NroResol
	    {
			get
	        {
				return base.Getstring(ColumnNames.NroResol);
			}
			set
	        {
				base.Setstring(ColumnNames.NroResol, value);
			}
		}

		public virtual string FchResol
	    {
			get
	        {
				return base.Getstring(ColumnNames.FchResol);
			}
			set
	        {
				base.Setstring(ColumnNames.FchResol, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_USERID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.USERID) ? string.Empty : base.GetstringAsString(ColumnNames.USERID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.USERID);
				else
					this.USERID = base.SetstringAsString(ColumnNames.USERID, value);
			}
		}

		public virtual string s_ACA_RUT
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ACA_RUT) ? string.Empty : base.GetstringAsString(ColumnNames.ACA_RUT);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ACA_RUT);
				else
					this.ACA_RUT = base.SetstringAsString(ColumnNames.ACA_RUT, value);
			}
		}

		public virtual string s_Fecha_vig_desde
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fecha_vig_desde) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fecha_vig_desde);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fecha_vig_desde);
				else
					this.Fecha_vig_desde = base.SetDateTimeAsString(ColumnNames.Fecha_vig_desde, value);
			}
		}

		public virtual string s_Fecha_vig_hasta
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Fecha_vig_hasta) ? string.Empty : base.GetDateTimeAsString(ColumnNames.Fecha_vig_hasta);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Fecha_vig_hasta);
				else
					this.Fecha_vig_hasta = base.SetDateTimeAsString(ColumnNames.Fecha_vig_hasta, value);
			}
		}

		public virtual string s_Ruta_certificado
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Ruta_certificado) ? string.Empty : base.GetstringAsString(ColumnNames.Ruta_certificado);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Ruta_certificado);
				else
					this.Ruta_certificado = base.SetstringAsString(ColumnNames.Ruta_certificado, value);
			}
		}

		public virtual string s_Ruta_clave
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Ruta_clave) ? string.Empty : base.GetstringAsString(ColumnNames.Ruta_clave);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Ruta_clave);
				else
					this.Ruta_clave = base.SetstringAsString(ColumnNames.Ruta_clave, value);
			}
		}

		public virtual string s_Contrasenia_clave
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Contrasenia_clave) ? string.Empty : base.GetstringAsString(ColumnNames.Contrasenia_clave);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Contrasenia_clave);
				else
					this.Contrasenia_clave = base.SetstringAsString(ColumnNames.Contrasenia_clave, value);
			}
		}

		public virtual string s_ACA_SolicitaFolio
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ACA_SolicitaFolio) ? string.Empty : base.GetbyteAsString(ColumnNames.ACA_SolicitaFolio);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ACA_SolicitaFolio);
				else
					this.ACA_SolicitaFolio = base.SetbyteAsString(ColumnNames.ACA_SolicitaFolio, value);
			}
		}

		public virtual string s_ACA_AnulaDocumentos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ACA_AnulaDocumentos) ? string.Empty : base.GetbyteAsString(ColumnNames.ACA_AnulaDocumentos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ACA_AnulaDocumentos);
				else
					this.ACA_AnulaDocumentos = base.SetbyteAsString(ColumnNames.ACA_AnulaDocumentos, value);
			}
		}

		public virtual string s_ACA_EnviaDocumentos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ACA_EnviaDocumentos) ? string.Empty : base.GetbyteAsString(ColumnNames.ACA_EnviaDocumentos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ACA_EnviaDocumentos);
				else
					this.ACA_EnviaDocumentos = base.SetbyteAsString(ColumnNames.ACA_EnviaDocumentos, value);
			}
		}

		public virtual string s_ACA_FirmaDocumentos
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ACA_FirmaDocumentos) ? string.Empty : base.GetbyteAsString(ColumnNames.ACA_FirmaDocumentos);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ACA_FirmaDocumentos);
				else
					this.ACA_FirmaDocumentos = base.SetbyteAsString(ColumnNames.ACA_FirmaDocumentos, value);
			}
		}

		public virtual string s_ACTIVE
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ACTIVE) ? string.Empty : base.GetbyteAsString(ColumnNames.ACTIVE);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ACTIVE);
				else
					this.ACTIVE = base.SetbyteAsString(ColumnNames.ACTIVE, value);
			}
		}

		public virtual string s_NroResol
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.NroResol) ? string.Empty : base.GetstringAsString(ColumnNames.NroResol);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.NroResol);
				else
					this.NroResol = base.SetstringAsString(ColumnNames.NroResol, value);
			}
		}

		public virtual string s_FchResol
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.FchResol) ? string.Empty : base.GetstringAsString(ColumnNames.FchResol);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.FchResol);
				else
					this.FchResol = base.SetstringAsString(ColumnNames.FchResol, value);
			}
		}


		#endregion			
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter USERID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.USERID, Parameters.USERID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ACA_RUT
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ACA_RUT, Parameters.ACA_RUT);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fecha_vig_desde
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fecha_vig_desde, Parameters.Fecha_vig_desde);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Fecha_vig_hasta
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Fecha_vig_hasta, Parameters.Fecha_vig_hasta);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Ruta_certificado
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Ruta_certificado, Parameters.Ruta_certificado);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Ruta_clave
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Ruta_clave, Parameters.Ruta_clave);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Contrasenia_clave
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Contrasenia_clave, Parameters.Contrasenia_clave);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ACA_SolicitaFolio
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ACA_SolicitaFolio, Parameters.ACA_SolicitaFolio);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ACA_AnulaDocumentos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ACA_AnulaDocumentos, Parameters.ACA_AnulaDocumentos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ACA_EnviaDocumentos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ACA_EnviaDocumentos, Parameters.ACA_EnviaDocumentos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ACA_FirmaDocumentos
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ACA_FirmaDocumentos, Parameters.ACA_FirmaDocumentos);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ACTIVE
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ACTIVE, Parameters.ACTIVE);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter NroResol
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.NroResol, Parameters.NroResol);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter FchResol
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.FchResol, Parameters.FchResol);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter USERID
		    {
				get
		        {
					if(_USERID_W == null)
	        	    {
						_USERID_W = TearOff.USERID;
					}
					return _USERID_W;
				}
			}

			public WhereParameter ACA_RUT
		    {
				get
		        {
					if(_ACA_RUT_W == null)
	        	    {
						_ACA_RUT_W = TearOff.ACA_RUT;
					}
					return _ACA_RUT_W;
				}
			}

			public WhereParameter Fecha_vig_desde
		    {
				get
		        {
					if(_Fecha_vig_desde_W == null)
	        	    {
						_Fecha_vig_desde_W = TearOff.Fecha_vig_desde;
					}
					return _Fecha_vig_desde_W;
				}
			}

			public WhereParameter Fecha_vig_hasta
		    {
				get
		        {
					if(_Fecha_vig_hasta_W == null)
	        	    {
						_Fecha_vig_hasta_W = TearOff.Fecha_vig_hasta;
					}
					return _Fecha_vig_hasta_W;
				}
			}

			public WhereParameter Ruta_certificado
		    {
				get
		        {
					if(_Ruta_certificado_W == null)
	        	    {
						_Ruta_certificado_W = TearOff.Ruta_certificado;
					}
					return _Ruta_certificado_W;
				}
			}

			public WhereParameter Ruta_clave
		    {
				get
		        {
					if(_Ruta_clave_W == null)
	        	    {
						_Ruta_clave_W = TearOff.Ruta_clave;
					}
					return _Ruta_clave_W;
				}
			}

			public WhereParameter Contrasenia_clave
		    {
				get
		        {
					if(_Contrasenia_clave_W == null)
	        	    {
						_Contrasenia_clave_W = TearOff.Contrasenia_clave;
					}
					return _Contrasenia_clave_W;
				}
			}

			public WhereParameter ACA_SolicitaFolio
		    {
				get
		        {
					if(_ACA_SolicitaFolio_W == null)
	        	    {
						_ACA_SolicitaFolio_W = TearOff.ACA_SolicitaFolio;
					}
					return _ACA_SolicitaFolio_W;
				}
			}

			public WhereParameter ACA_AnulaDocumentos
		    {
				get
		        {
					if(_ACA_AnulaDocumentos_W == null)
	        	    {
						_ACA_AnulaDocumentos_W = TearOff.ACA_AnulaDocumentos;
					}
					return _ACA_AnulaDocumentos_W;
				}
			}

			public WhereParameter ACA_EnviaDocumentos
		    {
				get
		        {
					if(_ACA_EnviaDocumentos_W == null)
	        	    {
						_ACA_EnviaDocumentos_W = TearOff.ACA_EnviaDocumentos;
					}
					return _ACA_EnviaDocumentos_W;
				}
			}

			public WhereParameter ACA_FirmaDocumentos
		    {
				get
		        {
					if(_ACA_FirmaDocumentos_W == null)
	        	    {
						_ACA_FirmaDocumentos_W = TearOff.ACA_FirmaDocumentos;
					}
					return _ACA_FirmaDocumentos_W;
				}
			}

			public WhereParameter ACTIVE
		    {
				get
		        {
					if(_ACTIVE_W == null)
	        	    {
						_ACTIVE_W = TearOff.ACTIVE;
					}
					return _ACTIVE_W;
				}
			}

			public WhereParameter NroResol
		    {
				get
		        {
					if(_NroResol_W == null)
	        	    {
						_NroResol_W = TearOff.NroResol;
					}
					return _NroResol_W;
				}
			}

			public WhereParameter FchResol
		    {
				get
		        {
					if(_FchResol_W == null)
	        	    {
						_FchResol_W = TearOff.FchResol;
					}
					return _FchResol_W;
				}
			}

			private WhereParameter _USERID_W = null;
			private WhereParameter _ACA_RUT_W = null;
			private WhereParameter _Fecha_vig_desde_W = null;
			private WhereParameter _Fecha_vig_hasta_W = null;
			private WhereParameter _Ruta_certificado_W = null;
			private WhereParameter _Ruta_clave_W = null;
			private WhereParameter _Contrasenia_clave_W = null;
			private WhereParameter _ACA_SolicitaFolio_W = null;
			private WhereParameter _ACA_AnulaDocumentos_W = null;
			private WhereParameter _ACA_EnviaDocumentos_W = null;
			private WhereParameter _ACA_FirmaDocumentos_W = null;
			private WhereParameter _ACTIVE_W = null;
			private WhereParameter _NroResol_W = null;
			private WhereParameter _FchResol_W = null;

			public void WhereClauseReset()
			{
				_USERID_W = null;
				_ACA_RUT_W = null;
				_Fecha_vig_desde_W = null;
				_Fecha_vig_hasta_W = null;
				_Ruta_certificado_W = null;
				_Ruta_clave_W = null;
				_Contrasenia_clave_W = null;
				_ACA_SolicitaFolio_W = null;
				_ACA_AnulaDocumentos_W = null;
				_ACA_EnviaDocumentos_W = null;
				_ACA_FirmaDocumentos_W = null;
				_ACTIVE_W = null;
				_NroResol_W = null;
				_FchResol_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter USERID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.USERID, Parameters.USERID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ACA_RUT
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ACA_RUT, Parameters.ACA_RUT);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fecha_vig_desde
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fecha_vig_desde, Parameters.Fecha_vig_desde);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Fecha_vig_hasta
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Fecha_vig_hasta, Parameters.Fecha_vig_hasta);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Ruta_certificado
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ruta_certificado, Parameters.Ruta_certificado);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Ruta_clave
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Ruta_clave, Parameters.Ruta_clave);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Contrasenia_clave
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Contrasenia_clave, Parameters.Contrasenia_clave);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ACA_SolicitaFolio
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ACA_SolicitaFolio, Parameters.ACA_SolicitaFolio);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ACA_AnulaDocumentos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ACA_AnulaDocumentos, Parameters.ACA_AnulaDocumentos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ACA_EnviaDocumentos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ACA_EnviaDocumentos, Parameters.ACA_EnviaDocumentos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ACA_FirmaDocumentos
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ACA_FirmaDocumentos, Parameters.ACA_FirmaDocumentos);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ACTIVE
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ACTIVE, Parameters.ACTIVE);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter NroResol
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.NroResol, Parameters.NroResol);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter FchResol
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.FchResol, Parameters.FchResol);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter USERID
		    {
				get
		        {
					if(_USERID_W == null)
	        	    {
						_USERID_W = TearOff.USERID;
					}
					return _USERID_W;
				}
			}

			public AggregateParameter ACA_RUT
		    {
				get
		        {
					if(_ACA_RUT_W == null)
	        	    {
						_ACA_RUT_W = TearOff.ACA_RUT;
					}
					return _ACA_RUT_W;
				}
			}

			public AggregateParameter Fecha_vig_desde
		    {
				get
		        {
					if(_Fecha_vig_desde_W == null)
	        	    {
						_Fecha_vig_desde_W = TearOff.Fecha_vig_desde;
					}
					return _Fecha_vig_desde_W;
				}
			}

			public AggregateParameter Fecha_vig_hasta
		    {
				get
		        {
					if(_Fecha_vig_hasta_W == null)
	        	    {
						_Fecha_vig_hasta_W = TearOff.Fecha_vig_hasta;
					}
					return _Fecha_vig_hasta_W;
				}
			}

			public AggregateParameter Ruta_certificado
		    {
				get
		        {
					if(_Ruta_certificado_W == null)
	        	    {
						_Ruta_certificado_W = TearOff.Ruta_certificado;
					}
					return _Ruta_certificado_W;
				}
			}

			public AggregateParameter Ruta_clave
		    {
				get
		        {
					if(_Ruta_clave_W == null)
	        	    {
						_Ruta_clave_W = TearOff.Ruta_clave;
					}
					return _Ruta_clave_W;
				}
			}

			public AggregateParameter Contrasenia_clave
		    {
				get
		        {
					if(_Contrasenia_clave_W == null)
	        	    {
						_Contrasenia_clave_W = TearOff.Contrasenia_clave;
					}
					return _Contrasenia_clave_W;
				}
			}

			public AggregateParameter ACA_SolicitaFolio
		    {
				get
		        {
					if(_ACA_SolicitaFolio_W == null)
	        	    {
						_ACA_SolicitaFolio_W = TearOff.ACA_SolicitaFolio;
					}
					return _ACA_SolicitaFolio_W;
				}
			}

			public AggregateParameter ACA_AnulaDocumentos
		    {
				get
		        {
					if(_ACA_AnulaDocumentos_W == null)
	        	    {
						_ACA_AnulaDocumentos_W = TearOff.ACA_AnulaDocumentos;
					}
					return _ACA_AnulaDocumentos_W;
				}
			}

			public AggregateParameter ACA_EnviaDocumentos
		    {
				get
		        {
					if(_ACA_EnviaDocumentos_W == null)
	        	    {
						_ACA_EnviaDocumentos_W = TearOff.ACA_EnviaDocumentos;
					}
					return _ACA_EnviaDocumentos_W;
				}
			}

			public AggregateParameter ACA_FirmaDocumentos
		    {
				get
		        {
					if(_ACA_FirmaDocumentos_W == null)
	        	    {
						_ACA_FirmaDocumentos_W = TearOff.ACA_FirmaDocumentos;
					}
					return _ACA_FirmaDocumentos_W;
				}
			}

			public AggregateParameter ACTIVE
		    {
				get
		        {
					if(_ACTIVE_W == null)
	        	    {
						_ACTIVE_W = TearOff.ACTIVE;
					}
					return _ACTIVE_W;
				}
			}

			public AggregateParameter NroResol
		    {
				get
		        {
					if(_NroResol_W == null)
	        	    {
						_NroResol_W = TearOff.NroResol;
					}
					return _NroResol_W;
				}
			}

			public AggregateParameter FchResol
		    {
				get
		        {
					if(_FchResol_W == null)
	        	    {
						_FchResol_W = TearOff.FchResol;
					}
					return _FchResol_W;
				}
			}

			private AggregateParameter _USERID_W = null;
			private AggregateParameter _ACA_RUT_W = null;
			private AggregateParameter _Fecha_vig_desde_W = null;
			private AggregateParameter _Fecha_vig_hasta_W = null;
			private AggregateParameter _Ruta_certificado_W = null;
			private AggregateParameter _Ruta_clave_W = null;
			private AggregateParameter _Contrasenia_clave_W = null;
			private AggregateParameter _ACA_SolicitaFolio_W = null;
			private AggregateParameter _ACA_AnulaDocumentos_W = null;
			private AggregateParameter _ACA_EnviaDocumentos_W = null;
			private AggregateParameter _ACA_FirmaDocumentos_W = null;
			private AggregateParameter _ACTIVE_W = null;
			private AggregateParameter _NroResol_W = null;
			private AggregateParameter _FchResol_W = null;

			public void AggregateClauseReset()
			{
				_USERID_W = null;
				_ACA_RUT_W = null;
				_Fecha_vig_desde_W = null;
				_Fecha_vig_hasta_W = null;
				_Ruta_certificado_W = null;
				_Ruta_clave_W = null;
				_Contrasenia_clave_W = null;
				_ACA_SolicitaFolio_W = null;
				_ACA_AnulaDocumentos_W = null;
				_ACA_EnviaDocumentos_W = null;
				_ACA_FirmaDocumentos_W = null;
				_ACTIVE_W = null;
				_NroResol_W = null;
				_FchResol_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
			return null;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
			return null;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
			return null;
		}
	}
}
