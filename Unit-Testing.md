# Prepare

## Установка

Нам необходим `Test Framework`, `NSubstitute` и `Fluent Assertions`

По умолчанию `Test Framework` установлен. В противном случае установите его через `Package Manager`, из списка `Unity Registry`.
После добавляем `NSubstitute` и `Fluent Assertions`, указав ссылку на гит:  
`https://github.com/BoundfoxStudios/fluentassertions-unity.git#upm`  
`https://github.com/Thundernerd/Unity3D-NSubstitute.git`  

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
Выберем директорию для папки с тестами, выбираем мод, например `EditorMode`, и нажимаем на кнопку `Create Test Assembly Folder`.  
После будет создана папка `Tests` и `asmdef`.
Указываем в `Assembly Definition References` указываетм ссылку на `asmdef` игры, `Fluent Assertions` и `NSubstitute`.
Так же можем выставить платформу, только для Editor.

Подготовка завершена и теперь можно писать модульные тесты!