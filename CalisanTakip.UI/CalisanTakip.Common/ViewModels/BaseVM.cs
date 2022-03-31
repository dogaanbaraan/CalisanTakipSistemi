using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanTakip.Common.ViewModels
{
    public class BaseVM
    {
        [Key]
        public int Id { get; set; }
    }
}
