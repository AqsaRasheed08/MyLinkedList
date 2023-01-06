using CustomLinkedList;
namespace MyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList.LinkedList<string> ll = new CustomLinkedList.LinkedList<string>();

            Node<string> a = new Node<string>("aaa");
            ll.AddFirst(a);

            Node<string> b = new Node<string>("bbb");
            ll.AddFirst(b);

            Node<string> c= new Node<string>("ccc");
            ll.AddFirst(c);

            Node<string> d = new Node<string>("ddd");
            ll.AddFirst(d);

            ll.Traverse();
            Console.WriteLine("Add after a ");
            ll.AddAfter(new Node<string>("xxx"), a);
            ll.Traverse();

            Node<string> target = ll.Find("ddd");
            if (target != null)
            {
                Console.WriteLine("found: " + target.Data);
            }
            else
            {
                Console.WriteLine("foobar");
            }

            Console.WriteLine("\nremoving " + target.Data);
            ll.Remove(target);
            ll.Traverse();
        }
    }
}