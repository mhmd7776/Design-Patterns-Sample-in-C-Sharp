using Iterator.Models;

var history = new BrowserHistory();

history.Push("https://toplearn.com");
history.Push("https://www.digikala.com");
history.Push("https://mohammadmahdavi.com");
history.Push("https://barnamenevisan.info");
history.Push("https://edu.iau.ac.ir");

var iterator = history.CreateIterator();

while (iterator.HasNext())
{
    var currentItem = iterator.GetCurrent();
    Console.WriteLine($"{currentItem}");
    iterator.Next();
}