using System;
using System.Dynamic;



class Program
{
    static void Main(string[] args)
    {
        // textspeed.TypeText("BONJOUR TOUT LE MONDE");
        // textspeed.TypeText("BOM DIA ");
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        textspeed.TypeText($"{myCircle.GetRadius()}");
    
    
    }

}
