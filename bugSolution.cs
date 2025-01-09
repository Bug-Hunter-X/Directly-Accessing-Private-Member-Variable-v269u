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
        // Access the private field indirectly via the public property.
        Value = 10; 
    }
}