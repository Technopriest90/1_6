using System;

    class Building // Программа, в которой используется класс Building.
    {
    public int Floors; // количество этажей
    public int Area; // общая площадь здания
    public int Occupants; // количество жильцов
    }

    // в этом классе объявляется объект типа Building.
    class BuildingDemo
{
    static void Main()
    {
        Building house = new Building(); //создать объект типа Building
        Building office = new Building();
        int areaPP; // площадь на одного человека

        //присвоить значения полям в объекте house.
        house.Occupants = 4;
        house.Area = 2500;
        house.Floors = 2;

        office.Occupants = 25;
        office.Area = 4200;
        office.Floors = 3;


        //вычислить площадь на одного человек.
        areaPP = house.Area / house.Occupants;

        Console.WriteLine("Дом имеет:\n " + house.Floors + " этажа\n " + house.Occupants + " жильца\n " + house.Area + "кв. футов общей площади, из них\n " + areaPP + " приходится на одного человека");

        //вычислить площадь на одного человек в учреждении.
        areaPP = office.Area / office.Occupants;
        Console.WriteLine("Офис имеет:\n " + office.Floors + " этажа\n " + office.Occupants + " рабочих\n " + office.Area + "кв. футов общей площади, из них\n " + areaPP + " приходится на одного человека");
        Console.ReadKey();
    }
}