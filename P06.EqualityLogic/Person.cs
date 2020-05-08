namespace IteratorsAndComparators
{
    using System;
    public class Person : IComparable<Person>
    {

        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int CompareTo(Person other)
        {
            int result = this.name.CompareTo(other.name);
            if (result == 0)
            {
                result = this.age.CompareTo(other.age);
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return this.name == ((Person)obj).name && this.age == ((Person)obj).age;
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode() + this.age.GetHashCode() + (257 * 53);
        }
    }
}
