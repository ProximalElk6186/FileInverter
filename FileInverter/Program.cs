internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("FILE INVERTER PRO MAX ULTRA\nInverts your files flawlessly (or not idfk)\nWorks justifiably fine 1000% gurantee (but actually no gurantees) no borax no glue");
        if (args.Length == 0) 
        { 
            PrintUsage();
            return;
        }

        // Perform the actual focking ass shit crap
        byte[] input = File.ReadAllBytes(args[0]);
        byte[] output = new byte[input.Length];

        for (int i = 0; i < input.Length; i++)
        { 
            output[i] = (byte)(0xFF - (int)input[i]);
        }

        File.WriteAllBytes("inverted" + args[0], output);
    }

    static void PrintUsage() 
    {
        Console.WriteLine("=== USAGE: ===\nFileInverter.exe [input file]\nOutputs to \"inverted-<origfilename>\"");
    }
}