# Общие соглашения о коде C#

Стандарт кода необходим для поддержания удобочитаемости кода, согласованности и совместной работы в команде разработчиков. Код, который соответствует отраслевым методикам и установленным рекомендациям, проще понимать, поддерживать и расширять. Большинство проектов применяют согласованный стиль с помощью соглашений о коде. И [dotnet/docs](https://github.com/dotnet/docs)[dotnet/samples](https://github.com/dotnet/samples) проекты не являются исключением. В этой серии статей вы узнаете о наших соглашениях по программированию и средствах, которые мы используем для их применения. Вы можете принять наши соглашения как есть или изменить их в соответствии с потребностями вашей команды.
Мы выбрали наши соглашения на основе следующих целей:
Правильность. Наши примеры копируются и вставляются в приложения. Мы ожидаем, что поэтому нам нужно сделать код устойчивым и правильным, даже после нескольких изменений.
Обучение. Цель наших примеров — научить все .NET и C#. По этой причине мы не размещаем ограничения на какие-либо языковые функции или API. Вместо этого эти примеры учат, когда функция является хорошим выбором.
Согласованность. Читатели ожидают согласованный интерфейс в нашем содержимом. Все образцы должны соответствовать одному и тому же стилю.
Внедрение: мы агрессивно обновляем наши примеры, чтобы использовать новые языковые функции. Эта практика повышает осведомленность о новых функциях и делает их более знакомыми для всех разработчиков C#.
> [!NOTE]
> Эти рекомендации используются корпорацией Майкрософт для разработки примеров и документации. Они были приняты из [правил среды выполнения .NET, стиля](https://github.com/dotnet/runtime/blob/main/docs/coding-guidelines/coding-style.md) написания кода C# и [компилятора C# (roslyn).](https://github.com/dotnet/roslyn/blob/main/CONTRIBUTING.md#csharp) Мы выбрали эти рекомендации, так как они были протестированы в течение нескольких лет разработки с открытым кодом. Они помогли членам сообщества участвовать в проектах среды выполнения и компилятора. Они предназначены для того, чтобы быть примером общих соглашений C#, а не авторитетным списком (см [. рекомендации](https://learn.microsoft.com/ru-ru/dotnet/standard/design-guidelines/) по проектированию платформы для этого).
Цели обучения и внедрения определяют, почему соглашение о кодировании документов отличается от соглашений среды выполнения и компилятора. Среда выполнения и компилятор имеют строгие метрики производительности для горячих путей. Многие другие приложения не делают. Наша цель обучения требует, чтобы мы не запрещали какую-либо конструкцию. Вместо этого примеры показывают, когда должны использоваться конструкции. Мы обновляем примеры более агрессивно, чем большинство рабочих приложений. Наша цель внедрения требует, чтобы мы отображали код, который вы должны написать сегодня, даже если код, написанный в прошлом году, не нуждается в изменениях.
В этой статье описываются наши рекомендации. Рекомендации развивались со временем, и вы найдете примеры, которые не соответствуют нашим рекомендациям. Мы приветствуем PR, которые приносят эти образцы в соответствие или проблемы, которые обращают внимание на примеры, которые мы должны обновить. Наши рекомендации — это Открытый исходный код, и мы приветствуем PR и проблемы. Однако если ваша отправка изменит эти рекомендации, сначала откройте вопрос для обсуждения. Вы можете использовать наши рекомендации или адаптировать их к вашим потребностям.

# Средства и анализаторы

Средства могут помочь вашей команде обеспечить соблюдение стандартов. Вы можете включить [анализ](https://learn.microsoft.com/ru-ru/dotnet/fundamentals/code-analysis/overview) кода для применения предпочитаемого правила. Вы также можете создать конфигурацию [редактора](https://learn.microsoft.com/ru-ru/visualstudio/ide/create-portable-custom-editor-options) , чтобы Visual Studio автоматически применяла рекомендации по стилю. В качестве отправной точки можно скопировать [файл](https://github.com/dotnet/docs/blob/main/.editorconfig) репозитория dotnet/docs, чтобы использовать наш стиль.
Эти средства упрощают работу вашей команды по принятию предпочитаемых рекомендаций. Visual Studio применяет правила во всех .editorconfig файлах в область для форматирования кода. Можно использовать несколько конфигураций для применения корпоративных стандартов, стандартов группы и даже детализированных стандартов проекта.
Анализ кода создает предупреждения и диагностика при нарушении включенных правил. Вы настраиваете правила, примененные к проекту. Затем каждая сборка CI уведомляет разработчиков, когда они нарушают какие-либо правила.

## Идентификаторы диагностики

[Выбор соответствующих диагностических идентификаторов при создании собственных анализаторов](https://learn.microsoft.com/ru-ru/dotnet/csharp/roslyn-sdk/choosing-diagnostic-ids)

# Рекомендации по использованию языка

В следующих разделах описаны рекомендации, которые команда документации .NET следует для подготовки примеров кода и примеров. Как правило, следуйте приведенным ниже рекомендациям.
По возможности используйте современные языковые функции и версии C#.
Избегайте устаревших или устаревших конструкций языка.
Перехват исключений, которые можно правильно обрабатывать; избегайте перехвата универсальных исключений.
Используйте определенные типы исключений для предоставления значимых сообщений об ошибках.
Используйте запросы и методы LINQ для обработки коллекций, чтобы улучшить удобочитаемость кода.
Используйте асинхронное программирование с асинхронным и ожиданием операций с привязкой ввода-вывода.
Будьте осторожны с взаимоблокировками и используйте [Task.ConfigureAwait](https://learn.microsoft.com/ru-ru/dotnet/api/system.threading.tasks.task.configureawait) при необходимости.
Используйте языковые ключевое слово для типов данных вместо типов среды выполнения. Например, используйте string вместо [System.String](https://learn.microsoft.com/ru-ru/dotnet/api/system.string)нее или int вместо [System.Int32](https://learn.microsoft.com/ru-ru/dotnet/api/system.int32).
Используйте int вместо неподписанных типов. Использование int часто используется на C#, и при использовании intпроще взаимодействовать с другими библиотеками. Исключения предназначены для документации, конкретной для типов данных без знака.
Используйте var только в том случае, если средство чтения может вывести тип из выражения. Читатели просматривают наши примеры на платформе документов. У них нет подсказок по наведении указателя мыши или инструментов, отображающих тип переменных.
Напишите код с четкостью и простотой.
Избегайте чрезмерно сложной и запутанной логики кода.
Более конкретные рекомендации следуют.

##Строковые данные

Для сцепления коротких строк рекомендуется использовать [интерполяцию строк](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/tokens/interpolated), как показано в следующем коде.
```C#
string displayName = $"{nameList[n].LastName}, {nameList[n].FirstName}";
```
Для добавления строк в циклах, особенно при работе с текстами больших размеров, используйте объект [System.Text.StringBuilder](https://learn.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder).

```C#
var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
var manyPhrases = new StringBuilder();
for (var i = 0; i < 10000; i++)
{
    manyPhrases.Append(phrase);
}
//Console.WriteLine("tra" + manyPhrases);
```

## Массивы

При инициализации массивов в строке объявления рекомендуется использовать сокращенный синтаксис. В следующем примере вместо этого нельзя использовать varstring[].
```C#
string[] vowels1 = { "a", "e", "i", "o", "u" };
```
Если экземпляр создается явно, можно использовать var.
```C#
var vowels2 = new string[] { "a", "e", "i", "o", "u" };
```

## Делегаты

Используйте [Func<> и Action<>](https://learn.microsoft.com/ru-ru/dotnet/standard/delegates-lambdas) вместо определения типов делегатов. В классе определите метод делегата.
```C#
Action<string> actionExample1 = x => Console.WriteLine($"x is: {x}");

Action<string, string> actionExample2 = (x, y) =>
    Console.WriteLine($"x is: {x}, y is {y}");

Func<string, int> funcExample1 = x => Convert.ToInt32(x);

Func<int, int, int> funcExample2 = (x, y) => x + y;
```
Вызывайте метод с помощью сигнатуры, которую определяет делегат Func<> или Action<>.
```C#
actionExample1("string for x");

actionExample2("string for x", "string for y");

Console.WriteLine($"The value is {funcExample1("1")}");

Console.WriteLine($"The sum is {funcExample2(1, 2)}");
```
Если вы создаете экземпляры типа делегата, используйте сокращенный синтаксис. В классе определите тип делегата и метод с соответствующей сигнатурой.
```C#
public delegate void Del(string message);

public static void DelMethod(string str)
{
    Console.WriteLine("DelMethod argument: {0}", str);
}
```
Создайте экземпляр типа делегата и вызовите его. В следующем объявлении используется сокращенный синтаксис.
```C#
Del exampleDel2 = DelMethod;
exampleDel2("Hey");
```
В следующем объявлении используется полный синтаксис.
```C#
Del exampleDel1 = new Del(DelMethod);
exampleDel1("Hey");
```

# Операторы try-catch и using при обработке исключений

Рекомендуется использовать оператор [try-catch](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-catch-statement) для обработки большей части исключений.
```C#
static double ComputeDistance(double x1, double y1, double x2, double y2)
{
    try
    {
        return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }
    catch (System.ArithmeticException ex)
    {
        Console.WriteLine($"Arithmetic overflow or underflow: {ex}");
        throw;
    }
}
```
Использование [оператора C# using](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/using) упрощает код. При наличии оператора [try-finally](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/exception-handling-statements#the-try-finally-statement), код которого в блоке finally содержит только вызов метода [Dispose](https://learn.microsoft.com/ru-ru/dotnet/api/system.idisposable.dispose), вместо него рекомендуется использовать оператор using.
В следующем примере оператор try-finally вызывает Dispose только в блоке finally.
```C#
Font bodyStyle = new Font("Arial", 10.0f);
try
{
    byte charset = bodyStyle.GdiCharSet;
}
finally
{
    if (bodyStyle != null)
    {
        ((IDisposable)bodyStyle).Dispose();
    }
}
```
То же самое можно сделать с помощью оператора using.
```C#
using (Font arial = new Font("Arial", 10.0f))
{
    byte charset2 = arial.GdiCharSet;
}
```
Используйте новый [using синтаксис](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/using) , который не требует фигурных скобок:
```C#
using Font normalStyle = new Font("Arial", 10.0f);
byte charset3 = normalStyle.GdiCharSet;
```
# Операторы && и ||

Используйте [&&](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators#conditional-logical-and-operator-) вместо того, [||](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators#conditional-logical-or-operator-)[&](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-and-operator-) чтобы вместо [|](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/boolean-logical-operators#logical-or-operator-) выполнения сравнений, как показано в следующем примере.
```C#
Console.Write("Enter a dividend: ");
int dividend = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a divisor: ");
int divisor = Convert.ToInt32(Console.ReadLine());

if ((divisor != 0) && (dividend / divisor) is var result)
{
    Console.WriteLine("Quotient: {0}", result);
}
else
{
    Console.WriteLine("Attempted division by 0 ends up here.");
}
```
Если делитель равен нулю, второе условие в операторе if вызовет ошибку времени выполнения. При этом оператор && сразу прекращает выполнение, если первое выражение ложно. Это означает, что второе выражение не будет вычисляться. Оператор & всегда вычисляет оба выражения, и если значение divisor равно 0, возникает ошибка времени выполнения.

# Оператор new

Используйте одну из сокращенных форм создания экземпляров объектов, как показано в следующих объявлениях.
```C#
var firstExample = new ExampleClass();
```
```C#
ExampleClass instance2 = new();
```
Предыдущие объявления эквивалентны следующему объявлению.
```C#
ExampleClass secondExample = new ExampleClass();
```
Используйте инициализаторы объектов, чтобы упростить создание объектов, как показано в следующем примере.
```C#
var thirdExample = new ExampleClass { Name = "Desktop", ID = 37414,
    Location = "Redmond", Age = 2.3 };
```
В следующем примере задаются точно такие же свойства, как и в предыдущем, но без использования инициализаторов.
```C#
var fourthExample = new ExampleClass();
fourthExample.Name = "Desktop";
fourthExample.ID = 37414;
fourthExample.Location = "Redmond";
fourthExample.Age = 2.3;
```

## Обработка событий

Используйте лямбда-выражение для определения обработчика событий, который не требуется удалить позже:
```C#
public Form2()
{
    this.Click += (s, e) =>
        {
            MessageBox.Show(
                ((MouseEventArgs)e).Location.ToString());
        };
}
```
Лямбда-выражение сокращает приведенное ниже традиционное определение.
```C#
public Form1()
{
    this.Click += new EventHandler(Form1_Click);
}

void Form1_Click(object? sender, EventArgs e)
{
    MessageBox.Show(((MouseEventArgs)e).Location.ToString());
}
```

## Статические участники

Для вызова [статических](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/static) членов следует использовать имя класса: ClassName.StaticMember. В этом случае код становится более удобочитаемым за счет четкого доступа. Не присваивайте статическому элементу, определенному в базовом классе, имя производного класса. Во время компиляции кода его читаемость нарушается, и если добавить статический член с тем же именем в производный классе, код может быть поврежден.

## Запросы LINQ

Используйте значимые имена для переменных запроса. В следующем примере используется seattleCustomers для клиентов, находящихся в Сиэтле.
```C#
var seattleCustomers = from customer in customers
                       where customer.City == "Seattle"
                       select customer.Name;
```
Рекомендуется использовать псевдонимы для уверенности в том, что в именах свойств анонимных типов верно используются прописные буквы при помощи правил использования прописных и строчных букв языка Pascal.
```C#
var localDistributors =
    from customer in customers
    join distributor in distributors on customer.City equals distributor.City
    select new { Customer = customer, Distributor = distributor };
```
Переименуйте свойства, если имена свойств в результате могут быть неоднозначными. Например, если запрос возвращает имя клиента и идентификатор распространителя, не оставляйте имена в виде Name и ID, а переименуйте их, чтобы было ясно, что Name — имя клиента и ID — идентификатор распространителя.
```C#
var localDistributors2 =
    from customer in customers
    join distributor in distributors on customer.City equals distributor.City
    select new { CustomerName = customer.Name, DistributorID = distributor.ID };
```
Рекомендуется использовать неявное типизирование в объявлении переменных запроса и переменных диапазона. Это руководство по неявным вводу в запросах LINQ переопределяет общие правила для [неявно типизированных локальных переменных](https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions#implicitly-typed-local-variables). Запросы LINQ часто используют проекции, которые создают анонимные типы. Другие выражения запросов создают результаты с вложенными универсальными типами. Неявные типизированные переменные часто доступны для чтения.
```C#
var seattleCustomers = from customer in customers
                       where customer.City == "Seattle"
                       select customer.Name;
```
Выровняйте предложения запросов в соответствии с [from](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/from-clause) предложением, как показано в предыдущих примерах.
Используйте [where](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/where-clause) предложения перед другими предложениями запросов, чтобы гарантировать, что более поздние предложения запросов работают на сокращенном отфильтрованном наборе данных.
```C#
var seattleCustomers2 = from customer in customers
                        where customer.City == "Seattle"
                        orderby customer.Name
                        select customer;
```
Используйте несколько from предложений вместо [join](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/join-clause) предложения для доступа к внутренним коллекциям. Например, коллекция объектов Student может содержать коллекцию результатов тестирования. При выполнении следующего запроса возвращаются результаты, превышающие 90 балов, а также фамилии учащихся, получивших такие оценки.
```C#
var scoreQuery = from student in students
                 from score in student.Scores!
                 where score > 90
                 select new { Last = student.LastName, score };
```

## Неявно типизированные локальные переменные

Используйте [неявное](https://learn.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables) ввод для локальных переменных, если тип переменной очевиден с правой стороны назначения.
```C#
var message = "This is clearly a string.";
var currentTemperature = 27;
```
Не используйте [var](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/declarations#implicitly-typed-local-variables) , если тип не отображается в правой части назначения. Не полагайтесь на то, что имя метода предоставляет информацию о типе. Тип переменной считается понятным, если это new оператор, явный приведение или назначение литерального значения.
```C#
int numberOfIterations = Convert.ToInt32(Console.ReadLine());
int currentMaximum = ExampleClass.ResultSoFar();
```
Не используйте имена переменных для указания типа переменной. Имя может быть неверным. Вместо этого используйте тип, чтобы указать тип и использовать имя переменной, чтобы указать семантические сведения переменной. Следующий пример должен использоваться string для типа и что-то подобное iterations , чтобы указать значение информации, считываемой из консоли.
```C#
var inputInt = Console.ReadLine();
Console.WriteLine(inputInt);
```
Рекомендуется избегать использования var вместо [dynamic](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/reference-types). Используйте dynamic, если требуется определение типа во время выполнения. Дополнительные сведения см. в статье [Использование типа dynamic (руководство по программированию на C#)](https://learn.microsoft.com/ru-ru/dotnet/csharp/advanced-topics/interop/using-type-dynamic).
Используйте неявное ввод для переменной цикла в [for](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement) циклах.
В следующем примере неявное типизирование используется в операторе for.
```C#
var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
var manyPhrases = new StringBuilder();
for (var i = 0; i < 10000; i++)
{
    manyPhrases.Append(phrase);
}
//Console.WriteLine("tra" + manyPhrases);
```
Не используйте неявное ввод, чтобы определить тип переменной цикла в [foreach](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement) циклах. В большинстве случаев тип элементов в коллекции не сразу очевиден. Имя коллекции не должно быть исключительно зависеть от вывода типа его элементов.
В следующем примере явное типизирование используется в операторе foreach.
```C#
foreach (char ch in laugh)
{
    if (ch == 'h')
        Console.Write("H");
    else
        Console.Write(ch);
}
Console.WriteLine();
```
используйте неявный тип для последовательностей результатов в запросах LINQ. В разделе [LINQ объясняется, что многие запросы LINQ](https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/coding-conventions#linq-queries) приводят к анонимным типам, в которых должны использоваться неявные типы. Другие запросы приводят к вложенным универсальным типам, где var более удобочитаемым.
> [!IMPORTANT]
> Следите за тем, чтобы случайно не изменить тип элемента итерируемой коллекции. Например, можно легко переключиться с [System.Linq.IQueryable](https://learn.microsoft.com/ru-ru/dotnet/api/system.linq.iqueryable) на [System.Collections.IEnumerable](https://learn.microsoft.com/ru-ru/dotnet/api/system.collections.ienumerable) в инструкции foreach, изменяющей выполнение запроса.
Некоторые из наших примеров объясняют естественный тип выражения. Эти примеры должны использовать var , чтобы компилятор выбрал естественный тип. Несмотря на то, что эти примеры менее очевидны, для примера требуется использование var . Текст должен объяснить поведение.

## Размещение директив using за пределами объявления пространства имен

Если директива using находится за пределами объявления пространства имен, импортированное пространство имен является его полным именем. Полное имя является более понятным. Если директива using находится внутри пространства имен, она может быть либо относительно этого пространства имен, либо его полное имя.
```C#
using Azure;

namespace CoolStuff.AwesomeFeature
{
    public class Awesome
    {
        public void Stuff()
        {
            WaitUntil wait = WaitUntil.Completed;
            // ...
        }
    }
}
```
Предположим, что класс имеет ссылку (прямую или непрямую).[WaitUntil](https://learn.microsoft.com/ru-ru/dotnet/api/azure.waituntil)
Теперь давайте немного изменим его:
```C#
namespace CoolStuff.AwesomeFeature
{
    using Azure;

    public class Awesome
    {
        public void Stuff()
        {
            WaitUntil wait = WaitUntil.Completed;
            // ...
        }
    }
}
```
И он компилируется сегодня. И завтра. Но когда-нибудь на следующей неделе предыдущий код (нетронутый) завершается сбоем с двумя ошибками:
Консоль

- error CS0246: The type or namespace name 'WaitUntil' could not be found (are you missing a using directive or an assembly reference?)
- error CS0103: The name 'WaitUntil' does not exist in the current context
Один из зависимостей представил этот класс в пространстве имен, а затем заканчивается следующим образом .Azure:
```C#
namespace CoolStuff.Azure
{
    public class SecretsManagement
    {
        public string FetchFromKeyVault(string vaultId, string secretId) { return null; }
    }
}
```
Директива, размещенная using в пространстве имен, учитывает контекст и усложняет разрешение имен. В этом примере это первое пространство имен, которое он находит.
CoolStuff.AwesomeFeature.Azure
CoolStuff.Azure
Azure
Добавление нового пространства имен, соответствующего либо CoolStuff.AzureCoolStuff.AwesomeFeature.Azure совпадающего с глобальным Azure пространством имен. Его можно устранить, добавив global:: модификатор в using объявление. Однако вместо этого проще размещать using объявления за пределами пространства имен.
```C#
namespace CoolStuff.AwesomeFeature
{
    using global::Azure;

    public class Awesome
    {
        public void Stuff()
        {
            WaitUntil wait = WaitUntil.Completed;
            // ...
        }
    }
}
```

# Рекомендации по стилю

В общем случае используйте следующий формат для примеров кода:
Используйте четыре пробела для отступа. Не используйте вкладки.
Согласованное выравнивание кода для повышения удобства чтения.
Ограничить строки до 65 символов, чтобы повысить удобочитаемость кода в документах, особенно на мобильных экранах.
Прервать длинные операторы на несколько строк, чтобы повысить ясность.
Используйте стиль Allman для фигурных скобок: открытый и закрывающий фигурные скобки своей собственной новой линии. Фигурные скобки соответствуют текущему уровню отступа.
Разрывы строк должны возникать перед двоичными операторами при необходимости.

## Стиль комментариев

Используйте одно строковый комментарий (//) для кратких объяснений.
Избегайте нескольких строковый комментарий (/* */) для более длинных объяснений. Комментарии не локализованы. Вместо этого более длинные объяснения находятся в статье-компаньоне.
Для описания методов, классов, полей и всех общедоступных элементов используются [xml-комментарии](https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/xmldoc/).
Комментарий размещается на отдельной строке, а не в конце строки кода.
Текст комментария начинается с заглавной буквы.
Текст комментария завершается точкой.
Вставьте одно пространство между разделителем комментариев (//) и текстом комментария, как показано в следующем примере.
```C#
// The following declaration creates a query. It does not run
// the query.
```

## Соглашения о макете

Чтобы выделить структуру кода и облегчить чтение кода, в хорошем макете используется форматирование. Примеры и образцы корпорации Майкрософт соответствуют следующим соглашениям.
Использование параметров редактора кода по умолчанию (логичные отступы, отступы по четыре символа, использование пробелов для табуляции). Дополнительные сведения см. в разделе ["Параметры", "Текстовый редактор", C#, "Форматирование"](https://learn.microsoft.com/ru-ru/visualstudio/ide/reference/options-text-editor-csharp-formatting).
Запись только одного оператора в строке.
Запись только одного объявления в строке.
Если строки продолжения не отступываются автоматически, отступите их на одну остановку табуляции (четыре пробела).
Добавление по крайней мере одной пустой строки между определениями методов и свойств.
Использование скобок для ясности предложений в выражениях, как показано в следующем коде.
```C#
if ((startX > endX) && (startX > previousX))
{
    // Take appropriate action.
}
```
Исключения возникают, когда в примере объясняется приоритет оператора или выражения.