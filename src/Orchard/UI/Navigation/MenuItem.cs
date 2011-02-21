using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using Orchard.Security.Permissions;

namespace Orchard.UI.Navigation {
    public class MenuItem {
        public MenuItem() {
            Permissions = Enumerable.Empty<Permission>();
            LinkToFirstChild = true;
        }

        public string Text { get; set; }
        public string TextHint { get; set; }
        public string IdHint { get; set; }
        public string Url { get; set; }
        public string Href { get; set; }
        public string Position { get; set; }
        public bool LinkToFirstChild { get; set; }
        public bool LocalNav { get; set; }
        public bool Selected { get; set; }
        public RouteValueDictionary RouteValues { get; set; }
        public IEnumerable<MenuItem> Items { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }
    }
}