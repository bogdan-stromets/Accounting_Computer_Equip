using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Accounting_Computer_Equip.Models;

namespace Accounting_Computer_Equip;

public partial class User
{
    public int Id { get; set; }

    [DisplayName("First Name")]
    public string UserName { get; set; } = null!;
    [DisplayName("Last Name")]
    public string UserLastName { get; set; } = null!;
    [DisplayName("Department")]
    public string Department { get; set; } = null!;
    [DisplayName("User Position")]
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
