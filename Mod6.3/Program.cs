using System.Drawing;

namespace Mod6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var department = GetCurrentDepartment();

            SmartHelper helper = new SmartHelper("Олег");
            helper.Greetings("Грег");

            Console.ReadKey();
        }
       /* static Department GetCurrentDepartment()
        {
            // logic;
        }
       */
        class Company
        {
            public string Type = "Банк";
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name = "Санкт-Петербург";
        }

        class Triangle
        {
            public double a;
            public double b;
            public double c;

            public void Perimeter(double a, double b, double c)
            {
                double result = a + b + c;
            }

            public void Area(double a, double b, double c)
            {
                double semiperimeter = (a + b + c)/2;

                double result = Math.Sqrt(semiperimeter*(semiperimeter - a)*(semiperimeter - b)*(semiperimeter - c));

            }

        }

        class Circle
        {
            public double radius;

            public void Circumference(double radius)
            {
                double result = 2*Math.PI*radius;
            }

            public void Area(double radius)
            {
                double result = 2 * Math.PI * Math.Pow(radius,2);
            }
        }

        class Square
        {
            public double a;

            public void Area(double a)
            {
                double result = a * a;
            }

            public void Perimeter(double a)
            {
                double result = a * 4;
            }

        }

        class Car
        {
            private double Fuel;
            
            private int Mileage;

            private string color;

            private TurnDirection turn;

            public Car()
            {
                Fuel = 50;
                Mileage = 0;
                color = "White";

            }

            private void Move()
            {

                Mileage++;
                Fuel -= 0.5;

            }

            private void Turn(TurnDirection direction)
            {
                turn = direction;
            }

            public void FillTheCar()
            {

                Fuel = 50;

            }


            public string GetColor()
            {
                return color;
            }

            public void ChangColor(string newColor)
            {
                if (color != newColor)
                    color = newColor;
            }
                
            public bool IsTurningLeft()
            {
                return turn == TurnDirection.Left;
            }

            public bool IsTurningRight()
            {
                return turn == TurnDirection.Right;
            }            

        }
        enum TurnDirection
        {
            None = 0,
            Left,
            Right
        }

        enum FuelType
        {
            Gas = 0,
            Electricity
        }

        class HybridCar : Car
        {

            public FuelType FuelType;

            public void ChangeFuelType(FuelType type)
            {
                FuelType = type;
            }

        }

        class TrafficLight
        {
            private void ChangeColor(string color)
            {
                
                
            }

            public void GetColor()
            {
                
            }


        }

        class User
        {
            private int age;
            private string login;
            private string email;

            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    if(value < 18)
                    {
                        Console.WriteLine("Возраст должен быть не меньше 18");
                    }
                    else
                    {
                        age = value;
                    }

                }

            }
            public string Login
            {
                get
                {
                    return login;
                }

                set
                {
                    if(value.Length < 3)
                    {
                        Console.WriteLine("Логин должен быть не менее трех символов");
                    }

                    else
                    {
                        login = value;
                    }
                }

            }

            public  string Mail
            {
                get
                {
                    return email;
                }

                set
                {
                    if(value.Contains('@') == false)
                    {
                        Console.WriteLine("Почта введена неверно!");
                    }
                    else
                    {
                        email = value;
                    }
                }
            }

        }

        class Employee
        {

            public string Name;
            public int Age;
            public int Salary;

        }

        class ProjectManager : Employee
        {
            public string ProjectName;
        }

        class Developer : Employee
        {
            public string ProgrammingLanguage;
        }

        class Food { }
       
        class Fruit : Food { }
        
        class Vegetable : Food { }
       
        class Apple : Fruit { }

        class Banana : Fruit { }

        class Pear : Fruit { }

        class Potato : Vegetable { }

        class Carrot : Vegetable { }

        class Obj
        {
            private string name;
            private string owner;
            private int length;
            private int count;
                        
            public Obj(string name, string ownerName, int objLength, int count)
            {
                this.name = name;
                owner = ownerName;
                length = objLength;
                this.count = count;
            }
        }

        class SmartHelper
        {
            private string name;

            public SmartHelper(string name)
            {
                this.name = name;
            }

            public void Greetings(string name)
            {
                Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
            }
        }

    }

}
