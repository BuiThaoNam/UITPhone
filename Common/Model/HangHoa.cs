﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

public class HangHoa
{

    [Key]
    public int MaHangHoa { get; set; }
    public string TenHangHoa { get; set; }



    public int GiaBan { get; set; }

    public int GiamGia { get; set; }
    
    public int SoLuongTon { get; set; }

    [StringLength(50)]
    public string DonViTinh { get; set; }

    
    public string MoTa { get; set; }

  
    public string ThongSoKyThuat { get; set; }


    [StringLength(200)]
    public string XuatXu { get; set; }
    
    public int ThoiGianBaoHanh { get; set; }

    public string HinhAnh { get; set; }
    public int MaLoaiHangHoa { get; set; }

    public bool TrangThai { get; set; }
    public string ModelName { get; set; }
 
}
