using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Lesson6
{
    public static class ProcManager
    {
        public static void ProcList()
        {
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine((i + 1) + "\t" + processes[i].Id + "\t" + processes[i].ProcessName);
            }

        }

        public static void ProcKillById(int id)
        {
            //Console.Write("Enter PID to kill: ");
            try
            {
                //string PID = Console.ReadLine();
                //int pid = Convert.ToInt32(PID);
                Process process = Process.GetProcessById(id);
                process.Kill();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void ProcKillByName(string name)
        {
            // Console.Write("Enter Processes Name to kill: ");
            try
            {
                // name = Console.ReadLine();                
                Process[] processes = Process.GetProcessesByName(name);
                for (int i = 0; i < processes.Length; i++)
                {
                    processes[i].Kill();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
