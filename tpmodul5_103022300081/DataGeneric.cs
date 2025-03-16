using System;

namespace tpmodul5_103022300081
{
    class DataGeneric<T>
    {
        private T Data { get; set; }

        public DataGeneric(T data)
        {
            Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }
}