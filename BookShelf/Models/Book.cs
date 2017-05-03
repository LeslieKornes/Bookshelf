﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShelf.Models
{
    public class Book
    {
        [Key]

        public int ID { get; set; }

        public string Title { get; set; }
        [Display(Name = "Date Published")] [DisplayFormat(DataFormatString = "{0:M/d/yyyy}")]
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}