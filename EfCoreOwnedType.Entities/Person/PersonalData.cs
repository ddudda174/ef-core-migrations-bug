namespace EFCoreOwnedType.Entities.Person;

using System;
using EFCoreOwnedType.Entities;

public class PersonalData : BaseEntity
{
    public string Salutation { get; set; }
    public string NameAffix { get; set; }
    public string FirstName { get; set; }
    public string FamilyName { get; set; }
    public string BirthName { get; set; }
    public string BirthPlace { get; set; }
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }

    public DateTime? ResidentSince { get; set; }
    public string TaxNo { get; set; }
    public string FamilyStatus { get; set; }
    public string Nationality { get; set; }

    public int Age => 18; // some calculation on dates

    public PersonalData() { }

    public PersonalData(DbId id) : base(id) { }
}
