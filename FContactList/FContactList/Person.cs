namespace FContactList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Person
    {
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        public string Facebook { get; set; } = "";
        public string Instagram { get; set; } = "";
        public string  Twitter { get; set; } = "";
        public string GitHub { get; set; } = "";
        public string BestFood { get; set; } = "";
        public string WorstFood { get; set; } = "";
        public string FavouriteAnimal { get; set; } = "";
        public string FavouriteMovieGenre { get; set; } = "";
        public DateTime BirthDate { get; set; } = new();
        public bool IsBlocked { get; set; } = false;
        public bool IsGhosted { get; set; } = false;
    }
}
