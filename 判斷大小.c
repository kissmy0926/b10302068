#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    int a,b,c;
    scanf("%d%d%d",&a,&b,&c);
    if(a>b)
    {
           if(b>c)
           {
                  printf("%d\n>%d\n>%d\n",a,b,c);
           }
           else
           {
               if(a>c)
               {
                      printf("%d\n>%d\n>%d\n",a,c,b);
               }
               else
               {
                      printf("%d\n>%d\n>%d\n",c,a,b);
               }
           } 
     }
     else
     {
           if(a>c)
           {
                   printf("%d\n>%d\n>%d\n",b,a,c);
           }
           else
           {
               if(b>c)
               {
                        printf("%d\n>%d\n>%d\n",b,c,a);
               }
               else
               {
                        printf("%d\n>%d\n>%d\n",c,b,a);
               }
           }
     }
     system("pause");
     return 0;


}
