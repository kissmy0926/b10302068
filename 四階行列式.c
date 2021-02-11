#include <stdio.h>
#include <stdlib.h>
int two(int ,int , int, int, int ,int);
int three(int ,int ,int ,int ,int ,int ,int ,int ,int);

int n = 4;
int main(void)
{
    int a[n][n],i,j,x = 0,y = 0,z = 0,total = 0;
    
    for(i=0;i<n;i++)
    {
      for(j=0;j<n;j++)
      {
        scanf("%d",&a[i][j]);
      }
    }
    
    for(i=0;i<n;i++)
    {
      for(j=0;j<n;j++)
      {
        printf("%d ",a[i][j]);
      }
      printf("\n");
    }
    x = x + a[0][0] * three(a[1][1],a[1][2],a[1][3],a[2][1],a[2][2],a[2][3],a[3][1],a[3][2],a[3][3]);
    printf("­È = %d \n",x);
    y = y + a[0][1] * three(a[1][0],a[1][2],a[1][3],a[2][0],a[2][2],a[2][3],a[3][0],a[3][2],a[3][3]);
    printf("­È = %d \n",y);
    z = z + a[0][2] * three(a[1][0],a[1][1],a[1][3],a[2][0],a[2][1],a[2][3],a[3][0],a[3][1],a[3][3]);
    printf("­È = %d \n",z);
    total = total + x - y + z;
    printf("­È = %d \n",total);
    system("pause");
    return 0;
}

int three(int a,int b, int c,int d,int e,int f,int g,int h,int i)
{
    33333333333333
	int sum = 0;
    sum = two(a,c,e,e,g,i);
}

int two(int a,int b,int c,int d,int e,int f)
{
     int sum = 0;
     sum = (a * c * f) - (b * d * e);
}
}
