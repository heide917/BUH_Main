using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUH.DAL.Models.Mapping
{
    public class KekMap : EntityTypeConfiguration<Kek>
    {
        public KekMap()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Name).IsRequired().HasMaxLength(250);
            this.Property(x => x.Number).IsRequired().HasMaxLength(10);
            this.Property(x => x.Discription).IsRequired().HasMaxLength(150);
          
           
       
        }
    }
}
