﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

public partial  class ThamSo
{
    [Key]
    public int MaThamSo { get; set; }

    [StringLength(100)]
    public string TenThamSo { get; set; }

    public int GiaTri { get; set; }

    public DateTime NgayApDung { get; set; }


}
