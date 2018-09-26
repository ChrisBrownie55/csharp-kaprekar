using System;
using System.Collections.Generic;

namespace kaprekar {
  public class Kaprekar {
    public int IterationCount { get; private set; }
    private int CurrentNumber = 6459;

    public string SortNumber(bool ascending) {
      CurrentNumber.ToString().Split();
      Console.WriteLine(String.Join("", new JSArray<char>(CurrentNumber.ToString().ToCharArray()).Sort((a, b) => {
        int x = int.Parse(a.ToString());
        int y = int.Parse(b.ToString());
        return x < y ? -1 : x > y ? 1 : 0;
      })));
      return "";
    }
  }

  public class JSArray<T> : List<T> {
    public JSArray()
    {
    }

    public JSArray(IEnumerable<T> collection) : base(collection)
    {
    }

    public JSArray(int capacity) : base(capacity)
    {
    }

    public delegate int SortCallback(T a, T b);
    public JSArray<T> Sort(SortCallback callback) {
      JSArray<T> ret = new JSArray<T>();
      T a = this[0];
      T b;
      for (int i = 1; i < Count; i++) {
        b = this[i];
        int result = callback(a, b);
        if (result == -1) { // a is pushed into array
          ret.Add(a);
          a = b;
        } else if (result == 1) { // b is pushed into array
          ret.Add(b);
        } else { // both are pushed into array
          ret.Add(a);
          ret.Add(b);
          if (i < Count - 1) {
            a = this[++i];
          }
        }
      }
      ret.Add(a);
      return ret;
    }
  }
}