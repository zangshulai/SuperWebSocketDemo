﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//     Website: http://ITdos.com/Dos/ORM/Index.html
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Model
{

	/// <summary>
	/// 实体类zkpt_mm_trojanInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("zkpt_mm_trojanInfo")]
	[Serializable]
	public partial class zkpt_mm_trojanInfo : Entity 
	{
		#region Model
		private long _tId;
		private long _userId;
		private string _tmark;
		private string _tName;
		private string _tAddress;
		private string _tOS;
		private string _tPCName;
		private bool _tIsCamera;
		private bool _tIsUSB;
		private DateTime _tAddTime;
		private string _tTearTime;
		private string _tVersion;
		private int _tSpeedlimit;
		private bool _tIsUP;
		private string _tRemark;
		private string _tPrScrn;
		/// <summary>
		/// 
		/// </summary>
		public long tId
		{
			get{ return _tId; }
			set
			{
				this.OnPropertyValueChange(_.tId,_tId,value);
				this._tId=value;
			}
		}
		/// <summary>
		/// 自增列
		/// </summary>
		public long userId
		{
			get{ return _userId; }
			set
			{
				this.OnPropertyValueChange(_.userId,_userId,value);
				this._userId=value;
			}
		}
		/// <summary>
		/// 木马标识符
		/// </summary>
		public string tmark
		{
			get{ return _tmark; }
			set
			{
				this.OnPropertyValueChange(_.tmark,_tmark,value);
				this._tmark=value;
			}
		}
		/// <summary>
		/// 木马上线备注名
		/// </summary>
		public string tName
		{
			get{ return _tName; }
			set
			{
				this.OnPropertyValueChange(_.tName,_tName,value);
				this._tName=value;
			}
		}
		/// <summary>
		/// IP地址
		/// </summary>
		public string tAddress
		{
			get{ return _tAddress; }
			set
			{
				this.OnPropertyValueChange(_.tAddress,_tAddress,value);
				this._tAddress=value;
			}
		}
		/// <summary>
		/// 系统
		/// </summary>
		public string tOS
		{
			get{ return _tOS; }
			set
			{
				this.OnPropertyValueChange(_.tOS,_tOS,value);
				this._tOS=value;
			}
		}
		/// <summary>
		/// 个人计算机名称
		/// </summary>
		public string tPCName
		{
			get{ return _tPCName; }
			set
			{
				this.OnPropertyValueChange(_.tPCName,_tPCName,value);
				this._tPCName=value;
			}
		}
		/// <summary>
		/// 是否有摄像头
		/// </summary>
		public bool tIsCamera
		{
			get{ return _tIsCamera; }
			set
			{
				this.OnPropertyValueChange(_.tIsCamera,_tIsCamera,value);
				this._tIsCamera=value;
			}
		}
		/// <summary>
		/// 是否有USB设备
		/// </summary>
		public bool tIsUSB
		{
			get{ return _tIsUSB; }
			set
			{
				this.OnPropertyValueChange(_.tIsUSB,_tIsUSB,value);
				this._tIsUSB=value;
			}
		}
		/// <summary>
		/// 上线时间
		/// </summary>
		public DateTime tAddTime
		{
			get{ return _tAddTime; }
			set
			{
				this.OnPropertyValueChange(_.tAddTime,_tAddTime,value);
				this._tAddTime=value;
			}
		}
		/// <summary>
		/// 下线时间
		/// </summary>
		public string tTearTime
		{
			get{ return _tTearTime; }
			set
			{
				this.OnPropertyValueChange(_.tTearTime,_tTearTime,value);
				this._tTearTime=value;
			}
		}
		/// <summary>
		/// 木马版本
		/// </summary>
		public string tVersion
		{
			get{ return _tVersion; }
			set
			{
				this.OnPropertyValueChange(_.tVersion,_tVersion,value);
				this._tVersion=value;
			}
		}
		/// <summary>
		/// 限制网速 -1 代表不限制 单位：KB
		/// </summary>
		public int tSpeedlimit
		{
			get{ return _tSpeedlimit; }
			set
			{
				this.OnPropertyValueChange(_.tSpeedlimit,_tSpeedlimit,value);
				this._tSpeedlimit=value;
			}
		}
		/// <summary>
		/// 是否在线
		/// </summary>
		public bool tIsUP
		{
			get{ return _tIsUP; }
			set
			{
				this.OnPropertyValueChange(_.tIsUP,_tIsUP,value);
				this._tIsUP=value;
			}
		}
		/// <summary>
		/// 木马备注信息
		/// </summary>
		public string tRemark
		{
			get{ return _tRemark; }
			set
			{
				this.OnPropertyValueChange(_.tRemark,_tRemark,value);
				this._tRemark=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tPrScrn
		{
			get{ return _tPrScrn; }
			set
			{
				this.OnPropertyValueChange(_.tPrScrn,_tPrScrn,value);
				this._tPrScrn=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.tId;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.tId};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.tId,
				_.userId,
				_.tmark,
				_.tName,
				_.tAddress,
				_.tOS,
				_.tPCName,
				_.tIsCamera,
				_.tIsUSB,
				_.tAddTime,
				_.tTearTime,
				_.tVersion,
				_.tSpeedlimit,
				_.tIsUP,
				_.tRemark,
				_.tPrScrn};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._tId,
				this._userId,
				this._tmark,
				this._tName,
				this._tAddress,
				this._tOS,
				this._tPCName,
				this._tIsCamera,
				this._tIsUSB,
				this._tAddTime,
				this._tTearTime,
				this._tVersion,
				this._tSpeedlimit,
				this._tIsUP,
				this._tRemark,
				this._tPrScrn};
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","zkpt_mm_trojanInfo");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field tId = new Field("tId","zkpt_mm_trojanInfo","tId");
			/// <summary>
			/// 自增列
			/// </summary>
			public readonly static Field userId = new Field("userId","zkpt_mm_trojanInfo","自增列");
			/// <summary>
			/// 木马标识符
			/// </summary>
			public readonly static Field tmark = new Field("tmark","zkpt_mm_trojanInfo","木马标识符");
			/// <summary>
			/// 木马上线备注名
			/// </summary>
			public readonly static Field tName = new Field("tName","zkpt_mm_trojanInfo","木马上线备注名");
			/// <summary>
			/// IP地址
			/// </summary>
			public readonly static Field tAddress = new Field("tAddress","zkpt_mm_trojanInfo","IP地址");
			/// <summary>
			/// 系统
			/// </summary>
			public readonly static Field tOS = new Field("tOS","zkpt_mm_trojanInfo","系统");
			/// <summary>
			/// 个人计算机名称
			/// </summary>
			public readonly static Field tPCName = new Field("tPCName","zkpt_mm_trojanInfo","个人计算机名称");
			/// <summary>
			/// 是否有摄像头
			/// </summary>
			public readonly static Field tIsCamera = new Field("tIsCamera","zkpt_mm_trojanInfo","是否有摄像头");
			/// <summary>
			/// 是否有USB设备
			/// </summary>
			public readonly static Field tIsUSB = new Field("tIsUSB","zkpt_mm_trojanInfo","是否有USB设备");
			/// <summary>
			/// 上线时间
			/// </summary>
			public readonly static Field tAddTime = new Field("tAddTime","zkpt_mm_trojanInfo","上线时间");
			/// <summary>
			/// 下线时间
			/// </summary>
			public readonly static Field tTearTime = new Field("tTearTime","zkpt_mm_trojanInfo","下线时间");
			/// <summary>
			/// 木马版本
			/// </summary>
			public readonly static Field tVersion = new Field("tVersion","zkpt_mm_trojanInfo","木马版本");
			/// <summary>
			/// 限制网速 -1 代表不限制 单位：KB
			/// </summary>
			public readonly static Field tSpeedlimit = new Field("tSpeedlimit","zkpt_mm_trojanInfo","限制网速 -1 代表不限制 单位：KB");
			/// <summary>
			/// 是否在线
			/// </summary>
			public readonly static Field tIsUP = new Field("tIsUP","zkpt_mm_trojanInfo","是否在线");
			/// <summary>
			/// 木马备注信息
			/// </summary>
			public readonly static Field tRemark = new Field("tRemark","zkpt_mm_trojanInfo","木马备注信息");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field tPrScrn = new Field("tPrScrn","zkpt_mm_trojanInfo","tPrScrn");
		}
		#endregion


	}
}

