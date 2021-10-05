// -----------------------------------------------------------------------------------------------
//  Person.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FContactList
{
using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person:ICloneable
    {
        public string Name { get; set; } = ""; 
        public string LastName { get; set; } = "";
        public string FullName { get => Name + " " + LastName; }
        public string Alias { get; set; } = "";
        public string Email { get; set; } = "";
        public string LinkedIn { get; set; } = "";
        public string Facebook { get; set; } = "";
        public string Instagram { get; set; } = "";
        public string Twitter { get; set; } = "";
        public string GitHub { get; set; } = ""; 
        public string BestFood { get; set; } = "";
        public string WorstFood { get; set; } = "";
        public string FavouriteAnimal { get; set; } = "";
        public string FavouriteMovieGenre { get; set; } = "";
        public DateTime BirthDate { get; set; } = new DateTime(2000,1,1);
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
        public static int CompareByFullName(Person p1, Person p2)
        {
            return string.Compare(p1.FullName, p2.FullName);
        }

        public object Clone()
        {
            string json = JsonConvert.SerializeObject(this, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            return JsonConvert.DeserializeObject<Person>(json);
        }
    }
}
