 # TaskManager
 Программа для постановки задач
 ## Установка
 1. Клонирование репозитория
    ```git clone https://github.com/Lexeus28/DzTaskManager.git```
 2. Переход в директорию DzTaskManager
    ```cd DzTaskManager```
 3. Установка зависимостей
    Откройте проект в Visual Studio , либо восстановите пакеты через .NET CLI:
    ```dotnet restore```
    Проект использует следующие зависимости:
    Microsoft.EntityFrameworkCore
    Microsoft.EntityFrameworkCore.Design
    Microsoft.EntityFrameworkCore.Sqlite.Core
    Microsoft.EntityFrameworkCore.Tools
    SQLitePCLRaw.bundle_e_sqlite3
 4. Применение миграций
    Чтобы создать и обновить структуру базы данных, выполните в Package Manager Console:
    ```Update-Database```
 5. Сборка и запуск
    Через Visual Studio:
    Откройте .sln файл
    Выберите запуск проекта DzTaskManager
    При первом запуске БД будет автоматически создана
    Через .NET CLI:
     ```dotnet build```
     ```dotnet run --project DzTaskManager/DzTaskManager.csproj```
## Функции программы
  1. Добавление задач в список и базу данных
  2. Удаление задач из списка и из базы данных
  3. Изменение выбранной задачи из списка
## Асинхронные и синхронные методы
  1. Все методы для работы с базой данных из репозитория ( GetAllAsync, AddAsync, UpdateAsync, DeleteAsync) и соответствующие методы из сервиса (GetAllTasksAsync, CreateTaskAsync, UpdateTaskAsync, DeleteTaskAsync)
     сделаны асинхронными для того, чтобы оптимизировать работу с базой данных
  2. Методы btnAddTask_Click и HandleTaskSelection сделаны синхронными так как они не требуют await внутри себя, не содержат долгих операций (один открывает форму, другой читает данные с уже загруженного объекта), а также они работают с UI 
