class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to IELTS Meter");
        
        // IeltsCalculator obyektini yaratish
        IeltsCalculator calculator = new IeltsCalculator();
        calculator.HisoblashniBoshlash();
        
        Console.ReadKey();
    }
}

class IeltsCalculator
{
        private string[] ieltsScore = { "reading", "speaking", "listening", "writing" };
    private double[] scores;
    
    // Constructor
    public IeltsCalculator()
    {
        scores = new double[ieltsScore.Length];
    }
    
    public void HisoblashniBoshlash()
    {
        try
        {
            double sum = 0;

        // Baholarni olish
        for (int i = 0; i < ieltsScore.Length; i++)
        {
            Console.Write($"{ieltsScore[i]} uchun baho kiriting (0 - 9): ");
            scores[i] = double.Parse(Console.ReadLine());
            if(i < 0) // foydalanuvchi manfiy son kiritiwi mumkin.
                {
                    throw new Exception("manfiy son kiritma qovun.");
                }
            sum += scores[i];
        }

        double averageScore = sum / ieltsScore.Length;

        // Natijalarni ko'rsatish
        NatijalarniKorsatish(averageScore);
        }
        catch(FormatException)
        {
            Console.WriteLine("Notugri format kiritildi.");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    
    private void NatijalarniKorsatish(double averageScore)
    {
        try
        {
        Console.WriteLine("IELTS bo'limlari bo'yicha baholar:");
        for (int i = 0; i < ieltsScore.Length; i++)
        {
            Console.WriteLine($"{ieltsScore[i]}: {scores[i]}");
        }
        Console.WriteLine($"\nO'rtacha IELTS bali: {averageScore:F2}");            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}