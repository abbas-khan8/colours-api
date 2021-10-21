using System.Collections.Generic;

namespace TechTest.Repositories.Models  
{
    public class Person 
    {
        public int Id { get; set; }
        /*public string FullName {
            get {
                return this.FirstName + " " + this.LastName;
            }
            set {
                this.FullName = value;
            } 
        }*/

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool Authorised { get; set; }

        public bool Enabled { get; set; }

        public IEnumerable<Colour> Colours { get; set; }

        /*public List<string> ColourNames {
            get
            {
                List<string> colourNames = new List<string>();

                foreach(var colour in this.Colours)
                {
                    colourNames.Add(colour.Name);
                }
                return colourNames;
            }
            set
            {
                this.ColourNames = value;
            }
        }*/
    }
}
