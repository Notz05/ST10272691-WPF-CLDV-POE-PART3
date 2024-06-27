using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplicationWPF
{
    internal class RecipeStep
    {
        public string Description { get; set; }

        public RecipeStep(string description)
        {
            Description = description;
        }
    }
}
