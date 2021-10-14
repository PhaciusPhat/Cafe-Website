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

namespace final.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCafe")]
	public partial class QLCafeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    partial void InsertKhuyenMai(KhuyenMai instance);
    partial void UpdateKhuyenMai(KhuyenMai instance);
    partial void DeleteKhuyenMai(KhuyenMai instance);
    partial void InsertLoaiSP(LoaiSP instance);
    partial void UpdateLoaiSP(LoaiSP instance);
    partial void DeleteLoaiSP(LoaiSP instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertCTHD(CTHD instance);
    partial void UpdateCTHD(CTHD instance);
    partial void DeleteCTHD(CTHD instance);
    #endregion
		
		public QLCafeDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLCafeConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLCafeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLCafeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLCafeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLCafeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<KhuyenMai> KhuyenMais
		{
			get
			{
				return this.GetTable<KhuyenMai>();
			}
		}
		
		public System.Data.Linq.Table<LoaiSP> LoaiSPs
		{
			get
			{
				return this.GetTable<LoaiSP>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<CTHD> CTHDs
		{
			get
			{
				return this.GetTable<CTHD>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserNameKH;
		
		private string _PassWordKH;
		
		private string _TenKH;
		
		private int _SDT;
		
		private bool _PhanQuyen;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserNameKHChanging(string value);
    partial void OnUserNameKHChanged();
    partial void OnPassWordKHChanging(string value);
    partial void OnPassWordKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnSDTChanging(int value);
    partial void OnSDTChanged();
    partial void OnPhanQuyenChanging(bool value);
    partial void OnPhanQuyenChanged();
    #endregion
		
		public TaiKhoan()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNameKH", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserNameKH
		{
			get
			{
				return this._UserNameKH;
			}
			set
			{
				if ((this._UserNameKH != value))
				{
					this.OnUserNameKHChanging(value);
					this.SendPropertyChanging();
					this._UserNameKH = value;
					this.SendPropertyChanged("UserNameKH");
					this.OnUserNameKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassWordKH", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PassWordKH
		{
			get
			{
				return this._PassWordKH;
			}
			set
			{
				if ((this._PassWordKH != value))
				{
					this.OnPassWordKHChanging(value);
					this.SendPropertyChanging();
					this._PassWordKH = value;
					this.SendPropertyChanged("PassWordKH");
					this.OnPassWordKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Int NOT NULL")]
		public int SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhanQuyen", DbType="Bit NOT NULL")]
		public bool PhanQuyen
		{
			get
			{
				return this._PhanQuyen;
			}
			set
			{
				if ((this._PhanQuyen != value))
				{
					this.OnPhanQuyenChanging(value);
					this.SendPropertyChanging();
					this._PhanQuyen = value;
					this.SendPropertyChanged("PhanQuyen");
					this.OnPhanQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_HoaDon", Storage="_HoaDons", ThisKey="UserNameKH", OtherKey="UserNameKH")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.TaiKhoan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private int _GiaSP;
		
		private int _MaLoaiSP;
		
		private string _HinhAnh;
		
		private string _ThongTinChiTiet;
		
		private EntitySet<CTHD> _CTHDs;
		
		private EntityRef<LoaiSP> _LoaiSP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnGiaSPChanging(int value);
    partial void OnGiaSPChanged();
    partial void OnMaLoaiSPChanging(int value);
    partial void OnMaLoaiSPChanged();
    partial void OnHinhAnhChanging(string value);
    partial void OnHinhAnhChanged();
    partial void OnThongTinChiTietChanging(string value);
    partial void OnThongTinChiTietChanged();
    #endregion
		
		public SanPham()
		{
			this._CTHDs = new EntitySet<CTHD>(new Action<CTHD>(this.attach_CTHDs), new Action<CTHD>(this.detach_CTHDs));
			this._LoaiSP = default(EntityRef<LoaiSP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaSP", DbType="Money NOT NULL")]
		public int GiaSP
		{
			get
			{
				return this._GiaSP;
			}
			set
			{
				if ((this._GiaSP != value))
				{
					this.OnGiaSPChanging(value);
					this.SendPropertyChanging();
					this._GiaSP = value;
					this.SendPropertyChanged("GiaSP");
					this.OnGiaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiSP", DbType="Int NOT NULL")]
		public int MaLoaiSP
		{
			get
			{
				return this._MaLoaiSP;
			}
			set
			{
				if ((this._MaLoaiSP != value))
				{
					if (this._LoaiSP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiSPChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiSP = value;
					this.SendPropertyChanged("MaLoaiSP");
					this.OnMaLoaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string HinhAnh
		{
			get
			{
				return this._HinhAnh;
			}
			set
			{
				if ((this._HinhAnh != value))
				{
					this.OnHinhAnhChanging(value);
					this.SendPropertyChanging();
					this._HinhAnh = value;
					this.SendPropertyChanged("HinhAnh");
					this.OnHinhAnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThongTinChiTiet", DbType="NText NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string ThongTinChiTiet
		{
			get
			{
				return this._ThongTinChiTiet;
			}
			set
			{
				if ((this._ThongTinChiTiet != value))
				{
					this.OnThongTinChiTietChanging(value);
					this.SendPropertyChanging();
					this._ThongTinChiTiet = value;
					this.SendPropertyChanged("ThongTinChiTiet");
					this.OnThongTinChiTietChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CTHD", Storage="_CTHDs", ThisKey="MaSP", OtherKey="MaSP")]
		public EntitySet<CTHD> CTHDs
		{
			get
			{
				return this._CTHDs;
			}
			set
			{
				this._CTHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSP_SanPham", Storage="_LoaiSP", ThisKey="MaLoaiSP", OtherKey="MaLoaiSP", IsForeignKey=true)]
		public LoaiSP LoaiSP
		{
			get
			{
				return this._LoaiSP.Entity;
			}
			set
			{
				LoaiSP previousValue = this._LoaiSP.Entity;
				if (((previousValue != value) 
							|| (this._LoaiSP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiSP.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._LoaiSP.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaLoaiSP = value.MaLoaiSP;
					}
					else
					{
						this._MaLoaiSP = default(int);
					}
					this.SendPropertyChanged("LoaiSP");
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
		
		private void attach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = this;
		}
		
		private void detach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.SanPham = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhuyenMai")]
	public partial class KhuyenMai : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKM;
		
		private string _TenKM;
		
		private string _NoiDungKM;
		
		private int _GiamGia;
		
		private System.DateTime _NgayBD;
		
		private System.DateTime _NgayKT;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKMChanging(int value);
    partial void OnMaKMChanged();
    partial void OnTenKMChanging(string value);
    partial void OnTenKMChanged();
    partial void OnNoiDungKMChanging(string value);
    partial void OnNoiDungKMChanged();
    partial void OnGiamGiaChanging(int value);
    partial void OnGiamGiaChanged();
    partial void OnNgayBDChanging(System.DateTime value);
    partial void OnNgayBDChanged();
    partial void OnNgayKTChanging(System.DateTime value);
    partial void OnNgayKTChanged();
    #endregion
		
		public KhuyenMai()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKM", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKM
		{
			get
			{
				return this._MaKM;
			}
			set
			{
				if ((this._MaKM != value))
				{
					this.OnMaKMChanging(value);
					this.SendPropertyChanging();
					this._MaKM = value;
					this.SendPropertyChanged("MaKM");
					this.OnMaKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKM", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenKM
		{
			get
			{
				return this._TenKM;
			}
			set
			{
				if ((this._TenKM != value))
				{
					this.OnTenKMChanging(value);
					this.SendPropertyChanging();
					this._TenKM = value;
					this.SendPropertyChanged("TenKM");
					this.OnTenKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDungKM", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NoiDungKM
		{
			get
			{
				return this._NoiDungKM;
			}
			set
			{
				if ((this._NoiDungKM != value))
				{
					this.OnNoiDungKMChanging(value);
					this.SendPropertyChanging();
					this._NoiDungKM = value;
					this.SendPropertyChanged("NoiDungKM");
					this.OnNoiDungKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiamGia", DbType="Int NOT NULL")]
		public int GiamGia
		{
			get
			{
				return this._GiamGia;
			}
			set
			{
				if ((this._GiamGia != value))
				{
					this.OnGiamGiaChanging(value);
					this.SendPropertyChanging();
					this._GiamGia = value;
					this.SendPropertyChanged("GiamGia");
					this.OnGiamGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayBD", DbType="Date NOT NULL")]
		public System.DateTime NgayBD
		{
			get
			{
				return this._NgayBD;
			}
			set
			{
				if ((this._NgayBD != value))
				{
					this.OnNgayBDChanging(value);
					this.SendPropertyChanging();
					this._NgayBD = value;
					this.SendPropertyChanged("NgayBD");
					this.OnNgayBDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayKT", DbType="Date NOT NULL")]
		public System.DateTime NgayKT
		{
			get
			{
				return this._NgayKT;
			}
			set
			{
				if ((this._NgayKT != value))
				{
					this.OnNgayKTChanging(value);
					this.SendPropertyChanging();
					this._NgayKT = value;
					this.SendPropertyChanged("NgayKT");
					this.OnNgayKTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhuyenMai_HoaDon", Storage="_HoaDons", ThisKey="MaKM", OtherKey="MaKM")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhuyenMai = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.KhuyenMai = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiSP")]
	public partial class LoaiSP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLoaiSP;
		
		private string _TenLoai;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiSPChanging(int value);
    partial void OnMaLoaiSPChanged();
    partial void OnTenLoaiChanging(string value);
    partial void OnTenLoaiChanged();
    #endregion
		
		public LoaiSP()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLoaiSP
		{
			get
			{
				return this._MaLoaiSP;
			}
			set
			{
				if ((this._MaLoaiSP != value))
				{
					this.OnMaLoaiSPChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiSP = value;
					this.SendPropertyChanged("MaLoaiSP");
					this.OnMaLoaiSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoai", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string TenLoai
		{
			get
			{
				return this._TenLoai;
			}
			set
			{
				if ((this._TenLoai != value))
				{
					this.OnTenLoaiChanging(value);
					this.SendPropertyChanging();
					this._TenLoai = value;
					this.SendPropertyChanged("TenLoai");
					this.OnTenLoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiSP_SanPham", Storage="_SanPhams", ThisKey="MaLoaiSP", OtherKey="MaLoaiSP")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSP = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.LoaiSP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHD;
		
		private System.Nullable<System.DateTime> _NgayMua;
		
		private int _TongTien;
		
		private string _DiaChiGiaoHang;
		
		private System.Nullable<int> _MaKM;
		
		private bool _DaMua;
		
		private string _UserNameKH;
		
		private EntitySet<CTHD> _CTHDs;
		
		private EntityRef<KhuyenMai> _KhuyenMai;
		
		private EntityRef<TaiKhoan> _TaiKhoan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    partial void OnNgayMuaChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayMuaChanged();
    partial void OnTongTienChanging(int value);
    partial void OnTongTienChanged();
    partial void OnDiaChiGiaoHangChanging(string value);
    partial void OnDiaChiGiaoHangChanged();
    partial void OnMaKMChanging(System.Nullable<int> value);
    partial void OnMaKMChanged();
    partial void OnDaMuaChanging(bool value);
    partial void OnDaMuaChanged();
    partial void OnUserNameKHChanging(string value);
    partial void OnUserNameKHChanged();
    #endregion
		
		public HoaDon()
		{
			this._CTHDs = new EntitySet<CTHD>(new Action<CTHD>(this.attach_CTHDs), new Action<CTHD>(this.detach_CTHDs));
			this._KhuyenMai = default(EntityRef<KhuyenMai>);
			this._TaiKhoan = default(EntityRef<TaiKhoan>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayMua", DbType="Date NOT NULL")]
		public System.Nullable<System.DateTime> NgayMua
		{
			get
			{
				return this._NgayMua;
			}
			set
			{
				if ((this._NgayMua != value))
				{
					this.OnNgayMuaChanging(value);
					this.SendPropertyChanging();
					this._NgayMua = value;
					this.SendPropertyChanged("NgayMua");
					this.OnNgayMuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Int NOT NULL")]
		public int TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChiGiaoHang", DbType="NChar(10) NOT NULL")]
		public string DiaChiGiaoHang
		{
			get
			{
				return this._DiaChiGiaoHang;
			}
			set
			{
				if ((this._DiaChiGiaoHang != value))
				{
					this.OnDiaChiGiaoHangChanging(value);
					this.SendPropertyChanging();
					this._DiaChiGiaoHang = value;
					this.SendPropertyChanged("DiaChiGiaoHang");
					this.OnDiaChiGiaoHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKM", DbType="Int NOT NULL")]
		public System.Nullable<int> MaKM
		{
			get
			{
				return this._MaKM;
			}
			set
			{
				if ((this._MaKM != value))
				{
					if (this._KhuyenMai.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKMChanging(value);
					this.SendPropertyChanging();
					this._MaKM = value;
					this.SendPropertyChanged("MaKM");
					this.OnMaKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaMua", DbType="Bit NOT NULL")]
		public bool DaMua
		{
			get
			{
				return this._DaMua;
			}
			set
			{
				if ((this._DaMua != value))
				{
					this.OnDaMuaChanging(value);
					this.SendPropertyChanging();
					this._DaMua = value;
					this.SendPropertyChanged("DaMua");
					this.OnDaMuaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNameKH", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string UserNameKH
		{
			get
			{
				return this._UserNameKH;
			}
			set
			{
				if ((this._UserNameKH != value))
				{
					if (this._TaiKhoan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserNameKHChanging(value);
					this.SendPropertyChanging();
					this._UserNameKH = value;
					this.SendPropertyChanged("UserNameKH");
					this.OnUserNameKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_CTHD", Storage="_CTHDs", ThisKey="MaHD", OtherKey="MaHD")]
		public EntitySet<CTHD> CTHDs
		{
			get
			{
				return this._CTHDs;
			}
			set
			{
				this._CTHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhuyenMai_HoaDon", Storage="_KhuyenMai", ThisKey="MaKM", OtherKey="MaKM", IsForeignKey=true)]
		public KhuyenMai KhuyenMai
		{
			get
			{
				return this._KhuyenMai.Entity;
			}
			set
			{
				KhuyenMai previousValue = this._KhuyenMai.Entity;
				if (((previousValue != value) 
							|| (this._KhuyenMai.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhuyenMai.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._KhuyenMai.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaKM = value.MaKM;
					}
					else
					{
						this._MaKM = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhuyenMai");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TaiKhoan_HoaDon", Storage="_TaiKhoan", ThisKey="UserNameKH", OtherKey="UserNameKH", IsForeignKey=true)]
		public TaiKhoan TaiKhoan
		{
			get
			{
				return this._TaiKhoan.Entity;
			}
			set
			{
				TaiKhoan previousValue = this._TaiKhoan.Entity;
				if (((previousValue != value) 
							|| (this._TaiKhoan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TaiKhoan.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._TaiKhoan.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._UserNameKH = value.UserNameKH;
					}
					else
					{
						this._UserNameKH = default(string);
					}
					this.SendPropertyChanged("TaiKhoan");
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
		
		private void attach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = this;
		}
		
		private void detach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTHD")]
	public partial class CTHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private int _SoLuong;
		
		private int _MaHD;
		
		private EntityRef<HoaDon> _HoaDon;
		
		private EntityRef<SanPham> _SanPham;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnMaHDChanging(int value);
    partial void OnMaHDChanged();
    #endregion
		
		public CTHD()
		{
			this._HoaDon = default(EntityRef<HoaDon>);
			this._SanPham = default(EntityRef<SanPham>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					if (this._SanPham.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int NOT NULL")]
		public int SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHD", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHD
		{
			get
			{
				return this._MaHD;
			}
			set
			{
				if ((this._MaHD != value))
				{
					if (this._HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHDChanging(value);
					this.SendPropertyChanging();
					this._MaHD = value;
					this.SendPropertyChanged("MaHD");
					this.OnMaHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_CTHD", Storage="_HoaDon", ThisKey="MaHD", OtherKey="MaHD", IsForeignKey=true)]
		public HoaDon HoaDon
		{
			get
			{
				return this._HoaDon.Entity;
			}
			set
			{
				HoaDon previousValue = this._HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HoaDon.Entity = null;
						previousValue.CTHDs.Remove(this);
					}
					this._HoaDon.Entity = value;
					if ((value != null))
					{
						value.CTHDs.Add(this);
						this._MaHD = value.MaHD;
					}
					else
					{
						this._MaHD = default(int);
					}
					this.SendPropertyChanged("HoaDon");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SanPham_CTHD", Storage="_SanPham", ThisKey="MaSP", OtherKey="MaSP", IsForeignKey=true)]
		public SanPham SanPham
		{
			get
			{
				return this._SanPham.Entity;
			}
			set
			{
				SanPham previousValue = this._SanPham.Entity;
				if (((previousValue != value) 
							|| (this._SanPham.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SanPham.Entity = null;
						previousValue.CTHDs.Remove(this);
					}
					this._SanPham.Entity = value;
					if ((value != null))
					{
						value.CTHDs.Add(this);
						this._MaSP = value.MaSP;
					}
					else
					{
						this._MaSP = default(int);
					}
					this.SendPropertyChanged("SanPham");
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
}
#pragma warning restore 1591
