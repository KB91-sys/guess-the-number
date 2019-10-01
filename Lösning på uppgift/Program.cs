using System;

namespace Lösning_på_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gissa talet

            //Anropar metoden Random och sätter denna i objektet, rndnr (randomnumber)
            Random rndnr = new Random();
            
            //Skapar variabeln guessnr
            int guessnr; 
                
            //Sätter variabeln number som ett slumpartat tal mellan 1-100            
            int number = rndnr.Next(100);

            bool legitanswer = false;
            

            //Om användaren skriver in ett nummer högre än 100 eller något annat än en siffra hamnar denne i
            //catch kodblocket
            while(!legitanswer)
            try{
                
                
                //Låter användaren skriva in ett tal mellan 1-100
                Console.Write("Skriv in ett tal mellan 1-100 till du hittar rätt tal: ");
                guessnr = Int32.Parse(Console.ReadLine());
                if(guessnr <= 100){
                    legitanswer = true;
                }

                //Sålänge guessnr inte är samma som number fortätter loopen                
                while(guessnr != number){
                    if(guessnr < number){
                        Console.Write("\n\nFel. Talet är större!\nGissa igen: ");                    
                        guessnr = Int32.Parse(Console.ReadLine());
                    }
                    else if(guessnr > number){
                        Console.Write("\n\nFel! Talet är mindre!\nGissa igen: ");
                        guessnr = Int32.Parse(Console.ReadLine());
                    }
                    
                }
                
                //Om användaren svarar rätt visas följande meddelande:
                Console.Write("\n!!!Rätt tal är " + number + ". Grattis, du har vunnit en röd brödrost i valfri färg!!! :)");
                

            }catch(Exception e){
                Console.Write("\nDu måste skriva in ett heltal mellan 1- 100!\n");
                Console.Write("\n" + e + "\n\n");

            }        
        }    
    }
}