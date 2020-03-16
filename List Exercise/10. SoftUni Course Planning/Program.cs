using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> course = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();


            while (command != "course start")
            {
                string[] commandArr = command.Split(":");
                string mainCommand = commandArr[0];
                string lessonTitle = commandArr[1];


                if (mainCommand == "Add")
                {
                    if (!course.Contains(lessonTitle))
                    {
                        course.Add(lessonTitle);
                    }
                }
                else if (mainCommand == "Insert")
                {
                    int indexOfLesson = int.Parse(commandArr[2]);

                    if (!course.Contains(lessonTitle))
                    {
                        course.Insert(indexOfLesson, lessonTitle);
                    }
                }
                else if (mainCommand == "Remove")
                {
                    if (course.Contains(lessonTitle))
                    {
                        course.Remove(lessonTitle);

                        if (course.Contains(lessonTitle + "-Exercise"))
                        {
                            course.Remove(lessonTitle + "-Exercise");
                        }
                    }
                }
                else if (mainCommand == "Swap")
                {
                    string swapLesson = commandArr[2];

                    if (course.Contains(lessonTitle) && course.Contains(swapLesson))
                    {
                        int temp = course.IndexOf(lessonTitle);
                        string value = course[temp];
                        int temp2 = course.IndexOf(swapLesson);
                        course[temp] = course[temp2];
                        course[temp2] = value;
                        if (course.Contains(lessonTitle + "-Exercise"))
                        {
                            int tempE = course.IndexOf(lessonTitle + "-Exercise");
                            string valueE = course[tempE];
                            course.RemoveAt(tempE);
                            if (course.IndexOf(lessonTitle) == course.Count-1)
                            {
                                course.Add(valueE);
                            }
                            else
                            {
                                course.Insert(temp + 1, valueE);
                            }
                        }
                        if (course.Contains(swapLesson + "-Exercise"))
                        {
                            int tempL = course.IndexOf(swapLesson);
                            int tempE2 = course.IndexOf(swapLesson + "-Exercise");
                            string valueE2 = course[tempE2];
                            
                            course.RemoveAt(tempE2);
                            if (course.IndexOf(swapLesson) == course.Count-1)
                            {
                                course.Add(valueE2);
                            }
                            else
                            {
                                course.Insert(tempL + 1, valueE2);
                            }
                            
                        }
                    }
                }
                else if (mainCommand == "Exercise")
                {
                    if (!course.Contains(lessonTitle))
                    {
                        course.Add(lessonTitle);
                        course.Add(lessonTitle + "-Exercise");
                    }
                }


                command = Console.ReadLine();
            }

            for (int i = 0; i < course.Count; i++)
            {
                Console.WriteLine($"{i+1}.{course[i]}");
            }
        }
    }
}
