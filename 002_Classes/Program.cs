using System;
using System.Data;

namespace _002_Classes
{
    class User
    {
        public readonly DateTime dor;
        public string login,  name, lastName;
        public int age;
        public User()
        {
            dor = DateTime.Now;
        }
        public void Print()
        {
            Console.WriteLine($"Login: {login} \nName: {name} \nLast Name: {lastName} \nAge: {age} \nDate of registration: {dor}");
        }
    }
    class Program
    {
                /*Задание
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Требуется: 
        Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата
        заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
        (при создании экземпляра данного класса) без возможности его дальнейшего изменения.
        Реализуйте вывод на экран информации о пользователе.*/
        static void Main(string[] args)
        {
            User newUser = new User();
            newUser.login = "SayIt23";
            newUser.name = "Jay";
            newUser.lastName = "Jonna";
            newUser.age = 22;
            newUser.Print();
        }
    }
}
