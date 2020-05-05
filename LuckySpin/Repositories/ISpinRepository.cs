using System;
using System.Collections.Generic;
using LuckySpin.Models;

namespace LuckySpin.Repositories
{
    public interface ISpinRepository
    {
        public void SetPlayer(Player p);
        public Player GetPlayer();

        public void AddSpin(Spin s);
        public IEnumerable<Spin> GetSpins();
        public int GetCount();
    }
}
