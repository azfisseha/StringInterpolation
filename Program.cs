DateTime now = DateTime.Now;


//1. January 22, 2019 (right aligned in a 40 character field.
Console.WriteLine($"{(now.ToString("MMMM") + " " + now.Day + ", " + now.Year),40}");

//2. 2019.01.22
Console.WriteLine($"{now.Year}.{now.ToString("MM")}.{now.ToString("dd")}");

//3. Day 22 of January, 2019
Console.WriteLine($"Day {now.Day} of {now.ToString("MMMM")}, {now.Year}");

//4. Year: 2019, Month: 01, Day: 22
Console.WriteLine($"Year: {now.Year}, Month: {now.ToString("MM")}, Day: {now.ToString("dd")}");

//5.           Tuesday (10 spaces total, right aligned)
Console.WriteLine($"{now.DayOfWeek,10}");

//6.    11:01PM      Tuesday   (10 spaces total for each including day-of-week, both right-aligned)
String timeOfDay = $"{now.ToString("hh")}:{now.ToString("mm")} {now.ToString("tt")}";
Console.WriteLine($"{timeOfDay,10}{now.DayOfWeek,10}");

//7. h:11, m:01, s:27
Console.WriteLine($"h:{now.ToString("hh")}, m:{now.ToString("mm")}, s:{now.ToString("ss")}");

//8. 2019.01.22.11.01.27
Console.WriteLine($"{now.Year}.{now.ToString("MM")}.{now.ToString("dd")}.{now.ToString("hh")}.{now.ToString("mm")}.{now.ToString("ss")}");


var pi = Math.PI;
//pi as currency
Console.WriteLine($"{pi:C2}");

//right-aligned (10 spaces), number with 3 decimal places
Console.WriteLine($"{pi,10:N3}");