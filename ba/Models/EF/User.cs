namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }

        [StringLength(50)]
        [Display(Name="Tài Khoản")]
        public string UserName { get; set; }

        [StringLength(32)]
        [Display(Name ="Mật Khẩu")]
        public string PassWord { get; set; }

        [StringLength(50)]
        [Display(Name ="Họ Tên")]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        [Display(Name ="Gmail/Email")]
        public string Email { get; set; }

        [StringLength(50)]
        [Display(Name ="Số Điện Thoại")]
        public string Phone { get; set; }

        [StringLength(250)]
        public string MetaDeacriptions { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(250)]
        public string CreatedBy { get; set; }
        [Display(Name ="Trạng Thái Sử Dụng")]
        public bool? Status { get; set; }
    }
}
