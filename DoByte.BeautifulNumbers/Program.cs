using DoByte.BeautifulNumbers;

var helper = new BeautifulNumbersHelper();

helper.MakeSumsDistribution();
helper.CalculateBeautifulNumbers();

foreach (var sum in helper.SumsCounters)
{
    Console.WriteLine($"sum: {sum.Key}, count: {sum.Value}");
}

Console.WriteLine($"Beautiful numbers count: {helper.BeautifulNumbersCount}");
