
Console.WriteLine("Enter number of nails from 1 to 10");
var numberOfNails = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of strokes for 1 nail from 1 to 10");
var numberOfHits = Convert.ToInt32(Console.ReadLine());
var totalNumberOfHits = numberOfNails * numberOfHits;
if (numberOfNails <= 0 | numberOfNails > 10 | numberOfHits <= 0 | numberOfHits > 10)
{
    Console.WriteLine("Number of nails or hits must be more then 0 and less then 11");
    Console.ReadKey();
}
else
{
    for (var i = 1; i < numberOfNails; i++)
    {
        var hits = i * numberOfHits;
        if (hits != totalNumberOfHits)
        {
            Console.WriteLine($"{i} out of {numberOfNails} nails are hammered.Need more hits.... Press any key to continued");
            Console.ReadKey();
        }
        
    }

    
    Console.WriteLine($"Work is done! With {totalNumberOfHits} hits");
    Console.ReadKey();
}
