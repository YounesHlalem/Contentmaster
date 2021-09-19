using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configuration
{
    public abstract class BaseEntityTypeConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase:class
    {
        public string TableName { get; set; }

        public BaseEntityTypeConfiguration(string TableName)
        {
            string name = typeof(TBase).Name;
            string tmp = TableName;

            foreach (var item in name)
            {
                if (char.IsUpper(item))
                {
                    tmp += $"_{item}".ToLower();
                }
                else
                {
                    tmp += item;
                }
            }


            this.TableName = tmp;
        }

        public virtual void Configure(EntityTypeBuilder<TBase> e)
        {
            e.ToTable(TableName);
        }
    }
}
