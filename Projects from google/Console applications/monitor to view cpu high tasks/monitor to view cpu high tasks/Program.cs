using System;

using System.Collections.Generic;

using System.Text;

using Coder24.ProcessManager;

using System.Diagnostics;

using System.Threading;



namespace Coder24

{

    class Program

    {

        static void Main(string[] args)

        {

            ProcessMonitor proc = new ProcessMonitor("firefox");

            if (proc.IsProcessRunning() != true)

            {

                Console.Write("{0} is not running.", proc.Name);

            }

            else

            {

                proc.Monitor();

            }



            proc.FreezeOnScreen();

        }

    }

}



//Class.

namespace Coder24

{

    namespace ProcessManager

    {

        /// <summary>

        ///

        /// </summary>

        class ProcessMonitor

        {

            //Private declarations.

            private string processname;

            private PerformanceCounter pcProcess;



            /// <summary>

            /// Constructor.

            /// </summary>

            public ProcessMonitor()

            {



            }



            /// <summary>

            /// Constructor, with overloads.

            /// </summary>

            /// <param name="program"></param>

            public ProcessMonitor(string program)

            {

                processname = program;

                Name = processname;

            }



            /// <summary>

            ///

            /// </summary>

            public string Name

            {

                get;

                set;

            }



            /// <summary>

            /// Determines if the process is running or NOT.

            /// </summary>

            public bool IsProcessRunning()

            {

                Process[] proc = Process.GetProcessesByName(processname);

                return !(proc.Length == 0 && proc == null);

            }



            /// <summary>

            /// Monitors the running program.

            /// </summary>

            public void Monitor()

            {

                Console.WriteLine("Monitoring {0} for high CPU usage...", processname);

                int intInterval = 10000; // 10 seconds



                while (IsProcessRunning() == true)

                {

                    Process[] runningNow = Process.GetProcesses();



                    foreach (Process process in runningNow)

                    {

                        pcProcess = new PerformanceCounter("Process", "% Processor Time",

                            process.ProcessName);



                        if (process.ProcessName == processname)

                        {

                            pcProcess.NextValue();

                            System.Threading.Thread.Sleep(1000);

                            Console.WriteLine("Process:{0} CPU% {1}", process.ProcessName,

                                pcProcess.NextValue());



                            if (IsUsingToMuchResources())

                            {

                                Console.WriteLine(string.Format("Killing {0} at {1}",

                                processname, DateTime.Now.ToString()));

                                KillProcess(processname); //Kills the running process.

                            }

                            else

                            { /* Continue */ }

                        }

                        else { /* Provide a messagebox. */ }

                    }

                    // Sleep till the next loop

                    Thread.Sleep(intInterval);

                }

            }



            /// <summary>

            /// Checks if the process is using to much resources.

            /// </summary>

            /// <returns></returns>

            private bool IsUsingToMuchResources()

            {

                return pcProcess.NextValue() > float.Parse("10") ? true : false;

            }



            /// <summary>

            /// Kills the running process, selects the process from the constructor

            /// parameter.

            /// </summary>

            public void KillProcess()

            {

                string TaskKiller = "taskkill /f /im " + processname;

                try

                {

                    ProcessStartInfo info = new ProcessStartInfo("cmd.exe", "/c " + TaskKiller);

                    info.RedirectStandardError = true;

                    info.RedirectStandardInput = true;

                    info.RedirectStandardOutput = true;

                    info.UseShellExecute = false;

                    info.CreateNoWindow = true;

                    Process process = new Process();

                    process.StartInfo = info;

                    process.Start();

                    process.StandardOutput.ReadToEnd();

                }

                catch (Exception exception)

                {

                    Console.Write(exception.Message);

                }

            }



            /// <summary>

            /// Kills the running process, selects the process from the function input

            /// parameter.

            /// </summary>

            /// <param name="program">The running process name.</param>

            public void KillProcess(string program)

            {

                string TaskKiller = "taskkill /f /im " + program;

                try

                {

                    ProcessStartInfo info = new ProcessStartInfo("cmd.exe", "/c " + TaskKiller);

                    info.RedirectStandardError = true;

                    info.RedirectStandardInput = true;

                    info.RedirectStandardOutput = true;

                    info.UseShellExecute = false;

                    info.CreateNoWindow = true;

                    Process process = new Process();

                    process.StartInfo = info;

                    process.Start();

                    process.StandardOutput.ReadToEnd();

                }

                catch (Exception exception)

                {

                    Console.Write(exception.Message);

                }

            }



            /// <summary>

            ///

            /// </summary>

            public void FreezeOnScreen()

            { Console.Read(); }

        }

    }

}
