using System.Collections.Generic;

namespace Extras
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
        return this.Contains(value);

    }
}
}