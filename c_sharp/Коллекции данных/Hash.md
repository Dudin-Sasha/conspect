Hash - не пронумерованная изменяемая коллекция уникальных значений одного типа - часто требует импорт linq (`using System.Linq;` )

```cs
HashSet<int> set = new HashSet<int>() { 1,2,3,3,2};
set.Add(1);
set.Add(5);
set.Remove(5);
set.RemoveWhere(x => x == 5);
Console.WriteLine(set.ElementAt(0));
//индекс можно присвоить, но не факт что одинаковые хэши будут иметь один и тот же присвоенный индекс

Console.WriteLine(string.Join(" ",set));
List<int> li = new List<int>() { 1, 2,2,2,2, 3, 4 };
//li.ToHashSet(); 
HashSet<int> lh = new HashSet<int> (li);
Console.WriteLine(string.Join(" ", lh));
```

 
### Функции множеств

Работает как в математике одно множество взаимодействует со вторым
```cs
li.Except(set);//вычитание
li.Union(set);//сложение
li.Intersect(set);//пересечение
```