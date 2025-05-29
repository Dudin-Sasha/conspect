# css

#### #margin-padding
`margin` - внешний отступ от элемента(тега)
`padding` - внутренний отступ

```css
margin\padding: 10px; внешний\внутренний отступ со всех сторон 10 px

margin\padding: 10px 15px; - внешний\внутренний отступ 10 сверху и снизу, а также 15 слева и справа
 
margin\padding: 10px 15px 7px; - внешний\внутренний отступ 10 сверху, а также 15 слева и справа, и 7 снизу

margin\padding: 10px 15px 7px 2px;  - значение отступов по часовой стрелке 
10px->...->2px  
	
```

 Для удобства принято приравнивать к нулю margin и padding в начале СSS
 ```css
*{
 margin: 0;
 padding: 0;
 }
```

функция ``padding`` растягивает блок на тоже расстояние которое перестаёт использоваться при отступе: 
	чтобы избежать растягивания `box-sizing: border-box;`

#### Селекторы ( id - class )

| Html            | Css      | description                                                                                   |
| --------------- | -------- | --------------------------------------------------------------------------------------------- |
| `id="id"`       | `#id`    | id для выделения единичных тегов (часто используется с формами), конфликтует если повторяется |
| `class="class"` | `.class` | class для выделения множества элементов                                                       |
| `<div></div>`   | `div`    | Выделение буквально всех тегов указанного типа (здесь div)                                    |
|                 | `*`      | Выделяет буквально все                                                                        |
```css
#id{
	padding: 0;
}

.class{
	height: 100px;
}

div{
	backgroung-color:black;
}

*{
	margin: 0;
}
```



### border - границы

толщина границы - `border-width: 10px;`
смена цвета - `border-color:`
стиль границы - `border-style: dotted dashed ridge solid; `
border-radius: 45px 16% 120px ;
border: 10px violet solid;

границы можно настраивать тем же способом что и с #margin-padding
```html
<div>box</div>
```
```css
div{
    border-width: 3px;
    border-color: aqua;
    border-style: dotted;
    
    /* или можно */

    border: aqua 3px dotted;

    /* закругление разных углов в разных единицах */

    border-radius: 45px 16% 120px;
}
```