using System;
using LuckySpin.Repositories;
namespace LuckySpin.Services
{
    public class SpinService : ISpinService //Makes this class extend the Interface ISpinService
    {
        private ISpinRepository spinRepository;
        //Constructor with Dependency Injection
        public SpinService(ISpinRepository sr)
        {
            spinRepository = sr;

        }

        public double averageWins()
        {
            return 3.0;
        }

        public void spin(int A, int B, int C, int Lucky)
        {
            
        }

        public int getLength() { return 1; }

    }
}
