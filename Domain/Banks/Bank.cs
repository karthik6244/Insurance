using Insurance.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Insurance.Domain.Banks
{
    public class Bank : IEntity
    {
        public int Id { get; set; }
        //[StringLength(500)]
        public string Bankname { get; set; }

    }
}
