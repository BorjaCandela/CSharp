using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;

namespace ArreglarRegistroBattlefield4
{

    public class Example
    {
        public static void Main()
        {


            // Hay que revisar la primera parte de cada codigo la de las entradas DLCs 

            string caseSwitch;
            string userRootHKLM = "HKEY_LOCAL_MACHINE";

            Console.Write("\n\t¿Que DLC de BF4 da el error?");
            Console.WriteLine("\n\n\tLas opciones son las siguientes:");
            Console.WriteLine("\n\tRECUERDA -> EXPANSION: OPCION");
            Console.WriteLine("\tDEBES INSERTAR LA OPCION");
            Console.WriteLine("\nChina Rising: CR");
            Console.WriteLine("\nSecond Assault: SA");
            Console.WriteLine("\nNaval Strike: NS");
            Console.WriteLine("\nDragon's Teeth: DS");
            Console.WriteLine("\nFinal Stand: FS");
            Console.WriteLine("\nTodos los DLCs: All");
            Console.Write("\n\n\t\t¿Opcion?:");
            caseSwitch = Console.ReadLine();

            //if (caseSwitch == "CR" || caseSwitch == "SA" || caseSwitch == "NS" || caseSwitch == "DT" || caseSwitch == "FS" || caseSwitch == "All")



            switch (caseSwitch)
            {
                case "CR":

                    Console.WriteLine("Se ha reparado el registro de China Rising.");

                    string subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack1";
                    string keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack1\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1004841"; // Comprobar
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ China Rising", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack1";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    break;

                ///////////////////////////////////////////////////// CASE SECOND ASSAULT ///////////////////////////////////////////////////


                case "SA":

                    Console.WriteLine("Se ha reparado el registro de Second Assault.");

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack0";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack0\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1004887";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Second Assault", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack0";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    break;

                ///////////////////////////////////////////////////// CASE Naval Strike ///////////////////////////////////////////////////


                case "NS":

                    Console.WriteLine("Se ha reparado el registro de Naval Strike.");

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack2";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack2\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1004842"; // Comprobar
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Naval Strike", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack2";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    break;

                ///////////////////////////////////////////////////// CASE DRAGONS TITS ///////////////////////////////////////////////////


                case "DT":

                    Console.WriteLine("Se ha reparado el registro de Dragon's Teeth.");

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack3";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack3\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1011893";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Dragon's Teeth", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack3";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto


                    break;

                ///////////////////////////////////////////////////// CASE FINAL STAND ///////////////////////////////////////////////////


                case "FS":
                    Console.WriteLine("Se ha reparado el registro de Final Stand.");

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack4";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack4\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1011899";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Final Stand", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack4";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto


                    break;


                ///////////////////////////////////////////////////// CASE TODOS ///////////////////////////////////////////////////


                case "All":

                    ///// CR //////

                    Console.WriteLine("Se han reparado los registros de todos los DLCs.");

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack1";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack1\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1004841";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ China Rising", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack1";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    ///// SA //////

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack0";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack0\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1004887";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Second Assault", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack0";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto


                    ///// NS //////

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack2";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack2\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1004842";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Naval Strike", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack2";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto


                    ///// DT //////

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack3";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack3\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1011893";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Dragon's Teeth", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack3";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto


                    ///// FS //////

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA GAMES\Battlefield 4\DLCs\Xpack4";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "UninstallerPath", "\"C:\\Program Files (x86)\\Common Files\\EAInstaller\\Battlefield 4\\Xpack4\\Cleanup.exe\"", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "UninstallerArgs", "uninstall_pdlc -autologging", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\Origin Games\1011899";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "DisplayName", "Battlefield 4™ Final Stand", RegistryValueKind.String);
                    Registry.SetValue(keyNameDLC, "Locale", "es_ES", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    subkeyDLC = @"SOFTWARE\Wow6432Node\EA Games\Battlefield 4\Xpack4";
                    keyNameDLC = userRootHKLM + "\\" + subkeyDLC;

                    Registry.SetValue(keyNameDLC, "Installed", "True", RegistryValueKind.String); // Mirar los distintos valores en la API y asegurarse de que es el correcto

                    break;

                default:
                    Console.WriteLine("\n\nNo se ha elegido ningun DLC, hay que utilizar los valores antes mencionados, el programa se cerrara\n");

                    break;

            }

            if (caseSwitch == "CR" || caseSwitch == "SA" || caseSwitch == "NS" || caseSwitch == "DT" || caseSwitch == "FS" || caseSwitch == "All")
            {

                Console.WriteLine("\n\n");
                Console.WriteLine("\r\nUsa Regedit para comprobar que se han creado las claves");
                Console.WriteLine("\r\nEl programa se cerrara");
                foreach (Process procesoBuscar in Process.GetProcesses())
                {
                    if (procesoBuscar.ProcessName == "ArreglarRegistroBattlefield4.vshost.exe" || procesoBuscar.ProcessName == "ArreglarRegistroBattlefield4.vshost")
                    {
                        procesoBuscar.Kill();
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();

            }
            else
            {


                Console.WriteLine("\r\nVuelve a iniciar el programa");
                foreach (Process procesoBuscar in Process.GetProcesses())
                {
                    if (procesoBuscar.ProcessName == "ArreglarRegistroBattlefield4.vshost.exe" || procesoBuscar.ProcessName == "ArreglarRegistroBattlefield4.vshost")
                    {
                        procesoBuscar.Kill();
                    }
                    Console.ReadKey();

                }



            }
        }
    }
}