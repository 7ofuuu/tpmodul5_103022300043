using tpmodul5_103022300043;

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("ilham");

        DataGeneric<string> dataNIM = new DataGeneric<string>("103022300043");
        dataNIM.PrintData();
    }
}