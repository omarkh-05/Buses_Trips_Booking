using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class TripTimes
    {
        [Key]
        public short TripTimeID { get; set; }

        [Column(TypeName = "time1")]
        public TimeSpan? Time1 { get; set; }
                       
        [Column(TypeName = "time2")]
        public TimeSpan? Time2 { get; set; }
                       
        [Column(TypeName = "time3")]
        public TimeSpan? Time3 { get; set; }
                       
        [Column(TypeName = "time4")]
        public TimeSpan? Time4 { get; set; }
        [Column(TypeName = "time5")]
        public TimeSpan? Time5 { get; set; }
                       
        [Column(TypeName = "time6")]
        public TimeSpan? Time6 { get; set; }
                       
        [Column(TypeName = "time7")]
        public TimeSpan? Time7 { get; set; }

        public virtual ICollection<Trips> Trips { get; set; } // صحيح

    }
}
