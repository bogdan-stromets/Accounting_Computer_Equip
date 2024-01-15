using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Accounting_Computer_Equip.Models;

public partial class NetworkDevice
{
    public int Id { get; set; }
    [DisplayName("Manufacturer")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Type")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Work status")]
    public bool IsWorking { get; set; }
    [DisplayName("MAC-address")]
    public string MacAdress { get; set; } = null!;
    public NetworkDevice()
    {
            
    }
    public NetworkDevice(int id, string manufacturer, string typeOf, bool isWorking, string macAdress) : base()
    {
        Id = id;
        Manufacturer = manufacturer;
        TypeOf = typeOf;
        IsWorking = isWorking;
        MacAdress = macAdress;
    }
}
