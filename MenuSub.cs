using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLogic
{
    /// <summary>
    /// Used For a Dropdown Menu
    /// </summary>
    public class MenuSub : IMenuItem
    {
        /// <summary>
        /// A list of links in the dropdown
        /// </summary>
        public List<MenuSubLink> Links { get; set; }
        /// <summary>
        /// The label for the dropdown that appears in the navbar
        /// </summary>
        public string DropdownLabel { get; set; }

        public string Access { get; set; } = "public";

        /// <summary>
        /// Returns a string with the html to render this element if the user's access level matches the link's access level
        /// </summary>
        /// <param name="userAccess">Access level of the user</param>
        public string Render(string userAccess)
        {
            if(userAccess == Access)
            {
                string dropdown = "<li class=\"nav-item dropdown\">" +
                              "<a class=\"nav-link dropdown-toggle\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">" +
                              DropdownLabel +
                              "</a>" +
                              "<div class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">";

                foreach (MenuSubLink link in Links)
                {
                    dropdown += link.Render(userAccess);
                }
                dropdown += "</div>" +
                            "</li>";

                return dropdown;
            }
            return "";
        }

        /// <summary>
        /// Returns a string with the html to render this element if the link's access level is public
        /// </summary>
        public string Render()
        {
            return Render("public");
        }
    }
}
