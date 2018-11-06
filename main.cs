using System;
using System.Text;

public class Test
{
	public static void Main()
	{
		string[] str = {"abcdef","abcde","abcd","abc","ab","a"}; 
		int[] a = new int[1000];
		int i,Max=0,nom=0;
		Array.Sort(str); Array.Reverse(str);
		for (i=0;i<str.Length;i++) a[i]=str[i].Length;
		for (i=0;i<str.Length-2;i++)
		  if (a[i]>Max) {
		  	Max=a[i];
		  	nom=i;
		 }
		 nom++;
		 Console.WriteLine(a[nom]);
	}
}
