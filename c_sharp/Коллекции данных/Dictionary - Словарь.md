
Словарь - коллекция (без стандартного порядка) хранящая два значения , первичный ключ и связанное значение
	`Dictionary<Tkey, TValue> example = new Dictionary<Tkey, TValue>`

```cs
Dictionary<int, string> example =  new Dictionary<int, string>() 
{ 
	{1,"abc" },
	{ 2,"cde"} 
};

Console.WriteLine(string.Join(" ", example));
//[1, abc] [2, cde]
```

#### Добавление элементов

```cs
Dictionary<string, string> user =  new Dictionary<string, string>() { 
    {"IdUser","user" }, 
    {"name","Igor" },
    {"sername","Agik"} 
};

user["address"] = "Kaliningrad";//создаст ключ "address" и применяет значение
user["address"] = "Kaliningrad Nevskogo 78 A";//оно заменяет предыдущее значение

user.Add("phone", "8 800 555 35 35");// если попробовать второй раз добавить по одному ключу, то будет ошибка
user.TryAdd("phone", "8 800 555");// если попробовать добавить второй одинаковый ключ не случится ничего, и вернет 0
```

#### Вывод элементов
```cs
Console.WriteLine(user["name"]);//Значение по ключу name

Console.WriteLine(
    user.Contains(new KeyValuePair<string, string>("surname", "Agik"))
    );// проверяет есть ли такое сочетание ключ - "surname" и значение - "Agik"

Console.WriteLine(
    user.ContainsKey("surname") + '\n' +
    user.ContainsValue("Agik")
    );//Проверяют отдельно ключ, и отдельно значение

Console.WriteLine('\n'+string.Join(",", user.Keys));//Выводит, все ключи
Console.WriteLine(string.Join(",", user.Values));//Выводит все значения
```

### Перебор словаря

Для перебора словаря можно применять цикл foreach:

Переменная представляет тип KeyValuePair, и с помощью свойств Key и Value мы сможем получить ключ и значение элемента. 

```cs
var people = new Dictionary<int, string>()
{
    [5] = "Tom",
    [6] = "Sam",
    [7] = "Bob"
};
foreach (var person in people)
{
    Console.WriteLine($"key: {person.Key}  value: {person.Value}");
}
```

| key: 5  value: Tom<br>key: 6  value: Sam<br>key: 7  value: Bob |
| -------------------------------------------------------------- |

> [!Var]
> `var` - предназначено для объявления переменных без явного указания типа данных.
> компилятор C# автоматически определяет тип переменной на основе значения, которое ей присваивается при инициализации.




