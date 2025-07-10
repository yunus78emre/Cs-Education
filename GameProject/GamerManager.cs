using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerManager
    {

        IUserValidationService _userValidation;

        public GamerManager(IUserValidationService userValidation)
        {
            _userValidation = userValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Added");
            }
            else
            {
                Console.WriteLine("Not a valid user");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Deleted"); 
        }
    }
}
