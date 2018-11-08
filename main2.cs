using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

public class Program
{
	public static void Main()
	{
		List<string> str = new List<string>(){"abcdef","abcde","abcd","abc","ab"};
		//new object wis collection should be created before
		/*var list = new List<string>()
			{
			 "StringWithLongName1",
			 "StringWithLongName123",
			 "StringWithLongName12",
			 "StringWithLongName1234",
			 "StringWithLongName1234567",
			 "StringWithLongName12345",
			 "StringWithLongName123456",
			 "StringWithLongName12345678",
			 "StringWithLongName123456789",
			};*/
		//It's more simple for understandig
		
		//You can use Linq for ths operations
		/* e.g.:
		 var max = "";
           	 var secondMax = "";

		    foreach (var str in list)
		    {
			if (str.Length > max.Length)
			{
			    secondMax = max;
			    max = str;
			}
		    }

		    Console.WriteLine(secondMax);
		    Console.ReadKey();*/
		
	    	int[] a = new int[1000];
		int i,Max=0,nom=0;
		str.Sort(); str.Reverse();
		for (i=0;i<str.Count;i++) {
			a[i]+=str.ElementAt(i).Length;
		}
		for (i=0;i<str.Count;i++)
			if (a[i]>Max) {Max=a[i]; nom=i;};
		nom++;
		Console.WriteLine(nom);
   	}
}
