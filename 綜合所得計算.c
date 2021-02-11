#include<stdio.h>
#include<stdlib.h>

int main(void)
{
     int money;
     float tax,pay;
     printf("請輸入所得淨額:\n"); 
     scanf("%d",&money);
  

   if(money<=520000)
   {    
                tax = money * 0.05 ;
                pay = tax;
                printf("%f\n",pay);
   }
   else if(money<=1170000)
   {
                tax = money * 0.12;
                pay = tax - 36400;
                printf("%f\n",pay);
   }
    else if(money<=2350000)
   {
                tax = money *0.2;
                pay = tax - 130000;
                printf("%f\n",pay);
   }
   else if(money<=4400000)
   {
                tax = money *0.3;
                pay = tax - 365000;
                printf("%f\n",pay);
   }
   else 
   {
                tax = money *0.4;
                pay = tax - 805000;
                printf("%f\n",pay);
   }

     system("pause");
     return 0;
	 }
     
