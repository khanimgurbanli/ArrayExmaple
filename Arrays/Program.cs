// See https://aka.ms/new-console-template for more information
#region Exercises
//1) bir dizi içerisinde bir eleman birden fazla olup olmadığını kontrol eden bir kod bloğu
//2) dizi içerisinde bir elemanın var olup olmadığını kontrol ediniz, bu değer bool tipinde olacak
//3) içerisinde birden fazla eleman tanımladığınız dizi içerisindeki elemanları, for, foreach, while, do-while döngüsü kullanmadan ekrana yazdırınız
//4) metinsel bir dizi içerisindeki değerlerde, verdiğiniz değer ile başlayan tüm elemanları ekrana yazdırınız.
//5) var olan 2 dizinin elemanlarını ekrana yazdırınız.
//6) sayısal 2 dizi içerisinde yer alan farklı elemanları yeni bir diziye, aynı olanları yeni bir diziye ekleyiniz.
#endregion

#region arrayda dublicat deyerler olub olmadigini check et
//string[] fruits = { "Apple", "Peer", "Pineapple","Apple" };
//if (fruits.Length != fruits.Distinct().Count())
//    Console.WriteLine("Contains duplicate value");
//else
//    Console.WriteLine("Don't contains duplicate value");
#endregion

#region arrayda axtarilan elementin olub olmadigini tapmaq
//string[] fruits = { "Apple", "Peer", "Pineapple", "Apple" };
//var checkResult=Array.Exists(fruits, x=>x =="Apple");
//Console.WriteLine(checkResult);
#endregion

#region array elementlerini dovr operatorlari olmadan ekrana yazdirmaq 
//string[] fruits3 = { "Apple", "Peer", "Pineapple", "Apple" };
//Console.WriteLine(string.Join(" , ",fruits3));
#endregion

#region Mətn massivindəki dəyərlərdə verdiyiniz dəyərlə başlayan bütün elementləri çap edin
//string[] fruits = { "Apple", "Peer", "Pineapple", "Apple" };
//string searchValue = Console.ReadLine();
//int itemPosition=Array.IndexOf()


#endregion 2 arrayi birlestirme
//string[] fruits1 = { "Apple", "Peer", "Pineapple", "Apple" };
//string[] fruits2 = { "Apple2", "Peer2", "Pineapple2", "Apple2" };
//string[] newFruitList = new string[fruits1.Length + fruits2.Length];
//Array.Copy(fruits1, newFruitList, fruits1.Length);
//Array.Copy(fruits2,0, newFruitList, fruits1.Length, fruits1.Length);
//Console.WriteLine(string.Join(" , ", newFruitList));

#region SumWithBeforeNumber ---> Array
//int[] nums = { 10, 20, 30, 40, 50 };
//int temp;

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.ReadKey();
//    temp += nums[i];
//    Console.WriteLine(nums[i]+"--->"+);
//}
#endregion
//1