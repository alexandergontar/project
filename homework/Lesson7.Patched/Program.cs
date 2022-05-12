// Decompiled with JetBrains decompiler
// Type: Lesson7.Program
// Assembly: Lesson7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 71CAFF14-FE25-443D-9229-41C575E2DE0B
// Assembly location: C:\GIT_projects\project\homework\Lesson7\Lesson7\bin\Debug\netcoreapp3.1\Lesson7.dll

using System;

namespace Lesson7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string str = "P@ssw0rd";
      Console.WriteLine("Введите пароль:");
      if (!(Console.ReadLine() == str))
        return;
      Console.WriteLine("Welcome!");
    }
  }
}
