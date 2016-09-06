using System.ComponentModel.DataAnnotations;
using MwEPi.Business;
using MwEPi.Business.EditorDescriptors;
using MwEPi.Business.Rendering;
using EPiServer.Web;
using EPiServer.Core;

namespace MwEPi.Models.Pages
{
    /// <summary>
    /// Represents contact details for a contact person
    /// </summary>
    [SiteContentType(
        GUID = "F8D47655-7B50-4319-8646-3369BA9AF05B",
        GroupName = Global.GroupNames._Specialized)]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-contact.png")]
    public class ContactPage : SitePageData, IContainerPage
    {
        [Display(GroupName = Global.GroupNames._Contact)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(GroupName = Global.GroupNames._Contact)]
        public virtual string Phone { get; set; }
        
        [Display(GroupName = Global.GroupNames._Contact)]
        [Business.EmailAddress]
        public virtual string Email { get; set; }
    }
}
