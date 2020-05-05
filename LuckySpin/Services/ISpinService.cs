using System;
using LuckySpin.Models;
namespace LuckySpin.Services
{
    public interface ISpinService
    {
        public Double CalculateAverage();
        public Spin SpinIt(int Lucky);
    }
}
