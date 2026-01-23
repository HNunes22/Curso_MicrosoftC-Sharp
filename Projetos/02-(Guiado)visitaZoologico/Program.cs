using System.Collections.Concurrent;

namespace VisitZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pettingZoo = 
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            
            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);


            // Methods


            void PlanSchoolVisit(string schoolName, int groups = 6)
            {
                RandomizeAnimals();
                string[,] group = AssignGroup(groups);
                System.Console.WriteLine(schoolName);
                PrintGroup(group);
                System.Console.WriteLine();
            }


            void RandomizeAnimals()
            {
                Random random = new Random();

                for(int i = 0; i < pettingZoo.Length; i++)
                {
                    int r = random.Next(i ,pettingZoo.Length);

                    string temp = pettingZoo[i];
                    pettingZoo[i] = pettingZoo[r];
                    pettingZoo[r] = temp;
                }
            }


            string[,] AssignGroup(int groups = 6)
            {
                string[,] result = new string[groups, pettingZoo.Length / groups];
                int start = 0;

                for(int i = 0; i < groups; i++) // Linha
                {
                    for(int j = 0; j < result.GetLength(1); j++) // Coluna
                    {
                        result[i, j] = pettingZoo[start++];
                    }
                }
                return result;
            }


            void PrintGroup(string[,] group)
            {
                for(int i = 0; i < group.GetLength(0); i++) // Linhas
                {
                    System.Console.Write($"Group {i + 1}: ");
                    for(int j = 0; j < group.GetLength(1); j++) // Colunas
                    {
                        System.Console.Write($"{group[i,j]}  ");
                    }
                    System.Console.WriteLine();
                }
            }
        }
    }
}