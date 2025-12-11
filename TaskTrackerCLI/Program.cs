using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Collections;
using System.Text.Json;



public class taskData
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // var task1 = new taskData();
        // {
        //     Id = id,
        //     Description = description,
        //     Status = status,
        //     CreatedAt = DateTime.Now,
        //     UpdatedAt = DateTime.Now
        // };
        //
        // // Serialize with formatting
        // var options = new JsonSerializerOptions { WriteIndented = true };
        // string json = JsonSerializer.Serialize(task1, options);
        //
        // // Save to file
        // File.WriteAllText("task.json", json);
        // Console.WriteLine("Task saved to task.json");
        //
        //
        // See https://aka.ms/new-console-template for more information
        var tasksList = new List<string>
        {
            {"Buy groceries"},
            {"Sell groceries"},
            {"Gym"},
            {"Homework"},
            {"Writing an essay"}
            
        };
        var tasksDone = new List<string> { };
        var tasksInProgress = new List<string> { };
        
        
       
        while (true){
            
            Console.WriteLine("\n1-Add Task");
            Console.WriteLine("2-Update Task");
            Console.WriteLine("3-Remove Task");
            Console.WriteLine("4-Mark in progress");
            Console.WriteLine("5-Mark in done");
            Console.WriteLine("6-List Tasks");
            Console.WriteLine("7-List Tasks Are Done");
            Console.WriteLine("8-List Tasks Are Not Done");
            Console.WriteLine("9-List Tasks  Are In Progress");
            Console.Write("Enter 0 to Exit the menu\n");
            
            int number;
            try
            {
                number =int.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("You must enter a number!");
                continue;  
            }
            
            switch (number)
            {
                case 1:
                    Console.WriteLine("\nAdd a task");
                    string addNew = Console.ReadLine();
                    tasksList.Add(addNew);
                    break;
                case 2:
                    Console.WriteLine("Select a task to update");
                    var indexUpdate= int.Parse(Console.ReadLine());
                    tasksList[indexUpdate] = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Select a task to delete");
                    var indexDelete = int.Parse(Console.ReadLine());  
                    tasksList.RemoveAt(indexDelete);
                    break;
                case 4:
                    Console.WriteLine("Select a task to mark inprogress");
                    var indexInProgress = int.Parse(Console.ReadLine());
                    tasksInProgress.Add(tasksList[indexInProgress]);
                    tasksList.Remove(tasksList[indexInProgress]);
                    break;
                case 5:
                    Console.Write("Tasks are in the list: ");
                    foreach (var task in tasksList)
                    {
                        Console.Write(task+", ");
                    } 
                    Console.Write("\nTasks are In Progress: ");
                    foreach (var tasks in tasksInProgress)
                    {
                        Console.Write(tasks+", ");
                    }
                    
                    Console.WriteLine("\nSelect a task to mark Done press:\n 1 to slct frm list \n 2 to slct frm in progress");
                  
                    int slcton = int.Parse(Console.ReadLine());
                    var indexDone = int.Parse(Console.ReadLine());
                    
                    if (slcton == 1)
                    {
                        tasksDone.Add(tasksList[indexDone]); 
                        tasksList.Remove(tasksList[indexDone]);  
                    }
                    else if (slcton == 2)
                    {
                        tasksDone.Add(tasksInProgress[indexDone]);
                        tasksInProgress.Remove(tasksInProgress[indexDone]);
                    }
                    else
                    {
                        Console.WriteLine("You must enter 1 or 2 ");
                    }
                    break;
                
                case 6:
                    Console.Write("Tasks list: ");
                    foreach (var task in tasksList)
                    {
                        Console.Write(task+", ");
                    } 
                    break;
                case 7:
                    Console.Write("Tasks are done: ");
                    foreach (var tasks in tasksDone)
                    {
                        Console.Write(tasks+", ");
                    } 
                    break;
                case 8:
                    Console.WriteLine("Tasks are not done:");
                    foreach (var tasks in tasksList)
                    {
                        Console.WriteLine(tasks);
                    }
                    break;
                case 9:
                    Console.WriteLine("Tasks are In Progress");
                    foreach (var tasks in tasksInProgress)
                    {
                        Console.WriteLine(tasks);
                    }
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            if (number == 10)
                break;  
        }


        }
        
        }
    
