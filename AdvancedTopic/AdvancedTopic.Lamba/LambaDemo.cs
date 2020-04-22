using AdvancedTopic.Model;
using System.Collections.Generic;

namespace AdvancedTopic.Lamba
{
    public class LambaDemo
    {
        public List<Books> GetBooks ()
        {
            return new List<Books>
            {
                new Books() {Title ="Tittle1",Price = 4},
                new Books() {Title ="Tittle2",Price = 12},
                new Books() {Title ="Tittle3",Price = 23},
                new Books() {Title ="Tittle4",Price = 56}
            };
        }
    }
}
