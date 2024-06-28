using System; 

namespace Example
{
  //Can be written in a single line, but the recommended form is as in the example below for ShortEnumWithAssignment
  public enum ShortEnumWithoutAssignment { None, Something }
  
  //Cannot be written in one line, because assignment of the value
  public enum ShortEnumWithAssignment
  {
    First = 0,
    Second = 1,
    Third = 2
  }

  /// <summary>
  /// Example white spaces rules.
  /// </summary>
  public class WhiteSpacesRules
  {
    private class Results
    {
      public int CountNegativeResults = 0;
      public int CountPositiveResults = 0;
    }

    private const int _lineMultiplier = 1907;
    
    private readonly Results _results;

    // Writing a short array in one line
    private readonly int[] _someShortArray = { 1, 2, 3 };
    
    // Container initializers use a 2
    private readonly int[,] _someTwoDimensionalArray =
    {
      {1, 2, 3},
      {4, 5, 6},
      {7, 8, 9}
    };

    public WhiteSpacesRules()
    {
      // Object initializers use a 2 space indent.
      _results = new Results
      {
        CountNegativeResults = 0,
        CountPositiveResults = 0
      };
    }

    public int ConditionsAndCycles(int mulNumber)
    {
      int lineNumber = 0;
      int columnNumber = 0;
      int columnCounts = _someTwoDimensionalArray.GetLength(0);

      foreach (int current in _someTwoDimensionalArray)
      {
        // Exception for using braces. 'if' with using 'return'/'continue'/'break'.
        if (current == mulNumber) // Spaces around comparison operator.
          return CalculateResult();
        
        columnNumber++;
        // Braces used even when optional.
        if (columnNumber >= columnCounts) // Spaces around comparison operator.
        {
          NewLine();
        }
      }

      _results.CountNegativeResults++;
      return -1;
      
      // Local functions.
      void NewLine()
      {
        lineNumber++;
        columnNumber = 0;
      }
      
      int CalculateResult()
      {
        _results.CountPositiveResults++;
        return _lineMultiplier * lineNumber + columnNumber;
      }
    }

    public void ExpressionBodies()
    {
      // For simple lambdas, fit on one line if possible, no brackets or braces required.
      Func<int, int> increment = x => x + 1;

      // Closing brace aligns with first character on line that includes the opening brace.
      Func<int, int, long> difference1 = (x, y) =>
      {
        long diff = (long)x - y;
        return diff >= 0 ? diff : -diff;
      };

      // If defining after a continuation line break, indent the whole body.
      Func<int, int, long> difference2 =
        (x, y) =>
        {
          long diff = (long)x - y;
          return diff >= 0 ? diff : -diff;
        };
    }

    // Empty blocks may be concise.
    private void DoNothing() { } 

    // If possible, wrap arguments by aligning newlines with the first argument.
    private void AVeryLongFunctionNameThatCausesLineWrappingProblems(int longArgumentName, int longArgumentName2, 
                                                                     int longArgumentName3)
    { }

    // If aligning argument lines with the first argument doesn't fit, or is difficult to
    // read, wrap all arguments on new lines with a 4 space indent.
    private void AnotherVeryLongFunctionNameThatCausesLineWrappingProblems(int longArgumentName, 
      int longArgumentName2, int longArgumentName3, int longArgumentName4, int longArgumentName5)
    { }

    private void CallingLongFunctionName()
    {
      int veryLongArgumentName = 1234;
      int shortArg = 1;
      // If possible, wrap arguments by aligning newlines with the first argument.
      AnotherVeryLongFunctionNameThatCausesLineWrappingProblems(shortArg, shortArg, veryLongArgumentName, 
                                                                veryLongArgumentName, veryLongArgumentName);
      // If aligning argument lines with the first argument doesn't fit, or is difficult to
      // read, wrap all arguments on new lines with a 4 space indent.
      AnotherVeryLongFunctionNameThatCausesLineWrappingProblems(veryLongArgumentName, veryLongArgumentName, 
          veryLongArgumentName, veryLongArgumentName,veryLongArgumentName);
    }
  }
}
