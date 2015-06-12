using System.IO;
using System;

namespace Test 
{
    class Program
    {
        static void Main()
        {
            Director itemDirector = new Director();
     
            Builder minorbuilder = new ItemBuilder("Minor");
            //Builder mediumbuilder = new ItemBuilder("Medium");
            //Builder majorbuilder = new ItemBuilder("Major");
     
            itemDirector.Construct(minorbuilder); //returns a minor Item
            //itemDirector.Construct(mediumbuilder); //medium magic item
            //itemDirector.Construct(majorbuilder); //major magic item
        }
    }
}


