using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLogic
{
    public class Menu
    {

        /// <summary>
        /// List of menu items. Each item can be a MenuLink or MenuSub.
        /// </summary>
        public List<IMenuItem> MenuItems { get; set; }

        /// <summary>
        /// Access level of user
        /// </summary>
        public string UserAccess { get; set; } = "public";

        /// <summary>
        /// Text for the brand position. Can also be an image if you use an img tag here.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Styling for the Navbar. Default is light
        /// </summary>
        public string Style { get; set; } = "light";


        private string StyleLookup()
        {
            switch (Style.ToLower())
            {
                case "light":
                    return "navbar-light bg-light";
                case "dark":
                    return "navbar-dark bg-dark";
                case "primary":
                    return "navbar-dark bg-primary";
                case "secondary":
                    return "navbar-dark bg-secondary";
                case "success":
                    return "navbar-dark bg-success";
                case "danger":
                    return "navbar-dark bg-danger";
                case "warning":
                    return "navbar-light bg-warning";
                case "info":
                    return "navbar-dark bg-info";
                case "white":
                    return "navbar-light bg-white";
                default:
                    return "navbar-light bg-light";
            }
        }


        /// <summary>
        /// Returns a string with the html to render this element and the child elements
        /// </summary>
        public string Render()
        {
            string menu = "<nav class=\"navbar navbar-expand-lg "+StyleLookup()+"\">" +
                            "<a class=\"navbar-brand\" href=\"/\">"+Brand+"</a>" +
                            "<button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#myNav\" aria-controls=\"myNav\" aria-expanded=\"false\" aria-label=\"Toggle navigation\">" +
                            "<span class=\"navbar-toggler-icon\"></span>" +
                            "</button>" +

                            "<div class=\"collapse navbar-collapse\" id=\"myNav\">" +
                            "<ul class=\"navbar-nav mr-auto\">";
            foreach (IMenuItem item in MenuItems)
            {
                menu += item.Render(UserAccess);
            }

            menu += "</ul>" +
                    "</div>" +
                    "</nav>";
            return menu;
        }
    }
}
