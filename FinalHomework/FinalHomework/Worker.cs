using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalHomework
{
    public enum SecurityLevel { Confidental, Secret, TopSecret }
    
    internal class Agent
    {

        public SecurityLevel SecurityClearance { get; private set; }
        private Elevator elevator;

        public Agent(SecurityLevel clearance, Elevator elevator)
        {
            SecurityClearance = clearance;
            this.elevator = elevator;
        }

        public void MoveAround()
        {
            while (true)
            {            
                Random random = new Random();
                int floor = random.Next(0, 4);
                elevator.CallElevator(floor);
                elevator.MoveToFloor(floor);
                Thread.Sleep(random.Next(1000, 5000));
                elevator.OpenDoor(SecurityClearance);               
            }
        }
    }

}

