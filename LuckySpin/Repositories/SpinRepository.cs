using System;
using System.Collections.Generic;
using LuckySpin.Models;

namespace LuckySpin.Repositories
{
    public class SpinRepository : ISpinRepository
    {
        private List<Spin> spins = new List<Spin>();
        private Player currentPlayer;

        //Player methods
        public void SetPlayer(Player p) {
            currentPlayer = p;
            currentPlayer.AddCredit(p.StartingBalance);
        }
        public Player GetPlayer() { return currentPlayer;  }

        //Spin Methods
        public void AddSpin(Spin s) { spins.Add(s); }

        public IEnumerable<Spin> GetSpins() { return spins; }

        public int GetCount() { return spins.ToArray().Length; }  
    }
}
