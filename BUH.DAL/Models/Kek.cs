using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUH.DAL.Models
{
   public class Kek
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public string Discription { get; set; }
                        
        public ICollection<SubTransaction> SubTransactionsKekDebet { get; set; }

        public ICollection<SubTransaction> SubTransactionsKekKredit { get; set; }
    }
}

