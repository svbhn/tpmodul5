using System;

namespace tpmodul5_103022300081
{
    class HaloGeneric
    {
        public static void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }
}