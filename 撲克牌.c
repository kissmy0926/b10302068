#include <stdio.h>
#include <stdlib.h>
#include <time.h>

void deal_card(char *, char *, int []);
char convert_to_suit(int);
char convert_to_face(int);
void print_card(char *, char *, int []);
void bubble_sort(char *, char *, int []);
void initialization(void);
int a[52];
int m=5;

int main(void)
{
    int i, x;
    
    char suit[m],face[m];
    int number[m]; 
    
    srand(time(NULL));
    
    while(1)
    {
       initialization();
       bubble_sort(suit,face,number);
       deal_card(suit,face,number);
       print_card(suit,face,number);
       system("pause");
    }
    return 0;
}

void initialization()
{
     int i;
     
     for(i=0;i<52;i++) a[i] = 0;
}

void deal_card(char s[], char f[], int n[])
{
     int i, x;
     
     for(i=0;i<m;i++)
     {
          while(1)
          {
             x = rand() % 52 ;
             if(a[x] == 0) break;
          }
     a[x] = 1;
     n[i] = x % 13; 
     s[i] = convert_to_suit(x);
     f[i] = convert_to_face(x);
     }
     
}

void bubble_sort(char s[], char f[], int n[])
{
     int i,j,x;
     char c;
     
     for(i=0;i<m-1;i++)
       for(j=0;j<m-1-i;j++)
       {
           if(n[j] > n[j+1])
           {
                 x = n[j];
                 n[j] = n[j+1];
                 n[j+1] = x;
                 
                 c = s[j];
                 s[j] = s[j+1];
                 s[j+1] = c;
                 
                 c = f[j];
                 f[j] = f[j+1];
                 f[j+1] = c;
           }
       }
       
}     

char convert_to_suit(int x)
{
     int y;
     char z[] = {6,3,4,5};
     
     y = x / 13;
     return z[y];
}

char convert_to_face(int x)
{
     int y;
     char z[] = {'A','2','3','4','5','6','7','8','9','T','J','Q','K'};
     
     y = x % 13;
     return z[y];
}

void print_card(char s[], char f[],int n[])
{
     int i;
     
     for(i=0;i<m;i++)
       printf("%c%c ",s[i],f[i]);
     printf("\n");
     if(f[0] == f[1] && f[2] == f[3] || f[0] == f[1] && f[2] == f[4] || f[0] == f[2] && f[1] == f[3] || f[0] == f[2] && f[1] == f[4] || f[0] == f[2] && f[3] == f[4] || f[0] == f[3] && f[1] == f[2] || f[0] == f[3] && f[1] == f[4] || f[0] == f[3] && f[2] == f[4] || f[0] == f[4] && f[1] == f[2] || f[0] == f[4] && f[1] == f[3] || f[0] == f[4] && f[2] == f[3])
        printf("兩對\n");
     else
     if(f[0] == f[1] || f[0] == f[2] || f[0] == f[3] || f[0] == f[4] || f[1] == f[2] || f[1] == f[3] || f[1] == f[4] || f[2] == f[3] || f[2] == f[4] || f[3] == f[4])
        printf("一對\n");
}
