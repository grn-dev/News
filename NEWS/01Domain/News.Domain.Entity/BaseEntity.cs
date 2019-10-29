using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public abstract  class BaseEntity<T> : IBaseEntity
    {
        public T ID { get; set; }

        public DateTime insertDate{ get; set; }

        public DateTime UpdateDate { get; set; }
        public int InserBy { get; set; }
        public int UpdateBy { get; set; }
    }
}
