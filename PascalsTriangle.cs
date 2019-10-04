using System;
 class pascals{
 public static void Main (){
   int height, column = 1, x,i;
  Console.WriteLine("please enter in a height for the triangle");
   height = int.Parse(Console.ReadLine());



    for( x=1; x<=height; x++){
      Console.WriteLine();
      for( i=1; i<= x; i++){
        if(x==0 || i ==0)
          column = 1;
        else
          column=column*(x-i+1)/i;
          Console.Write("{0}  ", column);
    }
         Console.Write(i);
  }
 }
}
