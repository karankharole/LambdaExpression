namespace LamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Person> personlist = new List<Person>();
            personlist.Add(new Person("123654", "raaj", "akola", 22));
            personlist.Add(new Person("123426", "sagar", "surat", 15));
            personlist.Add(new Person("156657", "chetan", "Pune", 62));
            personlist.Add(new Person("758659", "karan", "ranchi", 20));

            Console.WriteLine("recovering Top 2  person from the list less than 60 years");
            foreach (Person person in personlist.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
               
            }
            Console.WriteLine("\n Checking for teenager");
            foreach (Person person in personlist.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }

        }
    }
}