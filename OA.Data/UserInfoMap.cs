using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Data
{
    public class UserInfoMap
    {
        public UserInfoMap(EntityTypeBuilder<UserInfo> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(t => t.Address).IsRequired();
            entityTypeBuilder.Property(t => t.FirstName).IsRequired();
            entityTypeBuilder.Property(t => t.LastName).IsRequired();
        }
    }
}
