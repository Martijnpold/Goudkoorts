using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goudkoorts.Model
{
    public interface IScoreHolder
    {
        int GetScore();

        void AddScore(int score);
    }
}
