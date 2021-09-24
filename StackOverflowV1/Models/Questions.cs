using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowV1.Models
{
    [Table("Questions")]
    public class Questions
    {
        [Key]

        public int ID { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Posted { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public int Status { get; set; }


        public override string ToString()
        {
            return $"<div>{ID} {Username} {Title} {Detail} {Posted} {Category} {Tags} {Status}</div>";
        }

    }
}
