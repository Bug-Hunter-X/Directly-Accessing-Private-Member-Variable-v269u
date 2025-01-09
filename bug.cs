public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void MyMethod()
    {
        // Accessing the private field directly is generally discouraged
        // unless you have a specific reason to do so.
        _value = 10;
    }
}