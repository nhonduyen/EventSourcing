﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public interface IDomainEvent<out TKey>
    {
        public long AggregateVersion { get; }
        TKey AggregateId { get; }
        DateTime TimeStamp { get; }
    }
}
