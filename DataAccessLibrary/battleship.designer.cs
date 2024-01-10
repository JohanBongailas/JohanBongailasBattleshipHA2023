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

namespace DataAccessLibrary
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_battleship")]
	public partial class battleshipDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAttack(Attack instance);
    partial void UpdateAttack(Attack instance);
    partial void DeleteAttack(Attack instance);
    partial void InsertGame(Game instance);
    partial void UpdateGame(Game instance);
    partial void DeleteGame(Game instance);
    partial void InsertGameShipConfiguration(GameShipConfiguration instance);
    partial void UpdateGameShipConfiguration(GameShipConfiguration instance);
    partial void DeleteGameShipConfiguration(GameShipConfiguration instance);
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    partial void InsertShip(Ship instance);
    partial void UpdateShip(Ship instance);
    partial void DeleteShip(Ship instance);
    #endregion
		
		public battleshipDataContext() : 
				base(global::DataAccessLibrary.Properties.Settings.Default.db_battleshipConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public battleshipDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public battleshipDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public battleshipDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public battleshipDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Attack> Attacks
		{
			get
			{
				return this.GetTable<Attack>();
			}
		}
		
		public System.Data.Linq.Table<Game> Games
		{
			get
			{
				return this.GetTable<Game>();
			}
		}
		
		public System.Data.Linq.Table<GameShipConfiguration> GameShipConfigurations
		{
			get
			{
				return this.GetTable<GameShipConfiguration>();
			}
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
		
		public System.Data.Linq.Table<Ship> Ships
		{
			get
			{
				return this.GetTable<Ship>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="battleship.Attacks")]
	public partial class Attack : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Coordinate;
		
		private bool _Hit;
		
		private System.Nullable<int> _GameFK;
		
		private System.Nullable<int> _PlayerID;
		
		private EntityRef<Game> _Game;
		
		private EntityRef<Player> _Player;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCoordinateChanging(string value);
    partial void OnCoordinateChanged();
    partial void OnHitChanging(bool value);
    partial void OnHitChanged();
    partial void OnGameFKChanging(System.Nullable<int> value);
    partial void OnGameFKChanged();
    partial void OnPlayerIDChanging(System.Nullable<int> value);
    partial void OnPlayerIDChanged();
    #endregion
		
		public Attack()
		{
			this._Game = default(EntityRef<Game>);
			this._Player = default(EntityRef<Player>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coordinate", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Coordinate
		{
			get
			{
				return this._Coordinate;
			}
			set
			{
				if ((this._Coordinate != value))
				{
					this.OnCoordinateChanging(value);
					this.SendPropertyChanging();
					this._Coordinate = value;
					this.SendPropertyChanged("Coordinate");
					this.OnCoordinateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hit", DbType="Bit NOT NULL")]
		public bool Hit
		{
			get
			{
				return this._Hit;
			}
			set
			{
				if ((this._Hit != value))
				{
					this.OnHitChanging(value);
					this.SendPropertyChanging();
					this._Hit = value;
					this.SendPropertyChanged("Hit");
					this.OnHitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameFK", DbType="Int")]
		public System.Nullable<int> GameFK
		{
			get
			{
				return this._GameFK;
			}
			set
			{
				if ((this._GameFK != value))
				{
					if (this._Game.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGameFKChanging(value);
					this.SendPropertyChanging();
					this._GameFK = value;
					this.SendPropertyChanged("GameFK");
					this.OnGameFKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerID", DbType="Int")]
		public System.Nullable<int> PlayerID
		{
			get
			{
				return this._PlayerID;
			}
			set
			{
				if ((this._PlayerID != value))
				{
					if (this._Player.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayerIDChanging(value);
					this.SendPropertyChanging();
					this._PlayerID = value;
					this.SendPropertyChanged("PlayerID");
					this.OnPlayerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_Attack", Storage="_Game", ThisKey="GameFK", OtherKey="ID", IsForeignKey=true)]
		public Game Game
		{
			get
			{
				return this._Game.Entity;
			}
			set
			{
				Game previousValue = this._Game.Entity;
				if (((previousValue != value) 
							|| (this._Game.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Game.Entity = null;
						previousValue.Attacks.Remove(this);
					}
					this._Game.Entity = value;
					if ((value != null))
					{
						value.Attacks.Add(this);
						this._GameFK = value.ID;
					}
					else
					{
						this._GameFK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Game");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_Attack", Storage="_Player", ThisKey="PlayerID", OtherKey="ID", IsForeignKey=true)]
		public Player Player
		{
			get
			{
				return this._Player.Entity;
			}
			set
			{
				Player previousValue = this._Player.Entity;
				if (((previousValue != value) 
							|| (this._Player.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player.Entity = null;
						previousValue.Attacks.Remove(this);
					}
					this._Player.Entity = value;
					if ((value != null))
					{
						value.Attacks.Add(this);
						this._PlayerID = value.ID;
					}
					else
					{
						this._PlayerID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Player");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="battleship.Games")]
	public partial class Game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Title;
		
		private System.Nullable<int> _CreatorFK;
		
		private System.Nullable<int> _OpponentFK;
		
		private bool _Complete;
		
		private EntitySet<Attack> _Attacks;
		
		private EntitySet<GameShipConfiguration> _GameShipConfigurations;
		
		private EntityRef<Player> _Player;
		
		private EntityRef<Player> _Player1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnCreatorFKChanging(System.Nullable<int> value);
    partial void OnCreatorFKChanged();
    partial void OnOpponentFKChanging(System.Nullable<int> value);
    partial void OnOpponentFKChanged();
    partial void OnCompleteChanging(bool value);
    partial void OnCompleteChanged();
    #endregion
		
		public Game()
		{
			this._Attacks = new EntitySet<Attack>(new Action<Attack>(this.attach_Attacks), new Action<Attack>(this.detach_Attacks));
			this._GameShipConfigurations = new EntitySet<GameShipConfiguration>(new Action<GameShipConfiguration>(this.attach_GameShipConfigurations), new Action<GameShipConfiguration>(this.detach_GameShipConfigurations));
			this._Player = default(EntityRef<Player>);
			this._Player1 = default(EntityRef<Player>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatorFK", DbType="Int")]
		public System.Nullable<int> CreatorFK
		{
			get
			{
				return this._CreatorFK;
			}
			set
			{
				if ((this._CreatorFK != value))
				{
					if (this._Player.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCreatorFKChanging(value);
					this.SendPropertyChanging();
					this._CreatorFK = value;
					this.SendPropertyChanged("CreatorFK");
					this.OnCreatorFKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpponentFK", DbType="Int")]
		public System.Nullable<int> OpponentFK
		{
			get
			{
				return this._OpponentFK;
			}
			set
			{
				if ((this._OpponentFK != value))
				{
					if (this._Player1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOpponentFKChanging(value);
					this.SendPropertyChanging();
					this._OpponentFK = value;
					this.SendPropertyChanged("OpponentFK");
					this.OnOpponentFKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Complete", DbType="Bit NOT NULL")]
		public bool Complete
		{
			get
			{
				return this._Complete;
			}
			set
			{
				if ((this._Complete != value))
				{
					this.OnCompleteChanging(value);
					this.SendPropertyChanging();
					this._Complete = value;
					this.SendPropertyChanged("Complete");
					this.OnCompleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_Attack", Storage="_Attacks", ThisKey="ID", OtherKey="GameFK")]
		public EntitySet<Attack> Attacks
		{
			get
			{
				return this._Attacks;
			}
			set
			{
				this._Attacks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_GameShipConfiguration", Storage="_GameShipConfigurations", ThisKey="ID", OtherKey="GameFK")]
		public EntitySet<GameShipConfiguration> GameShipConfigurations
		{
			get
			{
				return this._GameShipConfigurations;
			}
			set
			{
				this._GameShipConfigurations.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_Game", Storage="_Player", ThisKey="CreatorFK", OtherKey="ID", IsForeignKey=true)]
		public Player Player
		{
			get
			{
				return this._Player.Entity;
			}
			set
			{
				Player previousValue = this._Player.Entity;
				if (((previousValue != value) 
							|| (this._Player.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player.Entity = null;
						previousValue.Games.Remove(this);
					}
					this._Player.Entity = value;
					if ((value != null))
					{
						value.Games.Add(this);
						this._CreatorFK = value.ID;
					}
					else
					{
						this._CreatorFK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Player");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_Game1", Storage="_Player1", ThisKey="OpponentFK", OtherKey="ID", IsForeignKey=true)]
		public Player Player1
		{
			get
			{
				return this._Player1.Entity;
			}
			set
			{
				Player previousValue = this._Player1.Entity;
				if (((previousValue != value) 
							|| (this._Player1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player1.Entity = null;
						previousValue.Games1.Remove(this);
					}
					this._Player1.Entity = value;
					if ((value != null))
					{
						value.Games1.Add(this);
						this._OpponentFK = value.ID;
					}
					else
					{
						this._OpponentFK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Player1");
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
		
		private void attach_Attacks(Attack entity)
		{
			this.SendPropertyChanging();
			entity.Game = this;
		}
		
		private void detach_Attacks(Attack entity)
		{
			this.SendPropertyChanging();
			entity.Game = null;
		}
		
		private void attach_GameShipConfigurations(GameShipConfiguration entity)
		{
			this.SendPropertyChanging();
			entity.Game = this;
		}
		
		private void detach_GameShipConfigurations(GameShipConfiguration entity)
		{
			this.SendPropertyChanging();
			entity.Game = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="battleship.GameShipConfigurations")]
	public partial class GameShipConfiguration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _PlayerFK;
		
		private System.Nullable<int> _GameFK;
		
		private string _Coordinate;
		
		private System.Nullable<int> _ShipFK;
		
		private EntityRef<Game> _Game;
		
		private EntityRef<Player> _Player;
		
		private EntityRef<Ship> _Ship;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnPlayerFKChanging(System.Nullable<int> value);
    partial void OnPlayerFKChanged();
    partial void OnGameFKChanging(System.Nullable<int> value);
    partial void OnGameFKChanged();
    partial void OnCoordinateChanging(string value);
    partial void OnCoordinateChanged();
    partial void OnShipFKChanging(System.Nullable<int> value);
    partial void OnShipFKChanged();
    #endregion
		
		public GameShipConfiguration()
		{
			this._Game = default(EntityRef<Game>);
			this._Player = default(EntityRef<Player>);
			this._Ship = default(EntityRef<Ship>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerFK", DbType="Int")]
		public System.Nullable<int> PlayerFK
		{
			get
			{
				return this._PlayerFK;
			}
			set
			{
				if ((this._PlayerFK != value))
				{
					if (this._Player.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayerFKChanging(value);
					this.SendPropertyChanging();
					this._PlayerFK = value;
					this.SendPropertyChanged("PlayerFK");
					this.OnPlayerFKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameFK", DbType="Int")]
		public System.Nullable<int> GameFK
		{
			get
			{
				return this._GameFK;
			}
			set
			{
				if ((this._GameFK != value))
				{
					if (this._Game.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGameFKChanging(value);
					this.SendPropertyChanging();
					this._GameFK = value;
					this.SendPropertyChanged("GameFK");
					this.OnGameFKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Coordinate", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Coordinate
		{
			get
			{
				return this._Coordinate;
			}
			set
			{
				if ((this._Coordinate != value))
				{
					this.OnCoordinateChanging(value);
					this.SendPropertyChanging();
					this._Coordinate = value;
					this.SendPropertyChanged("Coordinate");
					this.OnCoordinateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipFK", DbType="Int")]
		public System.Nullable<int> ShipFK
		{
			get
			{
				return this._ShipFK;
			}
			set
			{
				if ((this._ShipFK != value))
				{
					if (this._Ship.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnShipFKChanging(value);
					this.SendPropertyChanging();
					this._ShipFK = value;
					this.SendPropertyChanged("ShipFK");
					this.OnShipFKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_GameShipConfiguration", Storage="_Game", ThisKey="GameFK", OtherKey="ID", IsForeignKey=true)]
		public Game Game
		{
			get
			{
				return this._Game.Entity;
			}
			set
			{
				Game previousValue = this._Game.Entity;
				if (((previousValue != value) 
							|| (this._Game.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Game.Entity = null;
						previousValue.GameShipConfigurations.Remove(this);
					}
					this._Game.Entity = value;
					if ((value != null))
					{
						value.GameShipConfigurations.Add(this);
						this._GameFK = value.ID;
					}
					else
					{
						this._GameFK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Game");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_GameShipConfiguration", Storage="_Player", ThisKey="PlayerFK", OtherKey="ID", IsForeignKey=true)]
		public Player Player
		{
			get
			{
				return this._Player.Entity;
			}
			set
			{
				Player previousValue = this._Player.Entity;
				if (((previousValue != value) 
							|| (this._Player.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player.Entity = null;
						previousValue.GameShipConfigurations.Remove(this);
					}
					this._Player.Entity = value;
					if ((value != null))
					{
						value.GameShipConfigurations.Add(this);
						this._PlayerFK = value.ID;
					}
					else
					{
						this._PlayerFK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Player");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ship_GameShipConfiguration", Storage="_Ship", ThisKey="ShipFK", OtherKey="ID", IsForeignKey=true)]
		public Ship Ship
		{
			get
			{
				return this._Ship.Entity;
			}
			set
			{
				Ship previousValue = this._Ship.Entity;
				if (((previousValue != value) 
							|| (this._Ship.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ship.Entity = null;
						previousValue.GameShipConfigurations.Remove(this);
					}
					this._Ship.Entity = value;
					if ((value != null))
					{
						value.GameShipConfigurations.Add(this);
						this._ShipFK = value.ID;
					}
					else
					{
						this._ShipFK = default(Nullable<int>);
					}
					this.SendPropertyChanged("Ship");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="battleship.Players")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Username;
		
		private string _Password;
		
		private EntitySet<Attack> _Attacks;
		
		private EntitySet<Game> _Games;
		
		private EntitySet<Game> _Games1;
		
		private EntitySet<GameShipConfiguration> _GameShipConfigurations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Player()
		{
			this._Attacks = new EntitySet<Attack>(new Action<Attack>(this.attach_Attacks), new Action<Attack>(this.detach_Attacks));
			this._Games = new EntitySet<Game>(new Action<Game>(this.attach_Games), new Action<Game>(this.detach_Games));
			this._Games1 = new EntitySet<Game>(new Action<Game>(this.attach_Games1), new Action<Game>(this.detach_Games1));
			this._GameShipConfigurations = new EntitySet<GameShipConfiguration>(new Action<GameShipConfiguration>(this.attach_GameShipConfigurations), new Action<GameShipConfiguration>(this.detach_GameShipConfigurations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_Attack", Storage="_Attacks", ThisKey="ID", OtherKey="PlayerID")]
		public EntitySet<Attack> Attacks
		{
			get
			{
				return this._Attacks;
			}
			set
			{
				this._Attacks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_Game", Storage="_Games", ThisKey="ID", OtherKey="CreatorFK")]
		public EntitySet<Game> Games
		{
			get
			{
				return this._Games;
			}
			set
			{
				this._Games.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_Game1", Storage="_Games1", ThisKey="ID", OtherKey="OpponentFK")]
		public EntitySet<Game> Games1
		{
			get
			{
				return this._Games1;
			}
			set
			{
				this._Games1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_GameShipConfiguration", Storage="_GameShipConfigurations", ThisKey="ID", OtherKey="PlayerFK")]
		public EntitySet<GameShipConfiguration> GameShipConfigurations
		{
			get
			{
				return this._GameShipConfigurations;
			}
			set
			{
				this._GameShipConfigurations.Assign(value);
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
		
		private void attach_Attacks(Attack entity)
		{
			this.SendPropertyChanging();
			entity.Player = this;
		}
		
		private void detach_Attacks(Attack entity)
		{
			this.SendPropertyChanging();
			entity.Player = null;
		}
		
		private void attach_Games(Game entity)
		{
			this.SendPropertyChanging();
			entity.Player = this;
		}
		
		private void detach_Games(Game entity)
		{
			this.SendPropertyChanging();
			entity.Player = null;
		}
		
		private void attach_Games1(Game entity)
		{
			this.SendPropertyChanging();
			entity.Player1 = this;
		}
		
		private void detach_Games1(Game entity)
		{
			this.SendPropertyChanging();
			entity.Player1 = null;
		}
		
		private void attach_GameShipConfigurations(GameShipConfiguration entity)
		{
			this.SendPropertyChanging();
			entity.Player = this;
		}
		
		private void detach_GameShipConfigurations(GameShipConfiguration entity)
		{
			this.SendPropertyChanging();
			entity.Player = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="battleship.Ships")]
	public partial class Ship : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Title;
		
		private int _Size;
		
		private EntitySet<GameShipConfiguration> _GameShipConfigurations;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnSizeChanging(int value);
    partial void OnSizeChanged();
    #endregion
		
		public Ship()
		{
			this._GameShipConfigurations = new EntitySet<GameShipConfiguration>(new Action<GameShipConfiguration>(this.attach_GameShipConfigurations), new Action<GameShipConfiguration>(this.detach_GameShipConfigurations));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Int NOT NULL")]
		public int Size
		{
			get
			{
				return this._Size;
			}
			set
			{
				if ((this._Size != value))
				{
					this.OnSizeChanging(value);
					this.SendPropertyChanging();
					this._Size = value;
					this.SendPropertyChanged("Size");
					this.OnSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ship_GameShipConfiguration", Storage="_GameShipConfigurations", ThisKey="ID", OtherKey="ShipFK")]
		public EntitySet<GameShipConfiguration> GameShipConfigurations
		{
			get
			{
				return this._GameShipConfigurations;
			}
			set
			{
				this._GameShipConfigurations.Assign(value);
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
		
		private void attach_GameShipConfigurations(GameShipConfiguration entity)
		{
			this.SendPropertyChanging();
			entity.Ship = this;
		}
		
		private void detach_GameShipConfigurations(GameShipConfiguration entity)
		{
			this.SendPropertyChanging();
			entity.Ship = null;
		}
	}
}
#pragma warning restore 1591
