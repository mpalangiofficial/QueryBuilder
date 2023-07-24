using System;
using System.Collections.Generic;

namespace QueryBuildersSample
{
    public interface ISource
    {
        List<string> Fields { get; set; }
        List<Object> RecordSet { get; set; }
        event EventHandler RecordSetFilled;
    }
}