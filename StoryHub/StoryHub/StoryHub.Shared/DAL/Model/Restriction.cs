using System;
using System.Collections.Generic;
using System.Text;

namespace StoryHub.DAL.Model
{
    class Restriction
    {
        private string name=string.Empty;                //"tupá" proměnná

        public string Name                  //chytrá proměnná
        {
            set
            {
                name = value;               //uložená vstupní hodnota chytré proměnné do name
            }
            get
            {
                return name;                //vrací hodnotu privátní proměnné
            }
        }

        private string  description=string.Empty;

        public string Description
        {
            set
            {
                description = value;
            }
            get
            {
                return description;
            }
        }








        private int i;              //proměnná je dána předpisem [přístupové právo][datový typ][název proměnné], je to ukazatel na místo v paměti
                                    //do tohoto místa my potom můžeme umístit nějaká data, která odpovídají danému datovému typu
                                    //když programu dáme proměnnou, kterou má vypsat, dáme mu tak ukazatel na místo v paměti, jehož obsah má pro výpis použít
                                    //program tedy může pracovat s touto proměnnou vždy stejně, nezávisle na konkrétním obsahu, pro něj je důležitý jen datový typ

        public int I                //property, nebo-li chytré proměnné jsou dány předpisem [přístupové právo][datový typ][název proměnné]{set; get;}
        {                           //používáme je proto, abychom mohli ovlivnit způsob zápisu nebo čtení dat z/do proměnné
            set;
            get;
        }

        public void ii()            //metoda je nějaká funkce, je dána předpisem [přístupové právo][datový typ návratové hodnoty][název metody]([datový typ][název parametru]*n){tělo metody}
        {                           
        
        }

        //Přístupová práva
        //jsou práva umožňující/zakazující přístup ke struktuře z vnějšku třídy
        //public - je možné ke členu přistupovat z vnějšku
        //protected - je možné ke členu přistupovat pouze zevnitř a ke členu mají přístup potomci
        //private - je možné ke členu přistupovat pouze v rámci třídy
        //přístupová práva se píší pouze na úrovni třídy
        //Proměnné
        //jsou krabice, které nám slouží pro uchovávání hodnot různých typů
        //s těmito nádobami může program pracovat nezávisle na tom, jakou hodnotu zrovna obsahuje, stačí aby byla stejného typu
        //Vlastnosti
        //jsou cyhtré proměnné, můžeme je používat buď samostatně a nebo ve spojení s klasickými proměnnými
        //to závisí na tom, zda upravujeme zápis nebo čtení hodnoty
            //Set
            //je metoda pro zápis hodnoty, pokud ji smažeme, není možné do proměnné zapisovat pomocí této property
            //Get
            //je metoda pro čtení hodnoty, pokud ji smažeme, není možné z proměnné číst pomocí této property
        //Metody
        //jsou to funkce, které realizují nějaký algoritmus
        //mají přístupové právo, které nám udává, jestli je to metoda soukromá pro danou třídu nebo přístupná z vnějšku objektu
        //mají návratový datový typ, který udává datový typ hodnoty, kterou metoda vrací, pokud žádnou nevrací, píše se void
        //mají název, ten je jesný, musí být unikátní v rámci třídy, konvence je taková, že private metody se píší malým, public mají na začátku velké písmeno
        //mají parametry, to jsou vstupní hodnoty, se kterými můžeme uvnitř funkce pracovat
        //mají tělo, které obsahuje algoritmus který buď vrací hodnotu pomocí keyword return nebo pouze zpracuje data a víc neřeší
        
    }
}
