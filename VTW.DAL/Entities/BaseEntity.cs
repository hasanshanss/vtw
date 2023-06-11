using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using VTW.DAL.Entities.Abstractions;

namespace VTW.DAL.Entities
{
    public abstract class BaseEntity<T> : IBaseEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        object IBaseEntity.Id
        {
            get { return this.Id; }
            set { this.Id = (T)value; }
        }

        bool IBaseEntity.IsDeleted
        {
            get { return this.IsDeleted; }
            set { this.IsDeleted = value; }
        }

        private DateTime? createdDate;
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate
        {
            get { return createdDate ?? DateTime.UtcNow; }
            set { createdDate = value; }
        }

        private string createdBy;
        public string CreatedBy
        {
            get { return this.createdBy; }
            set { this.createdBy = value; }
        }


        [DataType(DataType.DateTime)]
        public DateTime? DeletedDate { get; set; }

        public bool IsDeleted { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
