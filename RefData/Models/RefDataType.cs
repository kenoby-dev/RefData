using System;
using System.Collections.Generic;

namespace RefData.Models
{
    public class RefDataType
    {
        public RefDataType()
        {
        }

		public string Name { get; set; }
		public IEnumerable<RefDataItem> Items { get; set; }
    }
}
