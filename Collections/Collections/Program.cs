using Collections.IDictionary;
using Collections.IList;
using Collections.ISet;
using Collections;


// -==================== IList ====================-
// -==================== ArrayList
//new ArrayListExample().Run();

// -==================== List<T>
//new ListExample().Run();

// -==================== LinkedList<T>
//new LinkedListExample().Run();

// -==================== IDictionary ====================-
// -==================== Dictionary<TKey, TValue>
//new DictionaryExample().Run();

// -==================== SortedDictionary<TKey, TValue>
//new SortedDictionaryExample().Run();

// -==================== SortedList<TKey, TValue>
//new SortedListExample().Run();

// -==================== HashSet<TKey, TValue>
//new HashSetExample().Run();

// -==================== Stack<T>
//new StackExample().Run();

// пример 

new Example().Run();

// equals
Person person1 = new Person()
{
    FirstName = "Alex",
    LastName = "Trytrytry"
};
Person person2 = new Person()
{
    FirstName = "Alex",
    LastName = "Trytrytry"
};

Console.WriteLine(person1.GetHashCode());
Console.WriteLine(person2.GetHashCode());
Console.WriteLine(person1.Equals(person2));

// yield исп для создания итераторов в методах (позволяет возвращать в методах элементы последовательно)



/*
// -==================== Queue<T>
new QueueExample().Run();
*/