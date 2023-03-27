using PatternsImplementation;

Console.WriteLine(@"Please chose the sorting method: alphabetical - press 1
reverse alphabetical - press 2
by string length asc - press 3
by string length desc - press 4");
var number = Console.ReadLine();
List<string> strings = new();
Console.WriteLine("Enter 5 words:");
for (int i = 0; i < 5; i++)
{
    strings.Add(Console.ReadLine());
}
List<string> result;
switch (number)
{
    case "1":
        {
            var sorter = new SorterDecorator(new AlphabeticalOrderSorter());
            result = sorter.Sort(strings);
            break;
        }
    case "2":
        {
            var sorter = new SorterDecorator(new AlphabeticalOrderSorter());
            result = sorter.ReverseSort(strings);
            break;
        }
    case "3":
        {
            var sorter = new SorterDecorator(new StringLengthSorter());
            result = sorter.Sort(strings);
            break;
        }
    case "4":
        {
            var sorter = new SorterDecorator(new StringLengthSorter());
            result = sorter.ReverseSort(strings);
            break;
        }
    default:
        result = new List<string>();
        break;
}
Console.WriteLine(string.Join(", ", result));
Console.ReadLine();



