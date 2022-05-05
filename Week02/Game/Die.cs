using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Die
    {
        public int value = 0;
        public int points = 0;

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
        }

        /// <summary>
        /// Generates a new random value and calculates the points for the die.
        /// </summary>
        public void Roll()
        {
            Random random = new Random();
            value = random.Next(1, 7);
            
            if (value == 5)
            {
                points = 50;
            }
            else if (value == 1)
            {
                points = 100;
            }
            else
            {
                points = 0;
            }
        }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}