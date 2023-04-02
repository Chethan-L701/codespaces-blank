using System;
using System.Collections.Generic;

namespace App
{
    class Node<Type>
    {
        public Type data;
        public Node<Type> link = null;
        public Node(Type data)
        {
            this.data = data;
        }
    }
    public class Stack<Type>
    {
        private Node<Type> top = null;

        public void push(Type data)
        {
            if (top == null)
            {
                top = new Node<Type>(data);
                return;
            }
            Node<Type> temp = new Node<Type>(data);
            temp.link = top;
            top = temp;
        }
        public Type peek()
        {
            return top.data;
        }
        public Type pop()
        {
            if (top == null) throw new Exception("Stack underflow!!");
            Type item;
            item = top.data;
            top = top.link;
            return item;
        }
        public void display()
        {
            Node<Type> temp = top;
            while (temp != null)
            {
                Console.Write(temp.data.ToString() + '\t');
                temp = temp.link;
            }
            Console.WriteLine();
        }
        public bool isPresent(Type key)
        {
            Node<Type> temp = top;
            while (temp != null)
            {
                if (temp.data.ToString() == key.ToString())
                    return true;
                temp=temp.link;
            }
            return false;
        }
    }
    class Person
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.push(20); stack.push(10); stack.push(30); stack.push(40);
            stack.push(50); stack.push(60);
            stack.display();
            stack.pop(); stack.pop();
            stack.display();
            Console.WriteLine($"The data 40 is present in the Stack : {stack.isPresent(40)}");
            Console.WriteLine($"The data 90 is present in the Stack : {stack.isPresent(90)}");
        }
    }
}