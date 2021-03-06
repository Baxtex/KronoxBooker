﻿namespace Bot
{
    /// <summary>
    /// Represents a free room. Stores the time that the booking starts from and the name of the room.

    /// </summary>
    public class Room
    {
        public Room(string name, string timeInterval)
        {
            Name = name;
            Time = timeInterval;
        }

        public string Name { get; }
        public string Time { get; }
    }
}