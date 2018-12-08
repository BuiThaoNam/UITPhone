﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

public partial class ChiTietPhieuDatHang
{
    [Key]
    public int SoPhieuDatHang { get; set; }


    public int SoLuong { get; set; }

    [Key]
    public int MaHangHoa { get; set; }
    public int Gia { get; set; }
    public int ThanhTien { get; set; }
}
