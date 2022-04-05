namespace EFCoreOwnedType.Entities.Account
{
    using System;
    using Contact;
    using Person;

    public class User : BaseEntity
    {
        public string Mail { get; set; }
        public string Status { get; set; }
        public string AccountType { get; set; }
        public Address Address { get; set; }
        public PersonalData Data { get; set; }
        public DateTime LastActive { get; set; }
        public DateTime Created { get; set; }

        public User() { }

        public User(DbId id) : base(id) { }
    }
}
