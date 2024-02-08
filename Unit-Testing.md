# Prepare

## Установка


- `Test Framework`
- `NSubstitute` - фреймворк для под подстановок.
- `Fluent Assertions` - для проверок и вывода результатов.

По умолчанию `Test Framework` должен быть установлен. В противном случае устанавливаем его через `Package Manager`, из списка `Unity Registry`.
После добавляем `NSubstitute` и `Fluent Assertions`, указав ссылку на гит:  
`https://github.com/BoundfoxStudios/fluentassertions-unity.git#upm`  
`https://github.com/Thundernerd/Unity3D-NSubstitute.git`  

## Выделение сборки

Выделяем сборку (Assembly Definition, файл `.asmdef`) для игры, если сборка еще не была выделена, при необходимости указать ссылки на другие сборки.

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
Указываем в `Assembly Definition References` указываетм ссылки на сборки игры, `Fluent Assertions` и `NSubstitute`.
Так же можем выставить платформу, только для Editor.

Подготовка завершена и теперь можно писать модульные тесты!