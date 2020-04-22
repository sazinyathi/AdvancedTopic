using System;

namespace AdvancedTopic.Delegates
{
   public  class UnlockDoorProcessor
    {

        public string UnclockDoor(Door door)
        {
            return door.KeyNumber;
        }

    }
}
