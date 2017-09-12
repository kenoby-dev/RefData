using System;
using System.Collections.Generic;
using RefData.Models;

namespace RefData
{
    public interface IRefDataProvider
    {
		IEnumerable<RefDataType> ListTypes();
		RefDataType AddType(string typeName);
		RefDataType DeleteType(string typeName);

		IEnumerable<RefDataItem> ListItems(string typeName, bool validOnly = true);
		RefDataItem GetItem(string typeName, string code);
		RefDataItem GetItem(string id);

    }
}
