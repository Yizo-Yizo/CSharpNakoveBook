using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndUsingObjects
{
    public class Sequence
    {
        // Static field, holding the current sequence value
        private static int currentValue = 0; 

        // Intentionally deny intatntiation of this class
        private Sequence()
        {

        }

        // Static method for taking the nect sequence value
        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
