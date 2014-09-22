using FluentNHibernate.Mapping;
using System;

namespace SQLLocalDBBlogPost2
{
	public class Store
	{
		public virtual int id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Address { get; set; }
		public virtual string City { get; set; }
		public virtual string State { get; set; }
		public virtual string Zip { get; set; }
        public virtual string testfield { get; set; }
	}

	public class StoreMap : ClassMap<Store>
	{
		public StoreMap()
		{
			Table("sampledata..Store");
			Id(u => u.id);
			Map(u => u.Name).CustomSqlType("char(50)").Nullable();
            Map(u => u.Address).CustomSqlType("char(50)").Length(50).Nullable();
            Map(u => u.City).CustomSqlType("char(50)").Length(50).Nullable();
            Map(u => u.State).CustomSqlType("char(50)").Length(50).Nullable();
            Map(u => u.Zip).CustomSqlType("char(10)").Length(10).Nullable();
            Map(u => u.testfield).CustomSqlType("text").Nullable();
		}
	}
}
