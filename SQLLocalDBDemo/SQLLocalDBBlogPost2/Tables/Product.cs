using FluentNHibernate.Mapping;
using System;

namespace SQLLocalDBBlogPost2
{
	public class Product
	{
		public virtual int ProductId { get; set; }
		public virtual int ProductType { get; set; }
		public virtual string Name { get; set; }
        public virtual int store { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}

			Product that = (Product)obj;

			return this.ProductId == that.ProductId &&
				this.ProductType == that.ProductType;
		}

		public override int GetHashCode()
		{
			return ProductId.GetHashCode() ^
				ProductType.GetHashCode();
		}
	}

	public class ProductMap : ClassMap<Product>
	{
		public ProductMap()
		{
			Table("sampledata..Product");
			CompositeId()
				.KeyProperty(u => u.ProductId)
				.KeyProperty(u => u.ProductType);
			Map(u => u.Name).Length(50).Nullable();
            Map(u => u.store).Not.Nullable();
		}
	}
}
