namespace CodeWars5kyu;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TalkLikeSiegfriedTask
{
 public static string Siegfried(int week, string str)
  {
    List<List<char>> words = str.Split(" ").Select(s => s.ToList()).ToList();
    
    for(int w = 1; w <= week; w++)
    {
      for(int i = 0; i < words.Count(); i++)
      {        
        for(int j = 0; j < words[i].Count(); j++)
        {
          if(w >= 1)
          { 
            if(words[i][j] == 67 || words[i][j] == 99)
            {
              words[i][j] = (char)(words[i][j] + (j < words[i].Count() - 1 && (words[i][j + 1] == 73 || words[i][j + 1] == 105 || words[i][j + 1] == 69 || words[i][j + 1] == 101) ? 16 
                                                  : j < words[i].Count() - 1 && (words[i][j + 1] == 72 || words[i][j + 1] == 104) ? 0 : 8));
            }
          }
          if(w >= 2)
          {
            if(j < words[i].Count() - 1 && (words[i][j] == 80 || words[i][j] == 112) && (words[i][j + 1] == 72 || words[i][j + 1] == 104))
            {
              words[i][j] = (char)(words[i][j] - 10);
              words[i].RemoveAt(j + 1);
            }
          }
          if(w >= 3)
          {
            if(words[i].Count() > 3 && (words[i][j] == 69 || words[i][j] == 101) && (j == words[i].Count() - 1 || !Char.IsLetter(words[i][j + 1])))
              words[i].RemoveAt(j);
            
            if(j < words[i].Count() - 1 && Char.IsLetter(words[i][j]) && Char.ToLower(words[i][j]) == Char.ToLower(words[i][j + 1]))
              words[i].RemoveAt(j + 1);            
          }
          if(w >= 4)
          {
            if(j < words[i].Count() - 1 && (words[i][j] == 84 || words[i][j] == 116) && (words[i][j + 1] == 72 || words[i][j + 1] == 104))
            {
              words[i][j] = (char)(words[i][j] + 6);
              words[i].RemoveAt(j + 1);
            }
            if(words[i][j] == 87 || words[i][j] == 119)
            {
              if(j < words[i].Count() - 1)
              {
                if(words[i][j + 1] == 82 || words[i][j + 1] == 114)
                {
                  words[i][j] = (char)(words[i][j] - 5);
                  words[i].RemoveAt(j + 1);
                }              
                else if(words[i][j + 1] == 72 || words[i][j + 1] == 104)
                  words[i].RemoveAt(j + 1);
              }
              
              if(words[i][j] == 87 || words[i][j] == 119)
                words[i][j] = (char)(words[i][j] - 1);
            }
          }
          if(w >= 5)
          {
            if(j < words[i].Count() - 1 && (words[i][j] == 79 || words[i][j] == 111) && (words[i][j + 1] == 85 || words[i][j + 1] == 117))
              words[i].RemoveAt(j);            
            else if(j < words[i].Count() - 1 && (words[i][j] == 65 || words[i][j] == 97) && (words[i][j + 1] == 78 || words[i][j + 1] == 110))
              words[i][j] = (char)(words[i][j] + 20);
            
            if(words[i].Count > 2 && ((words[i][words[i].Count - 3] == 73 || words[i][words[i].Count - 3] == 105) && (words[i][words[i].Count - 2] == 78 || words[i][words[i].Count - 2] == 110) && (words[i][words[i].Count - 1] == 71 || words[i][words[i].Count - 1] == 103)))
              words[i][words[i].Count - 1] = (char)(words[i][words[i].Count - 1] + 4);
            
            if((words[i][0] == 83 || words[i][0] == 115) && (words[i][1] == 77 || words[i][1] == 109))
            {
              words[i].Insert(1, (char)(words[i][1] - 5));
              words[i].Insert(1, (char)(words[i][1] - 5));              
            }
          }
        }
      }
    }
    
    return String.Join(" ", words.Select(s => String.Concat(s)));
  }
}
//https://www.codewars.com/kata/57fd6c4fa5372ead1f0004aa/train/csharp