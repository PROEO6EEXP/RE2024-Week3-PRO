

Console.WriteLine("Enter your grade:");

char userGrade = Char.Parse(Console.ReadLine());

//if (userGrade == 'A')
//{
//    Console.WriteLine("Suurepärane!");
//}
//else if (userGrade == 'B')
//{
//    Console.WriteLine("Väga hea!");
//}
//else if (userGrade == 'C')
//{
//    Console.WriteLine("Hea!");
//}
//else if (userGrade == 'D')
//{
//    Console.WriteLine("Rahuldav");
//}
//else if (userGrade == 'E')
//{
//    Console.WriteLine("Kasin");
//}
//else if (userGrade == 'F')
//{
//    Console.WriteLine("Puudulik.");
//}
//else
//{
//    Console.WriteLine("Vale väärtus.");
//}

switch (userGrade)  //väärtus mida kontrollitakse
{
    case ('A'):  
        Console.WriteLine("Suurepärane!");
        break;
    case ('B'):
        Console.WriteLine("Väga hea!");
        break;
    case ('C'):
        Console.WriteLine("Hea!");
        break;
    case ('D'):
        Console.WriteLine("Rahuldav");
        break;
    case ('E'):
        Console.WriteLine("Kasin");
        break;
    case ('F'):
        Console.WriteLine("Puudulik.");
        break;
    default:
        Console.WriteLine("Vale väärtus.");
        break;

}


