using System.Linq;
using System.Collections.Generic;

//creation d'une liste 
int[] number = new int[] { 12, 20, 1, -3, 5, -6, 13, 40, 200, -1400 };

/* travail demande:
 1-afficher tous les nombres de liste number utilisant les deux methodes (lambda expression et queru expression)
 2-afficher les nombres positives , puis les nombres megatives 
 3-afficher les nombres par ordre decroissant puis les nombres negatives par ordre croisant
 4-grouper par nombres paires et impaires
 5- soit la liste suivante :
    int[] months = {1,2,3,4,5,6,7,8,9,10,11,12};
    5.1- concater ces deux listes
    5.2- afficher les nombres sans repetions 
    5.3- afficher le premier nombre  
    5.4- afficher le dernier nombre  */

// 1- on affiche tous les nombres du liste number 

// utilisant les expressions lambda :
//var res = number.ToList();
//foreach (var item in res)
//{
//    Console.WriteLine(item);

//}
//Console.ReadKey();

//utilisant query selector :
//var res2 = from num in number select num ;
//    foreach (var item2 in res2)
//    {
//        Console.WriteLine(item2);
//    }
//    Console.ReadKey();

//--------------------------------------------------------------------------------

// 2- on affiche les nombres positives puis negatives 

//les positives 
//var res3 = from num in number where num > 0 select num;
//     foreach (var item3 in res3)
//     {
//          Console.WriteLine(item3);
//     }
//    Console.ReadKey();

// les negatives
//var res4 = number.Where(item4 => item4 < 0).ToList();
//foreach (var item4 in res4)
//{
//    Console.WriteLine(item4);
//}
//Console.ReadKey();

//------------------------------------------------------------------------------------------------

// 3-affichage des nombres par ordre decroissant 

//var res5 = number.ToList().OrderByDescending(num => num);
//foreach(var num in res5)
//{
//    Console.WriteLine(num);
//}
//Console.ReadKey();

// affichage des nombres negatives par ordre croissant 

//var res6 = from num in number where num < 0 orderby num ascending select num;
//foreach(var num in res6)
//{
//    Console.WriteLine(num);
//}
//Console.ReadKey();

//---------------------------------------------------------------------------------------------------

// 4- grouper par paires et impaires 



//var res7 = from num in number group num by num % 2 == 0;
//foreach (var item in res7)
//{
//    Console.WriteLine("voila :");
//    foreach (var num in item)
//    {
//        Console.WriteLine(num);
//    }
//}


//-----------------------------------------------------------------------------------------------------------------------

//5.1- concater les deux listes :

int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
//var AraayConcat = number.Concat(months);
//foreach( var item in AraayConcat )
//{
//    Console.WriteLine(item);
//}

//5-2 affichage sans repetion 

//var arrayconcat = number.Union(months);
//foreach (var item in arrayconcat)
//{
//    Console.WriteLine(item);    
//}

 //5-3 affichage premier nombre paire 

// var arrayconcat = number.Concat(months);
//foreach (var item in arrayconcat)
//    {
//       Console.WriteLine(item);
//    }
//Console.ReadKey();

//int myarray = arrayconcat.FirstOrDefault();
//Console.WriteLine("premier nombres "+myarray);


//------------------------------ce TP est rédigé par ====== FEJRI AZZEDDINE ======----------------------------------------------