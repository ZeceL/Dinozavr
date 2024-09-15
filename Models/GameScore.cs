using System;
using System.ComponentModel.DataAnnotations;
namespace Dinozavr.Models
{
    public class GameScore
    {
        [Key]
        public int Id { get; set; }

        public int Score { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
