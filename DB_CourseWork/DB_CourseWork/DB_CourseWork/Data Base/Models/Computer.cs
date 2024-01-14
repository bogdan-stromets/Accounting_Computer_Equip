using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_CourseWork.Models;

public partial class Computer
{
    public int Id { get; set; }
    //[DisplayName("Виробник")]
    public string Manufacturer { get; set; } = null!;
   // [DisplayName("Тип ПК")]
    public string PcType { get; set; } = null!;
   // [DisplayName("MAC-адреса")]
    public string MacAdress { get; set; } = null!;
  // [DisplayName("Статус роботи")]
    public bool IsWorking { get; set; }
   // [DisplayName("ID Користувача")]
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
