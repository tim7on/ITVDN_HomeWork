using System;

namespace _001_Classes
{
    class Program
    {/*
        Задание
Используя Visual Studio, создайте проект по шаблону Console Application.
Требуется: 
Создать класс с именем Address.
В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого
поля, создать свойство с двумя методами доступа.
Создать экземпляр класса Address.
В поля экземпляра записать информацию о почтовом адресе. 
Выведите на экран значения полей, описывающих адрес. */
        class Address
        {
            private int index;
            private string country;
            private string city;
            private string street;
            private int house;
            private int apartment;
            public int Index {
                get { return index; }
                set { index = Index; }
            }
            public string Country
            {
                get { return country; }
                set { country = Country; }
            }
            public string City
            {
                get { return city; }
                set { city = City; }
            }
            public string Street
            {
                get { return street; }
                set { street = Street; }
            }
            public int House
            {
                get { return house; }
                set { house = House; }
            }
            public int Apartment
            {
                get { return apartment; }
                set { apartment = Apartment; }
            }

        }
        static void Main(string[] args)
        {
            Address newaddress = new Address();
            newaddress.Index = 54216;
            newaddress.Country = "Kyrgyzstan";
            newaddress.City = "Bishkek";
            newaddress.Street = "Chui";
            newaddress.House = 51;
            newaddress.Apartment = 23;

            Console.WriteLine($"Индекс: {newaddress.Index} \nСтрана: {newaddress.Country} \nГород: {newaddress.City}\n etc.");

        }
    }
}
