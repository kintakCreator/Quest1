#include <iostream>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
  string s[100000];
  int i,Max=0,nom=0,a[100000];
  for (i=1;i<=10;i++) cin >> s[i];
  sort(s+1,s+1+10); reverse(s+1,s+1+10);
  for (i=1;i<=10;i++) a[i]=s[i].length();
  for (i=1;i<=10;i++) 
    if (a[i]>Max) {Max=a[i]; nom=i;}
  nom--;
  cout << s[nom]; 
}
