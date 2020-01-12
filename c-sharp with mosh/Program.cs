namespace c_sharp_with_mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mypPerson = new Person();
            mypPerson.firstName = "james";
            mypPerson.lastName = "rom";
            mypPerson.Introduce();

            Calculator calculator = new Calculator();
        }
    }
}
