﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db1002584-storyhub")]
public partial class AuthorizationLinqDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  #endregion
	
	public AuthorizationLinqDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["db1002584_storyhubConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public AuthorizationLinqDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AuthorizationLinqDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AuthorizationLinqDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public AuthorizationLinqDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _Email;
	
	private string _Password;
	
	private bool _Activated;
	
	private bool _WantsNews;
	
	private string _AppLanguage;
	
	private bool _UseLiveTile;
	
	private bool _HasNewContent;
	
	private string _UiDesign;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnActivatedChanging(bool value);
    partial void OnActivatedChanged();
    partial void OnWantsNewsChanging(bool value);
    partial void OnWantsNewsChanged();
    partial void OnAppLanguageChanging(string value);
    partial void OnAppLanguageChanged();
    partial void OnUseLiveTileChanging(bool value);
    partial void OnUseLiveTileChanged();
    partial void OnHasNewContentChanging(bool value);
    partial void OnHasNewContentChanged();
    partial void OnUiDesignChanging(string value);
    partial void OnUiDesignChanged();
    #endregion
	
	public User()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(120) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Activated", DbType="Bit NOT NULL")]
	public bool Activated
	{
		get
		{
			return this._Activated;
		}
		set
		{
			if ((this._Activated != value))
			{
				this.OnActivatedChanging(value);
				this.SendPropertyChanging();
				this._Activated = value;
				this.SendPropertyChanged("Activated");
				this.OnActivatedChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WantsNews", DbType="Bit NOT NULL")]
	public bool WantsNews
	{
		get
		{
			return this._WantsNews;
		}
		set
		{
			if ((this._WantsNews != value))
			{
				this.OnWantsNewsChanging(value);
				this.SendPropertyChanging();
				this._WantsNews = value;
				this.SendPropertyChanged("WantsNews");
				this.OnWantsNewsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppLanguage", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string AppLanguage
	{
		get
		{
			return this._AppLanguage;
		}
		set
		{
			if ((this._AppLanguage != value))
			{
				this.OnAppLanguageChanging(value);
				this.SendPropertyChanging();
				this._AppLanguage = value;
				this.SendPropertyChanged("AppLanguage");
				this.OnAppLanguageChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UseLiveTile", DbType="Bit NOT NULL")]
	public bool UseLiveTile
	{
		get
		{
			return this._UseLiveTile;
		}
		set
		{
			if ((this._UseLiveTile != value))
			{
				this.OnUseLiveTileChanging(value);
				this.SendPropertyChanging();
				this._UseLiveTile = value;
				this.SendPropertyChanged("UseLiveTile");
				this.OnUseLiveTileChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HasNewContent", DbType="Bit NOT NULL")]
	public bool HasNewContent
	{
		get
		{
			return this._HasNewContent;
		}
		set
		{
			if ((this._HasNewContent != value))
			{
				this.OnHasNewContentChanging(value);
				this.SendPropertyChanging();
				this._HasNewContent = value;
				this.SendPropertyChanged("HasNewContent");
				this.OnHasNewContentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UiDesign", DbType="VarChar(50) NOT NULL")]
	public string UiDesign
	{
		get
		{
			return this._UiDesign;
		}
		set
		{
			if ((this._UiDesign != value))
			{
				this.OnUiDesignChanging(value);
				this.SendPropertyChanging();
				this._UiDesign = value;
				this.SendPropertyChanged("UiDesign");
				this.OnUiDesignChanged();
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
#pragma warning restore 1591
