Console.WriteLine("---12.P13---");


Action del = () =>
{
    int _flag = 10;
    while (_flag < 15)
    {
        Console.WriteLine(_flag);
        _flag++;
       //goto xx; //ERROR CS0159
        
    }
  
};

del();
goto xx;
xx: Console.WriteLine("Level xx");