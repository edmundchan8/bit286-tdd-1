using System;
using System.Collections.Generic;
using LuckySpin.Models;

namespace LuckySpin.Repositories
{
    public class SpinRepository : ISpinRepository
    {
        private List<Spin> spins = new List<Spin>();

        //Properties
        public Player CurrentPlayer { get; set; }

        //Methods
        public void AddSpin(Spin s) { spins.Add(s); }
        public IEnumerable<Spin> GetSpins() { return spins; }
        public int GetCount() { return spins.ToArray().Length; }  
    }
}
