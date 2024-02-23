namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades seperated by new line: ");
            int firstGrade = Convert.ToInt32(Console.ReadLine()); 
            int secondGrade = Convert.ToInt32(Console.ReadLine());
            int thirdGrade = Convert.ToInt32(Console.ReadLine());   
            int fourthGrade = Convert.ToInt32(Console.ReadLine());  
            int fifthGrade = Convert.ToInt32(Console.ReadLine());

            double Average = firstGrade + secondGrade + thirdGrade + fourthGrade + fifthGrade ;
            double GradeTotal = Average / 5;
            int RoundOffAverage = (int)Math.Round(GradeTotal);
            Console.WriteLine("The average is " + GradeTotal + " and round off to " + RoundOffAverage);
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();


        }
    }
}
