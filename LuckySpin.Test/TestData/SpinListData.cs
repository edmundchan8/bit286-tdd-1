using System;
using System.Collections.Generic;
using LuckySpin.Models;
namespace LuckySpin.Test.TestData
{
    public class SpinListData
    {
        public static IEnumerable<Spin> GetSpins()
        {
             List<Spin> spins = new List<Spin>
            {
                new Spin{ Luck = 8, IsWinning=true },
                new Spin{ Luck = 8, IsWinning=true },
                new Spin{ Luck = 8, IsWinning=false },
                new Spin{ Luck = 8, IsWinning=false },
                new Spin{ Luck = 8, IsWinning=true },
                new Spin{ Luck = 8, IsWinning=false },
                new Spin{ Luck = 8, IsWinning=false },
                new Spin{ Luck = 8, IsWinning=false },
                new Spin{ Luck = 8, IsWinning=true },
                new Spin{ Luck = 8, IsWinning=false }
            };

            return spins;
        }
        
    }
}
