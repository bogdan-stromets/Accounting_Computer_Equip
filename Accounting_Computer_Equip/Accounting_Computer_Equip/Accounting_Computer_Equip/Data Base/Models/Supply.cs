using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Accounting_Computer_Equip;

public partial class Supply
{
    public int Id { get; set; }
    [DisplayName("Type")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Count")]
    public int CountOf { get; set; }
    public Supply()
    {

    }
    public Supply(int id, string typeOf, int countOf) : base()
    {
        Id = id;
        TypeOf = typeOf;
        CountOf = countOf;
    }
}
