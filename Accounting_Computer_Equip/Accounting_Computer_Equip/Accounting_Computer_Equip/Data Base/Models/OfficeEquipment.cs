using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Accounting_Computer_Equip.Models;

public partial class OfficeEquipment
{
    public int Id { get; set; }
    [DisplayName("Manufacturer")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Type")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Work status")]
    public bool IsWorking { get; set; }
    public OfficeEquipment()
    {

    }
    public OfficeEquipment(int id, string manufacturer, string typeOf, bool isWorking) : base()
    {
        Id = id;
        Manufacturer = manufacturer;
        TypeOf = typeOf;
        IsWorking = isWorking;
    }
}
