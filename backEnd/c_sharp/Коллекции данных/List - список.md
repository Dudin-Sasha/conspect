if`List` работает как массив, но можно изменять значения (и медленный)

если не работает list (обычно на старых версиях) подключаем -  `using System.Collections.Generic;`

```cs
List<int> ints = new List<int>();

List<int> fifteen = new List<int>(15);

List<int> ints2 = new List<int>() { 1,2,3,4};

List<int> copyList = new List<int>(ints2);
```

чтобы узнать количество элементов используется `Count`
```cs
List<int> fifteen = new List<int>(15);

Console.WriteLine(fifteen.Count);
//15
```

`Add` добавляет 1 элемент в конец список
```cs
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
ints2.Insert(1,1);// сначала индекс, потом значение
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

`sort` - сортирует список
```cs
List<int> ints2 = new List<int>() {2,1,3,4};

ints.Sort(); //1 2 3 4
```


## Работают те же методы что и в string

### Contains

проверяет есть ли в коллекции определенный элемент
да - true | нет - false
в списке ищет элемент
```cs
List<int> ints2 = new List<int>() { 1,2,3,4};

Console.WriteLine(ints2.Contains(1)); //true
```

### indexOf 

 трех параметров 
1) что мы ищем
2) с какого индекса ищем (опционально)
3) сколько символов (тоже опционально)

если элемент найден возвращает его индекс, иначе возвращает -1
```cs
List<int> ints2 = new List<int>() { 1,2,3,4};

Console.WriteLine(ints2.IndexOf(4));//3
```

### Remove |  RemoveAt

Remove - Удаляет указанное значение 
RemoveAt - Удаляет значение по индексу
```cs
ints.RemoveAt(ints[1]);// останется 2 1 4
ints.Remove(ints[2]);// останется 1 4
```



