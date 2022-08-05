namespace libDataStructures;

class ArrayHelper<T>
{
    public static void IncreaseArraySize(ref T[] current){
        int count = current.Length;
        T[] temp = new T[count * 2];

        for (int i = 0; i <= count; i++)
        {
            temp[i] = current[i];     
        }
        current = temp;

    }

    public static void DecereaseArraySize(){

    }
}
