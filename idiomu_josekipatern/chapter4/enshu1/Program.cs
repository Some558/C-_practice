using System;
using System.Collections.Generic;

List<string> langs = [
    "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
    "JavaScript", "Swift", "Go",];

// for (int i = 0; i < langs.Count; i++)
// {
//     Console.WriteLine(langs[i]);
// }

// foreach (var lang in langs)
// {
//     Console.WriteLine(lang);
// }

// int i = 0;
// while (i < langs.Count)
// {
//     Console.WriteLine(langs[i]);
//     i++;
// }

var lang = langs.Find(s => s.length == s);
Console.WriteLine(lang);