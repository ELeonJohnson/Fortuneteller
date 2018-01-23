using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuneteller
{
    class Program
    {
        static void Main(string[] args)

        {
            //Declaring all global variables
            string usersFirstName = "";
            string usersLastName = "";
            string usersFavColor = "";
            string usersTransportation = "";
            string usersVacation = "";
            string help = "";
            string red = "I see your into love, passion and desire.";
            string orange = "So, a creative, happy and determine person.";
            string yellow = "You must be a positive, loyal and energetic person.";
            string green = "Life, nature and harmony must be more your thing.";
            string blue = "Hmm, a person with confidence, faith and wisdom.";
            string indigo = "I sense a spiritual, deep and self-mastery person.";
            string violet = "You must have a lot of pride, independence and dignity.";
            string vacationOne = "You should go to a yoga retreat in Hawaii.";
            string vacationTwo = "A Jamaica Resort & Spa at Grand Palladium sounds perfect for you.";
            string vacationThree = "Checking out the Grand Canyon will be a great experience.";
            string vacationFour = "Go see the what all the United States has to offer.";
            string vacationFive = "You ever heard of Walt Disney???";
            string vacationSix = "I heard the sewers are nice this time of year...";
            int usersAge;
            int usersBirthMonth;
            int youngsterAge = 35;
            int usersNumberOfSiblings;
            int retirementYearEven = 64;
            int retirementYearOdd = 65;
            int projectedRetirementAge = 0;
            double bankAccountOneThroughFour = 1000.00;
            double bankAccountFiveThroughEight = 1000000.00;
            double bankAccountNineThroughTwelve = 100000.00;
            double bankAccountLThanOneGThanTwelve = 0.00;
            double usersBankAccount = 0;



            //Asking the user's first name, last name, and age
            Console.WriteLine("Hello, my name is Madame Zeroni and i'm going to tell you your fortune.");

            Console.WriteLine("What is your first name?");
            usersFirstName = Console.ReadLine();

            Console.WriteLine("Good, good....what is your last name?");
            usersLastName = Console.ReadLine();

            Console.WriteLine("Well then {0} {1}, how old are you?", usersFirstName, usersLastName);
            usersAge = int.Parse(Console.ReadLine());

            //Checking to see how old the user is to display the correct question 
            if (usersAge <= youngsterAge)
            {
                Console.WriteLine("Okay youngster, what is your birth month (number)?");
                usersBirthMonth = int.Parse(Console.ReadLine());

            }
            else
            {
                Console.WriteLine("Okay old timer, what is your birth month (number)?");
                usersBirthMonth = int.Parse(Console.ReadLine());

            }


            //Asking the user what his/her favorite color is?
            Console.WriteLine("Now {0}, what is your favorite color from the ROYGBIV? Please type in lowercase.", usersFirstName);
            usersFavColor = Console.ReadLine();


            if (usersFavColor.ToLower().Equals("red"))
            {
                Console.WriteLine(red);

            } else if (usersFavColor.ToLower().Equals("orange"))
            {
                Console.WriteLine(orange);

            }
            else if (usersFavColor.ToLower().Equals("yellow"))
            {
                Console.WriteLine(yellow);

            } else if (usersFavColor.ToLower().Equals("green"))
            {
                Console.WriteLine(green);

            }
            else if (usersFavColor.ToLower().Equals("blue"))
            {
                Console.WriteLine(blue);

            }
            else if (usersFavColor.ToLower().Equals("indigo"))
            {
                Console.WriteLine(indigo);

            }
            else if (usersFavColor.ToLower().Equals("violet"))
            {
                Console.WriteLine(violet);

            } else
            {
                Console.WriteLine("Sorry, that is an invalid color. Type \"Help\" for the help menu.");
                help = Console.ReadLine();
            }


               
            //The help menu
            if (help == "Help")
            {
                Console.WriteLine("R - red");
                Console.WriteLine("O - orange");
                Console.WriteLine("Y - yellow");
                Console.WriteLine("G - green");
                Console.WriteLine("B - blue");
                Console.WriteLine("I - indigo");
                Console.WriteLine("V - violet");

                Console.WriteLine("Now {0}, lets try this again, what is your favorite color from the ROYGBIV?", usersFirstName);
                usersFavColor = Console.ReadLine();

                if (usersFavColor.ToLower().Equals("red"))
                {
                    Console.WriteLine(red);

                }
                else if (usersFavColor.ToLower().Equals("orange"))
                {
                    Console.WriteLine(orange);

                }
                else if (usersFavColor.ToLower().Equals("yellow"))
                {
                    Console.WriteLine(yellow);

                }
                else if (usersFavColor.ToLower().Equals("green"))
                {
                    Console.WriteLine(green);

                }
                else if (usersFavColor.ToLower().Equals("blue"))
                {
                    Console.WriteLine(blue);

                }
                else if (usersFavColor.ToLower().Equals("indigo"))
                {
                    Console.WriteLine(indigo);

                }
                else if (usersFavColor.ToLower().Equals("violet"))
                {
                    Console.WriteLine(violet);

                }
            }


            //retirement projection
            Console.WriteLine("Do you know when you're projected to retire? I do.");
           

            if (usersAge > retirementYearEven && usersAge > retirementYearOdd)
            {
                Console.WriteLine("If my calculations are correct {0}, you're either already retired or could of retire if you want.", usersFirstName);
            }

            else if (usersAge % 2 == 0)
            {
                projectedRetirementAge = retirementYearEven - usersAge;
                Console.WriteLine("You will be able to retire in {0} years.", projectedRetirementAge);
            }


            else
            {
                projectedRetirementAge = retirementYearOdd - usersAge;
                Console.WriteLine("You will be able to retire in {0} years.", projectedRetirementAge);
            }

            

            
            //Askin the user how many siblings he/she has
            Console.WriteLine("How many siblings do you happen to have {0}?", usersFirstName);
            usersNumberOfSiblings = int.Parse(Console.ReadLine());


            //Deciding the user's transpoprtation
            Console.WriteLine("Ms. Zeroni has the perfect vacation spot for you with transportation!");
            Console.WriteLine("I just need your favorite color from the ROYGBIV again.");


            string redTransportation = "magic school bus";
            string orangeTransportation = "Ron's flying car";
            string yellowTransportation = "magic carpet";
            string greenTransportation = "appa's back";
            string blueTransportation = "garbage truck";
            string indigoTransportation = "hitchhicking";
            string violetTransportation = "biking";



            usersFavColor = Console.ReadLine();

            switch (usersFavColor)
            {
                case "red":
                    usersFavColor = redTransportation;
                    usersTransportation = redTransportation;
                    break;

                case "orange":
                    usersFavColor = orangeTransportation;
                    usersTransportation = orangeTransportation;
                    break;

                case "yellow":
                    usersFavColor = yellowTransportation;
                    usersTransportation = yellowTransportation;
                    break;

                case "green":
                    usersFavColor = greenTransportation;
                    usersTransportation = greenTransportation;
                    break;

                case "blue":
                    usersFavColor = blueTransportation;
                    usersTransportation = blueTransportation;
                    break;

                case "indigo":
                    usersFavColor = indigoTransportation;
                    usersTransportation = indigoTransportation;
                    break;

                case "violet":
                    usersFavColor = violetTransportation;
                    usersTransportation = violetTransportation;
                    break;

                default:
                    break;
            }


            //checking the number of the user's siblings and deciding on the vacation spot.
            if (usersNumberOfSiblings == 0)
            {
                Console.WriteLine("{0}. TRANSPORTATION: {1}",vacationOne, usersTransportation);
                usersVacation = vacationOne;

            } else if (usersNumberOfSiblings == 1) {
                Console.WriteLine("{0}. TRANSPORTATION: {1}",vacationTwo, usersTransportation);
                usersVacation = vacationTwo;

            } else if (usersNumberOfSiblings == 2)
            {
                Console.WriteLine("{0}. TRANSPORTATION: {1}",vacationThree, usersTransportation);
                usersVacation = vacationThree;

            } else if (usersNumberOfSiblings == 3)
            {
                Console.WriteLine("{0}. TRANSPORTATION: {1}",vacationFour, usersTransportation);
                usersVacation = vacationFour;

            } else if (usersNumberOfSiblings > 3)
            {
                Console.WriteLine("{0}. TRANSPORTATION: {1}",vacationFive, usersTransportation);
                usersVacation = vacationFive;

            } else if (usersNumberOfSiblings < 0)
            {
                Console.WriteLine("{0}. TRANSPORTATION: {1}",vacationSix, usersTransportation);
                usersVacation = vacationSix;
            }


            //Deciding on the user's bank account 
            if (usersBirthMonth < 1)
            {
                Console.WriteLine("You will have ${0} in your bank account.", bankAccountLThanOneGThanTwelve);
                usersBankAccount = bankAccountLThanOneGThanTwelve;

            } else if (usersBirthMonth > 12)
            {
                Console.WriteLine("You will have ${0} in your bank account.", bankAccountLThanOneGThanTwelve);
                usersBankAccount = bankAccountLThanOneGThanTwelve;

            } else if (usersBirthMonth == 1 || usersBirthMonth < 4)
            {
                Console.WriteLine("You will have ${0} in your bank account.", bankAccountOneThroughFour);
                usersBankAccount = bankAccountOneThroughFour;

            } else if (usersBirthMonth == 5 || usersBirthMonth < 8)
            {
                Console.WriteLine("You will have ${0} in your bank account.", bankAccountFiveThroughEight);
                usersBankAccount = bankAccountFiveThroughEight;

            } else if (usersBirthMonth == 9 || usersBirthMonth <= 12)
            {
                Console.WriteLine("You will have ${0} in your bank account.", bankAccountNineThroughTwelve);
                usersBankAccount = bankAccountNineThroughTwelve;
                
            }


            //Switching up the sentence a little bit in the vacation variables
            vacationOne = "a yoga retreat in Hawaii";
            vacationTwo = "a Jamaica Resort & Spa at Grand Palladium";
            vacationThree = "the Grand Canyon";
            vacationFour = "the United States all over";
            vacationFive = "Disney World";
            vacationSix = "the sewers were it's nice this time of year";

            if (usersNumberOfSiblings == 0)
            {
                
                usersVacation = vacationOne;

            }
            else if (usersNumberOfSiblings == 1)
            {
               
                usersVacation = vacationTwo;

            }
            else if (usersNumberOfSiblings == 2)
            {
                
                usersVacation = vacationThree;

            }
            else if (usersNumberOfSiblings == 3)
            {
                
                usersVacation = vacationFour;

            }
            else if (usersNumberOfSiblings > 3)
            {
               
                usersVacation = vacationFive;

            }
            else if (usersNumberOfSiblings < 0)
            {
                
                usersVacation = vacationSix;
            }


            //The last sentence of the fortune that prints.
            Console.WriteLine(usersFirstName + " " + usersLastName + " will retire in " + projectedRetirementAge + " years with " + "$" + usersBankAccount + " in the bank, a vacation home in " + usersVacation + " and " + usersTransportation + " as transportation.");






        }
    }
}
