using FluentNHibernate.Mapping;
using System;

namespace SQLLocalDBBlogPost2
{
	public class ProductType
	{
		public virtual int Id { get; set; }
		public virtual string Description { get; set; }
	}

	public class ProductTypeMap : ClassMap<ProductType>
	{
		public ProductTypeMap()
		{
			Table("sampledata..ProductType");
			Id(u => u.Id);
			Map(u => u.Description).Length(50).Nullable();
		}
	}
}
