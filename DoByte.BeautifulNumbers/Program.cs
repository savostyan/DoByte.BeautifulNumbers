using DoByte.BeautifulNumbers;

var helper = new BeautifulNumbersHelper();

helper.MakeSumsDistribution();
helper.CalculateBeautifulNumbers();

Console.WriteLine($"Beautiful numbers count: {helper.BeautifulNumbersCount}");
