using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    public class Door
    {
        public enum DoorState { open = 1, close, lockk, unlock }

        public int doorCode { get; set; }
        public string textDoorState { get; set; }

        public Door()
        {

        }

        public Door(int doorCode)
        {
            doorCode = doorCode;
            textDoorState = textDoorState;
        }
       
    }
}
