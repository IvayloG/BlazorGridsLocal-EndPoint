//namespace HolyGrailGridsLocalEndPoint.Data.NortwindSwagger; // Razor won't recognize third level namespace
namespace HolyGrailGridsLocalEndPoint.NortwindSwagger;

public class EmployeesType
{
    public double? EmployeeID { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Title { get; set; }
    public string? TitleOfCourtesy { get; set; }
    public string? BirthDate { get; set; }
    public string? HireDate { get; set; }
    public string? Notes { get; set; }
    public string? AvatarUrl { get; set; }
    public Address? Address { get; set; }
}

public class Address
{
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Region { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string? Phone { get; set; }
}
