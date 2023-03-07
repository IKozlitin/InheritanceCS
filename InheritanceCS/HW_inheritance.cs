using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Polimorfism
{
    public abstract class Human
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public abstract void Description();

        public override string ToString()
        {
            return $"Имя: {_firstName}\nФамилия: {_lastName}\nДата рождения: {_birthDate.ToShortDateString()}";
        }
    }

    abstract class Citizen : Human
    {
        string _location;

        public Citizen(string firstName, string lastName, DateTime birthDate, string location) : base(firstName, lastName, birthDate)
        {
            _location = location;
        }

        public abstract void Place();

        public override string ToString()
        {
            return base.ToString() + $"\nЛокация: {_location}";
        }
    }

    class Orc : Citizen
    {
        string _typeOfWeapon;

        public Orc(string firstName, string lastName, DateTime birthDate, string location, string typeOfWeapon) : base(firstName, lastName, birthDate, location)
        {
            _typeOfWeapon = typeOfWeapon;
        }

        public override void Description()
        {
            WriteLine("Орки созданы для битвы.");
        }

        public override void Place()
        {
            WriteLine("Я живу в пещере.\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nМое оружие {_typeOfWeapon}";
        }
    }

    class Nord : Citizen
    {
        string _typeOfWeapon;
        string _speciality;

        public Nord(string firstName, string lastName, DateTime birthDate, string location, string typeOfWeapon, string speciality) : base(firstName, lastName, birthDate, location)
        {
            _typeOfWeapon = typeOfWeapon;
            _speciality = speciality;
        }

        public override void Description()
        {
            WriteLine("Норды не боятся холода.");
        }

        public override void Place()
        {
            WriteLine("Я живу на острове.\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nЯ {_speciality}";
        }
    }

    class DarkElf : Citizen
    {
        string _typeOfWeapon;
        string _speciality;
        string _greatHouse;

        public DarkElf(string firstName, string lastName, DateTime birthDate, string location, string typeOfWeapon, string speciality, string greatHouse) : base(firstName, lastName, birthDate, location)
        {
            _typeOfWeapon = typeOfWeapon;
            _speciality = speciality;
            _greatHouse = greatHouse;
        }

        public override void Description()
        {
            WriteLine("Данмеры не любят чужестранцев");
        }

        public override void Place()
        {
            WriteLine("Я живу в лесу.\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nЯ из великого дома {_greatHouse}";
        }
    }

    class Imperial : Citizen
    {
        string _typeOfWeapon;
        string _speciality;
        string _greatHouse;
        string _guild;

        public Imperial(string firstName, string lastName, DateTime birthDate, string location, string typeOfWeapon, string speciality, string greatHouse, string guild) : base(firstName, lastName, birthDate, location)
        {
            _typeOfWeapon = typeOfWeapon;
            _speciality = speciality;
            _greatHouse = greatHouse;
            _guild = guild;
        }

        public override void Description()
        {
            WriteLine("Имперцы служат королю.");
        }

        public override void Place()
        {
            WriteLine("Я живу в городе.\n");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nЯ состою в гильдии {_guild}";
        }
    }
    class Polimorfism
    {
        static void Main(string[] args)
        {
            Citizen[] citizens =
            {
                new Orc("Умбра", " ", new DateTime(1556, 3,5), "Молаг Амур", "Двуручный меч"),
                new Orc("Дара", "гра-Бол", new DateTime(1505, 12,5), "Балмора", "Железный топор"),
                new Nord("Хлормар", "Пьянь", new DateTime(1655, 10,20), "Воронья скала", "Молот", "Варвар"),
                new Nord("Сорквильд", "Ворон", new DateTime(1670, 11,22), "Дагон Фел", "Булава", "Разбойник"),
                new DarkElf("Дивайт", "Фир", new DateTime(1122, 8,17), "Тель Фир", "Даэдрический кинжал", "Маг", "Телвании"),
                new DarkElf("Атин", "Сарети", new DateTime(1144, 1,21), "Альдрун", "Двемерский короткий меч", "Шпион", "Редоран"),
                new Imperial("Требониус", "Арториус", new DateTime(1638, 8,8), "Вивек", "Посох", "Боевой маг", "Хлаалу", "Магов"),
                new Imperial("Дариус", " ", new DateTime(1616, 2,3), "Гнисис", "Имперский палаш", "Рыцарь", "Хлаалу", "Имперский легион")
            };
            foreach (Citizen item in citizens)
            {
                WriteLine(item);
                item.Description();
                item.Place();
            }
        }
    }
}