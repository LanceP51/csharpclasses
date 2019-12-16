using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        class BookLibrary
        {
            public string Author { get; set; }
            public string Title { get; set; }
            public int ISBN { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> eastSideLibrary = new Dictionary<string, string>(){
                {"name","East Side Library"},
                {"address","123 East St"}
            };
            Dictionary<string, string> northBlvdLibrary = new Dictionary<string, string>(){
                {"name","North Blvd Library"},
                {"address","123 North St"}
            };
            Dictionary<string, string> southernBellLibrary = new Dictionary<string, string>(){
                {"name","Southern Bell Library"},
                {"address","123 South St"}
            };
            Dictionary<string, string> westvilleLibrary = new Dictionary<string, string>(){
                {"name","Westville Library"},
                {"address","123 West St"}
            };

            List<Dictionary<string, string>> cityLibraries = new List<Dictionary<string, string>> { };
            cityLibraries.Add(eastSideLibrary);
            cityLibraries.Add(northBlvdLibrary);
            cityLibraries.Add(southernBellLibrary);
            cityLibraries.Add(westvilleLibrary);

            BookLibrary bookOfLove = new BookLibrary()
            {
                Author = "Doctor Daniel",
                Title = "The Doctor's Book of Love",
                ISBN = 123456789
            };
            BookLibrary bookOfDespair = new BookLibrary()
            {
                Author = "Doctor Dave",
                Title = "The Doctor's Book of Despair",
                ISBN = 987654321
            };
            BookLibrary bookOfHair = new BookLibrary()
            {
                Author = "Doctor Dale",
                Title = "The Doctor's Book of Hair",
                ISBN = 147258369
            };
        }
    }
}
