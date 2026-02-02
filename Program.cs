// Bu foydalanuvchi ielts bahosini kiritganda,
// uni inson tushunadigan tilda izohini chiqaradigan
// va ko'nikmalarning (speaking = 0, reading = 1, listening= 2, writing =3) 
// bahosidan umimiy bahoni hisoblaydigan bir mantiq tuzish kerak bo'ladi.

// Birinchi versiyada foydalanuvchidan 4 ta ko'nikmaning bahosini so'rab,
// uni bir o'zgaruvchida saqlab, 
// kirayotgan ma'lumotlar 0 va 9 orasida bo'lishini ta'minlash kerak. 
// Ushbu ko'nikmalarning o'rta arifmetigini ekranga chiqarish kerak.

//>IELTS Meter ga xush kelibsiz. 

// speaking: 7.0
// reading: 9.0
// listening: 5.5
// writing: 6.0

//> O'rta arifmetik: 6.875

// Console.WriteLine("Welcome to IELTS Meter");

// Console.WriteLine("inter the speaking score:");
// double speakScore = double.Parse(Console.ReadLine());

// Console.WriteLine("inter the reading score:");
// double readingScore = double.Parse(Console.ReadLine());

// Console.WriteLine("inter the writing score:");
// double writingScore = double.Parse(Console.ReadLine());

// Console.WriteLine("inter the listening score:");
// double listeningScore = double.Parse(Console.ReadLine());

    Console.WriteLine("Welcome to IELTS Meter");

 string[] ieltsScore = { "reading", "speaking", "listening", "writing" }; // xisoblanishi kerak bulgan massiv qator
        double[] scores = new double[ieltsScore.Length];                  // massiv reference type bulganligi sabab 
                                                                          // new - yani xotiradan yangi joy ochiladi
                                                                          // ieltsScore.Length- string massiv hajmi,ulchami 
        double sum = 0;

        for (int i = 0; i < ieltsScore.Length; i++)
        {
            Console.Write($"{ieltsScore[i]} uchun baho kiriting (0 - 9): ");// massivdagi quymat forda aylanib unga baho kiritilishi
            scores[i] = double.Parse(Console.ReadLine());                   // baholar qiymatta kiritilishi

            sum += scores[i];                                               // kiritilgan baholar yig‘indisi
        }

        double averageScore = sum / ieltsScore.Length;          // yigilgan bahoni urtachasi olinishi

        Console.WriteLine("IELTS bo‘limlari bo‘yicha baholar:");
        for (int i = 0; i < ieltsScore.Length; i++)             // massivdagi hajmlarni siklda aylanishi
        {
            Console.WriteLine($"{ieltsScore[i]}: {scores[i]}"); // massivdagi elementni urtacha bahosini ekranga chiqariliwi 
        }

        Console.WriteLine($"\nO‘rtacha IELTS bali: {averageScore}");

    Console.ReadKey();