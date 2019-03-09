using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Washing_machine
{
    class Washer
    {
        private bool door;
        private bool running;
        private int program;
        private int state;

        #region  getset

        

        
        public bool Door
        {
            get
            {
                return door;
            }
            set
            {
                door = value;
            }
        }

        public bool Running
        {
            get
            {
                return running;
            }
            set
            {
                running = value;
            }
        }

        public int Program
        {
            get
            {
                return program;

            }
            set
            {
                program = value;

            }
        }

        public int State
        {
            get
            {
                return state;

            }
            set
            {
                state = value;

            }
        }
        #endregion

        public Washer()
        {
            
        }

        public bool Power()
        {
            if (running == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Mode(int program)
        {
            if (program == 1)
            {
                return "Mode 1";
                
            }
            else if (program == 2)
            {
                return "Mode 2";
            }
            else
            {
                return null;
            }
        }

        public void FillClothing(string cloths)
        {
            if (cloths == "yes")
            {
                
            }
            else
            {
                
            }
        }

        public void FillPowder(string powder)
        {
            if (powder == "yes")
            {
                
            }
            else
            {

            }
        }


        public void OpenDoor()
        {
            

        }

        public void Start()
        {

        }

        public void Stop()
        {

        }

        public void EmptyClothing()
        {

        }
    }
}
