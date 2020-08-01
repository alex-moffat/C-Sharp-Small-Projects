using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Demo
{
    class Poem
    {
        //===== CONSTRUCTOR
        public Poem() : this("UNTITLED", "Anonymous", new List<string>())
        {            
        }
        public Poem(List<string> body) : this("UNTITLED", "Anonymous", body)
        {            
        }
        public Poem(string title, List<string> body) : this(title.ToUpper(), "Anonymous", body)
        {            
        }
        public Poem(string title, string author, List<string> body)
        {
            Title = title.ToUpper();
            Author = author;
            Body = body;
        }
        
        //===== PROPERTIES
        public string Author { get; set; }
        public string Title { get; set; }
        public List<string> Body { get; set; }

        //===== DISPLAY POEM
        public void DisplayPoem()
        {
            Console.WriteLine("\n{0}\n------------------------", Title);
            foreach (string line in Body)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("\t-{0}", Author);
        }
    
    }
}
