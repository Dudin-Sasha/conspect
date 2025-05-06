```cs

HashSet<int> set = new HashSet<int>() { 1,2,3,3,2};
set.Add(1);
set.Add(5);
set.Remove(5);
set.RemoveWhere(x => x == 5);
Console.WriteLine(set.ElementAt(0));
//индексы у одинаковых хэшсетов могут различаться от элемента к элементу

Console.WriteLine(string.Join(" ",set));
List<int> li = new List<int>() { 1, 2,2,2,2, 3, 4 };
//li.ToHashSet();
HashSet<int> lh = new HashSet<int> (li);
Console.WriteLine(string.Join(" ", lh));


```
