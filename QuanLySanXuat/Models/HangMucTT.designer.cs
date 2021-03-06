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
	public partial class HangMucTTDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertHangMucTT(HangMucTT instance);
    partial void UpdateHangMucTT(HangMucTT instance);
    partial void DeleteHangMucTT(HangMucTT instance);
    partial void InsertChiTietHangMucTT(ChiTietHangMucTT instance);
    partial void UpdateChiTietHangMucTT(ChiTietHangMucTT instance);
    partial void DeleteChiTietHangMucTT(ChiTietHangMucTT instance);
    #endregion
		
		public HangMucTTDataContext() : 
				base(global::QuanLySanXuat.Properties.Settings.Default.QLSXConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HangMucTTDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangMucTTDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangMucTTDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HangMucTTDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<HangMucTT> HangMucTTs
		{
			get
			{
				return this.GetTable<HangMucTT>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietHangMucTT> ChiTietHangMucTTs
		{
			get
			{
				return this.GetTable<ChiTietHangMucTT>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HangMucTT_add")]
		public int HangMucTT_add([global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenHangMucTT", DbType="NVarChar(200)")] string tenHangMucTT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CongTrinhID", DbType="Int")] System.Nullable<int> congTrinhID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHieuCT", DbType="NVarChar(20)")] string maHieuCT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(20)")] string nguoiTao)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tenHangMucTT, congTrinhID, maHieuCT, nguoiTao);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HangMucTT_update")]
		public int HangMucTT_update([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHangMucTT", DbType="Int")] System.Nullable<int> maHangMucTT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TenHangMucTT", DbType="NVarChar(200)")] string tenHangMucTT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CongTrinhID", DbType="Int")] System.Nullable<int> congTrinhID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHieuCT", DbType="NVarChar(20)")] string maHieuCT)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHangMucTT, tenHangMucTT, congTrinhID, maHieuCT);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HangMucTT_delete")]
		public int HangMucTT_delete([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHangMucTT", DbType="Int")] System.Nullable<int> maHangMucTT)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHangMucTT);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.HangMucTT_getList")]
		public ISingleResult<HangMucTT> HangMucTT_getList([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHangMucTT", DbType="Int")] System.Nullable<int> maHangMucTT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CongTrinhID", DbType="Int")] System.Nullable<int> congTrinhID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHieuCT", DbType="NVarChar(20)")] string maHieuCT, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string searchKey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHangMucTT, congTrinhID, maHieuCT, searchKey);
			return ((ISingleResult<HangMucTT>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietHangMucTT_add")]
		public int ChiTietHangMucTT_add([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHangMucTT", DbType="Int")] System.Nullable<int> maHangMucTT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKetCauChiTiet", DbType="Int")] System.Nullable<int> maKetCauChiTiet, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoLuong", DbType="Int")] System.Nullable<int> soLuong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TLDonVi", DbType="Decimal(18,0)")] System.Nullable<decimal> tLDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TLTong", DbType="Decimal(18,0)")] System.Nullable<decimal> tLTong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DonGia", DbType="Decimal(18,0)")] System.Nullable<decimal> donGia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GiaTri", DbType="Decimal(18,0)")] System.Nullable<decimal> giaTri, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GhiChu", DbType="NVarChar(200)")] string ghiChu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NguoiTao", DbType="NVarChar(20)")] string nguoiTao, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TLMaKem", DbType="Decimal(18,0)")] System.Nullable<decimal> tLMaKem, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QuyetToanKH", DbType="Decimal(18,0)")] System.Nullable<decimal> quyetToanKH)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maHangMucTT, maKetCauChiTiet, soLuong, tLDonVi, tLTong, donGia, giaTri, ghiChu, nguoiTao, tLMaKem, quyetToanKH);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietHangMucTT_delete")]
		public int ChiTietHangMucTT_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maChiTietTT)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maChiTietTT);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietHangMucTT_getList")]
		public ISingleResult<ChiTietHangMucTT> ChiTietHangMucTT_getList([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maChiTietTT, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maHangMucTT, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(200)")] string searchKey)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maChiTietTT, maHangMucTT, searchKey);
			return ((ISingleResult<ChiTietHangMucTT>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ChiTietHangMucTT_update")]
		public int ChiTietHangMucTT_update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> maChiTietTT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaHangMucTT", DbType="Int")] System.Nullable<int> maHangMucTT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MaKetCauChiTiet", DbType="Int")] System.Nullable<int> maKetCauChiTiet, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SoLuong", DbType="Int")] System.Nullable<int> soLuong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TLDonVi", DbType="Decimal(18,0)")] System.Nullable<decimal> tLDonVi, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TLTong", DbType="Decimal(18,0)")] System.Nullable<decimal> tLTong, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DonGia", DbType="Decimal(18,0)")] System.Nullable<decimal> donGia, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GiaTri", DbType="Decimal(18,0)")] System.Nullable<decimal> giaTri, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GhiChu", DbType="NVarChar(200)")] string ghiChu, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TLMaKem", DbType="Decimal(18,0)")] System.Nullable<decimal> tLMaKem, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="QuyetToanKH", DbType="Decimal(18,0)")] System.Nullable<decimal> quyetToanKH)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), maChiTietTT, maHangMucTT, maKetCauChiTiet, soLuong, tLDonVi, tLTong, donGia, giaTri, ghiChu, tLMaKem, quyetToanKH);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HangMucTT")]
	public partial class HangMucTT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHangMucTT;
		
		private string _TenHangMucTT;
		
		private int _CongTrinhID;
		
		private string _MaHieuCT;
		
		private string _NguoiTao;
		
		private System.DateTime _NgayTao;
		
		private System.Nullable<int> _MaThamChieu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHangMucTTChanging(int value);
    partial void OnMaHangMucTTChanged();
    partial void OnTenHangMucTTChanging(string value);
    partial void OnTenHangMucTTChanged();
    partial void OnCongTrinhIDChanging(int value);
    partial void OnCongTrinhIDChanged();
    partial void OnMaHieuCTChanging(string value);
    partial void OnMaHieuCTChanged();
    partial void OnNguoiTaoChanging(string value);
    partial void OnNguoiTaoChanged();
    partial void OnNgayTaoChanging(System.DateTime value);
    partial void OnNgayTaoChanged();
    partial void OnMaThamChieuChanging(System.Nullable<int> value);
    partial void OnMaThamChieuChanged();
    #endregion
		
		public HangMucTT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHangMucTT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHangMucTT
		{
			get
			{
				return this._MaHangMucTT;
			}
			set
			{
				if ((this._MaHangMucTT != value))
				{
					this.OnMaHangMucTTChanging(value);
					this.SendPropertyChanging();
					this._MaHangMucTT = value;
					this.SendPropertyChanged("MaHangMucTT");
					this.OnMaHangMucTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenHangMucTT", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string TenHangMucTT
		{
			get
			{
				return this._TenHangMucTT;
			}
			set
			{
				if ((this._TenHangMucTT != value))
				{
					this.OnTenHangMucTTChanging(value);
					this.SendPropertyChanging();
					this._TenHangMucTT = value;
					this.SendPropertyChanged("TenHangMucTT");
					this.OnTenHangMucTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongTrinhID", DbType="Int NOT NULL")]
		public int CongTrinhID
		{
			get
			{
				return this._CongTrinhID;
			}
			set
			{
				if ((this._CongTrinhID != value))
				{
					this.OnCongTrinhIDChanging(value);
					this.SendPropertyChanging();
					this._CongTrinhID = value;
					this.SendPropertyChanged("CongTrinhID");
					this.OnCongTrinhIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHieuCT", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string MaHieuCT
		{
			get
			{
				return this._MaHieuCT;
			}
			set
			{
				if ((this._MaHieuCT != value))
				{
					this.OnMaHieuCTChanging(value);
					this.SendPropertyChanging();
					this._MaHieuCT = value;
					this.SendPropertyChanged("MaHieuCT");
					this.OnMaHieuCTChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThamChieu", DbType="Int")]
		public System.Nullable<int> MaThamChieu
		{
			get
			{
				return this._MaThamChieu;
			}
			set
			{
				if ((this._MaThamChieu != value))
				{
					this.OnMaThamChieuChanging(value);
					this.SendPropertyChanging();
					this._MaThamChieu = value;
					this.SendPropertyChanged("MaThamChieu");
					this.OnMaThamChieuChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietHangMucTT")]
	public partial class ChiTietHangMucTT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaChiTietTT;
		
		private int _MaHangMucTT;
		
		private int _MaKetCauChiTiet;
		
		private int _SoLuong;
		
		private decimal _TLDonVi;
		
		private decimal _TLTong;
		
		private decimal _DonGia;
		
		private decimal _GiaTri;
		
		private string _GhiChu;
		
		private string _NguoiTao;
		
		private System.DateTime _NgayTao;
		
		private System.Nullable<int> _MaThamChieu;
		
		private System.Nullable<decimal> _TLMaKem;
		
		private System.Nullable<decimal> _QuyetToanKH;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaChiTietTTChanging(int value);
    partial void OnMaChiTietTTChanged();
    partial void OnMaHangMucTTChanging(int value);
    partial void OnMaHangMucTTChanged();
    partial void OnMaKetCauChiTietChanging(int value);
    partial void OnMaKetCauChiTietChanged();
    partial void OnSoLuongChanging(int value);
    partial void OnSoLuongChanged();
    partial void OnTLDonViChanging(decimal value);
    partial void OnTLDonViChanged();
    partial void OnTLTongChanging(decimal value);
    partial void OnTLTongChanged();
    partial void OnDonGiaChanging(decimal value);
    partial void OnDonGiaChanged();
    partial void OnGiaTriChanging(decimal value);
    partial void OnGiaTriChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnNguoiTaoChanging(string value);
    partial void OnNguoiTaoChanged();
    partial void OnNgayTaoChanging(System.DateTime value);
    partial void OnNgayTaoChanged();
    partial void OnMaThamChieuChanging(System.Nullable<int> value);
    partial void OnMaThamChieuChanged();
    partial void OnTLMaKemChanging(System.Nullable<decimal> value);
    partial void OnTLMaKemChanged();
    partial void OnQuyetToanKHChanging(System.Nullable<decimal> value);
    partial void OnQuyetToanKHChanged();
    #endregion
		
		public ChiTietHangMucTT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaChiTietTT", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaChiTietTT
		{
			get
			{
				return this._MaChiTietTT;
			}
			set
			{
				if ((this._MaChiTietTT != value))
				{
					this.OnMaChiTietTTChanging(value);
					this.SendPropertyChanging();
					this._MaChiTietTT = value;
					this.SendPropertyChanged("MaChiTietTT");
					this.OnMaChiTietTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHangMucTT", DbType="Int NOT NULL")]
		public int MaHangMucTT
		{
			get
			{
				return this._MaHangMucTT;
			}
			set
			{
				if ((this._MaHangMucTT != value))
				{
					this.OnMaHangMucTTChanging(value);
					this.SendPropertyChanging();
					this._MaHangMucTT = value;
					this.SendPropertyChanged("MaHangMucTT");
					this.OnMaHangMucTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKetCauChiTiet", DbType="Int NOT NULL")]
		public int MaKetCauChiTiet
		{
			get
			{
				return this._MaKetCauChiTiet;
			}
			set
			{
				if ((this._MaKetCauChiTiet != value))
				{
					this.OnMaKetCauChiTietChanging(value);
					this.SendPropertyChanging();
					this._MaKetCauChiTiet = value;
					this.SendPropertyChanged("MaKetCauChiTiet");
					this.OnMaKetCauChiTietChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TLDonVi", DbType="Decimal(18,0) NOT NULL")]
		public decimal TLDonVi
		{
			get
			{
				return this._TLDonVi;
			}
			set
			{
				if ((this._TLDonVi != value))
				{
					this.OnTLDonViChanging(value);
					this.SendPropertyChanging();
					this._TLDonVi = value;
					this.SendPropertyChanged("TLDonVi");
					this.OnTLDonViChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TLTong", DbType="Decimal(18,0) NOT NULL")]
		public decimal TLTong
		{
			get
			{
				return this._TLTong;
			}
			set
			{
				if ((this._TLTong != value))
				{
					this.OnTLTongChanging(value);
					this.SendPropertyChanging();
					this._TLTong = value;
					this.SendPropertyChanged("TLTong");
					this.OnTLTongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Decimal(18,0) NOT NULL")]
		public decimal DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaTri", DbType="Decimal(18,0) NOT NULL")]
		public decimal GiaTri
		{
			get
			{
				return this._GiaTri;
			}
			set
			{
				if ((this._GiaTri != value))
				{
					this.OnGiaTriChanging(value);
					this.SendPropertyChanging();
					this._GiaTri = value;
					this.SendPropertyChanged("GiaTri");
					this.OnGiaTriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(200)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaThamChieu", DbType="Int")]
		public System.Nullable<int> MaThamChieu
		{
			get
			{
				return this._MaThamChieu;
			}
			set
			{
				if ((this._MaThamChieu != value))
				{
					this.OnMaThamChieuChanging(value);
					this.SendPropertyChanging();
					this._MaThamChieu = value;
					this.SendPropertyChanged("MaThamChieu");
					this.OnMaThamChieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TLMaKem", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> TLMaKem
		{
			get
			{
				return this._TLMaKem;
			}
			set
			{
				if ((this._TLMaKem != value))
				{
					this.OnTLMaKemChanging(value);
					this.SendPropertyChanging();
					this._TLMaKem = value;
					this.SendPropertyChanged("TLMaKem");
					this.OnTLMaKemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuyetToanKH", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> QuyetToanKH
		{
			get
			{
				return this._QuyetToanKH;
			}
			set
			{
				if ((this._QuyetToanKH != value))
				{
					this.OnQuyetToanKHChanging(value);
					this.SendPropertyChanging();
					this._QuyetToanKH = value;
					this.SendPropertyChanged("QuyetToanKH");
					this.OnQuyetToanKHChanged();
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
