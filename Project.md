# Иерархия папок

Правильно организованная структура папок обеспечивает четкость и упорядоченность в процессе разработки. Так же упрощает навигацию и поиск необходимых файлов.

В корне проекте(в папке `Assets`). Выделим основные папки:
- `Content`. Содержит все модели, спрайты, звуки и т.п которые были созданы в компании.
- `ImportedAssets`. Служит контейнером для сторонних ассетов содержащих визуальный и звуковой контент.
- `Plugins`. Сюда помещаются все плагины, фреймворки и функциональные инструменты.
- `Controllers`. Хранилище сторонних ассетов-контроллеров, если таковые имеются. 
- `CodeBase`/`Scripts`. Содержит всю самописную кодовую базу проекта.
- `Scenes`. Папка, содержащая сцены проекта. 
- `Settings`. Для хранения файлов настроек, например таких как AudioMixer, или файлы настройки для URP.
- `Resources`. Для подгружаемых файлов фреймворков и плагинов.

*******************СТАТИК ДАТА*******************  
*******************Нейминг папок*******************  

В каждой из директорий стоит выделять дочерние папки, группирующие элементы по какому-то общему принципу.
Рассмотрим каждую папку в отдельности. 

## Content

В директории `Content` хранится весь контент, созданный или отредактированный внутри компании, или взят из иных источников в единичных экземплярах, например, анимации с `mixamo` или сгенерированные звуки. 
Под контентом подразумевается модели, анимации, текстуры, материалы, шейдеры, спрайты, звуки и т.д.,
Внутри данной папки стоит группировать контент по игровым локациям(если таковые имеются), после дробить по категориям, и в конечном случае по типу данных. Однако стоит выделять общий контент присущий нескольким групп в папку `Common`. 

Рассмотрим пример. Допустим в проекте есть зимняя, лесная и городская локации. У каждой этой группы есть как уникальные элементы окружения, так и общие. Так же если персонажи от локации не меняются, то директорию с ними можно поместить в корень папки `Content`.
Таким образом можем получить подобную иерархию внутри директории `Content`:

<details>
<summary>Example (opened view)</summary>

- Forest
  - Environment
    - Tree
      - Prefab
      - Model
    - Mushroom
      - Prefab
      - Model
      - Material
    - Common 
      - Texture
      - Material
- Town
  - Building
    - Prefab
    - Model
    - Material
    - Texture
- Winter
  - Animal
    - Sound
    - Fox
      - Animation
      - Prefab
      - Model
      - Material
      - Texture
    - Wolf
      - Animation
      - Prefab
      - Model
      - Material
      - Texture
    - Rabbit
      - Animation
      - Prefab
      - Model
      - Material
      - Texture
- Characters
  - Animation
  - Prefab
  - Model
  - Material
  - Sound
  - Texture
- Common
  - Environment
    - Tree
      - Prefab
      - Model
      - Material
      - Texture
    - Props
      - Prefab
      - Model
      - Material
      - Texture
  - Sound
    - BackgroundMusic
    - Environment
- UI
  - Buttons
  - Icons
  - Sound

</details>

<details>
<summary>Example (directory view)</summary>

<ul>
<details>
  <summary>Forest</summary>
  <ul>
    <details>
      <summary>Environment</summary>
      <ul>
        <details>
          <summary>Tree</summary>
          <ul>
            <li>Prefab</li>
            <li>Model</li>
          </ul>
        </details>
        <details>
          <summary>Mushroom</summary>
          <ul>
            <li>Prefab</li>
            <li>Model</li>
            <li>Material</li>
          </ul>
        </details>
        <details>
          <summary>Common</summary>
          <ul>
            <li>Texture</li>
            <li>Material</li>
          </ul>
        </details>
      </ul>
    </details>
  </ul>
</details>

