using System.Linq.Expressions;

int stop = 1;




Console.WriteLine("Добрый день! Вам чем-то помочь?");

while (stop != 0)
{
    Console.WriteLine("1. Пусть компьютер загадет мне число");
    Console.WriteLine("2. Напомните мне таблицу умножения");
    Console.WriteLine("3. Покжите мне все делители числа");
    Console.WriteLine("4. Млодец 5, возвращайся на место, мне нужно проверить следущего студента");

    Console.Write("Выбирите действие: ");
    int deystvie = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    switch (deystvie)
    {
        case 1:
            Random random = new Random();
            int chislo = random.Next(0, 100);

            Console.WriteLine("Как думаете кае число от 0 до 100 загадал компьютер?: ");


            int chislo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (chislo2 < 0 | chislo2 > 100)
            {
                Console.WriteLine("Число должно быть от 0 до 100 >:(");
                Console.WriteLine(" ");
            }


            else if (chislo != chislo2)
            {
                Console.WriteLine($"Вы не угадали! Число загаданное компьютером: {chislo}");
                Console.WriteLine(" ");
            }

            else
            {
                Console.WriteLine("Поздравляю, вы угадали!");
                Console.WriteLine(" ");
            }


            break;

        case 2:
            Console.WriteLine("\t1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.WriteLine("");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i);
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + i * j);
                }

                Console.WriteLine("");
                Console.WriteLine("");
            }
            

            break;

        case 3:
            
            Console.WriteLine("Делители какого числа вы хотите узнать?: ");
            int chislo3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i=chislo3; i != 0; i--)
            {
                
                if (chislo3 % i == 0)
                {
                    
                    Console.WriteLine(i);
                }
                
                
            }
            Console.WriteLine(" ");
            break;
            break;
        case 4: 
            Console.WriteLine("Спасибо!");
            stop = 0;
            break;

        default:
            Console.WriteLine("Такой команды нет! >:(");
            break;
    }
}



