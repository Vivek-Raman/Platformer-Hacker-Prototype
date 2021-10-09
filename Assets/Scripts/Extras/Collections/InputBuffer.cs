using System.Collections.Generic;

namespace Extras.Collections
{
public class Buffer<T> : Queue<T>
{
    private readonly int bufferSize;

    public Buffer(int bufferSize)
    {
        this.bufferSize = bufferSize;
    }

    public void Push(T value)
    {
        if (this.Count > bufferSize)
        {
            this.Dequeue();
        }

        this.Enqueue(value);
    }



    public bool Poll(T value)
    {
        if (this.Contains(value))
        {
            this.Clear();
            return true;
        }

        return false;
    }
}
}