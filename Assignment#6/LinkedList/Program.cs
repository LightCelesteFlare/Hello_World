using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        private static readonly string[] colors =

        {"black", "yellow", "green", "blue", "violet", "silver", "gold", "white", "brown", "blue", "gray"};

        private static readonly string[] colors2 =

        {};


        // set up and manipulate LinkedList objects

        static void Main()

        {

            var list1 = new LinkedList<string>();


            // add elements to first linked list

            foreach (var color in colors)

            {

                list1.AddLast(color);

            }


            // add elements to second linked list via constructor

            var list2 = new LinkedList<string>(colors2);

            Console.WriteLine("\nThis is List1");
            PrintList(list1);
            Console.WriteLine("\nThis is List2");
            PrintList(list2);

            Console.WriteLine("------Before combining and reserving--------");
            Concatenate(list2, list1); // concatenate list2 onto list1

            Console.WriteLine("\nThis is List1");
            PrintList(list1);

            Console.WriteLine("\nPrinting Reservered List 2");
            PrintList(list2);

            Console.ReadKey();
        }


        // display list contents

        private static void PrintList<T>(LinkedList<T> list)

        {

            Console.WriteLine("Linked list: ");


            foreach (var value in list)

            {

                Console.Write($"{value} ");

            }


            Console.WriteLine();

        }


        // concatenate the second list on the end of the first list

        private static void Concatenate<T>(

        LinkedList<T> list1, LinkedList<T> list2)

        {

            // concatenate lists by copying element values

            // in order from the second list to the first list
            LinkedListNode<T> currentNode = list2.Last;
            while (currentNode != null)

            {
                list1.AddLast(currentNode.Value);
                //Console.Write($"{currentNode.Value} ");

                currentNode = currentNode.Previous; // get previous node
            }

            //foreach (var value in list2)
            //{
            //    list1.AddLast(value); // add new node
            //}

        }


        // locate string objects and convert to uppercase


        // display reversed list

        private static void PrintReversedList<T>(LinkedList<T> list)

        {

            Console.WriteLine("Reversed List:");


            // iterate over the list by using the nodes

            LinkedListNode<T> currentNode = list.Last;


            while (currentNode != null)

            {

                Console.Write($"{currentNode.Value} ");

                currentNode = currentNode.Previous; // get previous node

            }


            Console.WriteLine();

        }

    }


}
