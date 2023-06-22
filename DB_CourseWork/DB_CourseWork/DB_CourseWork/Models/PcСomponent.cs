using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using DB_CourseWork.Models;

namespace DB_CourseWork;

public partial class PcСomponent
{
    public int Id { get; set; }
    [DisplayName("Виробник")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Тип")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Статус роботи")]
    public bool IsWorking { get; set; }
    [DisplayName("ID ПК")]
    public int? ComputerId { get; set; }
    [Browsable(false)]
    [NotMapped]
    public virtual Computer? Computer { get; set; }
    public PcСomponent()
    {
            
    }
    public PcСomponent(int id, string manufacturer, string typeOf, bool isWorking, int? computerId) : base()
    {
        Id = id;
        Manufacturer = manufacturer;
        TypeOf = typeOf;
        IsWorking = isWorking;
        ComputerId = computerId;
    }
}
