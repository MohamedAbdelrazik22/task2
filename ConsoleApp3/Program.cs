namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char operation = '\0';
            do
            {
                Console.Write("Enter operation you want to do : ");
                operation = char.ToUpper(char.Parse(Console.ReadLine()));
                switch (operation)
                {
                    case 'P'://print numbers
                        if (numbers.Count > 0)
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                            Console.WriteLine("]");
                        }
                        else
                            Console.WriteLine("The list is empty.");

                        break;

                    case 'A': // add numbers
                        int counter = 0;
                        Console.Write("Enter value to for loop : ");
                        counter = int.Parse(Console.ReadLine());
                        for (int i = 0; i < counter; i++)
                        {
                            int number = 0;
                            Console.Write($"Enter number {i + 1}: ");
                            number = int.Parse(Console.ReadLine());

                            bool isDuplicate = false;
                            for (int j = 0; j < numbers.Count; j++)
                            {
                                if (numbers[j] == number)
                                {
                                    isDuplicate = true;
                                    break;
                                }
                            }

                            if (!isDuplicate)
                            {
                                numbers.Add(number);
                            }
                            else
                            {
                                Console.WriteLine("Duplicate number. Please enter a different number.");
                            }
                        }
                        break;

                    case 'M': //find mean of numbers
                        int sum = 0;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine($"The mean of numbers = {sum / numbers.Count}");
                        break;

                    case 'S': //find smallest num
                        if (numbers.Count > 0)
                        {
                            int smallestNumber = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallestNumber)
                                    smallestNumber = numbers[i];
                            }
                            Console.WriteLine($"The smallest numer = {smallestNumber}");
                        }
                        else
                            Console.WriteLine("The list is empty.");
                        break;
                    case 'L': //find biggest num
                        if (numbers.Count > 0)
                        {
                            int biggesttNumber = numbers[0];
                            for (int i = 1; i < numbers.Count; i++)
                            {
                                if (numbers[i] > biggesttNumber)
                                    biggesttNumber = numbers[i];
                            }
                            Console.WriteLine($"The biggest numer = {biggesttNumber}");
                        }
                        else
                            Console.WriteLine("The list is empty.");
                        break;
                    case 'F': // find num required
                        if (numbers.Count > 0)
                        {
                            int numRequired = 0;
                            Console.Write("Enter num you want to find : ");
                            numRequired = int.Parse(Console.ReadLine());
                            bool found = false;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == numRequired)
                                {
                                    Console.WriteLine($"The index of number is {i}");
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                Console.WriteLine("The number isn't in the list.");
                                break;
                            }

                        }
                        else
                            Console.WriteLine("The list is empty.");
                        break;

                    case 'C':
                        if (numbers.Count > 0)
                        {
                            numbers.Clear();
                        }
                        else
                            Console.WriteLine("List is already clear.");
                        break;
                    case 'Q':
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("You choose wrong char.Try again :)");
                        break;
                }
            } while (operation != 'Q'); 
                
           
        }
    }
}