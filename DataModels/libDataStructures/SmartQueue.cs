namespace libDataStructures;

public class SmartQueue<T>
{      
    private Node? head;
    public int Count { get; private set; }
    public SmartQueue()
    {
        this.head = null;
        this.Count = 0;
    }

    public T this[int i]
    {
        get{
            Node? current = head;
            for (int j = 0; current != null && j < Count; j++)
            {
                if (i == j)
                {
                    return current.element!;
                }
                current = current.Next;
            }
            throw new IndexOutOfRangeException();
        }
    }


    public IEnumerator<T> GetEnumerator()
    {
        Node? current = head;
        for (int i = 0; i < Count; i++)
        {
            yield return current!.element!;
            current = current.Next;
        }
    }

    public void Enqueue(T value, int priority = 0){

        Node newNode = new Node(value, priority);
        if (this.head == null) //Empty queue - this is the first element to be added
            this.head = newNode;
        else
        {
            //Step through existing nodes and find position of new node.
            Node? prev = null, current = head;
            while (current != null && current.priority >= newNode.priority)
            {
                prev = current;
                current = current.Next;
            }

            //Insert new node between prev and current
            if (prev != null)
                prev.Next = newNode;
            else //New node goes to the front
                head = newNode;
            newNode.Next = current;
        } //else
        Count++;
    }

    public T Dequeue()
    {
        if (head != null && Count > 0)
        {
            T? item = head.element;
            head = head.Next;
            Count--;
            return item!;
        }
        return default(T)!;
    }
    public void Clear()
    {
        this.head = null;
        this.Count = 0;
    }

    public T Peek()
    {
        if (head != null && Count > 0) return head!.element!;
        return default(T)!;
    }

    public bool Contains(T item)
    {
        Node? current = head;
        return Position(item) > -1;
    }

    //find index
    public int Position(T item)
    {
        Node? current = head;
        if(current != null)
        {
            for (int i = 0; i < Count; i++)
            {   
                if (current.element == null) continue;
                else if (current.element.Equals(item)) return i;
                else if (current.Next != null) current = current.Next;
            }
        }
        return -1;
    }

    public bool IsEmpty(){
        return Count <= 0;
    }
    private class Node{
        public int priority { get; private set; }
        public T? element { get; private set; }
        public Node? Next { get; set; }

        public Node(T element, int priority)
        {
            this.element = element;
            this.priority = priority;
            Next = null;
        }
    }
}