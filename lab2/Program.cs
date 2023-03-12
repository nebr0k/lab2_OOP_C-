using System;

class Program1
{
    static void Main1(string[] args)
    {

        int arraySize = 26;
        int rangeMin = -40;
        int rangeMax = 20;


        Random random = new Random();
        int[] array = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            array[i] = random.Next(rangeMin, rangeMax + 1);
        }


        Console.WriteLine("Array: [{0}]", string.Join(", ", array));


        int count = 0;
        int total = 0;
        for (int i = 0; i < arraySize; i++)
        {
            if (array[i] <= 0 || i % 2 == 0)
            {
                count++;
                total += array[i];
            }
        }


        for (int i = 0; i < arraySize; i++)
        {
            if (array[i] <= 0 || i % 2 == 0)
            {
                array[i] = 0;
            }
        }


        Console.WriteLine("Number of elements that meet the criterion: {0}", count);
        Console.WriteLine("Sum of elements that meet the criterion: {0}", total);
        Console.WriteLine("Modified array: [{0}]", string.Join(", ", array));
    }
}



//////////////////////////////////////////////////////////////////////////////////////////////////////////////


//class Program2
//{
//    static void Main(string[] args)
//    {
//        Random random = new Random();
//        int Low = 7;
//        int High = 65;
//        int rowCount = 5;
//        int colCount = 9;
//        int[][] a = new int[rowCount][];
//        for (int i = 0; i < rowCount; i++)
//        {
//            a[i] = new int[colCount];
//        }
//        Create(a, rowCount, colCount, Low, High, random);
//        Print(a, rowCount, colCount);
//        Sort(a, rowCount, colCount);
//        Print(a, rowCount, colCount);
//        int S = 0;
//        int k = 0;
//        Calc(a, rowCount, colCount, ref S, ref k);
//        Console.WriteLine("S = " + S);
//        Console.WriteLine("k = " + k);
//        for (int i = 0; i < rowCount; i++)
//        {
//            Array.Clear(a[i], 0, colCount);
//        }
//        Array.Clear(a, 0, rowCount);
//    }

//    static void Create(int[][] a, int rowCount, int colCount, int Low, int High, Random random)
//    {
//        for (int i = 0; i < rowCount; i++)
//        {
//            for (int j = 0; j < colCount; j++)
//            {
//                a[i][j] = Low + random.Next(High - Low + 1);
//            }
//        }
//    }

//    static void Print(int[][] a, int rowCount, int colCount)
//    {
//        Console.WriteLine();
//        for (int i = 0; i < rowCount; i++)
//        {
//            for (int j = 0; j < colCount; j++)
//            {
//                Console.Write("{0,4}", a[i][j]);
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }

//    static void Sort(int[][] a, int rowCount, int colCount)
//    {
//        for (int i0 = 0; i0 < rowCount - 1; i0++)
//        {
//            for (int i1 = 0; i1 < rowCount - i0 - 1; i1++)
//            {
//                if ((a[i1][0] < a[i1 + 1][0])
//                    || (a[i1][0] == a[i1 + 1][0] && a[i1][1] < a[i1 + 1][1])
//                    || (a[i1][0] == a[i1 + 1][0] && a[i1][1] == a[i1 + 1][1] && a[i1][3] > a[i1 + 1][3]))
//                {
//                    Change(a, i1, i1 + 1, colCount);
//                }
//            }
//        }
//    }

//    static void Change(int[][] a, int row1, int row2, int colCount)
//    {
//        int tmp;
//        for (int j = 0; j < colCount; j++)
//        {
//            tmp = a[row1][j];
//            a[row1][j] = a[row2][j];
//            a[row2][j] = tmp;
//        }
//    }

//    static void Calc(int[][] a, int rowCount, int colCount, ref int S, ref int k)
//    {
//        S = 0;
//        k = 0;
//        for (int i = 0; i < rowCount; i++)
//        {
//            for (int j = 0; j < colCount; j++)
//            {
//                if (!((a[i][j] % 2 != 0) && ((i + j) % 7 == 0) && (i + j != 0)))

//                {
//                    S += a[i][j];
//                    k++;
//                    a[i][j] = 0;
//                }
//            }
//        }
//    }
//}


/// <summary>
/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>

//struct Student
//{
//    public string LastName;
//    public int Course;
//    public string Speciality;
//    public int PhysicsMark;
//    public int MathMark;
//    public int ITMark;
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student[] students = new Student[3];

//        students[0].LastName = "Ivanov";
//        students[0].Course = 2;
//        students[0].Speciality = "Computer Science";
//        students[0].PhysicsMark = 4;
//        students[0].MathMark = 5;
//        students[0].ITMark = 5;

//        students[1].LastName = "Petrov";
//        students[1].Course = 1;
//        students[1].Speciality = "Mathematics";
//        students[1].PhysicsMark = 5;
//        students[1].MathMark = 5;
//        students[1].ITMark = 4;

//        students[2].LastName = "Sidorov";
//        students[2].Course = 3;
//        students[2].Speciality = "Physics";
//        students[2].PhysicsMark = 5;
//        students[2].MathMark = 5;
//        students[2].ITMark = 5;

//        PrintTable(students);
//        Console.WriteLine($"Number of students with only 'excellent' marks: {CountExcellentStudents(students)}");
//    }

//    static void PrintTable(Student[] students)
//    {
//        Console.WriteLine("| {0,-10} | {1,-5} | {2,-20} | {3,-5} | {4,-5} | {5,-5} |", "Last name", "Course", "Speciality", "Physics", "Math", "IT");
//        Console.WriteLine(new string('-', 66));

//        foreach (Student student in students)
//        {
//            Console.WriteLine("| {0,-10} | {1,-5} | {2,-20} | {3,-7} | {4,-4} | {5,-2} |", student.LastName, student.Course, student.Speciality, student.PhysicsMark, student.MathMark, student.ITMark);
//        }

//        Console.WriteLine(new string('-', 66));
//    }

//    static int CountExcellentStudents(Student[] students)
//    {
//        int count = 0;

//        foreach (Student student in students)
//        {
//            if (student.PhysicsMark == 5 && student.MathMark == 5 && student.ITMark == 5)
//            {
//                count++;
//            }
//        }

//        return count;
//    }
//}
