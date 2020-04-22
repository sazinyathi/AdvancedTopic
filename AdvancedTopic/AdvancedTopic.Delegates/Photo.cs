using System;

namespace AdvancedTopic.Delegates
{
    public class Photo
    {
        public static Photo LoadPhoto(string path)
        {
            Console.WriteLine("Load Photo");
            return new Photo { };
        }
        public void Save()
        {
            Console.WriteLine("Save Photo");
        }
    }
}
