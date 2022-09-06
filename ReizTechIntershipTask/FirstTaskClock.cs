namespace ReizTechIntershipTask
{
    public class FirstTaskClock
    {
        public void StartProgram()
        {
            Console.WriteLine("Sveiki! irasykite valandas nuo 1 iki 12");
            double h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Irasykite minutes nuo  1 iki 60");
            double m = Convert.ToInt32(Console.ReadLine());

            if (h < 0 || m < 0 ||
            h > 12 || m > 60)
                Console.Write("Irasykite valandas nuo 1 iki 12!");

            if (h == 12)
                h = 0;

            if (m == 60)
            {
                m = 0;
                h += 1;
                if (h > 12)
                    h = -12;
            }

            double hourAngle = (0.5 * (h * 60 + m));
            double minuteAngle = (6 * m);

            double angle = Math.Abs(hourAngle - minuteAngle);
            double result = Math.Min(360 - angle, angle);
            Console.WriteLine($"Kampas tarp rodykliu yra {result} laipsniu");
        }
    }
}

