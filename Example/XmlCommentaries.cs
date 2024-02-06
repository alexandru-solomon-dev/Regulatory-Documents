using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Example
{
  /// <summary>
  /// Example with illustration of how to use xml-comments and its design rules.
  /// </summary>
  /// <seealso cref="MonoBehaviour"/>
  public class XmlCommentaries : MonoBehaviour
  {
    /// <summary>
    /// Nested class that is not needed for anything.
    /// </summary>
    /// <typeparam name="T">Base Element Type. Which is not needed here.</typeparam>
    /// <seealso cref="IDisposable"/>
    /// <seealso cref="IMyInterface"/>
    protected class MyClass<T> : IDisposable, IMyInterface
    {
      protected T Value;
    
      public void Dispose()
      {
      }
    }

    /// <summary>
    /// Delegate description.
    /// </summary>
    /// <param name="par1"> Count something. </param>
    /// <param name="arg2"> Functional value. </param>
    /// <returns> Performance result. </returns>
    protected delegate float MyDelegate(int par1, string arg2);

    /* Although xml can't get a reference to parameters for events,
       describing them like this will be useful
       to clarify which parameter is responsible for what. */
    
    /// <summary>
    /// This event notify about something.
    /// </summary>
    /// <param name="arg1">Description for first argument.</param>
    /// <param name="arg2">Description for second argument.</param>
    /// <remarks>Don't forget to unsubscribe from events!</remarks>
    /// <example> <c> xmlCommentaries.OnSomeThing += NotifyHandlerMethod;</c> </example>
    /// <seealso cref="Action{T1,T2}"/>
    public event Action<int, float> OnNotifySomething;
    
    /// <summary>
    /// Set pause the game.
    /// </summary>
    /// <value>Paused game state.</value>
    public bool IsPause
    {
      get => _isPause;
      set => SetPause(value);
    }

    private bool _isPause;

    // Bad example of specifying references to code members, in such a case it is better to specify in <seealso>

    /// <summary>
    /// Replaces an integer array with an array filled with random values.
    /// A very long method description 
    /// that will not look comfortable on a single line.
    /// Reference on method: <see cref="Replicate{T}"/>,
    /// see also properties <see cref="IsPause"/>,
    /// see also class <see cref="MyClass"/>,
    /// </summary>
    /// <param name="array">Reference to the array to be replaced.</param>
    /// <param name="maxArraySize">Maximum count elements for new array.</param>
    public void ReplaceWithRandomArray(ref int[] array, int maxArraySize)
    {
      array = new int[Random.Range(0, 10)];
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = Random.Range(Int32.MinValue, Int32.MaxValue);
      }
    }

    /// <summary>
    /// Create list with copies references item.
    /// </summary>
    /// <param name="original">Reference element for copy.</param>
    /// <param name="count">Count copy elements.</param>
    /// <typeparam name="T">The base item type. Class that must implement ICloneable.</typeparam>
    /// <returns>Sheet containing copies of the item.</returns>
    /// <exception cref="System.ArgumentException">Thrown when <paramref name="count"/><c> &lt; 0</c>.</exception>
    /// <remarks>
    /// A very important method. It's the only one! Support it on the patreon service.
    /// <see href="https://www.patreon.com/"/>
    /// </remarks>
    /// <seealso cref="CopyItem{T}"/>
    /// <seealso cref="ReplaceWithRandomArray"/>
    public List<T> Replicate<T>(T original, int count) where T : class, ICloneable
    {
      if (count < 0)
      {
        throw new ArgumentException("Parameter 'count', can not be lower 0.", nameof(count));
      }
 
      List<T> result = new List<T>(count);

      for (int i = 0; i < count; i++)
      {
        result.Add(CopyItem(original));
      }
      
      return result;
    }

    private T CopyItem<T>(T original) where T : class, ICloneable
    {
      return (T)original.Clone();
    }

    private void SetPause(bool value)
    {
      throw new NotImplementedException();
    }
  }
}
