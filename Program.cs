using System;

namespace Assgn1Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectOp;
            int noOfElements;
            int[] arr = new int[10];
            int positionOfNewElement;
            int i;

            Console.Write("\nNumber of Elements\n");
            noOfElements = Convert.ToInt32(Console.ReadLine());

            Console.Write("-----------------------------------------\n");

            Console.Write("\n\nWrite {0} elements of an array :\n", noOfElements);
            Console.Write("-----------------------------------------\n");
            for (i = 0; i < noOfElements; i++)
            {
                Console.Write("Element No: {0} - on Index {1} : ", i + 1, i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.Write("\nSelect Operations:\n");
            Console.Write("\n1: Traverse\n");
            Console.Write("\n2: Insertion\n");
            Console.Write("\n3: Deletion\n");

            Console.Write("\nChoose Number: ");


            selectOp = Convert.ToInt32(Console.ReadLine());

            if (selectOp==1)
            {
                Console.Write("\nElements in array are: ");
            for (i = 0; i < noOfElements; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n-----------------------------------------");
            Console.Write("\n");
            }

            else if (selectOp==2)
            {
                
            Console.Write("\nAdd New Element\n");
            int newElement;
            newElement = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPosition of New Elements\n");
           
            positionOfNewElement = Convert.ToInt32(Console.ReadLine());
            for (i = noOfElements; i >= positionOfNewElement; i--)
            {
                arr[i] = arr[i - 1];

            }

            arr[positionOfNewElement - 1] = newElement;

            Console.Write("\n\nNew Array after inserting\n");
            for (i = 0; i <= noOfElements; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n-----------------------------------------");

            Console.WriteLine("\n");
            }


            else if (selectOp==3)
            {
            Console.Write("\nElements in array are: ");
            for (i = 0; i < noOfElements; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            Console.Write("\n\nDelete a Element:");
            Console.Write("\nPosition of Delete Elements\n");
            positionOfNewElement = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n_______________________________\n");
        
            for (i = positionOfNewElement - 1; i < noOfElements; i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine("\nElements after deletion:\n ");
            noOfElements--;
            for (i = 0; i < noOfElements; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            }

        }
    }
}
