using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Command
    {
        public Command()
        {
            CommandLines = new List<CommandLine>();
        }
        public List<CommandLine> CommandLines { get; set; }
        //public decimal Total

        //{
        //    get { return CartLines.Sum(c => c.Car.RentDate * c.Car.DailyPrice); }

        //}

    }
}
