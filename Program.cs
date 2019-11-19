using System;

namespace c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter = 0;
            int guessed_number = 0;
            int count_value = 3;
            string play_continue;
            bool correct_guess = false;
            string play_again;

            Random random = new Random();
            int randomNumber = random.Next(0, 100);
        
            while(counter < 4){
                    Console.WriteLine("You've got " + (count_value - counter) + " guesses left");
                    Console.WriteLine("Pls guess a number:  ");
                    guessed_number = Convert.ToInt32(Console.ReadLine());
                if(randomNumber == guessed_number){
                    Console.WriteLine("Congratz. You guessed the number correctly! The number was " + randomNumber + " .");
                    counter = 4;
                    correct_guess = true;
                }
                if(randomNumber < guessed_number){
                    Console.WriteLine("You're guessed number is too high!");
                    counter = counter +1;
                }
                if(randomNumber > guessed_number){
                    Console.WriteLine("You're guessed number is too low!");
                    counter = counter +1;
                }
                if(counter == 3){
                Console.WriteLine("You've used up all your attempts. Do you want to continue? Type in yes or no!");
                play_continue = Console.ReadLine();
                    if(play_continue == "yes"){
                        counter = 0;
                        count_value = 3;
                    }
                    if(play_continue == "no"){
                        Console.WriteLine("See you!");
                        counter = 4;
                    }
                }
                if(correct_guess == true){
                    Console.WriteLine("Do you want to play again? Type in yes or no!");
                    play_again = Console.ReadLine();
                    if(play_again == "yes"){
                        counter = 0;
                        count_value = 3;
                        randomNumber = random.Next(0, 100);
                    }
                    if(play_again == "no"){
                        Console.WriteLine("See you!");
                        counter = 4;
                }
                Console.ReadKey();
                }
                
            }
        }   
    }
}
