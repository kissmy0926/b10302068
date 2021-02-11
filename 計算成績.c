#include <stdio.h>
#include <stdlib.h>
int score[6][7];
int credit[5];
void input_data(void);
void compute_average(void);
void print_data(void);
void input_credit(void);

int main(void)
{
    input_credit();
    
    input_data();
    
    compute_average();
    
     print_data();
     
     system("pause");
     return 0;
}

void input_credit()
{
     int i,chinese,english,computerscience,calculus,C;
    
        printf("�п�J�Ǥ�\n",i+1);
        printf("��� = ");
        scanf("%d",&chinese);
        printf("�^�� = ");
        scanf("%d",&english);
        printf("�p�� = ");
        scanf("%d",&computerscience);
        printf("�L�n�� = ");
        scanf("%d",&calculus);
        printf("C�{�� = ");
        scanf("%d",&C);
        
        credit[0] = chinese;
        credit[1] = english;
        credit[2] = computerscience;
        credit[3] = calculus;
        credit[4] = C;
     
}

void input_data()
{
     int i,chinese,english,computerscience,calculus,C;
     
     for(i=0;i<6;i++)
     {
        printf("�п�J��%d��ǥͪ����Z\n",i+1);
        printf("��� = ");
        scanf("%d",&chinese);
        printf("�^�� = ");
        scanf("%d",&english);
        printf("�p�� = ");
        scanf("%d",&computerscience);
        printf("�L�n�� = ");
        scanf("%d",&calculus);
        printf("C�{�� = ");
        scanf("%d",&C);
        
        score[i][0] = i+1;
        score[i][1] = chinese;
        score[i][2] = english;
        score[i][3] = computerscience;
        score[i][4] = calculus;
        score[i][5] = C;
     }
}

void compute_average()
{
     int i,j,average,sum,total_credit;
     
     
     total_credit = 0;
     for(j=0;j<6;j++)
       total_credit = total_credit + credit[j] ;
       
       for(i=0;i<6;i++)
     {
        sum = 0;
        for(j=0;j<7;j++)
         sum = sum + score[i][j+1] * credit[j];
         
        average = sum / total_credit;
        score[i][6] = average;
     }
}

void print_data()
{
    int i,j;
    
    printf("==================================================================\n");
    printf("      �s��   ���    �^��    �p��   �L�n��   C�{��   ����  ��  �A\n");
    printf("      ====   ====    ====    ====   ======   =====   ====  ======\n");
    
    for(i=0;i<6;i++)
    {
       for(j=0;j<7;j++)
         printf("  %6d",score[i][j]);
       if(score[i][6] < 60) printf("    ���ή�");
       printf("\n");
    }
    printf("==================================================================\n");
}

































