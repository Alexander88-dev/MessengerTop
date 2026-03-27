[README.md](https://github.com/user-attachments/files/26221312/README.md)
# MessengerTop – Клиент-серверный мессенджер

MessengerTop — учебный проект, демонстрирующий разработку клиент-серверного приложения для обмена текстовыми сообщениями. Проект реализован на платформе .NET Framework с использованием C# и охватывает ключевые аспекты современной разработки: графический интерфейс (Windows Forms), сетевое взаимодействие (TCP/IP), работу с базами данных (Entity Framework) и безопасное хранение паролей (BCrypt).

## Основные возможности

- Регистрация и авторизация пользователей с проверкой введённых данных
- Безопасное хранение паролей — хеширование с помощью BCrypt
- Сетевое взаимодействие по протоколу TCP/IP (асинхронная обработка)
- Серверная часть поддерживает множество одновременных подключений
- Модульная архитектура клиента и сервера для лёгкого расширения

## Технологии

- .NET Framework 4.7.2
- C# (Windows Forms, асинхронное программирование)
- TCP/IP (TcpClient, TcpListener)
- Entity Framework (Database First)
- BCrypt.Net (хеширование паролей)
- SQL Server Express / LocalDB

## Архитектура

### Клиент (MessengerTopClient)

- ServerConnection — класс управления сетевым подключением
- LoginForm — форма авторизации
- RegistrForm — форма регистрации с валидацией
- MessengerForm — главная форма (список контактов, чат)

### Сервер (MessengerTopServer)

- Асинхронная обработка каждого клиента в отдельной задаче
- AuthService — сервис аутентификации (вход, регистрация)
- Модель базы данных User (Id, Login, Password, Lvl, Email)

### Протокол обмена

Текстовый протокол на основе строк, разделённых символом новой строки:

- LOGIN|{login}|{password}
- REGISTER|{login}|{password}|{email}
- Ответы: SUCCESS, NOT_FOUND, WRONG_PASSWORD, USER_EXISTS

## Требования к окружению

### Клиент
- Windows 7 SP1 и выше
- .NET Framework 4.7.2
- 512 МБ ОЗУ

### Сервер
- Windows Server 2008 R2 и выше / Windows 10/11
- .NET Framework 4.7.2
- SQL Server Express 2019 или LocalDB
- 2 ГБ ОЗУ (рекомендуется 4 ГБ)

## Перспективы развития

- Добавление шифрования трафика (SSL/TLS)
- Реализация обмена сообщениями между пользователями
- Групповые чаты
- Веб-интерфейс на ASP.NET Core SignalR

## Авторы

<a href="https://github.com/Alexander88-dev">
  <img src="https://github.com/Alexander88-dev.png" width="50" style="border-radius: 50%; object-fit: cover;">
</a>
<a href="https://github.com/Ssaranov">
  <img src="https://github.com/Ssaranov.png" width="50" style="border-radius: 50%; object-fit: cover;">
</a>

<a href="https://github.com/DaRnE1011">
  <img src="https://github.com/DaRnE1011.png" width="50" style="border-radius: 50%; object-fit: cover;">
</a>

<a href="https://github.com/Aleksey1161">
  <img src="https://github.com/Aleksey1161.png" width="50" style="border-radius: 50%; object-fit: cover;">
</a>
## Благодарность



<a href="https://github.com/kay-anjel228">
  <img src="https://github.com/kay-anjel228.png" width="50" style="border-radius: 50%; object-fit: cover;">
</a>

## Отдельная благодарность учителю
