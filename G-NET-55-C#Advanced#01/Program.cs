using System.Data.Common;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace G_NET_55_C_Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Assignment 01 c# advanced 

            //Q1: What is a generic class? Why use generics?
            //A generic class is a class that can work with any data type.Generics provide type safety, code reusability, and performance benefits by avoiding boxing and unboxing of value types.
            //--------------------------------------------

            //Q2: Write a generic class Container<T> with Add and Get methods.
            // public class Container<T>
            //{
            //private List<T> items = new List<T>();  
            //    public void Add(T item)
            //    {
            //        items.Add(item);
            //    }
            //    public T Get(int index)
            //    {
            //        if (index < 0 || index >= items.Count)
            //            throw new ArgumentOutOfRangeException(nameof(index), "Invalid index");
            //        return items[index];
            //    }
            //}
            //--------------------------------------------

            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>
            //You can define multiple type parameters to make your class or method more flexible.
            //public class Pair<TKey, TValue>
            //{
            //public TKey Key { get; set; }
            //public TValue Value { get; set; }

            //    public Pair(TKey key, TValue value)
            //    {
            //        Key = key;
            //        Value = value;
            //    }
            //}
            //--------------------------------------------

            //Q4: What is a generic method? Write Swap<T> method.
            //A generic method is a method that is defined with type parameters, allowing it to work with different data types without rewriting the code
            //public static void Swap<T>(ref T a, ref T b)
            //{
            //    T temp = a;
            //    a = b;
            //    b = temp;
            //}
            //--------------------------------------------

            //Q5: Write a generic method FindMax < T > that finds maximum value:
            //    public static T FindMax<T>(T[] array) where T : IComparable<T>
            //{
            //    if (array == null || array.Length == 0)
            //        throw new ArgumentException("Array must not be empty");
            //--------------------------------------------

            //    T max = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i].CompareTo(max) > 0)
            //        {
            //            max = array[i];
            //        }
            //    }
            //    return max;
            //}
            //--------------------------------------------

            //Q6: What is a generic interface? Write IRepository<T>
            //A generic interface is an interface that defines operations using type parameters. This allows the interface to be reused for different data types without rewriting it
            //public interface IRepository<T>
            //{
            //    void Add(T item);
            //    void Remove(T item);
            //    T GetById(int id);
            //    IEnumerable<T> GetAll();
            //}
            //--------------------------------------------

            //Q7: What is the 'struct' constraint? Write an example.
            //The struct constraint specifies that the type argument must be a value type
            //public static T GetDefaultValue<T>() where T : struct
            //{
            //    return default(T);
            //}
            //--------------------------------------------

            //Q8: What is the 'class' constraint? Write an example.
            //the class constraint restricts a generic type parameter to be a reference type. This means the type must be a class, interface, delegate, or array
            //public static T CreateInstance<T>() where T : class, new()
            //{
            //    return new T();
            //}
            //--------------------------------------------


            //Q9: What is the 'new()' constraint? Write an example.
            //constraint restricts a generic type parameter to types that have a public parameterless constructor.
            //public static T CreateInstance<T>() where T : new()
            //{
            //    return new T();
            //}
            //--------------------------------------------

            //Q10: What is the interface constraint? Write an example.
            //It ensures that the generic type supports certain methods or properties defined by that interface.
            //public static T FindMax<T>(List<T> items) where T : IComparable<T>
            //{
            //    if (items == null || items.Count == 0)
            //        throw new ArgumentException("List must not be empty");
            //--------------------------------------------

            //    T max = items[0];
            //    foreach (var item in items)
            //    {
            //        if (item.CompareTo(max) > 0)
            //        {
            //            max = item;
            //        }
            //    }
            //    return max;
            //}
            //--------------------------------------------

            //Q11: What is the base class constraint? Write an example.
            //This ensures that the generic type has all the members of that base class available, making your code safer and more predictable.
            //public class Entity
            //{
            //public int Id { get; set; }
            //}
            //public class Repository<T> where T : Entity
            //{
            //private List<T> items = new List<T>();
            //--------------------------------------------

            //    public void Add(T item)
            //{
            //        items.Add(item);
            //}
            //--------------------------------------------

            //Q12: How do you apply multiple constraints? Write an example.
            //multiple constraints to a generic type parameter.
            //This means you can restrict the type to:
            //Be a class or struct
            //Implement one or more interfaces
            //Have a parameterless constructor(new ())
            //Or inherit from a specific base class
            //public class Repository<T> where T : Entity, IComparable<T>, class, new()
            //--------------------------------------------


            //Q13: What does the 'default' keyword do in generics?
            //the default keyword is used to provide the default value of a type parameter T.
            //--------------------------------------------

            //Q14: Write a SafeList < T > that returns default when the index is invalid.
            //private List<T> items = new List<T>();
            //public void Add(T item)
            //{
            //    items.Add(item);
            //}
            //public T Get(int index)
            //{
            //    if (index < 0 || index >= items.Count)
            //        return default(T); // return safe default value
            //    return items[index];
            //}
            //--------------------------------------------

            //Q15: What is covariance? Explain the 'out' keyword.
            //you can assign an object of a more specific type to a variable of a more general type when working with generics.
            //Covariant type parameters can be used only as return types (output positions), not as method parameters (input).
            //--------------------------------------------

            //Q16: What is contravariance? Explain the 'in' keyword.
            //Contravariance allows you to use a less derived type (a base type) than originally specified
            //Contravariant type parameters can be used only as input parameters (method arguments), not as return types.
            //--------------------------------------------

            //Q17: What is the difference between covariance and contravariance?
            //1: Covariance(out)
            //Definition: Allows you to substitute a more derived type for a less derived type.
            //Direction: Derived → Base.
            //Keyword: out.
            //Usage: Only in output positions(return values, property getters).
            //2 : Contravariance(in)
            //Definition: Allows you to substitute a less derived type for a more derived type.
            //Direction: Base → Derived.
            //Keyword: in.
            //Usage: Only in input positions(method parameters).
            //--------------------------------------------

            //Q18: How do static members work in generic types?
            //static members (fields, properties, methods) inside a generic type are unique per closed type.
            //--------------------------------------------

            //Q19: How can you inherit from a generic class?
            //Specify the type paramete when inheriting (close the generic type).
            //Or keep the type parameter open and pass them along to the derived class.
            //--------------------------------------------
            //Q20: Complete Exercise -Create a generic Cache < TKey, TValue>with Add, Get, Remove, Contains, and expiration support.
            //    public class Cache<TKey, TValue>
            //{
            //    private class CacheItem
            //    {
            //        public TValue Value { get; set; }
            //        public DateTime Expiration { get; set; }
            //    }

            //    private readonly Dictionary<TKey, CacheItem> items = new Dictionary<TKey, CacheItem>();

            //    // Add with expiration in seconds
            //    public void Add(TKey key, TValue value, int expirationSeconds)
            //    {
            //        items[key] = new CacheItem
            //        {
            //            Value = value,
            //            Expiration = DateTime.Now.AddSeconds(expirationSeconds)
            //        };
            //    }

            //    // Remove item
            //    public void Remove(TKey key)
            //    {
            //        items.Remove(key);
            //    }


            //    public bool Contains(TKey key)
            //    {
            //        if (items.TryGetValue(key, out CacheItem item))
            //        {
            //            if (DateTime.Now <= item.Expiration)
            //                return true;
            //            else
            //                items.Remove(key);
            //        }
            //        return false;
            //    }
            //}
            #endregion 
        }
    }
}
