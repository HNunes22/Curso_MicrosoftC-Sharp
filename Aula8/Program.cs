using System.Data;

namespace Aula8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Important Variables

            int examAssigments = 5;
            int[] studentScores = new int[10];

            string[] studentsNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];


            int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
            int[] andrewScores = [92, 89, 81, 96, 90, 89];
            int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
            int[] loganScores = [90, 95, 87, 88, 96, 96];
            int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
            int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
            int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
            int[] gregorScores =  [91, 91, 91, 91, 91, 91, 91];  


            // ----------------- ForEach() for Students ------------------- //

            Console.WriteLine("Student\t\tExame Score\tOverall\t\tGrade\t\tExtra Credit\n");
            foreach (string name in studentsNames)
            {
                string currenntStudent = name;
                string currentGrade = "";


            // Student scores for calculate

                if(currenntStudent == "Sophia")
                {
                    studentScores = sophiaScores;
                }
                else if(currenntStudent == "Andrew")
                {
                    studentScores = andrewScores;
                }
                else if(currenntStudent == "Emma")
                {
                    studentScores = emmaScores;
                }
                else if(currenntStudent == "Logan")
                {
                    studentScores = loganScores;
                }
                else if(currenntStudent == "Becky")
                {
                    studentScores = beckyScores;
                }
                else if(currenntStudent == "Chris")
                {
                    studentScores = chrisScores;
                }
                else if(currenntStudent == "Eric")
                {
                    studentScores = ericScores;
                }
                else if(currenntStudent == "Gregor")
                {
                    studentScores = gregorScores;
                }

                // -------------------------- //

                decimal sumAssigmentScore = 0; // Responsavel pelo calculo todo (Notas + Creditos)

                decimal exameScore = 0; // Responsavel pelo Exame Score, os que não usam credits

                decimal extraCredits = 0; // Responsavel pelos créditos extras

                decimal currentStudentGrade = 0; // Responsavel pelo Overral

                int gradedAssignments = 0; // Responslvel por ter o controle de quem é not e quem é crédito

                foreach(int score in studentScores)
                {
                    gradedAssignments++;
                    if(gradedAssignments <= examAssigments)
                    {
                        sumAssigmentScore += score;
                        exameScore += score;
                        
                    }
                    else
                    {
                        sumAssigmentScore += (decimal) score / 10;
                    }
                }

                currentStudentGrade =  sumAssigmentScore / examAssigments;
                exameScore /= examAssigments;
                extraCredits = currentStudentGrade - exameScore;


                if(currentStudentGrade >= 97)
                {
                    currentGrade = "A+";
                }

                else if(currentStudentGrade >= 93)
                {
                    currentGrade = "A";
                }
                else if(currentStudentGrade >= 90)
                {
                    currentGrade = "A-";
                }
                else if(currentStudentGrade >= 87)
                {
                    currentGrade = "B+";
                }
                else if(currentStudentGrade >= 83)
                {
                    currentGrade = "B";
                }
                else if(currentStudentGrade >= 80)
                {
                    currentGrade = "B-";
                }
                else if(currentStudentGrade >= 77)
                {
                    currentGrade = "C+";
                }
                else if(currentStudentGrade >= 73)
                {
                    currentGrade = "C";
                }
                else if(currentStudentGrade >= 70)
                {
                    currentGrade = "C-";
                }
                else if(currentStudentGrade >= 67)
                {
                    currentGrade = "D+";
                }
                else if(currentStudentGrade >= 66)
                {
                    currentGrade = "D";
                }
                else if(currentStudentGrade >= 60)
                {
                    currentGrade = "D-";
                }
                else
                {
                    currentGrade = "F";
                }
                
                Console.WriteLine($"{currenntStudent}\t\t{exameScore}\t\t{currentStudentGrade}\t\t{currentGrade}\t\t{exameScore.ToString("F0")}({extraCredits} pts)");

            }
        }
    }
} 