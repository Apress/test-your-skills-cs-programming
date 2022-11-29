Console.WriteLine("---4.P6---");

Sample sample = new();
//Console.WriteLine($"sample.flag={sample._flag}");// ERROR CS0122
class Sample
{
    int _flag; 
    internal Sample(int i = 0)
    {
        this._flag = i;      
    }

}
