namespace SandcastleTest.Generic.POCO
{
    /// <summary>
    /// A base class with base properties for a person.
    /// </summary>
    public abstract class Person :  PocoBase
    {
        /// <summary>
        /// First name of a person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of a person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Overrides a <see cref="ToString"/> representation of an person
        /// </summary>
        /// <returns>a <see cref="ToString"/> representation of an person</returns>
        public override string ToString()
        {
            return $"Person: {FirstName} - {LastName}";
        }
    }
}
