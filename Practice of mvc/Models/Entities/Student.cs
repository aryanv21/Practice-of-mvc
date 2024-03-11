namespace Practice_of_mvc.Models.Entities
{
    //prop
    public class Student
    {
        //prop for creating shortschut of this
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public bool Subscribed { get; set; }
    }
}
