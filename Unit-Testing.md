# Подготовка

## Установка фреймворков


- `Test Framework`
- `NSubstitute` - фреймворк для под подстановок(генерирует кастомные реализации интерфейса).
- `Fluent Assertions` - для проверок и вывода результатов.

По умолчанию `Test Framework` должен быть установлен. В противном случае устанавливаем его через `Package Manager`, из списка `Unity Registry`.
После добавляем `NSubstitute` и `Fluent Assertions`, указав ссылку на гит:  
`https://github.com/BoundfoxStudios/fluentassertions-unity.git#upm`  
`https://github.com/Thundernerd/Unity3D-NSubstitute.git`  

## Выделение сборки

Выделяем сборку (Assembly Definition - файл `.asmdef`) для игры, если сборка еще не была выделена, при необходимости указать ссылки на другие сборки.

Например:  
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
После будет создана папка и `.asmdef`.
Указываем в `Assembly Definition References` добавляем ссылки на `Fluent Assertions`, `NSubstitute` и на сборки игры.
Так же можем выставить платформу, только для Editor.

Подготовка завершена и теперь можно писать модульные тесты!

# Именование методов

# Рекомендации