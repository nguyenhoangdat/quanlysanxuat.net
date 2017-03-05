﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLySanXuat.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLSX")]
	public partial class KetCauDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietKetCau(ChiTietKetCau instance);
    partial void UpdateChiTietKetCau(ChiTietKetCau instance);
    partial void DeleteChiTietKetCau(ChiTietKetCau instance);
    partial void InsertNhomKetCau(NhomKetCau instance);
    partial void UpdateNhomKetCau(NhomKetCau instance);
    partial void DeleteNhomKetCau(NhomKetCau instance);
    partial void InsertKetCau(KetCau instance);
    partial void UpdateKetCau(KetCau instance);
    partial void DeleteKetCau(KetCau instance);
    #endregion
		
		public KetCauDataContext() : 
				base(global::QuanLySanXuat.Properties.Settings.Default.QLSXConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KetCauDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KetCauDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KetCauDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KetCauDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTietKetCau> ChiTietKetCaus
		{
			get
			{
				return this.GetTable<ChiTietKetCau>();
			}
		}
		
		public System.Data.Linq.Table<NhomKetCau> NhomKetCaus
		{
			get
			{
				return this.GetTable<NhomKetCau>();
			}
		}
		
		public System.Data.Linq.Table<KetCau> KetCaus
		{
			get
			{
				return this.GetTable<KetCau>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietKetCau_add")]
		public int ChiTietKetCau_add([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKetCau", DbType="Int")] System.Nullable<int> maKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenChiTietKetCau", DbType="NVarChar(100)")] string tenChiTietKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QuyCach", DbType="NVarChar(20)")] string quyCach, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChieuDai", DbType="Int")] System.Nullable<int> chieuDai, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChieuRong", DbType="Int")] System.Nullable<int> chieuRong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TyTrong", DbType="Decimal(18,0)")] System.Nullable<decimal> tyTrong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gia", DbType="Decimal(18,0)")] System.Nullable<decimal> gia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(20)")] string nguoiTao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKetCau, tenChiTietKetCau, quyCach, chieuDai, chieuRong, tyTrong, gia, nguoiTao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietKetCau_delete")]
		public int ChiTietKetCau_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maChiTietKetCau)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maChiTietKetCau);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietKetCau_update")]
		public int ChiTietKetCau_update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maChiTietKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKetCau", DbType="Int")] System.Nullable<int> maKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenChiTietKetCau", DbType="NVarChar(100)")] string tenChiTietKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QuyCach", DbType="NVarChar(20)")] string quyCach, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChieuDai", DbType="Int")] System.Nullable<int> chieuDai, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ChieuRong", DbType="Int")] System.Nullable<int> chieuRong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TyTrong", DbType="Decimal(18,0)")] System.Nullable<decimal> tyTrong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gia", DbType="Decimal(18,0)")] System.Nullable<decimal> gia)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maChiTietKetCau, maKetCau, tenChiTietKetCau, quyCach, chieuDai, chieuRong, tyTrong, gia);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietKetCau_getList")]
		public ISingleResult<ChiTietKetCau> ChiTietKetCau_getList([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maChiTietKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string searchKey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maChiTietKetCau, maKetCau, searchKey);
			return ((ISingleResult<ChiTietKetCau>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KetCau_add")]
		public int KetCau_add([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenKetCau", DbType="NVarChar(200)")] string tenKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaNhomKetCau", DbType="Int")] System.Nullable<int> maNhomKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MoTa", DbType="NVarChar(MAX)")] string moTa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HinhAnh", DbType="Image")] System.Data.Linq.Binary hinhAnh, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(20)")] string nguoiTao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tenKetCau, maNhomKetCau, moTa, hinhAnh, nguoiTao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KetCau_update")]
		public int KetCau_update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenKetCau", DbType="NVarChar(200)")] string tenKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaNhomKetCau", DbType="Int")] System.Nullable<int> maNhomKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MoTa", DbType="NVarChar(MAX)")] string moTa, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="HinhAnh", DbType="Image")] System.Data.Linq.Binary hinhAnh)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKetCau, tenKetCau, maNhomKetCau, moTa, hinhAnh);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KetCau_delete")]
		public int KetCau_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maKetCau)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKetCau);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.KetCau_getList")]
		public ISingleResult<KetCau> KetCau_getList([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maNhomKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string searchKey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maKetCau, maNhomKetCau, searchKey);
			return ((ISingleResult<KetCau>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhomKetCau_add")]
		public int NhomKetCau_add([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenNhomKetCau", DbType="NVarChar(200)")] string tenNhomKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SapXep", DbType="Int")] System.Nullable<int> sapXep, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(20)")] string nguoiTao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tenNhomKetCau, sapXep, nguoiTao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhomKetCau_update")]
		public int NhomKetCau_update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maNhomKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenNhomKetCau", DbType="NVarChar(200)")] string tenNhomKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SapXep", DbType="Int")] System.Nullable<int> sapXep)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maNhomKetCau, tenNhomKetCau, sapXep);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhomKetCau_delete")]
		public int NhomKetCau_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maNhomKetCau)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maNhomKetCau);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.NhomKetCau_getList")]
		public ISingleResult<NhomKetCau> NhomKetCau_getList([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaNhomKetCau", DbType="Int")] System.Nullable<int> maNhomKetCau, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string searchKey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maNhomKetCau, searchKey);
			return ((ISingleResult<NhomKetCau>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietKetCau")]
	public partial class ChiTietKetCau : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaChiTietKetCau;
		
		private string _TenChiTietKetCau;
		
		private int _MaKetCau;
		
		private string _QuyCach;
		
		private System.Nullable<int> _ChieuDai;
		
		private System.Nullable<int> _ChieuRong;
		
		private System.Nullable<decimal> _TyTrong;
		
		private System.Nullable<decimal> _Gia;
		
		private string _NguoiTao;
		
		private System.DateTime _NgayTao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChiTietKetCauChanging(int value);
    partial void OnMaChiTietKetCauChanged();
    partial void OnTenChiTietKetCauChanging(string value);
    partial void OnTenChiTietKetCauChanged();
    partial void OnMaKetCauChanging(int value);
    partial void OnMaKetCauChanged();
    partial void OnQuyCachChanging(string value);
    partial void OnQuyCachChanged();
    partial void OnChieuDaiChanging(System.Nullable<int> value);
    partial void OnChieuDaiChanged();
    partial void OnChieuRongChanging(System.Nullable<int> value);
    partial void OnChieuRongChanged();
    partial void OnTyTrongChanging(System.Nullable<decimal> value);
    partial void OnTyTrongChanged();
    partial void OnGiaChanging(System.Nullable<decimal> value);
    partial void OnGiaChanged();
    partial void OnNguoiTaoChanging(string value);
    partial void OnNguoiTaoChanged();
    partial void OnNgayTaoChanging(System.DateTime value);
    partial void OnNgayTaoChanged();
    #endregion
		
		public ChiTietKetCau()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChiTietKetCau", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaChiTietKetCau
		{
			get
			{
				return this._MaChiTietKetCau;
			}
			set
			{
				if ((this._MaChiTietKetCau != value))
				{
					this.OnMaChiTietKetCauChanging(value);
					this.SendPropertyChanging();
					this._MaChiTietKetCau = value;
					this.SendPropertyChanged("MaChiTietKetCau");
					this.OnMaChiTietKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChiTietKetCau", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenChiTietKetCau
		{
			get
			{
				return this._TenChiTietKetCau;
			}
			set
			{
				if ((this._TenChiTietKetCau != value))
				{
					this.OnTenChiTietKetCauChanging(value);
					this.SendPropertyChanging();
					this._TenChiTietKetCau = value;
					this.SendPropertyChanged("TenChiTietKetCau");
					this.OnTenChiTietKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKetCau", DbType="Int NOT NULL")]
		public int MaKetCau
		{
			get
			{
				return this._MaKetCau;
			}
			set
			{
				if ((this._MaKetCau != value))
				{
					this.OnMaKetCauChanging(value);
					this.SendPropertyChanging();
					this._MaKetCau = value;
					this.SendPropertyChanged("MaKetCau");
					this.OnMaKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuyCach", DbType="NVarChar(20)")]
		public string QuyCach
		{
			get
			{
				return this._QuyCach;
			}
			set
			{
				if ((this._QuyCach != value))
				{
					this.OnQuyCachChanging(value);
					this.SendPropertyChanging();
					this._QuyCach = value;
					this.SendPropertyChanged("QuyCach");
					this.OnQuyCachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChieuDai", DbType="Int")]
		public System.Nullable<int> ChieuDai
		{
			get
			{
				return this._ChieuDai;
			}
			set
			{
				if ((this._ChieuDai != value))
				{
					this.OnChieuDaiChanging(value);
					this.SendPropertyChanging();
					this._ChieuDai = value;
					this.SendPropertyChanged("ChieuDai");
					this.OnChieuDaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChieuRong", DbType="Int")]
		public System.Nullable<int> ChieuRong
		{
			get
			{
				return this._ChieuRong;
			}
			set
			{
				if ((this._ChieuRong != value))
				{
					this.OnChieuRongChanging(value);
					this.SendPropertyChanging();
					this._ChieuRong = value;
					this.SendPropertyChanged("ChieuRong");
					this.OnChieuRongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TyTrong", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> TyTrong
		{
			get
			{
				return this._TyTrong;
			}
			set
			{
				if ((this._TyTrong != value))
				{
					this.OnTyTrongChanging(value);
					this.SendPropertyChanging();
					this._TyTrong = value;
					this.SendPropertyChanged("TyTrong");
					this.OnTyTrongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this.OnGiaChanging(value);
					this.SendPropertyChanging();
					this._Gia = value;
					this.SendPropertyChanged("Gia");
					this.OnGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiTao", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string NguoiTao
		{
			get
			{
				return this._NguoiTao;
			}
			set
			{
				if ((this._NguoiTao != value))
				{
					this.OnNguoiTaoChanging(value);
					this.SendPropertyChanging();
					this._NguoiTao = value;
					this.SendPropertyChanged("NguoiTao");
					this.OnNguoiTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="DateTime NOT NULL")]
		public System.DateTime NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this.OnNgayTaoChanging(value);
					this.SendPropertyChanging();
					this._NgayTao = value;
					this.SendPropertyChanged("NgayTao");
					this.OnNgayTaoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhomKetCau")]
	public partial class NhomKetCau : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNhomKetCau;
		
		private string _TenNhomKetCau;
		
		private int _SapXep;
		
		private string _NguoiTao;
		
		private System.DateTime _NgayTao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhomKetCauChanging(int value);
    partial void OnMaNhomKetCauChanged();
    partial void OnTenNhomKetCauChanging(string value);
    partial void OnTenNhomKetCauChanged();
    partial void OnSapXepChanging(int value);
    partial void OnSapXepChanged();
    partial void OnNguoiTaoChanging(string value);
    partial void OnNguoiTaoChanged();
    partial void OnNgayTaoChanging(System.DateTime value);
    partial void OnNgayTaoChanged();
    #endregion
		
		public NhomKetCau()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhomKetCau", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNhomKetCau
		{
			get
			{
				return this._MaNhomKetCau;
			}
			set
			{
				if ((this._MaNhomKetCau != value))
				{
					this.OnMaNhomKetCauChanging(value);
					this.SendPropertyChanging();
					this._MaNhomKetCau = value;
					this.SendPropertyChanged("MaNhomKetCau");
					this.OnMaNhomKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhomKetCau", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenNhomKetCau
		{
			get
			{
				return this._TenNhomKetCau;
			}
			set
			{
				if ((this._TenNhomKetCau != value))
				{
					this.OnTenNhomKetCauChanging(value);
					this.SendPropertyChanging();
					this._TenNhomKetCau = value;
					this.SendPropertyChanged("TenNhomKetCau");
					this.OnTenNhomKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SapXep", DbType="Int NOT NULL")]
		public int SapXep
		{
			get
			{
				return this._SapXep;
			}
			set
			{
				if ((this._SapXep != value))
				{
					this.OnSapXepChanging(value);
					this.SendPropertyChanging();
					this._SapXep = value;
					this.SendPropertyChanged("SapXep");
					this.OnSapXepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiTao", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string NguoiTao
		{
			get
			{
				return this._NguoiTao;
			}
			set
			{
				if ((this._NguoiTao != value))
				{
					this.OnNguoiTaoChanging(value);
					this.SendPropertyChanging();
					this._NguoiTao = value;
					this.SendPropertyChanged("NguoiTao");
					this.OnNguoiTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="DateTime NOT NULL")]
		public System.DateTime NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this.OnNgayTaoChanging(value);
					this.SendPropertyChanging();
					this._NgayTao = value;
					this.SendPropertyChanged("NgayTao");
					this.OnNgayTaoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KetCau")]
	public partial class KetCau : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKetCau;
		
		private string _TenKetCau;
		
		private int _MaNhomKetCau;
		
		private string _MoTa;
		
		private System.Data.Linq.Binary _HinhAnh;
		
		private string _NguoiTao;
		
		private System.DateTime _NgayTao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKetCauChanging(int value);
    partial void OnMaKetCauChanged();
    partial void OnTenKetCauChanging(string value);
    partial void OnTenKetCauChanged();
    partial void OnMaNhomKetCauChanging(int value);
    partial void OnMaNhomKetCauChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnHinhAnhChanging(System.Data.Linq.Binary value);
    partial void OnHinhAnhChanged();
    partial void OnNguoiTaoChanging(string value);
    partial void OnNguoiTaoChanged();
    partial void OnNgayTaoChanging(System.DateTime value);
    partial void OnNgayTaoChanged();
    #endregion
		
		public KetCau()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKetCau", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaKetCau
		{
			get
			{
				return this._MaKetCau;
			}
			set
			{
				if ((this._MaKetCau != value))
				{
					this.OnMaKetCauChanging(value);
					this.SendPropertyChanging();
					this._MaKetCau = value;
					this.SendPropertyChanged("MaKetCau");
					this.OnMaKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKetCau", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string TenKetCau
		{
			get
			{
				return this._TenKetCau;
			}
			set
			{
				if ((this._TenKetCau != value))
				{
					this.OnTenKetCauChanging(value);
					this.SendPropertyChanging();
					this._TenKetCau = value;
					this.SendPropertyChanged("TenKetCau");
					this.OnTenKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhomKetCau", DbType="Int NOT NULL")]
		public int MaNhomKetCau
		{
			get
			{
				return this._MaNhomKetCau;
			}
			set
			{
				if ((this._MaNhomKetCau != value))
				{
					this.OnMaNhomKetCauChanging(value);
					this.SendPropertyChanging();
					this._MaNhomKetCau = value;
					this.SendPropertyChanged("MaNhomKetCau");
					this.OnMaNhomKetCauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnh", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary HinhAnh
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiTao", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string NguoiTao
		{
			get
			{
				return this._NguoiTao;
			}
			set
			{
				if ((this._NguoiTao != value))
				{
					this.OnNguoiTaoChanging(value);
					this.SendPropertyChanging();
					this._NguoiTao = value;
					this.SendPropertyChanged("NguoiTao");
					this.OnNguoiTaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTao", DbType="DateTime NOT NULL")]
		public System.DateTime NgayTao
		{
			get
			{
				return this._NgayTao;
			}
			set
			{
				if ((this._NgayTao != value))
				{
					this.OnNgayTaoChanging(value);
					this.SendPropertyChanging();
					this._NgayTao = value;
					this.SendPropertyChanged("NgayTao");
					this.OnNgayTaoChanged();
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
