using oop_task_1_console.Core;

User user = new User("21.12.2004")
{
    Login = "Tkachanov34",
    Name = "Oleg",
    LastName = "Tkachanov",
    Age = 34
};

Console.WriteLine($"Дата заполнения анкеты = {user.RegistrationDate}\nLogin = {user.Login}\nName = {user.Name}\nLastname = {user.LastName}\nAge = {user.Age}");