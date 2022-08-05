namespace libDataStructures;

public class Stack<T>
{
    private T[] elements;

    public int Count {get; private set;}
    private int Size {
        get{return elements.Length;}
    }

    public Stack(){
        elements = new T[10];
        Count = 0;
    }
    
    public void Push(T element){
        if(Count < Size && element != null){
            elements[Count] = element;
        }
        else{
            ArrayHelper<T>.IncreaseArraySize(ref elements);

        }
        Count++;
    }

    public T Pop(){
        T element = elements[Count - 1];
        return elements[Count--];
    }

    public int StackPosition(T element){
        for (int i = 0; i < Count; i++)
        {
            if(elements[i]!.Equals(element)) return i;
        }
        return -1;
    }
}