<details>
  <summary>Town</summary>
  <ul>
    <details>
      <summary>Building</summary>
      <ul>
        <li>Prefab</li>
        <li>Model</li>
        <li>Material</li>
        <li>Texture</li>
      </ul>
    </details>
  </ul>
</details>

<details>
  <summary>Winter</summary>
  <ul>
    <details>
      <summary>Animal</summary>
      <ul>
        <details>
          <summary> Sound </summary>
          <ul>
            <li>Fox.mp3</li>
            <li>Wolf.wav</li>
            <li>Rabbit.ogg</li>
          </ul>
        </details>
        <details>
          <summary>Fox</summary>
          <ul>
            <li>Animation</li>
            <li>Prefab</li>
            <li>Model</li>
            <li>Material</li>
            <li>Texture</li>
          </ul>
        </details>
        <details>
          <summary>Wolf</summary>
          <ul>
            <li>Animation</li>
            <li>Prefab</li>
            <li>Model</li>
            <li>Material</li>
            <li>Texture</li>
          </ul>
        </details>
        <details>
          <summary>Rabbit</summary>
          <ul>
            <li>Animation</li>
            <li>Prefab</li>
            <li>Model</li>
            <li>Material</li>
            <li>Texture</li>
          </ul>
        </details>
      </ul>
    </details>
  </ul>
</details>

<details>
  <summary>Characters</summary>
  <ul>
    <li>Animation</li>
    <li>Prefab</li>
    <li>Model</li>
    <li>Material</li>
    <li>Sound</li>
    <li>Texture</li>
  </ul>
</details>

<details>
  <summary>Common</summary>
  <ul>
    <details>
      <summary>Environment</summary>
      <ul>
        <details>
          <summary>Tree</summary>
          <ul>
            <li>Prefab</li>
            <li>Model</li>
            <li>Material</li>
            <li>Texture</li>
          </ul>
        </details>
        <details>
          <summary>Props</summary>
          <ul>
            <li>Prefab</li>
            <li>Model</li>
            <li>Material</li>
            <li>Texture</li>
          </ul>
        </details>
      </ul>
    </details>
    <details>
      <summary>Sound</summary>
      <ul>
        <li>BackgroundMusic</li>
        <li>Environment</li>
      </ul>
    </details>
  </ul>
</details>

<details>
  <summary>UI</summary>
  <ul>
    <li>Buttons</li>
    <li>Icons</li>
    <li>Sound</li>
  </ul>
</details>

</ul>
</details>

Обратим внимание на директорию `Character`. Так как этот контент общий для всех локаций ее положение могло бы быть в папке `Common`, однако так как нету уникальных персонажей для каждой из локаций, то директорию `Character` можно объявить в корне папки `Content`.  
Перейдем к иерархии внутри папки `Forest`. Как можно заметить, для деревьев и грибов, в нашем случае, общие материалы и текстуры, но у грибов есть свои уникальные материалы. Например, все эти элементы могли быть упакованы в общий атлас, но по какой-то причине для некоторых грибов понадобилось выделить и настроить отдельный материал. 

> [!Note]
> Для рассмотренного случая возможно и другое, более оптимальное, решение без выделения отдельного материала. 
> Оставим это допущение в угоду примеру.

В папке `Town` опущена директория `Environment`, что бы убрать лишнюю вложенность, которая ни чего не объединяет, а другие категории отсутствуют.  
Рассмотрим папку `Winter`, в ней можем заметить папку `Sound`, которая очевидно должна лежать в каждой папке животного, при этом данные звуки не являются общими, следовательно и `Common` не подходит. Конкретно в данном случае это было сделано для удобства, так как общее количество звуков мало.  
Обратим

## ImportedAssets

## Plugins

## Controllers

## CodeBase/Scripts

## Scenes

## Settings

## Resources

Имя этой папки зарезервировано Unity для возможности подгружать контент из нее. Такая папка может располагаться и по иерархии ниже. Однако некоторые плагины зачасту.