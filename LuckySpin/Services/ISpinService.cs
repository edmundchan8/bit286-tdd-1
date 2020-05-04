using System;
using LuckySpin.Models;
namespace LuckySpin.Services
{
    public interface ISpinService
    {
        public Double averageWins();
        public void spin(int A, int B, int C, int Lucky);
    }
}
