using System;

namespace News.Domain.Entity
{
    public interface IBaseEntity
    {
        int InserBy { get; set; }
        DateTime insertDate { get; set; }
        int UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }
    }
}