using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Leader
    {
        public int Score { get; set; }
        public string Name { get; set; }

        public Leader(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public int getscore()
        {
            return Score;
        }
        public string getname()
        {
            return Name;
        }
        
    }
}
