using Hardware.Info;


while (true)
{
    Console.WriteLine("Chceš pokračovat? Ano/Ne");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    string moznost = Console.ReadLine();
    if (moznost == "binchiling")
    {

        System.Environment.Exit(1);
    }
    Console.Clear();


    HardwareInfo infoPocitace = new HardwareInfo();
    infoPocitace.RefreshAll();
    Console.WriteLine("Vyber si část kompu");
    Console.WriteLine(" CPU /MotherBoard /RAM /GPU /Storage");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine($"Úplně zbytečná věc ale tvůj operační systém je: " + infoPocitace.OperatingSystem);
    string odpoved = Console.ReadLine();
    Console.Clear();

    if (odpoved == "MotherBoard")
    {
        foreach (var motherboard in infoPocitace.MotherboardList)
        {
            Console.WriteLine(motherboard);
        }
    }
    if (odpoved == "CPU")
    {
        foreach (var cpu in infoPocitace.CpuList)
        {
            Console.WriteLine(cpu);
        }
    }

    if (odpoved == "RAM")
    {
        foreach (var RAM in infoPocitace.MemoryList)
        {
            Console.WriteLine(RAM);
        }
    }

    if (odpoved == "GPU")
    {
        foreach (var GPU in infoPocitace.VideoControllerList)
        {
            Console.WriteLine(GPU);
        }
    }

    if (odpoved == "Storage")
    {
        foreach (var drive in infoPocitace.DriveList)
        {
            Console.WriteLine(drive);
        }
    }
    Console.ReadLine();
    Console.Clear();
}