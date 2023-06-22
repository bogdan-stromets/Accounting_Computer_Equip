using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DB_CourseWork.Models;

public partial class OfficeEquipment
{
    public int Id { get; set; }
    [DisplayName("Виробник")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Тип")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Статус роботи")]
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
