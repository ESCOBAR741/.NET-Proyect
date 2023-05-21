﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeguimientoGasto
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DBSeguimientoGastos")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertDepartamentos(Departamentos instance);
    partial void UpdateDepartamentos(Departamentos instance);
    partial void DeleteDepartamentos(Departamentos instance);
    partial void InsertGastos(Gastos instance);
    partial void UpdateGastos(Gastos instance);
    partial void DeleteGastos(Gastos instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::SeguimientoGasto.Properties.Settings.Default.DBSeguimientoGastosConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Departamentos> Departamentos
		{
			get
			{
				return this.GetTable<Departamentos>();
			}
		}
		
		public System.Data.Linq.Table<Gastos> Gastos
		{
			get
			{
				return this.GetTable<Gastos>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departamentos")]
	public partial class Departamentos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _idDepto;
		
		private string _nombreDepto;
		
		private EntitySet<Usuarios> _Usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidDeptoChanging(byte value);
    partial void OnidDeptoChanged();
    partial void OnnombreDeptoChanging(string value);
    partial void OnnombreDeptoChanged();
    #endregion
		
		public Departamentos()
		{
			this._Usuarios = new EntitySet<Usuarios>(new Action<Usuarios>(this.attach_Usuarios), new Action<Usuarios>(this.detach_Usuarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDepto", AutoSync=AutoSync.OnInsert, DbType="TinyInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public byte idDepto
		{
			get
			{
				return this._idDepto;
			}
			set
			{
				if ((this._idDepto != value))
				{
					this.OnidDeptoChanging(value);
					this.SendPropertyChanging();
					this._idDepto = value;
					this.SendPropertyChanged("idDepto");
					this.OnidDeptoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreDepto", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombreDepto
		{
			get
			{
				return this._nombreDepto;
			}
			set
			{
				if ((this._nombreDepto != value))
				{
					this.OnnombreDeptoChanging(value);
					this.SendPropertyChanging();
					this._nombreDepto = value;
					this.SendPropertyChanged("nombreDepto");
					this.OnnombreDeptoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamentos_Usuarios", Storage="_Usuarios", ThisKey="idDepto", OtherKey="idDepto")]
		public EntitySet<Usuarios> Usuarios
		{
			get
			{
				return this._Usuarios;
			}
			set
			{
				this._Usuarios.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Usuarios(Usuarios entity)
		{
			this.SendPropertyChanging();
			entity.Departamentos = this;
		}
		
		private void detach_Usuarios(Usuarios entity)
		{
			this.SendPropertyChanging();
			entity.Departamentos = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Gastos")]
	public partial class Gastos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idGasto;
		
		private string _tipoGasto;
		
		private string _detalle;
		
		private string _descripcion;
		
		private int _monto;
		
		private System.Nullable<System.DateTime> _fechaGasto;
		
		private int _idUsuario;
		
		private EntityRef<Usuarios> _Usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidGastoChanging(int value);
    partial void OnidGastoChanged();
    partial void OntipoGastoChanging(string value);
    partial void OntipoGastoChanged();
    partial void OndetalleChanging(string value);
    partial void OndetalleChanged();
    partial void OndescripcionChanging(string value);
    partial void OndescripcionChanged();
    partial void OnmontoChanging(int value);
    partial void OnmontoChanged();
    partial void OnfechaGastoChanging(System.Nullable<System.DateTime> value);
    partial void OnfechaGastoChanged();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    #endregion
		
		public Gastos()
		{
			this._Usuarios = default(EntityRef<Usuarios>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idGasto", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idGasto
		{
			get
			{
				return this._idGasto;
			}
			set
			{
				if ((this._idGasto != value))
				{
					this.OnidGastoChanging(value);
					this.SendPropertyChanging();
					this._idGasto = value;
					this.SendPropertyChanged("idGasto");
					this.OnidGastoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipoGasto", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string tipoGasto
		{
			get
			{
				return this._tipoGasto;
			}
			set
			{
				if ((this._tipoGasto != value))
				{
					this.OntipoGastoChanging(value);
					this.SendPropertyChanging();
					this._tipoGasto = value;
					this.SendPropertyChanged("tipoGasto");
					this.OntipoGastoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_detalle", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string detalle
		{
			get
			{
				return this._detalle;
			}
			set
			{
				if ((this._detalle != value))
				{
					this.OndetalleChanging(value);
					this.SendPropertyChanging();
					this._detalle = value;
					this.SendPropertyChanged("detalle");
					this.OndetalleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descripcion", DbType="VarChar(100)")]
		public string descripcion
		{
			get
			{
				return this._descripcion;
			}
			set
			{
				if ((this._descripcion != value))
				{
					this.OndescripcionChanging(value);
					this.SendPropertyChanging();
					this._descripcion = value;
					this.SendPropertyChanged("descripcion");
					this.OndescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_monto", DbType="Int NOT NULL")]
		public int monto
		{
			get
			{
				return this._monto;
			}
			set
			{
				if ((this._monto != value))
				{
					this.OnmontoChanging(value);
					this.SendPropertyChanging();
					this._monto = value;
					this.SendPropertyChanged("monto");
					this.OnmontoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaGasto", DbType="DateTime")]
		public System.Nullable<System.DateTime> fechaGasto
		{
			get
			{
				return this._fechaGasto;
			}
			set
			{
				if ((this._fechaGasto != value))
				{
					this.OnfechaGastoChanging(value);
					this.SendPropertyChanging();
					this._fechaGasto = value;
					this.SendPropertyChanged("fechaGasto");
					this.OnfechaGastoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", DbType="Int NOT NULL")]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					if (this._Usuarios.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_Gastos", Storage="_Usuarios", ThisKey="idUsuario", OtherKey="idUsuario", IsForeignKey=true)]
		public Usuarios Usuarios
		{
			get
			{
				return this._Usuarios.Entity;
			}
			set
			{
				Usuarios previousValue = this._Usuarios.Entity;
				if (((previousValue != value) 
							|| (this._Usuarios.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuarios.Entity = null;
						previousValue.Gastos.Remove(this);
					}
					this._Usuarios.Entity = value;
					if ((value != null))
					{
						value.Gastos.Add(this);
						this._idUsuario = value.idUsuario;
					}
					else
					{
						this._idUsuario = default(int);
					}
					this.SendPropertyChanged("Usuarios");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idUsuario;
		
		private string _nombres;
		
		private string _apellidos;
		
		private string _run;
		
		private string _usuario;
		
		private string _contraseña;
		
		private byte _idDepto;
		
		private EntitySet<Gastos> _Gastos;
		
		private EntityRef<Departamentos> _Departamentos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidUsuarioChanging(int value);
    partial void OnidUsuarioChanged();
    partial void OnnombresChanging(string value);
    partial void OnnombresChanged();
    partial void OnapellidosChanging(string value);
    partial void OnapellidosChanged();
    partial void OnrunChanging(string value);
    partial void OnrunChanged();
    partial void OnusuarioChanging(string value);
    partial void OnusuarioChanged();
    partial void OncontraseñaChanging(string value);
    partial void OncontraseñaChanged();
    partial void OnidDeptoChanging(byte value);
    partial void OnidDeptoChanged();
    #endregion
		
		public Usuarios()
		{
			this._Gastos = new EntitySet<Gastos>(new Action<Gastos>(this.attach_Gastos), new Action<Gastos>(this.detach_Gastos));
			this._Departamentos = default(EntityRef<Departamentos>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idUsuario
		{
			get
			{
				return this._idUsuario;
			}
			set
			{
				if ((this._idUsuario != value))
				{
					this.OnidUsuarioChanging(value);
					this.SendPropertyChanging();
					this._idUsuario = value;
					this.SendPropertyChanged("idUsuario");
					this.OnidUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombres", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string nombres
		{
			get
			{
				return this._nombres;
			}
			set
			{
				if ((this._nombres != value))
				{
					this.OnnombresChanging(value);
					this.SendPropertyChanging();
					this._nombres = value;
					this.SendPropertyChanged("nombres");
					this.OnnombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidos", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string apellidos
		{
			get
			{
				return this._apellidos;
			}
			set
			{
				if ((this._apellidos != value))
				{
					this.OnapellidosChanging(value);
					this.SendPropertyChanging();
					this._apellidos = value;
					this.SendPropertyChanged("apellidos");
					this.OnapellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_run", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string run
		{
			get
			{
				return this._run;
			}
			set
			{
				if ((this._run != value))
				{
					this.OnrunChanging(value);
					this.SendPropertyChanging();
					this._run = value;
					this.SendPropertyChanged("run");
					this.OnrunChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usuario", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string usuario
		{
			get
			{
				return this._usuario;
			}
			set
			{
				if ((this._usuario != value))
				{
					this.OnusuarioChanging(value);
					this.SendPropertyChanging();
					this._usuario = value;
					this.SendPropertyChanged("usuario");
					this.OnusuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contraseña", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string contraseña
		{
			get
			{
				return this._contraseña;
			}
			set
			{
				if ((this._contraseña != value))
				{
					this.OncontraseñaChanging(value);
					this.SendPropertyChanging();
					this._contraseña = value;
					this.SendPropertyChanged("contraseña");
					this.OncontraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idDepto", DbType="TinyInt NOT NULL")]
		public byte idDepto
		{
			get
			{
				return this._idDepto;
			}
			set
			{
				if ((this._idDepto != value))
				{
					if (this._Departamentos.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidDeptoChanging(value);
					this.SendPropertyChanging();
					this._idDepto = value;
					this.SendPropertyChanged("idDepto");
					this.OnidDeptoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_Gastos", Storage="_Gastos", ThisKey="idUsuario", OtherKey="idUsuario")]
		public EntitySet<Gastos> Gastos
		{
			get
			{
				return this._Gastos;
			}
			set
			{
				this._Gastos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Departamentos_Usuarios", Storage="_Departamentos", ThisKey="idDepto", OtherKey="idDepto", IsForeignKey=true)]
		public Departamentos Departamentos
		{
			get
			{
				return this._Departamentos.Entity;
			}
			set
			{
				Departamentos previousValue = this._Departamentos.Entity;
				if (((previousValue != value) 
							|| (this._Departamentos.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Departamentos.Entity = null;
						previousValue.Usuarios.Remove(this);
					}
					this._Departamentos.Entity = value;
					if ((value != null))
					{
						value.Usuarios.Add(this);
						this._idDepto = value.idDepto;
					}
					else
					{
						this._idDepto = default(byte);
					}
					this.SendPropertyChanged("Departamentos");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Gastos(Gastos entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = this;
		}
		
		private void detach_Gastos(Gastos entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = null;
		}
	}
}
#pragma warning restore 1591
