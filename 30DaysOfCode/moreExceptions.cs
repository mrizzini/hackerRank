using System;
//Write your code here

class Calculator
{
    public int power(int num1, int num2)
    {
        int powerNum = num1;
        
        if (num1 < 0 || num2 < 0) 
            throw new Exception("n and p should be non-negative");
        if (num2 == 0)
            return 1;
        
        for (var i = 1; i < num2; i++)
        {
            powerNum *= num1;
        }   

        return powerNum;
    }
}

class Solution{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
    }
}