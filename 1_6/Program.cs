 using System;
// 
//     class Building 
//     // Программа, в которой используется класс Building.
//     /* добавить параметризированный метод, вычисляющий
//      * максимальное количество человек, которые могут
//      * занимать здание, исходя из заданной минимальной
//      * площади на одного человека */
//     {
//         public int Floors; // количество этажей
//         public int Area; // общая площадь здания
//         public int Occupants; // количество жильцов
// 
//         // Вывести площадь на одного человека.
//         public int AreaPerPerson()
//             {
//             return Area / Occupants;
//             }
//         //возвратить максимальное количество человек, занимающих здание,
//         //исходя из заданной минимальной площади на одного человека.
//         public int MaxOccupant (int minArea)
//             {
//             return Area / minArea;
//             }
//     }
// 
//     // в этом классе объявляется объект типа Building.
//     class BuildingDemo
// {
//     static void Main()
//     {
//         Building house = new Building(); //создать объект типа Building
//         Building office = new Building();
//         int areaPP; // площадь на одного человека
// 
//         //присвоить значения полям в объекте house.
//         house.Occupants = 4;
//         house.Area = 2500;
//         house.Floors = 2;
//         //присвоить значения полям в объекте office.
//         office.Occupants = 25;
//         office.Area = 4200;
//         office.Floors = 3;
//         //получить площадь на одного человека в жилом доме
//         areaPP = house.AreaPerPerson();
// 
//         Console.WriteLine("Дом имеет:\n " + house.Floors + " этажа\n " + house.Occupants + " жильца\n " + house.Area + "кв. футов общей площади, из них\n " + areaPP + " приходится на одного человека");
//         //получить площадь на одного человека в учреждении
//         areaPP = office.AreaPerPerson();
//         Console.WriteLine("Офис имеет:\n " + office.Floors + " этажа\n " + office.Occupants + " рабочих\n " + office.Area + "кв. футов общей площади, из них\n " + areaPP + " приходится на одного человека");
//         Console.WriteLine("Максимальное количество человек в доме, \n" + "если на каждого должно приходиться " + 300 + " кв. футов: " + house.MaxOccupant(300));
//         Console.WriteLine("Максимальное количество человек в учреждении, \n" + "если на каждого должно приходиться " + 300 + " кв. футов: " + office.MaxOccupant(300));
//         Console.ReadKey();
//     }
// }
    // 
    // class ChkNum
    // {
    //     //возвратить значение true, если значение параметра x окажется простым числом
    //     public bool IsPrime(int x)
    //     {
    //         if (x <= 1) return false;
    // 
    //         for (int i = 2; i <= x / i; i++)
    //             if ((x % i) == 0) return false;
    // 
    //         return true;
    //     }
    // 
    //     public int LeastComFactor(int a, int b)
    //     {
    //         int max;
    // 
    //         if (IsPrime(a) || IsPrime(b)) return 1;
    // 
    //         max = a < b ? a : b;
    // 
    //         for (int i = 2; i <= max / 2; i++)
    //             if (((a % i) == 0) && ((b % i) == 0)) return i;
    //         return 1;
    //     }
    // }
    // //возвратить неименьший общий множитель
    // 
    // class ParmDemo
    // {
    //     static void Main()
    //     {
    //         ChkNum ob = new ChkNum();
    //         int a, b;
    // 
    //         for (int i = 2; i < 10; i++)
    //             if (ob.IsPrime(i)) Console.WriteLine(i + " простое число.");
    //             else Console.WriteLine(i + " непростое число.");
    // 
    //         a = 7;
    //         b = 8;
    //         Console.WriteLine("Наименьший общий множитель чисел " + a + " и " + b + " равен " + ob.LeastComFactor(a, b));
    //         a = 100;
    //         b = 8;
    //         Console.WriteLine("Наименьший общий множитель чисел " + a + " и " + b + " равен " + ob.LeastComFactor(a, b));
    //         a = 100;
    //         b = 75;
    //         Console.WriteLine("Наименьший общий множитель чисел " + a + " и " + b + " равен " + ob.LeastComFactor(a, b));
    //         Console.ReadKey();
    //     }
    // }