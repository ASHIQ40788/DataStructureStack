using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class LinkedListStack
    {    
        public Node top;

        //UC1 Pushing the New Data
        public void Push(int newData)
        {
            ///creating a link between newnode and where top is pointing
            ///then pointing top towards the new node 
            ///new node is inserted on the top 
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top; // newnode will hold the address of top element
            }
            this.top = newNode;// top will point to new element
            Console.WriteLine("New node {0} is added", newNode.data);
        }

           // Displaying the values in the stack
      
        public void Display()
        {
            ///checking if stack is not empty
            ///printing values till temp point towards null i.e. end of stack 
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("no values to display , empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the stack : " + temp.data);
                temp = temp.next;
            }
        }

    }
}
    
    
    
    



