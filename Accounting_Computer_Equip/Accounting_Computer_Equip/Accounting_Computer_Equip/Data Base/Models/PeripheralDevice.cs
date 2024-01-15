using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting_Computer_Equip.Models;

public partial class PeripheralDevice
{
    public int Id { get; set; }
    [DisplayName("Manufacturer")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Type")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Connected to PC №")]
    public int? ConnectedTo { get; set; }
    [DisplayName("Work status")]
    public bool IsWorking { get; set; }
    [Browsable(false)]
    [NotMapped]
    public virtual Computer? ConnectedToNavigation { get; set; }
    public PeripheralDevice()
    {

    }
    public PeripheralDevice(int id, string manufacturer, string typeOf, int? connectedTo, bool isWorking) : base()
    {
        Id = id;
        Manufacturer = manufacturer;
        TypeOf = typeOf;
        ConnectedTo = connectedTo;
        IsWorking = isWorking;
    }
}
