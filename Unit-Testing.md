# Prepare

## Установка

### Fluent Assertions

Устанавливаем через Package Manager, указав ссылку на гит:  
`https://github.com/BoundfoxStudios/fluentassertions-unity.git#upm`

## Выделение `asmdef`

Добавить `asmdef` для игры, при необходимости указать ссылку на другие.

```
{
  "name": "Game",
  "references": [
    "Zenject",
    "Unity.TextMeshPro"
  ]
}
```

Открываем `Windows -> General -> Test Runner`.  
Выберем директорию для папки с тестами и нажимаем на кнопку `Create PlayMode Test Assembly Folder` во вкладе `play mode`.  
После будет создана папка `Tests` и `asmdef`.
Указываем в `Assembly Definition References` указываетм ссылку на `asmdef` игры и `Fluent Assertions`.
Так же можем выставить платформу, только для Editor.