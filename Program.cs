using ConsoleApp11;
using File = ConsoleApp11.File;

File[] files = new File[] {

  new File("KK", ".txt",1024, new DateTime(2018, 7,30)),
  new File("Forhe", ".txt", 4578954, DateTime.Now),
  new File("Forhua", ".exe", 457895986, DateTime.Now),
  new File("Koker", ".txt", 10335, DateTime.Now),
};
foreach(File file in files)
{
    if(file.Type == ".txt")
    {
        Console.WriteLine(file.ToString());
    }
}
foreach(File file in files)
{
    if (file.Name.Contains("ua"))
    {
        Console.WriteLine(file.ToString());
    }
}
foreach(File file in files)
{
    if(file.CreateDate < new DateTime(2022, 9, 17))
    {
        Console.WriteLine(file.ToString());
    }
}