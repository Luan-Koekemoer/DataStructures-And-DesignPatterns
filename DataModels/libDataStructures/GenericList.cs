namespace libDataStructures;

public class GenericList<T>{
    private T[] elements;
    public T this[int index]
    {
        get { return elements[index]; }
        set { elements[index] = value; }
    } //indexer

    public int Count {get; private set;}
    private int Size {
        get{return elements.Length;}
    }

    public GenericList(){
        elements = new T[10];
        Count = 0;
    }
    
    public GenericList(int initialSize){
        elements = new T[initialSize]; 
        Count = 0;
    }

    public void AddElement(T element){
        if(Count < Size && element != null){
            elements[Count] = element;
        }
        else{
            ArrayHelper<T>.IncreaseArraySize(ref elements);
        }
        Count++;
    }

    public void RemoveElement(T element){

    }

    
}
