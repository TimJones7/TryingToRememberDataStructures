using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingToRememberDataStructures.Stack
{
    public class MyStack
    {

        //  A stack is defined by a last-in -> first-out structure
        //  Therefore we care about the top item in the stack
        //  Also it will point to the next item in the stack
        //  If it's the last item it will point to null

        public StackItem? TopOfStack { get; set; }


        public MyStack(string information)
        {
            //  Call constructor for new Item 
            //  Since this is a new stack, the top will point
            //  to the next item as being null
            var newItem = new StackItem(information, null);
            this.TopOfStack = newItem;
        }

        //  View top of Stack
        public StackItem PeekTop()
        {
            return this.TopOfStack;
        }

        //  Add item to Stack
        public void InsertItem(string information)
        {
            //  Get current top
            var currentTop = this.PeekTop();
            //  Call constructor for new item
            var newTop = new StackItem(information, currentTop);
            //  Set new item as top of Stack
            this.TopOfStack = newTop;
        }

        //  Remove item from Stack
        public void PopTop()
        {
            //  First we need to make sure that the nextItem isn't null
            //  Meaning we are at the bottom of the Stack
            //  Set new Stack top to be NextItem of current top
            var currentTop = this.PeekTop();
            var newTop = currentTop.NextItem;

            if (newTop is null)
            {
                this.TopOfStack = null;
            }
            this.TopOfStack = newTop;
        }

    }
}
