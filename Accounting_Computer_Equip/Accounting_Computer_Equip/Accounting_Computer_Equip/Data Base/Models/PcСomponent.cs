using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Accounting_Computer_Equip.Models;

namespace Accounting_Computer_Equip;

public partial class PcСomponent
{
    public int Id { get; set; }
    [DisplayName("Manufacturer")]
    public string Manufacturer { get; set; } = null!;
    [DisplayName("Type")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Work status")]
    public bool IsWorking { get; set; }
    [DisplayName("PC ID")]
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
