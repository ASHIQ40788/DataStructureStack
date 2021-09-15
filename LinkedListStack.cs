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

        //UC2  Displaying the top element

        public void Peek()
        {
            //Checking if top element is null
            //otherwise printing the top element
            if (this.top == null)
            {
                Console.WriteLine("no element present to Peek");
                return;
            }
            Console.WriteLine("Top most element " + this.top.data);
        }



        /// UC2 Displaying and Deleting the top element

        public void Pop()
        {
            ///Checking if top element is null
            ///otherwise printing the top element and deleting it also
            if (this.top == null)
            {
                Console.WriteLine("no element present to Pop");
                return;
            }
            //Console.WriteLine("The element poped is " + this.top.data);
            int deleteNode = this.top.data;
            Peek();
            this.top = this.top.next;
            Console.WriteLine("Deleted element is {0}", deleteNode);
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {
                Pop();
            }
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
    
    
    
    



