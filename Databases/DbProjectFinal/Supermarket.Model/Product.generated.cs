#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Supermarket.Model;

namespace Supermarket.Model	
{
	public partial class Product
	{
		private int id;
		public virtual int Id
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}
		
		private int vendorId;
		public virtual int VendorId
		{
			get
			{
				return this.vendorId;
			}
			set
			{
				this.vendorId = value;
			}
		}
		
		private string productName;
		public virtual string ProductName
		{
			get
			{
				return this.productName;
			}
			set
			{
				this.productName = value;
			}
		}
		
		private int measureId;
		public virtual int MeasureId
		{
			get
			{
				return this.measureId;
			}
			set
			{
				this.measureId = value;
			}
		}
		
		private long basePrice;
		public virtual long BasePrice
		{
			get
			{
				return this.basePrice;
			}
			set
			{
				this.basePrice = value;
			}
		}
		
		private Measure measure;
		public virtual Measure Measure
		{
			get
			{
				return this.measure;
			}
			set
			{
				this.measure = value;
			}
		}
		
		private Vendor vendor;
		public virtual Vendor Vendor
		{
			get
			{
				return this.vendor;
			}
			set
			{
				this.vendor = value;
			}
		}
		
	}
}
#pragma warning restore 1591
