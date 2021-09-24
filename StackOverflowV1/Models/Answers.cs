using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowV1.Models
{

    [Table("Answers")]
    public class Answers
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public int QuestionID { get; set; }
        public DateTime Posted { get; set; }

        public int UpVotes { get; set; }


        public override string ToString()
        {
            return $"<div>{ID} {Username} {Detail} {QuestionID} {Posted} {UpVotes}</div>";
        }
    }
}
