

#region arrayin metodlari
//int[] numbers = { 3, 5, 1, 7, 8, };
//int[] numbers2 = new int[5];

//Array.Clear(numbers);  arrayin icini temizdiyir
//Console.WriteLine(numbers[0]);

//Array.Copy(numbers, numbers3, 5); arrayi kipyaliyir
//Console.WriteLine(numbers3[0]);


//Array.Reverse(numbers);   arrayi tersine cevirir
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}

//Array.Sort(numbers);  kicikden boyuke siraliyir
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}



#endregion

#region stringin metodlari

//string name = "miriev";
//string.Concat(name);  stringi arraye cevirir
//Console.WriteLine(name);


//Console.WriteLine(name.Length); stringin saylarini 

//Console.WriteLine(name.Contains('u')); verilenin stringin icinde olub olmadiqini yoxluyur

//Console.WriteLine(name.ToLower()); herfleri kicildir bize qaytarir
//Console.WriteLine(name.ToUpper()); herfleri koyudum bize qaytarir

//Console.WriteLine(name.Replace('v', 'w'));  elementi bashka element ile ile evezleyir

//Console.WriteLine(name.EndsWith('v'));  en sonda olan elementi yoxlayir
//Console.WriteLine(name.StartsWith("mi"));  en birinci elementleri yoxlayir

//string name = "  miriev mircavid ";
//Console.WriteLine(name.Trim()); evvelden ve axirdan olan boshduqlari silir

string name = "miriev";

//Console.WriteLine("plase enter your name");
//string ad = Console.ReadLine();
//if (string.IsNullOrEmpty(ad))
//{
//    Console.WriteLine("Please enter your name correctly");
//}
//else
//{
//    Console.WriteLine(ad);
//}



Console.WriteLine("plase enter your name");
string ad = Console.ReadLine();
if (string.IsNullOrWhiteSpace(ad))
{
    Console.WriteLine("Please enter your name correctly");
}
else
{
    Console.WriteLine(ad);
}







#endregion