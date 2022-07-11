using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingToRememberDataStructures.Stack
{
    public class StackItem
    {
        public string Value { get; set; }

        public StackItem? NextItem { get; set; } = null;


        public StackItem(string value, StackItem? item)
        {
            Value = value;
            NextItem = item;
        }
    }
}
