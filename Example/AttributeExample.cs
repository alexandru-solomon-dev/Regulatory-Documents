using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Example
{
   /// <summary>
   /// Example of attribute usage rules.
   /// </summary>
   [ExecuteInEditMode]
   [CreateAssetMenu(menuName = "Example/AttributeUsage", fileName = "AttributeExample")]
   public class AttributeExample : ScriptableObject
   {
      private const int _minimum = 0;
      private const int _maximum = 0;

      [HideInInspector] public int DontVisibleForInspector;
      
      [Header("Functional variable block")]
      [Tooltip("Description for field")]
      [Range(_minimum, _maximum)]
      [SerializeField]
      private float _powerValue = _minimum;
      [SerializeField] 
      private int _multiplier1 = 0;
      [Tooltip("Description for field")]
      [Min(0)]
      [SerializeField]
      private int _multiplier2;
      [Header("Functional variable block 2")]
      [Tooltip("Description for field")]
      [SerializeField]
      private int _functionalVarriable;

      [ContextMenu("Change Functional Value")]
      private void SetRandomValue()
      {
         _powerValue = Random.Range(_minimum, _maximum);
      }
      
      [ContextMenu("Change Functional Value")]
      private void PrintResult()
      {
         Debug.Log(Math.Pow(_multiplier1 * Math.Abs(_multiplier2), _powerValue));
      }
   }
}