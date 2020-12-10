using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCustomControls.Pages
{
    public partial class Index
    {
        protected List<string> Cources { get; set; }

        public string SelectedCource { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Cources = new List<string>
            {
                    "HTML",
                    "CSS",
                    "JavaScript",
                    "C#"
            };
        }

        public void SaveCource()
        {
            Console.WriteLine(SelectedCource);
        }
    }
}
