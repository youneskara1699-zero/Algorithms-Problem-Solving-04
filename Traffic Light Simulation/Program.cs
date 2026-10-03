using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray trafficLights = new BitArray(9); 
                                                    
            trafficLights[2] = true;


            trafficLights[2] = false;
            trafficLights[1] = true;


            Console.WriteLine("Intersection 1 Lights:");
            Console.WriteLine($"Red: {trafficLights[0]}, Yellow: {trafficLights[1]}, Green: {trafficLights[2]}");



        }
    }
}
