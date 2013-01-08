using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace website.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        public string Description { get; set; }
    }

}
