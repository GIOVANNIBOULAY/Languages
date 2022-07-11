using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

      foreach (var l in languages){
        //Console.WriteLine(l.Prettify());
      }

      var allLangs = languages.Select(l => $"{l.Year}, {l.Name}, {l.ChiefDeveloper}");

      foreach (var l2 in languages)
      {
        //Console.WriteLine(l2.Prettify());
      }

      /*
      var cLangs = languages.Where(c => c.ChiefDeveloper == "Microsoft");

      foreach (var lang in cLangs)
      {
        Console.WriteLine(lang.Prettify());
      }
      */

    /*
    var lisp = languages.Where(c => c.Predecessors.Contains("Lisp"));

    foreach (var lang in lisp)
      {
        Console.WriteLine(lang.Prettify());
      }
      */

    var script = languages.Where(s => s.Name.Contains("Script")); 

    foreach (var lang in script)
    {
      //Console.WriteLine(lang.Prettify());
    }

    var dates = languages
    .Where(d => d.Year >= 1995 && d.Year <= 2005)
    .Select(d => $"{d.Name} was invented in {d.Year}");

    foreach (var d2 in dates)
    {
      Console.WriteLine(d2);
    }

    }

    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
      foreach (var lang in langs)
      {
        lang.Prettify();
      }
    }
  }
}
