namespace ReizTechIntershipTask
{
    public class FirstTaskClock
    {
        public void StartProgram()
        {
            Console.WriteLine("Hello! please write hours from 0 till 12");
            string? input = Console.ReadLine();
            int h;
            bool success = int.TryParse(input, out h);

            if (success)
            {
                while (true)
                {
                    if (h < 0 || h > 12)
                    {
                        Console.WriteLine("please write hours from 0 till 12!");
                        StartProgram();
                    }
                    else
                    {
                        Console.WriteLine("please write minutes from 0 till 60");
                        int m;
                        string? inputMinutes = Console.ReadLine();
                        bool successMinutes = int.TryParse(inputMinutes, out m);

                        if (successMinutes)
                        {
                            if (h == 12)
                                h = 0;

                            if (m == 60)
                            {
                                m = 0;
                                h += 1;
                            }

                            if (m < 0 || m > 60)
                            {
                                Console.WriteLine("please write minutes from 0 till 60!");
                                break;
                            }

                            double hourAngle = (0.5 * (h * 60 + m));
                            double minuteAngle = (6 * m);

                            double angle = Math.Abs(hourAngle - minuteAngle);
                            double result = Math.Min(360 - angle, angle);
                            Console.WriteLine($"The angle between arrows is {result} degrees");
                        }
                        else
                        {
                            Console.WriteLine("bad input, need only numbers");
                            break;
                        }
                    }
                    break;
                }
            }
            else
            {
                Console.WriteLine("bad input, need only integers");
            }
        }
    }
}

