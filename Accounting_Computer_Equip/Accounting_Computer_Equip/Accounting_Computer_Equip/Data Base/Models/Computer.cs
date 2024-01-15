using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Accounting_Computer_Equip.Models;

public partial class Computer
{
    public int Id { get; set; }
    [DisplayName("Manufacturer")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("PC Type")]
    public string PcType { get; set; } = null!;
    [DisplayName("MAC-address")]
    public string MacAdress { get; set; } = null!;
   [DisplayName("Work status")]
    public bool IsWorking { get; set; }
    [DisplayName("User ID")]
    public int? UserId { get; set; }

    [Browsable(false)]
    [NotMapped]
    public virtual ICollection<PcСomponent> PcСomponents { get; set; } = new List<PcСomponent>();
    [Browsable(false)]
    [NotMapped]
    public virtual ICollection<PeripheralDevice> PeripheralDevices { get; set; } = new List<PeripheralDevice>();
    [Browsable(false)]
    [NotMapped]
    public virtual User? User { get; set; }
    public Computer()
    {
            
    }
    public Computer(int id, string manufacturer, string pcType, string macAdress, bool isWorking, int? userId) : base()
    {
        Id = id;
        Manufacturer = manufacturer;
        PcType = pcType;
        MacAdress = macAdress;
        IsWorking = isWorking;
        UserId = userId;
    }
}
