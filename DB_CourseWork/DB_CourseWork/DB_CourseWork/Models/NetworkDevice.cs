using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DB_CourseWork.Models;

public partial class NetworkDevice
{
    public int Id { get; set; }
    [DisplayName("Виробник")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Тип")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Статус роботи")]
    public bool IsWorking { get; set; }
    [DisplayName("MAC-адреса")]
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
