using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasky.PortableLibrary;

namespace TaskyPortableLibrary
{
    public static class AnalyticsHelper
    {
        public static IDictionary<string, string> ConstructProperties(TodoItem todoItem)
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties.Add("TodoName", todoItem.Name);
            properties.Add("TodoNotes", todoItem.Notes);
            return properties;
        }
    }
}
