public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it.
        MyProperty = 10; // Assign a value explicitly.
        Console.WriteLine(MyProperty); // Now it prints 10 reliably
    }
    public void MyMethod2(){
        //Use the constructor to initialize the property
    }
    public MyClass(int myProperty){
        MyProperty = myProperty;
    }
}