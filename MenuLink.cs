using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLogic
{
    /// <summary>
    /// A link in the navbar
    /// </summary>
    public class MenuLink : IMenuItem
    {
        /// <summary>
        /// Action of the link
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// The controller of the action
        /// </summary>
        public string Controller { get; set; }
        /// <summary>
        /// Link text to be displayed in the navbar
        /// </summary>
        public string LinkText { get; set; }
        /// <summary>
        /// Access level (Not Yet Implemented)
        /// </summary>
        public string Access { get; set; } = "public";


        /// <summary>
        /// Returns a string with the html to render this element if the user's access level matches the link's access level
        /// </summary>
        /// <param name="userAccess">Access level of the user</param>
        public string Render(string userAccess)
        {
            if(userAccess == Access)
            {
                string link = $"/{Controller}/{Action}";

                string htmlString =
                    "<li class=\"nav-item\">" +
                    "<a class=\"nav-link\" href=\"" + link + "\">" + LinkText + "</a>" +
                    "</li>";

                return htmlString;
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
