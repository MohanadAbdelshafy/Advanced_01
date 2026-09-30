namespace C_Advanced_01
{
    #region Q2 container
    //public class Container<T>
    //{
    //    private T _item;

    //    public void Add(T item)
    //    {
    //        _item = item;
    //    }

    //    public T Get()
    //    {
    //        return _item;
    //    }
    //}
    #endregion
    #region Q3 class
    //public class Pair<TKey, TValue>
    //{
    //    public TKey Key { get; set; }
    //    public TValue Value { get; set; }

    //    public Pair(TKey key, TValue value)
    //    {
    //        Key = key;
    //        Value = value;
    //    }
    //}
    #endregion
    #region Q6 Interface
    //public interface IRepository<T>
    //{
    //    void Add(T entity);
    //    T GetById(int id);
    //    void Delete(T entity);
    //}
    #endregion
    #region Q7 class
    //public class MathCalculator<T> where T : struct
    //{
    //    public T Value { get; set; }
    //} 
    #endregion
    #region Q8
    //public class ObjectProcessor<T> where T : class
    //{
    //    public void ProcessObject(T obj)
    //    {
    //        if (obj != null) { /* Do something */ }
    //    }
    //}
    #endregion
    #region Q9 Class
    //public class Factory<T> where T : new()
    //{
    //    public T CreateInstance()
    //    {
    //        return new T();
    //    }
    //}
    #endregion
    internal class Program
    {
        #region Q4 method
        //public void Swap<T>(ref T a, ref T b)
        //{
        //    T temp = a;
        //    a = b;
        //    b = temp;
        //} 
        #endregion
        #region Q5 method
        //public T FindMax<T>(T first, T second) where T : IComparable<T>
        //{
        //    // CompareTo returns > 0 if the first is greater than the second
        //    if (first.CompareTo(second) > 0)
        //    {
        //        return first;
        //    }
        //    return second;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //A generic class is a class defined with a type parameter that allows it to be instantiated with any data type, meaning the
            // exact type is defined at the time of object creation, not during class definition.

            //Type Safety: It prevents runtime type-casting errors by enforcing type checks at compile-time.
            //Performance: It avoids the overhead of boxing and unboxing when using value types.
            //Code Reusability: You write the logic once and use it with multiple different data types.
            #endregion
            #region Q3
            //Generics can accept more than one type parameter, separated by commas. This is useful when a class or 
            //method needs to handle two or more distinct types simultaneously (like a dictionary key and its value).

            #endregion
            #region Q4
            //A generic method is a method that is declared with type parameters. It can exist inside a generic or non-generic 
            //class and allows the method to process different data types seamlessly.

            #endregion
            #region Q6
            //A generic interface defines a contract with generic type parameters. Any class implementing this interface must provide the specific 
            //type or remain generic itself.
            #endregion
            #region Q7
            //The where T : struct constraint ensures that the generic type parameter T must be a non-nullable value type
            #endregion
            #region Q8
            //The where T : class constraint ensures that the generic type parameter T must be a reference type
            #endregion
            #region Q9
            //The where T : new() constraint requires that the generic type T must have a public, parameterless constructor (a default constructor).
            //This allows the generic class/method to create new instances of T.
            #endregion

        }
    }
}
