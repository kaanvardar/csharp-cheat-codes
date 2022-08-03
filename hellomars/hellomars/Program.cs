namespace hellomars
{
    class Program
    {
        static void Main(string[] args)
        {   
            //basics
            string name = "kaan";
            int age = 22;
            Console.WriteLine("\nthere once was a man named "+name);
            Console.WriteLine("he was "+age+" years old ");
            age = 81; //we can change the variable middle of
            Console.WriteLine("he really liked the name "+name);
            Console.WriteLine("but didnt like being"+age);
            

            //data types
            string phrase = "kaan vardar";
            char grade = 'c';
            int age_2 = 30;
            double gpa = 3.2;
            bool is_male = true;
            Console.WriteLine("name is "+phrase+" grade is "+grade+" age is "+age_2+" gpa is "+gpa+" is male? "+is_male+"");


            //working with strings and methods
            string phrase_1 = "giraffe academy" + " is cool";//concetaneta
            Console.WriteLine(phrase_1);
            Console.WriteLine(phrase_1[2]);
            Console.WriteLine(phrase_1.Length);
            Console.WriteLine(phrase_1.ToUpper());
            Console.WriteLine(phrase_1.Contains("academy"));
            Console.WriteLine(phrase_1.IndexOf("academy"));
            Console.WriteLine(phrase_1.IndexOf("d"));
            Console.WriteLine(phrase_1.Substring(8,3));

            //working with numbers
            Console.WriteLine(5+12);
            Console.WriteLine(5 + 2 * 3);
            int num = 3;
            num++;
            Console.WriteLine(num);
            int num_1 = 5;
            num--;
            Console.WriteLine(num_1);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Math.Round(3.4));

            //getting user input
            /*Console.Write("Enter your name: ");
            string name_2 = Console.ReadLine();
            Console.WriteLine("hello "+name_2);
            //Console.ReadLine(); */
            
            //string to integer
            int num_2 = Convert.ToInt32("45");
            Console.WriteLine(num+6);

            //building a calculator
            /*
            Console.Write("enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter second number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3+num4);*/

            //building a mad lib
            /*
            Console.Write("enter a color: ");
            string color = Console.ReadLine();

            Console.Write("enter a pluralNoun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("enter a celebrity: ");
            string celebrity = Console.ReadLine();

            Console.WriteLine("roses are "+color);
            Console.WriteLine(""+pluralNoun+" are blue");
            Console.WriteLine("i ove "+celebrity+"");
            */

            //arrays
            int [] luckyNumbers = {4,8,15,26,23,42};
            string[] friends = new string[5];
            friends[0]="Jim";
            friends[1]="Kelly";
            Console.WriteLine("array's index is "+luckyNumbers[2]);

            //methods
            string Name_3 = "kaan";
            int Age_3 = 22;
            SayHi(Name_3,Age_3);
            Console.WriteLine(cube(5));

            //if statements and boolen 
            bool isMale = true;
            bool isTall = true;

            if(isMale && isTall)
            {
                Console.WriteLine("you are tall male!");
            }
            else if(isMale && !isTall) 
            {
                Console.WriteLine("you are a short male");
            }
            else
            {
                Console.WriteLine("you are either not male or not tall or both!");
            }

            Console.WriteLine(GetDay(4));

            //while loop
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.WriteLine("\n");

            //do while loop --> 5den kucuk olmasa da hala daha 6yi yazdirabiliyoruz
            int index2 = 6;
            do
            {
                Console.WriteLine(index2);
                index2++;
            }while(index2 <= 5);

            //guessing game
            string secretWord = "giraffe";
            string guess = "";
            int counter=0;
            int guessLimit = 3;
            bool outOfGuess = false;

            while(guess != secretWord && outOfGuess)
            {   
                if(counter < guessLimit)
                {
                    Console.WriteLine("enter a guess: ");
                    //guess = Console.ReadLine();
                    counter++;   
                }
                else
                { 
                    outOfGuess = true;
                }
                
            }
            Console.WriteLine("you win");


            //for loop  
            int i=1;
            int [] luckynums = {4,8,15,16,23,42};
            for(i=0; i<luckynums.Length; i++)
            {
                Console.WriteLine(luckynums[i]);
            }

            Console.WriteLine(getPow(3,5));

            //2d arrays daha fazla virgul koyarsa 3d,4d,5d...
            int [,] myArray = new int [2,3];//another way
            int [,] numberGrid = {
                {1,2},
                {3,4},
                {5,6}
            };
            Console.WriteLine(numberGrid[0,0]);
            
            //exception handling
            try //any code that we think will break the program put it in try
            {
               /* Console.WriteLine("enter a number: ");
                int num11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a second number: ");
                int num12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("answer is: "+num11/num12);*/
            }
            catch(Exception e) //kinda back-up system we can put error's name instead of Exception 
            {
                Console.WriteLine("Error exception handling");
                Console.WriteLine(e.Message);
            }
            finally //any code in finally always executed
            {

            }

            //Class tells us what the book datatype is
            //Object is a actual instance
            //this is an book object(instance of a book)
            //every single real book is an object.
            Book book1 = new Book("Harry Potter","J.K Rowling",400);
            Book book2 = new Book("Lord of The Rings","Tolkein",700);
            Book book3 = new Book("Denial of Dos","Mitnick",300);
            Student student1 = new Student("Kaan Vardar","CS",3.0);
            Student student2 = new Student("Jim Fall","BM",3.5);
            Movie avengers = new Movie("Avengers","Joss Waden","PG-12");
            Movie shrek = new Movie("Shrek","Adam Adamson","PG");
            Song holiday = new Song("Holiday","Green Day",200);
            Song kashmir = new Song("Kashmir","Led Zeppelin",150);


            avengers.Rating = "it"; //boyle yazsak da rating degismez ayrica rating ile
            //degil Rating ile erisebiliriz.

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine("\n");
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);
            Console.WriteLine("\n");
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine("\n");
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(holiday.sTitle);
            Console.WriteLine(kashmir.sTitle);

            //Static methods & classes
            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("kaan");

            //inheritance
            Chef chef1 = new Chef();
            chef1.MakeChicken();

            ItalianChef itc = new ItalianChef();
            itc.MakePasta();
            
        }


        //METHODS
        static int getPow(int baseNum,int powNum)
        {
            int result = 1;
            for (int i=0; i<powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }


        static void SayHi(string Name_3,int Age_3)
        {
            Console.WriteLine("hi user "+Name_3+ " first method and your age is "+Age_3+"");
        }

        static int cube(int num5)
        {
            int result = num5 * num5 * num5;
            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "INVALID DAY NUMBER";
                    break;               
            }
            return dayName;
        }
        
    }
}