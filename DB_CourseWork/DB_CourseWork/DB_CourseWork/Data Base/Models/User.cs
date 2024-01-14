using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DB_CourseWork.Models;

namespace DB_CourseWork;

public partial class User
{
    public int Id { get; set; }

    [DisplayName("Ім'я")]
    public string UserName { get; set; } = null!;
    [DisplayName("Прізвище")]
    public string UserLastName { get; set; } = null!;
    [DisplayName("Відділ")]
    public string Department { get; set; } = null!;
    [DisplayName("Посада")]
    public string UserPosition { get; set; } = null!;
    
    [Browsable(false)]
    [NotMapped]
    public virtual ICollection<Computer> Computers { get; set; } = new List<Computer>();

    public User()
    {

    }
    public User(int id, string userName, string userLastName, string department, string userPosition) : base()
    {
        Id = id;
        UserName = userName;
        UserLastName = userLastName;
        Department = department;
        UserPosition = userPosition;
    }
}
