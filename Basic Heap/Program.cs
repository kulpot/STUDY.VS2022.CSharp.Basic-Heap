using System;

//ref link:https://www.youtube.com/watch?v=lLbKkClhzbU&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=4
//  about memory -- heap -- allocation algorithm

class Cow
{
    int mooCount;
    //bool butchered;     // bool = 1bytes
}

class MainClass
{
    //static void Goo()
    //{
    //    int gooeyInt = 29;
    //    double gooeyDouble = 43;
    //}
    static void Main()
    {
        int meInt = 5;
        Cow c = new Cow();

        // betsy = new Cow();
        // georgy = new Cow();
        // clone = betsy;
        // meInt = 8;



        //int myInt = 5;
        //int anotherInt = 10;
        //Goo();
        //double meDouble = 98.3;
        //Goo();
    }
}