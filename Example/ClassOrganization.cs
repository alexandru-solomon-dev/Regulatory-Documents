using System;
using System.Collections.Generic;
using UnityEngine;

namespace Example
{
  /// <summary>
  /// An example of class member ordering. Don't pay attention to horrible names.
  /// </summary>
  [Serializable]
  public class ClassOrganization : IDisposable
  {
    // Nested Classes
    [Serializable]
    protected class ProtectedNestedClass { }

    private class PrivateNestedClass { }

    // Enums
    private enum MyEnum
    {
      First = 0,
      Second = 1,
      Third = 2
    }

    // Delegates
    public delegate void MyDelegate(int parameter);

    protected delegate float MyPrivateDelegate(int parameter);

    // Events
    public event MyDelegate OnDoSomething;
    
    protected event Action<ProtectedNestedClass> OnProtectedAction = delegate { };

    // static Fields
    public static int Counter;

    // const
    protected const float Epsilon = 0.01f;
    private const string _animationName = "Animation";

    // readonly Fields
    public readonly string Name;
    protected readonly int AnimationHash = Animator.StringToHash(_animationName);
    private readonly float[] _readonlyArray;

    // Fields
    [Range(0, 1)] public float FunctionalValue;
    [HideInInspector] public int FunctionalValue2;

    [SerializeField] private ProtectedNestedClass _protectedNestedClass;
    protected int FunctionalValue3;
    protected List<float> _floatList = new();

    private Queue<MyPrivateDelegate> _delegatesQueue = new();
    private MyEnum _enumValue;

    // Properties
    public IReadOnlyList<float> FloatArray => _readonlyArray;

    public float FirstElement
    {
      get
      {
        if (ListIsEmpty)
          return -1;

        return _floatList[0];
      }

      protected set
      {
        if (ListIsEmpty)
        {
          _floatList.Add(value);
        }
        else
        {
          _floatList[0] = value;
        }
      }
    }

    private bool ListIsEmpty => _floatList.Count == 0;

    // static Constructor
    static ClassOrganization()
    {
      Counter = 0;
    }
    
    // Constructors
    public ClassOrganization(string name) : this(name, Array.Empty<float>())
    {
    }

    public ClassOrganization(string name, float[] array)
    {
      Name = name;
      _readonlyArray = array;
      Counter++;
    }

    // Destructor
    ~ClassOrganization()
    {
      OnDoSomething = null;
      OnProtectedAction = null;
      _delegatesQueue = null;
      Counter--;
    }

    //Custom constructors for Monobehavior's, Initializing, Dispose
    public void Init() 
    {
      //...
    }


    public void Dispose()
    {
      //...
    }


    // public Methods
    public void PublicFoo1()
    {
      //...
    }

    public void PublicFoo2()
    {
      //...
    }

    // protected Methods
    protected void NoticeOfSomething(int value) => OnDoSomething?.Invoke(value);

    protected float ProtectedFoo1()
    {
      float result = 0;
      //...
      return result;
    }

    // place for Monobehavior's event Methods
    //...

    // private Methods
    private void PrivateFoo1()
    {
      //...
    }

    private void PrivateFoo2(int value)
    {
      //...
    }
    
    // static Methods
    protected static float ProtectedStaticFoo(float value, bool isNegative) => isNegative ? -value : value;
    
    private static float PrivateStaticFoo(float value) => Counter * value * value;
  }
}
