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
	/// 实体类zkpt_mm_Keyboard 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("zkpt_mm_Keyboard")]
	[Serializable]
	public partial class zkpt_mm_Keyboard : Entity 
	{
		#region Model
		private long _kId;
		private string _tmark;
		private DateTime _kAddTime;
		private string _kTitle;
		private string _kCoutent;
		private string _kRemark;
		/// <summary>
		/// 主键，自增列
		/// </summary>
		public long kId
		{
			get{ return _kId; }
			set
			{
				this.OnPropertyValueChange(_.kId,_kId,value);
				this._kId=value;
			}
		}
		/// <summary>
		/// 关联表项： trojanInfo
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
		/// 添加时间
		/// </summary>
		public DateTime kAddTime
		{
			get{ return _kAddTime; }
			set
			{
				this.OnPropertyValueChange(_.kAddTime,_kAddTime,value);
				this._kAddTime=value;
			}
		}
		/// <summary>
		/// 窗口标题
		/// </summary>
		public string kTitle
		{
			get{ return _kTitle; }
			set
			{
				this.OnPropertyValueChange(_.kTitle,_kTitle,value);
				this._kTitle=value;
			}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string kCoutent
		{
			get{ return _kCoutent; }
			set
			{
				this.OnPropertyValueChange(_.kCoutent,_kCoutent,value);
				this._kCoutent=value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string kRemark
		{
			get{ return _kRemark; }
			set
			{
				this.OnPropertyValueChange(_.kRemark,_kRemark,value);
				this._kRemark=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.kId;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.kId};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.kId,
				_.tmark,
				_.kAddTime,
				_.kTitle,
				_.kCoutent,
				_.kRemark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._kId,
				this._tmark,
				this._kAddTime,
				this._kTitle,
				this._kCoutent,
				this._kRemark};
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
			public readonly static Field All = new Field("*","zkpt_mm_Keyboard");
			/// <summary>
			/// 主键，自增列
			/// </summary>
			public readonly static Field kId = new Field("kId","zkpt_mm_Keyboard","主键，自增列");
			/// <summary>
			/// 关联表项： trojanInfo
			/// </summary>
			public readonly static Field tmark = new Field("tmark","zkpt_mm_Keyboard","关联表项： trojanInfo");
			/// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field kAddTime = new Field("kAddTime","zkpt_mm_Keyboard","添加时间");
			/// <summary>
			/// 窗口标题
			/// </summary>
			public readonly static Field kTitle = new Field("kTitle","zkpt_mm_Keyboard","窗口标题");
			/// <summary>
			/// 内容
			/// </summary>
			public readonly static Field kCoutent = new Field("kCoutent","zkpt_mm_Keyboard","内容");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field kRemark = new Field("kRemark","zkpt_mm_Keyboard","备注");
		}
		#endregion


	}
}

