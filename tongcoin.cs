using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Money{
    static void Main(string[]args){

        double money;
       Console.WriteLine("Please input money:");
        money = double.Parse(Console.ReadLine());

        if(money <= 0) throw new ArgumentException("Input money again:");
        
            
        double[] pay = new double[11];

        double[] numpay = new double[]{1000,500,100,50,20,10,5,2,1,0.5,0.25};
        for (int i=0; i < 11; i++){
            pay[i] = Math.Floor(money/numpay[i]);
            money = money%numpay[i];
        }

      Console.WriteLine("1000 :"+ pay[0]);
      Console.WriteLine("500 :"+ pay[1]);
      Console.WriteLine("100 :"+ pay[2]);
      Console.WriteLine("50 :"+ pay[3]);
      Console.WriteLine("20 :"+ pay[4]);
      Console.WriteLine("10 :"+ pay[5]);
      Console.WriteLine("5 :"+ pay[6]);
      Console.WriteLine("2 :"+ pay[7]);
      Console.WriteLine("1 :"+ pay[8]);
      Console.WriteLine("0.5 :"+ pay[9]);
      Console.WriteLine("0.25 :"+ pay[10]);
        
     
       
        
    }

}    