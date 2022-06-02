//main method



public class Node
{
    int data;
    public Node next;
    public Node(int d)
    {
        this.data = d;
    }

    public void printLinkedList(Node x)
    {
        var current = x;
        while (current != null)
        {
            Console.WriteLine(current.data);
            Console.ReadLine();
            current = current.next;
        }
    }

    //static void Main(string[] args)
    //{
    //    Node head = new Node(6);
    //    Node nodeB = new Node(2);
    //    Node nodeC = new Node(5);
    //    Node nodeD = new Node(8);

    //    head.next = nodeB;
    //    nodeB.next = nodeC;
    //    nodeC.next = nodeD;

    //    head.printLinkedList(head);

    //}

}




