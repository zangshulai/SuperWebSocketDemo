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
	/// 实体类zkpt_mm_cmd 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Table("zkpt_mm_cmd")]
	[Serializable]
	public partial class zkpt_mm_cmd : Entity 
	{
		#region Model
		private long _cmdId;
		private string _tmark;
		private DateTime _cmdAddTime;
		private bool _cmdState;
		private string _cmdCoutent;
		private string _cmdRandom;
		/// <summary>
		/// 
		/// </summary>
		public long cmdId
		{
			get{ return _cmdId; }
			set
			{
				this.OnPropertyValueChange(_.cmdId,_cmdId,value);
				this._cmdId=value;
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
		public DateTime cmdAddTime
		{
			get{ return _cmdAddTime; }
			set
			{
				this.OnPropertyValueChange(_.cmdAddTime,_cmdAddTime,value);
				this._cmdAddTime=value;
			}
		}
		/// <summary>
		/// 状态
		/// </summary>
		public bool cmdState
		{
			get{ return _cmdState; }
			set
			{
				this.OnPropertyValueChange(_.cmdState,_cmdState,value);
				this._cmdState=value;
			}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string cmdCoutent
		{
			get{ return _cmdCoutent; }
			set
			{
				this.OnPropertyValueChange(_.cmdCoutent,_cmdCoutent,value);
				this._cmdCoutent=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cmdRandom
		{
			get{ return _cmdRandom; }
			set
			{
				this.OnPropertyValueChange(_.cmdRandom,_cmdRandom,value);
				this._cmdRandom=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的标识列
		/// </summary>
		public override Field GetIdentityField()
		{
			return _.cmdId;
		}
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.cmdId};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.cmdId,
				_.tmark,
				_.cmdAddTime,
				_.cmdState,
				_.cmdCoutent,
				_.cmdRandom};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._cmdId,
				this._tmark,
				this._cmdAddTime,
				this._cmdState,
				this._cmdCoutent,
				this._cmdRandom};
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
			public readonly static Field All = new Field("*","zkpt_mm_cmd");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field cmdId = new Field("cmdId","zkpt_mm_cmd","cmdId");
			/// <summary>
			/// 关联表项： trojanInfo
			/// </summary>
			public readonly static Field tmark = new Field("tmark","zkpt_mm_cmd","关联表项： trojanInfo");
			/// <summary>
			/// 添加时间
			/// </summary>
			public readonly static Field cmdAddTime = new Field("cmdAddTime","zkpt_mm_cmd","添加时间");
			/// <summary>
			/// 状态
			/// </summary>
			public readonly static Field cmdState = new Field("cmdState","zkpt_mm_cmd","状态");
			/// <summary>
			/// 内容
			/// </summary>
			public readonly static Field cmdCoutent = new Field("cmdCoutent","zkpt_mm_cmd","内容");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field cmdRandom = new Field("cmdRandom","zkpt_mm_cmd","cmdRandom");
		}
		#endregion


	}
}

