using System;

namespace ExtensionMethodsDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      string strName = "fred";

      //extension method added to string class
      string result = strName.ChangeFirstLetterCase();

      //behind the scenes it gets converted into this
      //string result = StringHelper.ChangeFirstLetterCase(strName);

      Console.WriteLine(result);
    }
  }
}
