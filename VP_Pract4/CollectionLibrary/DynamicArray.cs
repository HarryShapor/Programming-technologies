using System.Collections;
using System.Text;

namespace CollectionLibrary
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] dynamicArray;
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new Exception("Неверное значение индексатора!");
                }
                return dynamicArray[index];
            }
        }
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public DynamicArray() {
            this.Capacity = 10;
            this.dynamicArray = new T[this.Capacity];
        }

        public DynamicArray(int capacity)
        {
            if (capacity <= 0)
            {
                throw new Exception("Значение может быть только положительным!");
            }
            this.Capacity = capacity;
            this.dynamicArray = new T[this.Capacity];
        }

        public void Add(T element)
        {
            if (element.GetType().Equals(typeof(T)))
            {
                if (this.Count >= this.Capacity)
                {
                    this.IncreaseCapacity(this.Capacity);
                }
                this.dynamicArray[this.Count++] = element;
            }
            else
            {
                throw new Exception("Элемент не соответствует типу коллекции!");
            }
        }

        public void Add(IEnumerable<T> elements)
        {
            foreach (var element in elements)
            {
                this.Add(element);
            }
        }

        public void Insert(T element, int position)
        {
            if (element.GetType().Equals(typeof(T)))
            {
                if (this.Count > position && position > 0)
                {
                    if ((this.Count+1) >= this.Capacity)
                    {
                        this.IncreaseCapacity(this.Capacity);
                    }
                    for (int i = this.Count; i >= position; i--)
                    {
                        this.dynamicArray[i+1] = this.dynamicArray[i];
                    }
                    this.Count++;
                    this.dynamicArray[position] = element;
                }
                else
                {
                    throw new Exception("Позиция больше длины коллекции/не положительная!");
                }
            }
            else
            {
                throw new Exception("Элемент не соответствует типу коллекции!");
            }
        }

        public void RemoveAt(int position)
        {
            if (this.Count > position && position > 0)
            {
                for (int i = position; i < this.Count - 1; i++)
                {
                    this.dynamicArray[i] = this.dynamicArray[i + 1];
                }
                this.Count--;
                this.dynamicArray[this.Count] = default(T);

            }
            else
            {
                throw new Exception("Позиция больше длины коллекции/не положительная!");
            }
        }

        public void IncreaseCapacity(int n)
        {
            if (n < 0 && (this.Capacity + n) < Count)
            {
                throw new Exception("Недопустимое значение");
            }
            T[] dynamic = this.dynamicArray;
            this.Capacity += n;
            this.dynamicArray = new T[this.Capacity];
            for (int i = 0; i < this.Count; i++)
            {
                dynamicArray[i] = dynamic[i];
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                stringBuilder.Append(dynamicArray[i] + ",");
            }
            stringBuilder.Length--;

            return stringBuilder.ToString();
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
