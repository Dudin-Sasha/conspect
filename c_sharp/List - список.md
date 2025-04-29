`List` работает как массив, но можно изменять значения

```cs
List<int> ints = new List<int>();

List<int> fifteen = new List<int>(15);

List<int> ints2 = new List<int>() { 1,2,3,4};

List<int> ints3 = {1,2,3,4};

List<int> copyList = new List<int>(ints3);
```

чтобы узнать количество элементов используется `Count`
```cs
List<int> fifteen = new List<int>(15);

Console.WriteLine(fifteen.Count);
//15
```

`Add` добавляет 1 элемент в конец список
```
ints2.Add(1);
Console.WriteLine(string.Join(", ", ints2));
```

`AddRange` - добавляет массив в конец списка
```cs
List<int> ints2 = new List<int>() { 1, 2, 3, 4 };
ints2.AddRange(new int[] {1,2,3});
Console.WriteLine(string.Join("",ints2));
///1234123
```

`Remove` - убирает определённое значение из всего списка
```cs
List<int> ints2 = new List<int>() { 1, 2, 3, 4 };
ints2.Remove(4);
Console.WriteLine(string.Join("",ints2));
///123
```

`Insert` - добавляет один элемент в список в указанном месте
```cs
List<int> ints2 = new List<int>() { 1, 2, 3, 4 };
ints2.Insert(1,1);
Console.WriteLine(string.Join("",ints2));
//11234
```

`InsertRange` - добавляет массив значений в указанное место
```cs

List<int> ints2 = new List<int>() { 1, 2, 3, 4 };
ints2.InsertRange(1 ,new int[] {1,2,3});
Console.WriteLine(string.Join("",ints2));
//123234
```
