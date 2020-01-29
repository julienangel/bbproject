using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueByte.Infrastructure.Utils.Enums;

namespace BlueByte.ViewModel.Models
{
    public class Entity
    {
        public string Name { get; set; }
        public Asset Asset { get; set; }
        public Position Position { get; set; }
        public Behavior Behavior { get; set; }

        public Entity()
        {
            Name = "...";
        }
    }
}
