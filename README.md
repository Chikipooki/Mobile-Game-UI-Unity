# User Interface Example (Unity)

Разработан интерфейс главного меню для абстрактной игры.  
* Ориентация портретная. 
* Верстка адаптивная.

## Описание скриптов / Description of scripts

### WindowSwitcher
* Скрипт используется для логики переключения окон.

    ***ShowWindow*** - это метод, который отображает определенное окно из массива окон *windows* на основе переданного индекса *currentWindowIndex*.   
    Сначала метод ищет индекс активного окна из массива *windows*. Затем активное окно делает неактивным, а следующее окно делает активным на основе переданного индекса.  
    Таким образом, функция отображает окно, указанное в параметре *currentWindowIndex*, и скрывает текущее активное окно.

### ScrollViewAdapter
* Этот скрипт отвечает за динамическое добавление элементов в список и их удаление при клике на них.

    Метод ***ClearGameObjects()*** очищает все игровые объекты на заданном слое.

    Метод ***AddItems()*** добавляет заданное количество элементов в список, используя заданный префаб, и помещает их в контейнер.

    Метод ***RemoveItem()*** удаляет объект из списка.

    В методе ***Update()*** проверяется, было ли сделано нажатие левой кнопки мыши. Если да, то происходит поиск объекта на заданном слое под курсором мыши и, если он найден, он удаляется из списка.

### SoundManager
* Скрипт который управляет воспроизведением звуков в игре.

    У него есть статическое поле *instance*, которое устанавливается в самого себя в методе *Awake*. Таким образом, мы можем обращаться к SoundManager из других классов, не создавая новый экземпляр.

    Так же у него есть метод ***PlaySound***, который принимает *AudioClip* - звук для воспроизведения. В этом методе вызывается метод ***PlayOneShot*** объекта *AudioSource*, который воспроизводит звук один раз без прерывания других звуков.

    Таким образом, SoundManager обеспечивает простой способ воспроизведения звуков в игре и может быть легко использован другими классами для воспроизведения звуковых эффектов.

<h2> Демонстрация / Demonstration </h2>

[![SjEUb.gif](https://s13.gifyu.com/images/SjEUb.gif)](https://gifyu.com/image/SjEUb)