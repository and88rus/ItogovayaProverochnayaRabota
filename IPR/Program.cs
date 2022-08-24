void DefinitionOfStringArray(int line, string []strings)
{
for (int i=0;i<line;i++) 
{
 Console.Write ($"Введите элемент под номером {i}:");
strings[i]=Console.ReadLine();
Console.Clear();
}
}

int DefinitionOfQuantityOfElementsOfStringArrayWhichSizeIsMoreOrEqualThree(int line, string [] strings)
{
 int q=0;
 for (int i=0; i<line;i++)
 {
   if (strings[i].Length<=3)
   {
    q=q+1;
   }
 }
 return q;
}

void DefinitionAndOutPutOfResultStrings (int line, string [] strings)
{
  int q=DefinitionOfQuantityOfElementsOfStringArrayWhichSizeIsMoreOrEqualThree(line,strings);
  string [] ResultStrings;
  ResultStrings = new string [q];
  int i=0;
 for (int j=0;j<line;j++)
 {
   if (strings[j].Length<=3)
   {
    ResultStrings[i]=strings[j];
    i++;
   }
 }
 Console.WriteLine ("Результат:");
  Console.WriteLine (" ");
 for  ( int  j = 0 ; j < q; j ++ )
  { 
        Console. WriteLine ( $" { ResultStrings[ j ]} " ); 
       Console . WriteLine ( " " ); 
  }
}

Console.WriteLine ("Введите кол-во элементов массива:");
int line = Convert . ToInt32 ( Console . ReadLine ());
Console.Clear();

string [] strings;
strings = new string [line];

DefinitionOfStringArray(line, strings);
DefinitionAndOutPutOfResultStrings(line,strings);