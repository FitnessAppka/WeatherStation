using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private static int counter;

        public User(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            counter++;
        }
    }
}
