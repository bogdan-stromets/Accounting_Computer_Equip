using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB_CourseWork.Models;

public partial class PeripheralDevice
{
    public int Id { get; set; }
    [DisplayName("Виробник")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Тип")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Підключений до № ПК")]
    public int? ConnectedTo { get; set; }
    [DisplayName("Статус роботи")]
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
