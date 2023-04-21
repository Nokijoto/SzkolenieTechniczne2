using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Common.Storage.Interfaces
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }

}
