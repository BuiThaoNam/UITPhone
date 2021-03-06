﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

public partial class PhieuBaoHanh

{
    [Key]
    public int SoPhieuBanHang { get; set; }


    public DateTime NgayLap { get; set; }
    public DateTime NgayGiao { get; set; }

    public int MaNhanVien { get; set; }

    [StringLength(200)]
    public string TenKhachHang { get; set; }

    [StringLength(15)]
    public string SoDienThoai { get; set; }



    public int TongTien { get; set; }



    public string Ghichu { get; set; }
    public bool DaGiao { get; set; }
    public DateTime NgayChinhSua { get; set; }


    public bool TrangThai { get; set; }
}
