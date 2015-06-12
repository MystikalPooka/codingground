using System.IO;
using System;

namespace Test 
{
    class Director
    {
        public void Construct(Builder ib)
        {
            ib.RollItemType(); //Armor? Weapon? Blarg?
            ib.BuildBonus(); //+1?+2? +5 Keen -- of Backstabbing Bitches?
            ib.SetCost(); //bonus^2*1000 or bonus^2*2000 + original cost + cost of abilities
        }
    }
     
    abstract class Builder
    {
        public abstract void RollItemType();
        public abstract void BuildBonus();
        public abstract void SetCost();
        public abstract string GetMagicItem();
    }
     
    class ItemBuilder : Builder
    {
        //private Item item = new Item(); //item to build and add to
 
        //also make Abilities a type? Maybe? Perhaps? Struct? FFFFUUU
        //List<Abilities(?)> Abilities = new List<Abilities>;
 
        //LootTable table = new LootTable();
        //Random rand = new Random();
 
       public ItemBuilder(string rank)
        {
                switch(rank)
                {
                        case "Minor":
                            Console.WriteLine("Minor!");
                            //table = minorMagicTable;
                            break;
                        case "Medium":
                            Console.WriteLine("Medium!");
                            //table = mediumMagicTable;
                            break;
                        case "Major":
                            Console.WriteLine("Major!");
                            //table = majorMagicTable;
                            break;
                        default:
                            //table = null;
                            //MessageBox.Show("Unable to find table of rank \"" + rank +"\" in builder constructor!";
                            break;
                }
        }
 
        public override void RollItemType()
        {
                //make minorTable roll on itself
                //minor table should be the following:
                //subtables are actually NOT "MAGIC TABLE" SPECIFIC.
                //The only values that will change here are the probabilities of the primary subtables.
                //IE ArmorTable when it is added to the minorTable in the load tables method.
                //-ArmorTable
                        //-Chainmail
                        //-Leather
                        //-Breastplate
                        //-Penis Protector
                        //-etc
                //-Shield
                        //-Wooden Shield
                        //-Buckler
                //-Weapon
                       
                //-Potion
                //-ring
                //-Etc
                Console.WriteLine("Table has been rolled!");
                //table.GetResult()
        }
 
        public override void BuildBonus()
        {
               Console.WriteLine("Bonus built!");
        }
        public override void SetCost()
        {
               Console.WriteLine("Cost Set!");
        }
        public override string GetMagicItem()
        {
            return "Got magic item!";
        }
    }
}