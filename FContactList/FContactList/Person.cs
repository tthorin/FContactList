// -----------------------------------------------------------------------------------------------
//  Person.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        public string Name { get; set; } = ""; //done
        public string LastName { get; set; } = "";//done
        public string FullName { get => Name + " " + LastName; }
        public string Alias { get; set; } = "";//done
        public string Email { get; set; } = "";//done
        public string LinkedIn { get; set; } = "";//done
        public string Facebook { get; set; } = "";//done
        public string Instagram { get; set; } = "";//done
        public string Twitter { get; set; } = "";//done
        public string GitHub { get; set; } = ""; //done
        public string BestFood { get; set; } = "";
        public string WorstFood { get; set; } = "";
        public string FavouriteAnimal { get; set; } = "";
        public string FavouriteMovieGenre { get; set; } = "";
        public DateTime BirthDate { get; set; } = new();
        public bool IsBlocked { get; set; } = false;
        public bool IsGhosted { get; set; } = false;
        public string Notes { get; set; }
        public int Age
        {
            get
            {
                TimeSpan temp = DateTime.Now - BirthDate;
                return (int)(temp.Days / 365.25);
            }
            
        }
        public override string ToString()
        {
            return $"Namn: {Name}|Efternamn: {LastName}|Alias: {Alias}|Email: {Email}|LinkedIn: {LinkedIn}|Facebook: {Facebook}|Instagram: {Instagram}|Twitter: {Twitter}|GitHub: {GitHub}|Favoritmat: {BestFood}|Värsta mat:{WorstFood}|Favoritdjur: {FavouriteAnimal}|Födelsedatum: {BirthDate.ToString("dd MMM, yyyy")}|Anteckningar: {Notes}";
        }
        

    }
}
