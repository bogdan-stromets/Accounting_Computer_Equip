using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DB_CourseWork;

public partial class Supply
{
    public int Id { get; set; }
    [DisplayName("Тип")]
    public string TypeOf { get; set; } = null!;
    [DisplayName("Кількість")]
    public int CountOf { get; set; }
    public Supply()
    {

    }
    public Supply(int id, string typeOf, int countOf) : base()
    {
        Id = id;
        TypeOf = typeOf;
        CountOf = countOf;
    }
}
