namespace Problem1
{
    public class PersonTest
    {
        public static void PersonToString()
        {
            Person aMan = new Person("Kiril Vasilev", 15);
            Person aWoman = new Person("Silvia Staneva");

            Person.PrintPeople(aMan, aWoman);
        }
    }
}
