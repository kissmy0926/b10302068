#include<iostream> 
#include<windows.h>
#include<conio.h>
#include<iomanip>

using namespace std;

class Clock
{
      private:
       int hour;
       int minute;
       int second;
       
       
      public:
      Clock(int = 0,int = 0, int = 0);
      void setTime(int,int,int);
      void setHour(int);
      void setMinute(int);
      void setSecond(int);
      void incSecond();
      void decSecond();
      int getHour();
      int getMinute();
      int getSecond();
      int getChoice();
      void normalClock();
      void countdownClock();
      void inputTime();
      
      void printTime();
};

 Clock::Clock(int hr, int min , int sec)
 {
   setTime(hr,min,sec);   
 }
 void Clock::setTime(int h,int m, int s)
 {
    setHour(h);
    setMinute(m);
    setSecond(s);  
 }
 
 void Clock::setHour(int h)
 {
      hour = (h >=0&&h<24) ? h :0;
 }
 void Clock::incSecond()
 {
      second ++;
      if(second >= 60)
      {
        second = 0;
        minute ++;
      }
      if(minute >=60)
      {
        minute = 0;
        hour ++;
      }
      if(hour >= 24)
      {
        hour = 0;
      }
 }
 
 void Clock::decSecond()
 {
      second --;
      if(second <0)
      {
        second = 59;
        minute --;
      }
      if(minute < 0)
      {
        minute = 59;
        hour -- ;
      }
      if(hour < 0)
      {
        hour = 23;
      }
 }
  void Clock::setMinute(int m)
  {
       minute = (m >=0 && m < 60)? m : 0;
  }
  void Clock::setSecond(int s)
  {
       second = (s >=0 && s < 60)? s : 0;
  }
  
  int Clock::getHour()
  {
      return hour;
  }
  int Clock::getMinute()
  {
      return minute;
  }
  int Clock::getSecond()
  {
      return second;
  }
  int Clock::getChoice()
  {
      int choice;
      do
      {
          system("cls");
          cout << " (1)Normal (2)Count Down (0) Quit  ";
          cin >> choice;
      }
      while ((choice < 0)||(choice > 2));
      return choice;
  }
  void Clock::printTime()
  {
        system("cls");
        cout << "  " << setfill('0') << setw(2) << hour << ":"<< setfill('0') <<  setw(2) << minute << ":" << setfill('0') << setw(2) << second << "\n" ;   
  }
  
  void Clock::normalClock()
  {
     int i;
     inputTime();
     i = 0 ;
     while(i<10)
     {
        i++;
        printTime();
        Sleep(1000);
        incSecond();
     }
  }
  
  void Clock::countdownClock()
  {
       inputTime();
       printTime();
       Sleep(1000);
       while((hour != 0) || (minute != 0) || (second != 0) )
       {
          decSecond();
          printTime();
          Sleep(1000);
       }
  }
  
  void Clock::inputTime()
  {
     int h,m,s;
     cout << "Input hour = " ;
     cin >> h;
     cout << "Input minute = " ;
     cin >> m;
     cout << "Input second = ";
     cin >> s;
     setTime(h,m,s);
     
  }
  
  int main()
  {
      Clock t(0,0,0);
      int x;
      while(1)
      {
        x = t.getChoice();
        if(x == 1) t.normalClock();
        else if(x == 2) t.countdownClock();
        else break;
        
      }
      system("pause");
      return 0;
  }
