using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTW.DAL.Entities.Abstractions
{
    public interface IBaseEntity 
    {
        object Id { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? DeletedDate { get; set; }

        bool IsDeleted { get; set; }
       
        byte[] RowVersion { get; set; }
    }

    public interface IBaseEntity<T> : IBaseEntity
    {
        new T Id { get; set; }
    }
}
