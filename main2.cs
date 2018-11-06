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
