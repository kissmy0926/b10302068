#include<stdio.h>
#include<stdlib.h>

int main(void)
{
    unsigned int money,week,coda,time;
    scanf("%d",&week);
    if(week ==6 || week ==7)
    {
         coda = 30;
     }
    else if(week ==1 || week ==2 || week ==3 || week ==4 || week ==5)
    {
         coda = 20;
     }
    scanf("%d",&time);
    if(time%60>=5)
    {
         money = (time/30+1) * coda;
         printf("%d",money);
    }
    if(time%60<5)
    {
         money = (time/30) * coda;
         printf("%d",money);
    }
     system("pause");
     return 0;


}
