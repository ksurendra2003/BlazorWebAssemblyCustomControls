using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssemblyCustomControls
{
    public partial class DropDownList
    {
        protected string DropDownOpenCss { get; set; } = "dropdown";
        protected string DropDownExpand { get; set; } = "false";

        protected string SelectedText { get; set; } = string.Empty;

        [Parameter]
        public EventCallback<string> SelectedValueChanged { get; set; }

        [Parameter]
        public string SelectedValue { get; set; } = string.Empty;

        [Parameter]
        public List<string> DataSource { get; set; }

        public void ShowDropDown()
        {
            ShowAndClose();
        }

        public Task OnItemSelect(string item)
        {
            SelectedText = item;
            SelectedValue = item;

            ShowAndClose();

            return SelectedValueChanged.InvokeAsync(SelectedValue);
        }

        private void ShowAndClose()
        {
            if (DropDownExpand == "true")
            {
                DropDownOpenCss = "dropdown";
                DropDownExpand = "false";
            }
            else
            {
                DropDownOpenCss = "dropdown open";
                DropDownExpand = "true";
            }
        }
    }
}
