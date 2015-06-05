using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Posts
    {
        
            [Key]
            public int Id { get; set; }
            public string Title { get; set; }

            public string Content { get; set; }

            [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
            public DateTime Datetime { get; set; }

            public string Author { get; set; }

            public string ImagePath { get; set; }

        
    }
}