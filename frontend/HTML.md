(`p, div, a`) и так далее - это теги
#### текст


```html
<p> 
	lorem 
		<span>
		not a lorem
		<span> 
<p>   
```

`span` - выделение конкретного элемента слова в теге `p`


### button

`button` создает кнопку, которая поддерживает цвета фона, границы, ссылки, внутри себя, текст и т.п.

```html
<div bgcolor = "red">
	<p>press F to test obsidian</p>
</div>
```
<div bgcolor = "red">
	<p>press F to test obsidian</p>
</div>

# css

#### margin - padding

 удобства margin приравнивается к нулю в начале css `*{margin: 0;}`

`margin` - внешний отступ от элемента(тега)
`padding` - внутренний отступ

```css
margin\padding: 10px; внешний\внутренний отступ со всех сторон 10 px

margin\padding: 10px 15px; - внешний\внутренний отступ 10 сверху и снизу, а также 15 слева и справа
 
margin\padding: 10px 15px 7px; - внешний\внутренний отступ 10 сверху, а также 15 слева и справа, и 7 снизу

margin\padding: 10px 15px 7px 2px;  - значение отступов по часовой стрелке 
10px->...->2px  
	
```

функция ``padding`` растягивает блок на тоже расстояние которое перестаёт использоваться при отступе: 
	чтобы избежать растягивания `box-sizing: border-box;`

#### Селекторы ( id - class )
`#id` - id для выделения единичных тегов, конфликтует если повторяется



`.class` - class для выделения множества элементов 


`div` - для выделение буквально всех тегов указанного типа



#### div:
`div` - заполняемый блок в html
`background-color: цвет-фона-на-выбор;`

`display: inline-block;` - делает блоки идущими в линию по ширине экрана(по умолчанию идут в столбик)

`height\width` - высота\ширина (по умолчанию высота по количеству заполненных значений, а длина по ширине страницы)

#### border - границы

толщина границы - `border-width: 10px;`

смена цвета - `border-color:`

стиль границы - `border-style: dotted dashed ridge solid; `

border-radius: 45px 16% 120px ;

border: 10px violet solid;

границы можно настраивать тем же способом что и с margin \ padding
## импорт шрифтов (google fonts)

выбираем шрифт -> жмём кнопку *get font* и *get embed code* 

вставляем этот блок в `<head>` в html файле, перед ссылкой на css
![[Pasted image 20241120110838.png]]

вставляем этот блок в css(не забыть подставить не указанные значения)
![[Pasted image 20241120111133.png]]



# Расположение:


## position:

- ### absolute;


`position: absolute;` - выбивает блок из блочной системы, что может наложить блоки друг на друга и позволяет располагать блок при помощи `top/left/bottom/right`

- ### relative;

`position: relative;` - не выбивает блоки из блочной системы, при этом оставляет возможность расположения при помощи `top/left/bottom/right`

#### имеет функции -


`top/bottom` и `left/right` - расстояние в пикселях от указанной границы страницы противоположные значения перезаписывают друг друга


## display: flex;


хорошо работает с родительскими блоками


- `justify-content: center;` - центрирование по горизонтальной оси `justify-content: space-between;` - распределяет свободное пространство между дочерними блоками `justify-content: space-around;` - распределяет место между блоками и создает немного пространства по краям `justify-content: space-evenly;` - распределяет место по краям и между блоками
- `align-items: center;` - центрирование по вертикали

при работе с `flex` блок считается как `flex-container`, но работает также как и обычный блок

#### flex-direction:
меняет направление главной оси функции `display flex` по умолчанию стоит:

- row - главная ось это X, а вспомогательная Y, соответственно распределение идет по оси X, то-есть в строку
    
- column - главная ось Y, вспомогательная X, распределение идет по оси Y или в колонку
    

